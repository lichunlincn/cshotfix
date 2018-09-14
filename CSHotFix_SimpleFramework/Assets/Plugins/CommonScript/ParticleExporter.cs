

//1、整体思路是这样的，Unity中调整好摄像机，正常播放特效，然后每帧截屏，保存成我们需要的png序列帧。这个不仅仅是特效可以这么用，其实模型也可以。比如我们需要同屏显示几百上千人，或者是无关紧要的怪物、场景物件等等，就可以使用这个导出成2d的序列帧，可以大大提高效率，使一些不可能的情况变为可能。

//2、关于时间和帧率的控制。由于截屏所需要的时间远远大于帧间隔，所以光效如果是播放1秒，则导出时间可能超过一分钟。Time.captureFrameRate可以设置帧率，设置后则忽略真实时间，光效、模型会按照帧率的时间来播放。这个接口恰好就是用在视频录制上的。

//3、光效画布控制。这个暂时没有找到好的方法，由于是全屏幕截屏，所以Game窗口的大小就是光效画布的大小。

//4、通过调整摄像机的位置、旋转，控制光效的显示信息。

//5、截屏函数就是GetTex2D()。这里面最主要的是ReadPixels函数。需要注意，CaptureFrame函数必须要以协程的方式运行，因为里面有一句yield return new WaitForEndOfFrame();如果没有这一句，会报一个错误，大概意思就是ReadPixels不在DrawFrame里面运行。

//6、截屏时间消耗很大，所以需要在截屏开始使用Time.timeScale=0暂停时间运行，截屏后再恢复

//7、注意截屏操作完成后清理各种资源，并进行GC。否则内存很有可能就不够用了，截100帧图片，内存很有可能就两三G了。

//8、截屏的时候使用了两个RenderTexture，分别绘制白底和黑底的图片，然后根据这两张图片计算出alpha。如果不是光效其实可以不这么麻烦，直接把Camera的backgroundColor中的alpha设置为0就可以了。但是光效使用了特殊的shader，比如Additive，这里涉及到alpha blend。绘制光效时如果也这样设置的话，导出的图片没有任何东西。所以必须要有实色背景。

using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class ParticleExporter : MonoBehaviour
{
    // Default folder name where you want the animations to be output
    public string folder = "PNG_Animations";

    // Framerate at which you want to play the animation
    public int frameRate = 25;                  // export frame rate 导出帧率，设置Time.captureFramerate会忽略真实时间，直接使用此帧率
    public float frameCount = 100;              // export frame count 导出帧的数目，100帧则相当于导出5秒钟的光效时间。由于导出每一帧的时间很长，所以导出时间会远远长于直观的光效播放时间
    public int frameInterval = 2;             //间隔多少帧截图
    private string realFolder = ""; // real folder where the output files will be
    private float originaltimescaleTime; // track the original time scale so we can freeze the animation between frames
    private int currentIndex = 0;
    private Camera exportCamera;    // camera for export 导出光效的摄像机，使用RenderTexture

    public void Start()
    {
        // set frame rate
        Time.captureFramerate = frameRate;

        // Create a folder that doesn't exist yet. Append number if necessary.
        realFolder = Path.Combine(folder, name);
        realFolder = Application.dataPath+"/../../../../ResLib/TextureSet/"+realFolder;
        // Create the folder
        if (!Directory.Exists(realFolder))
        {
            Directory.CreateDirectory(realFolder);
        }

        originaltimescaleTime = Time.timeScale;
        exportCamera = Camera.allCameras[0];
        ParticleSystem ps = gameObject.GetComponent<ParticleSystem>();
        if (ps != null)
        {
            ps.Stop();
            ps.Play();
        }
        if (frameInterval <= 0)
        {
            frameInterval = 1;
        }
    }

    void Update()
    {
        if (currentIndex++ < frameCount)
        {
            if (currentIndex % frameInterval == 0)
            {
                int idx = Mathf.FloorToInt( currentIndex / frameInterval);
                // 每帧截屏
                StartCoroutine(CaptureFrame(idx));
            }
            return;
        }
        else
        {
            Debug.Log("Finish");
            Debug.Break();
        }



    }

    IEnumerator CaptureFrame(int idx)
    {
        // Stop time
        Time.timeScale = 0;
        // Yield to next frame and then start the rendering
        // this is important, otherwise will have error
        yield return new WaitForEndOfFrame();

        string filename = String.Format("{0}/{1}.png", realFolder, idx);
        Debug.Log(filename);

        int width = Screen.width;
        int height = Screen.height;

        //Initialize and render textures
        RenderTexture blackCamRenderTexture = new RenderTexture(width, height, 24, RenderTextureFormat.ARGB32);
        RenderTexture whiteCamRenderTexture = new RenderTexture(width, height, 24, RenderTextureFormat.ARGB32);

        exportCamera.targetTexture = blackCamRenderTexture;
        exportCamera.backgroundColor = Color.black;
        exportCamera.Render();
        RenderTexture.active = blackCamRenderTexture;
        Texture2D texb = GetTex2D();

        //Now do it for Alpha Camera
        exportCamera.targetTexture = whiteCamRenderTexture;
        exportCamera.backgroundColor = Color.white;
        exportCamera.Render();
        RenderTexture.active = whiteCamRenderTexture;
        Texture2D texw = GetTex2D();

        // If we have both textures then create final output texture
        if (texw && texb)
        {
            Texture2D outputtex = new Texture2D(width, height, TextureFormat.ARGB32, false);

            // we need to check alpha ourselves,because particle use additive shader
            // Create Alpha from the difference between black and white camera renders
            for (int y = 0; y < outputtex.height; ++y)
            { // each row
                for (int x = 0; x < outputtex.width; ++x)
                { // each column
                    float alpha;
                    alpha = texw.GetPixel(x, y).r - texb.GetPixel(x, y).r;
                    alpha = 1.0f - alpha;
                    Color color;
                    if (alpha == 0)
                    {
                        color = Color.clear;
                    }
                    else
                    {
                        color = texb.GetPixel(x, y);
                    }
                    color.a = alpha;
                    outputtex.SetPixel(x, y, color);
                }
            }


            // Encode the resulting output texture to a byte array then write to the file
            byte[] pngShot = outputtex.EncodeToPNG();
            File.WriteAllBytes(filename, pngShot);

            // cleanup, otherwise will memory leak
            pngShot = null;
            RenderTexture.active = null;
            exportCamera.targetTexture = null;
            DestroyImmediate(outputtex);
            outputtex = null;
            DestroyImmediate(blackCamRenderTexture);
            blackCamRenderTexture = null;
            DestroyImmediate(whiteCamRenderTexture);
            whiteCamRenderTexture = null;
            DestroyImmediate(texb);
            texb = null;
            DestroyImmediate(texw);
            texb = null;

            System.GC.Collect();

            // Reset the time scale, then move on to the next frame.
            Time.timeScale = originaltimescaleTime;
        }
    }

    // Get the texture from the screen, render all or only half of the camera
    private Texture2D GetTex2D()
    {
        // Create a texture the size of the screen, RGB24 format
        int width = Screen.width;
        int height = Screen.height;
        Texture2D tex = new Texture2D(width, height, TextureFormat.ARGB32, false);
        // Read screen contents into the texture
        tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        tex.Apply();
        return tex;
    }
}

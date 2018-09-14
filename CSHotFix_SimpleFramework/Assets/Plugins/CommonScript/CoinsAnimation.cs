using UnityEngine;
using System.Collections;

public class CoinsAnimation : MonoBehaviour 
{

    public GameObject[] mCoinPrefab;
    public float mRate = 0.25f;
    public float mMoveSpeed = 2;
    public AnimationCurve mMoveSpeedCurve;
    public float mRotateSpeed = 3;

    private static CoinsAnimation Instance;

    private class Coin
    {
        public float mMoveTime;
        public Transform mTransform;
        public Vector3 mRotateSpeed;
    }

    private void Start()
    {
        Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;
    }

    private IEnumerator OnAnimation(float flyTime, int type, Vector3 sourceIn, Vector3 targetIn, int count)
    {
        Camera sceneCamera = Camera.main;
        Camera uiCamera = PluginsTool.UICamera;

        Vector3 source, target;
        if (null != uiCamera)
        {
            source = sourceIn;
            target = targetIn;

            // 将UI起点坐标转换为场景起点坐标并保存
            sourceIn = sceneCamera.ViewportToWorldPoint(uiCamera.WorldToViewportPoint(sourceIn));
        }
        else
        {
            source = sourceIn;
            target = targetIn;
        }

        System.Collections.Generic.List<Coin> coins = new System.Collections.Generic.List<Coin>();
        float generateTime = 0;
        float generateCount = 0;
        float moveSpeed = 1 / flyTime;

        while (true)
        {
            if (generateCount < count && generateTime <= 0)
            {
                Coin coin = new Coin();

                coin.mRotateSpeed = new Vector3(
                    Mathf.Lerp(0, 360, Random.Range(0, 1.0f)),
                    Mathf.Lerp(0, 360, Random.Range(0, 1.0f)),
                    Mathf.Lerp(0, 360, Random.Range(0, 1.0f))) * mRotateSpeed;

                GameObject go = Instantiate(mCoinPrefab[type], source, Random.rotationUniform) as GameObject;
                coin.mTransform = go.transform;

                coins.Add(coin);
                generateTime = mRate;
                generateCount++;
            }
            else
            {
                generateTime -= Time.deltaTime;
            }

            if (null != uiCamera)
            {
                // 将场景起点坐标转换为UI起点坐标，因为场景可以拖动，不然会造成效果分离的问题，所以必须转换一次
                source = uiCamera.ViewportToWorldPoint(sceneCamera.WorldToViewportPoint(sourceIn));
            }

            for (int i = coins.Count - 1; i >= 0; --i)
            {
                Coin coin = coins[i];
                coin.mTransform.position = Vector3.Lerp(source, target, coins[i].mMoveTime);
                coin.mTransform.Rotate(coin.mRotateSpeed.x * Time.deltaTime, coin.mRotateSpeed.y * Time.deltaTime, coin.mRotateSpeed.z * Time.deltaTime);
                coin.mMoveTime = coin.mMoveTime + Mathf.Max(mMoveSpeedCurve.Evaluate(coin.mMoveTime), 0.1f) * moveSpeed * Time.deltaTime;

                if (coin.mMoveTime >= 1)
                {
                    coins.RemoveAt(i);
                    Destroy(coin.mTransform.gameObject);
                }
            }

            if (generateCount >= count && coins.Count == 0)
            {
                break;
            }

            yield return null;
        }
    }

    public float BeginAnimation(int type, Vector3 source, Vector3 target, int count)
    {
        // 飞行时长
        float flyTime = (target - source).magnitude / mMoveSpeed;
        StartCoroutine(OnAnimation(flyTime, type, source, target, Mathf.Clamp(count, 1, 20)));
        return flyTime;
    }

    /// <summary>
    /// 播放特效
    /// </summary>
    /// <param name="type">类型</param>
    /// <param name="source">UI相机中的起点坐标</param>
    /// <param name="target">UI相机中的终点坐标</param>
    /// <param name="count">粒子数量</param>
    /// <returns>播放时长</returns>
    public static float Play(int type, Vector3 source, Vector3 target, int count)
    {
        if (null != Instance)
        {
            return Instance.BeginAnimation(type, source, target, count);
        }
        return 0;
    }
    
}

using LCL;
using UnityEngine;


public class LogicMain : IGameInterface
    {
        public override void Start()
        {
            //GameDll.ClassObjectPoolTest mytest = new GameDll.ClassObjectPoolTest();
            //mytest.StartTest();
            //Vector2 movedir = new Vector2(1, 0);
            //Vector3 basedir = new Vector3(0, 1, -1);
            //GameDll.Tool.ConvertToRelatedCoord(basedir, ref movedir);
            //初始化不销毁对象
            //GameDll.TestFraction.Main();
            DontDestroyGameObject();
            Debug.Log("gamedll start");
            //Debug.Log("root path is :" +ResourceManager.getRootPath());
            Debug.Log(Application.platform);
            
            //TestUdp.StartTest("",1, 3);
            //string url = ResourceManager.getRootPath() + "AssetBundle/New Resource.mf";
            ////ResourceManager.LoadResource(url,OnLoaded);
            //byte[] data_byte = ResourceManager.LoadResource(url);
            //ResourceManager.LoadResource(data_byte, OnLoaded);

            //StringManager.init();
            //string str = StringManager.getStringByKey("GAME_NAME");
            //Debug.Log(str);

            //SceneManager.EnterLogin("ULevel/login_map.csv");
            //UILogin.getInstance().SetVisiable(true);
            //GameDll.DebugHelper.m_bShow = false;
            //NetTest.run();

            //byte[] dest=new byte[1024*10];
            //int offset=0;

            //int  data1=12;
            //byte[] source1 =  BitConverter.GetBytes(data1);
            ////序列化
            //Array.Copy(source1, dest, sizeof(int));
            //offset += sizeof(int);

            //bool data2 = false;
            //byte[] source2 = BitConverter.GetBytes(data2);
            //Array.Copy(source2,0,dest,offset,sizeof(bool));
            //offset += sizeof(bool);

            //////////////////////////////////反序列化//////////////////////////////////////////
            //int offset2 = 0;
            //int getdata1=BitConverter.ToInt32(dest, offset2);
            //offset2 += sizeof(int);
            //bool getdata2 = BitConverter.ToBoolean(dest, offset2);
            //offset2 += sizeof(bool);

            //测试网络库
            //Net.Init();
            //Net.Connect("127.0.0.1", 8888);

            //TestSqlite3 sq = new TestSqlite3();
            //string path = ResourceManager.makeFullPath("Config/test.s3db");
            //path = path.Replace("file://", "");
            //sq.Init(path);
            //sq.Close();
            GameDll.CGameProcedure.InitStaticMemeber();

            UnityEngine.Application.targetFrameRate = GameDll.LogicRoot.m_GameFrameRate;

        }
        private void DontDestroyGameObject()
        {
            GameObject gameMain = GameDll.LogicRoot.GameMain;
        }
        public override void FixedUpdate()
        {

        }

        public override bool Update()
        {
            //Net.Update();
            GameDll.LogicRoot.TimeSinceLastFrame = Time.deltaTime;
            GameDll.CGameProcedure.Update();      
            return true;
        }

        public override void LateUpdate()
        {

        }
        public override bool OnGUI()
        {
            //if (GameDll.DebugHelper.m_bShow)
            //{
            //    GameDll.DebugHelper.frame();
            //}
            return true;
        }
        public override void OnApplicationPause()
        {

        }
        public override void OnDestroy()
        {

            //TestUdp.CloseTest();
        }
        public override void OnApplicationQuit()
        {
            UnityEngine.Debug.Log("LogicMain OnApplicationQuit");
            GameDll.CGameProcedure.ReleaseStaticMember();
        }
        public override void OnPlatformMessage(string msg)
        {
            Debug.Log("被动收到来自平台的消息：" + msg);
            string data = CallPlatform.callFunc("GetPlatformString", null);
            Debug.Log("主动请求平台消息：" + data);
        }

        public static string getHello()
        {
            return "hello world";
        }
        public override object OnMono2GameDll(string func, object data = null)
        {
            return GameDll.Tool.OnMono2GameDll(func, data);
        }
    }

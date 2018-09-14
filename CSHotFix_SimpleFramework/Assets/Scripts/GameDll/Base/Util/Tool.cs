using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.IO;
using LCL;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameDll
{
    public class Tool
    {
        public static Action<float> s_UpdateOnceFrame;
        public const float m_fToleranceValues = 0.001f;
        public static Guid NullGuid = Guid.Empty;
        public static StringBuilder StringBuilder = new StringBuilder();
        public static bool IsEqual(float a, float b)
        {
            return Mathf.Abs(a - b) <= m_fToleranceValues;
        }
        public static Vector3 ReadVector3(BinaryReader reader)
        {
            Vector3 v;
            v.x = reader.ReadSingle();
            v.y = reader.ReadSingle();
            v.z = reader.ReadSingle();
            return v;
        }
        public static Quaternion ReadQuaternion(BinaryReader reader)
        {
            Quaternion q;
            q.x = reader.ReadSingle();
            q.y = reader.ReadSingle();
            q.z = reader.ReadSingle();
            q.w = reader.ReadSingle();
            return q;
        }
        //所有子对象和他本身
        public static void SetLayerWithChild(GameObject parent, string layerName)
        {
            parent.layer = LayerMask.NameToLayer(layerName);
            int count = parent.transform.childCount;
            for (int i = 0; i < count; ++i)
            {
                Transform child = parent.transform.GetChild(i);
                child.gameObject.layer = LayerMask.NameToLayer(layerName);
                SetLayerWithChild(child.gameObject, layerName);
            }
        }
        //考虑到int数组在js里面效率比较低，所以采用list
        public static bool ParseInts(List<int> iDatas, string str, char spliter = ';')
        {
            if (String.IsNullOrEmpty(str))
            {
                UnityEngine.Debug.LogError("ParseInts str is null or empty");
                return false;
            }
            string[] datas = str.Split(spliter);

            if (datas != null && datas.Length > 0)
            {
                int count = datas.Length;
                iDatas.Clear();

                for (int i = 0; i < count; ++i)
                {
                    int data = 0;
                    if (!int.TryParse(datas[i], out  data))
                    {
                        UnityEngine.Debug.LogError("ParseInts error,datas[i] is not a number");
                        break;
                    }
                    else
                    {
                        iDatas.Add(data);
                    }
                }
                return true;
            }
            else
            {
                UnityEngine.Debug.LogError("datas == null or datas.Legth<=0");
                return false;
            }
        }
        public static bool ParseStrings(List<string> iDatas ,string str, char spliter = ';')
        {
            if (String.IsNullOrEmpty(str))
                return false;
            string[] datas = str.Split(spliter);
            if (datas != null && datas.Length > 0)
            {
                iDatas.Clear();
                iDatas.AddRange(datas);
                return true;
            }
            return false;
        }
        public static Vector3 ParseVector3(string str, char spliter = ';')
        {
            List<float> datas = ParseFloats(str, spliter);
            if (datas != null && datas.Count == 3)
            {
                Vector3 v =new Vector3(datas[0], datas[1], datas[2]);
                return v;
            }
            return Vector3.zero;
        }
        public static List<float> ParseFloats(string str, char spliter = ';')
        {
            string[] datas = str.Split(new char[] { spliter });

            if (datas != null && datas.Length > 0)
            {
                int count = datas.Length;
                List<float> iDatas = new List<float>();

                for (int i = 0; i < count; ++i)
                {
                    float data = 0;
                    if (!float.TryParse(datas[i], out data))
                    {
                        UnityEngine.Debug.LogError("ParseFloats error,datas[i] is not a float number");
                        break;
                    }
                    else
                    {
                        iDatas.Add(data);
                    }
                }
                return iDatas;
            }
            return null;
        }
        public static float GetDistanceSqr(Vector3 v0, Vector3 v1)
        {
            Vector3 vd = v0 - v1;
            float mag = vd.sqrMagnitude;
            return mag;
        }
        //public static int GetDistance(VInt3 v0, VInt3 v1)
        //{
            
        //    VInt3 vd = v0 - v1;
        //    int mag = vd.magnitude;
        //    return mag;
        //}
        public static bool NoGreaterThan(Vector3 point0, Vector3 point1, float dis)
        {
            return GetDistanceSqr(point0, point1) <= dis * dis;
        }
        public static void Check(bool bError, string message = "")
        {
            if (!bError)
            {
                if (message != "")
                {
                    Debug.LogError("Check Error:" + message);
                }
                else
                {
                    Debug.LogError("Check Error");
                }


            }
        }
        public static void AIDebug(string message)
        {
            Debug.Log(message);
        }
        public class bezieratParam
        {
            public float a;
            public float b;
            public float c;
            public float d;
            public float t;
        }
        public static float bezierat(bezieratParam param)
        {
            return (
                Mathf.Pow(1 - param.t, 3) * param.a +
                3 * param.t * (Mathf.Pow(1 - param.t, 2)) * param.b +
                3 * Mathf.Pow(param.t, 2) * (1 - param.t) * param.c +
                Mathf.Pow(param.t, 3) * param.d);
        }

        public static Vector2 WorldToScreenPoint(Vector3 pos)
        {
            Vector2 hr = WorldToUGUIPoint(pos);
            return UGUIToScreenPoint(hr);
        }
        public static Vector2 UGUIToScreenPoint(Vector2 pos)
        {
            pos.Set(pos.x - Screen.width / 2, pos.y - Screen.height / 2);
            return pos;
        }
        //将世界坐标转换为UGUI坐标，其中UGUI坐标是屏幕中心点为0，0
        public static Vector2 WorldToUGUIPoint(Vector3 wordPosition)
        {
            Vector2 hr = Vector2.zero;
            //Camera cam = GetCameraManager().GetCamera();
            //if (cam == null)
            //{
            //    UnityEngine.Debug.LogWarning("当前没有激活的相机");
            //    return hr;
            //}

            return hr;
        }
        public static Vector3 ScreenToWorldPoint(float x, float y, float z_depth)
        {
            Vector3 worldPos = Vector3.zero;
            Vector3 v = Vector3.zero;
            v.x = x;
            v.y = y;
            v.z = z_depth;
            Camera cam = Camera.main;
            if (cam != null)
            {
                worldPos = TransformTool.ScreenToWorldPoint(cam, v);
                return worldPos;
            }
            else
            {
                UnityEngine.Debug.LogWarning("当前没有激活的相机");
                return worldPos;
            }
        }
        public static Ray ScreenPointToRay(Vector3 screenpos)
        {
            Ray hr = new Ray();
            Camera cam = Camera.main;
            if (cam == null)
            {
                UnityEngine.Debug.LogWarning("当前没有激活的相机");
                return hr;
            }
            else
            {
                hr = TransformTool.ScreenPointToRay(cam, screenpos);
            }
            return hr;
        }
        public static void SetObjectVisible(GameObject gameObject, bool bVisible)
        {
            Renderer[] componentsInChildren = gameObject.GetComponentsInChildren<Renderer>();
            for (int i = 0; i < componentsInChildren.Length; i++)
            {
                componentsInChildren[i].enabled = bVisible;
            }
        }
        public static void SetObjectAlpha(GameObject gameObject, float fAlpha)
        {
            Renderer[] componentsInChildren = gameObject.GetComponentsInChildren<Renderer>();
            for (int i = 0; i < componentsInChildren.Length; i++)
            {
                for (int j = 0; j < componentsInChildren[i].materials.Length; j++)
                {
                    Color color = componentsInChildren[i].materials[j].color;
                    color.a = fAlpha;
                    if (color.a < 0f)
                    {
                        color.a = 0f;
                    }
                    componentsInChildren[i].materials[j].color = color;
                }
            }
        }
        public static Transform FindTransform(Transform parent, string name)
        {
            if (parent.name == name)
            {
                return parent;
            }
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform transform = FindTransform(parent.GetChild(i), name);
                if (transform != null)
                {
                    return transform;
                }
            }
            return null;
        }

        public static float GetBoundHigh(GameObject obj)
        {
            CapsuleCollider component = obj.GetComponent<CapsuleCollider>();
            if (component != null)
            {
                return component.height;
            }
            return 0f;
        }
        public static float DistanceWithBound(Vector3 pt1, float fBound1, Vector3 pt2, float fBound2)
        {
            float num = Vector3.Distance(pt1, pt2);
            num -= fBound1;
            num -= fBound2;
            return Mathf.Max(num, 0f);
        }
            
        public static void ChangeLayersRecursively(Transform transform, string name)
        {
            transform.gameObject.layer = LayerMask.NameToLayer(name);
            for (int i = 0; i < transform.childCount; i++)
            {
                ChangeLayersRecursively(transform.GetChild(i), name);
            }
        }
        public static GameObject AddChild(GameObject parent)
        {
            GameObject gameObject = new GameObject();
            if (parent != null)
            {
                Transform transform = gameObject.transform;
                transform.parent = parent.transform;
                ResetTransform(transform);
                gameObject.layer = parent.layer;
            }
            return gameObject;
        }
        public static GameObject AddChild(GameObject parent, GameObject prefab)
        {
            GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(prefab);
            AddChildImp(parent, gameObject);
            return gameObject;
        }

        public static void ResetTransform(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }
        public static void AddChildImp(GameObject parent, GameObject go)
        {
            if (go != null && parent != null)
            {
                Transform transform = go.transform;
                transform.SetParent(parent.transform);
                ResetTransform(transform);
                go.layer = parent.layer;
            }
        }
        public static GameObject GetGameObject(GameObject parent, string name)
        {
            if (parent == null)
            {
                return GameObject.Find(name);
            }
            Transform tr = parent.transform.Find(name);
            if (tr != null)
                return tr.gameObject;
            return null;
        }
        public static bool IsParent(GameObject _parent, GameObject _child)
        {
            Transform parent = _child.transform.parent;
            int maxLayer = 50;
            int layer = 0;
            while (parent != null)
            {
                if (layer >= maxLayer)
                {
                    break;
                }
                else
                {
                    layer += 1;
                }
                if (_parent.transform == parent)
                {
                    return true;
                }
                parent = parent.transform.parent;
            }
            return false;
        }


        public static object OnMono2GameDll(string func, object data = null)
        {
            switch (func)
            {
                case "Mono2GameDllCmd":
                    {
                        //DebugHelper.Mono2GameDllCmd((string)data);
                        break;
                    }
                //case "GetAssetBundleServerURL":
                //    {
                //        //获取资源更新的路径，一般是指从远程服务器更新的地址,带有协议头
                //        string path = "";
                //        t_globalBean httpUpdate = t_globalBean.GetConfig(5);
                //        if (httpUpdate != null)
                //        {
                //            if (httpUpdate.t_int == 1)
                //            {
                //                t_globalBean bean = t_globalBean.GetConfig(4);
                //                if (bean != null)
                //                {
                //                    string http = bean.t_string;
                //                    if (!http.EndsWith("/"))
                //                        http += "/";
                //                    path = http;
                //                }
                //            }
                //        }
                //        else
                //        {
                //            path = "file://" + ResourceManager.getRootPath();
                //        }
                //        return path;

                //    }
                case "RunLua2Bytes":
                    {
                        break;
                    }
            }
            return null;
        }


        public static Vector3 GetMaxVector3()
        {
            return new Vector3(10000, 10000, 10000);
        }

        //====================================
        //数学相关
        //public static int GetDist(VInt2 fvPos1, VInt2 fvPos2)
        //{
        //    VInt2 v = fvPos1 - fvPos2;
        //    return v.magnitude;
        //}
        //public static float GetDist(Vector2 fvPos1, Vector2 fvPos2)
        //{
        //    Vector2 v = fvPos1 - fvPos2;
        //    return v.magnitude;
        //}
        //public static int GetDist(VInt3 fvPos1, VInt3 fvPos2)
        //{
        //    VInt3 v = fvPos1 - fvPos2;
        //    return v.magnitude;
        //}
        //public static int GetDist(int x1, int z1, int x2, int z2)
        //{
        //    return IntMath.Sqrt((x1 - x2) * (x1 - x2) + (z1 - z2) * (z1 - z2));
        //}
        public static float GetDist(float x1, float z1, float x2, float z2)
        {
            return (float)Math.Sqrt((x1 - x2) * (x1 - x2) + (z1 - z2) * (z1 - z2));
        }
        public static float GetDist(Vector3 fvPos1, Vector3 fvPos2)
        {
            return (float)Math.Sqrt((fvPos1.x - fvPos2.x) * (fvPos1.x - fvPos2.x) + (fvPos1.y - fvPos2.y) * (fvPos1.y - fvPos2.y) + (fvPos1.z - fvPos2.z) * (fvPos1.z - fvPos2.z));
        }

        public static float GetDistSq(Vector2 fvPos1, Vector2 fvPos2)
        {
            return (float)(fvPos1.x - fvPos2.x) * (fvPos1.x - fvPos2.x) + (fvPos1.y - fvPos2.y) * (fvPos1.y - fvPos2.y);
        }
        public static float GetDistSq(float x1, float z1, float x2, float z2)
        {
            return (float)(x1 - x2) * (x1 - x2) + (z1 - z2) * (z1 - z2);
        }
        public static float GetDistSq(Vector3 fvPos1, Vector3 fvPos2)
        {
            return (fvPos1.x - fvPos2.x) * (fvPos1.x - fvPos2.x) + (fvPos1.y - fvPos2.y) * (fvPos1.y - fvPos2.y) + (fvPos1.z - fvPos2.z) * (fvPos1.z - fvPos2.z);
        }
      
        //度转方向
        public static Vector3 ConvertYAngleToDirection(float yAngle)
        {
            yAngle = Mathf.Deg2Rad * yAngle;
            float z = Mathf.Cos(yAngle);
            float x = Mathf.Sin(yAngle);
            return new Vector3(x, 0, z);
        }
        public static float GetYAngle(Vector2 fvPos1, Vector2 fvPos2)
        {
            return Vector2.Angle(fvPos1, fvPos2);
        }

        public static Vector3 GetCenter(Vector3 fvPos1, Vector3 fvPos2)
        {
            Vector3 fvRet;
            fvRet.x = (fvPos1.x + fvPos2.x) / 2.0f;
            fvRet.y = (fvPos1.y + fvPos2.y) / 2.0f;
            fvRet.z = (fvPos1.z + fvPos2.z) / 2.0f;
            return fvRet;
        }
        public static float GetHeight(float x, float z)
        {
            BattleManager batmgr = CGameProcedure.s_BattleManager;
            if (batmgr == null)
            {
                return 0;
            }
            else
            {
                IBattle battle = batmgr.GetCurrentBattle();
                if (battle == null)
                {
                    return 0;
                }
                else
                {
                    //UScene scene = battle.GetScene();
                    //if (scene == null)
                    {
                        return 0;
                    }
                    //else
                    //{
                    //    return scene.GetHeight(x, z);
                    //}
                }
            }
        }
        //public static UScene GetCurrentScene()
        //{
        //    BattleManager batmgr = CGameProcedure.s_BattleManager;
        //    if (batmgr == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        IBattle battle = batmgr.GetCurrentBattle();
        //        if (battle == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            return battle.GetScene();
        //        }
        //    }
        //}
        /// <summary>
        /// 获取角色当前移动方向
        /// </summary>
        /// <param name="Camera_Dir">角色参考相机的后方</param>
        /// <param name="UI_MoveDir">角色joystic移动的方向</param>
        public static Vector2 ConvertToRelatedCoord(Vector3 Camera_Dir )
        {
            Vector2 UI_MoveDir = Vector2.zero;
            //角色参考相机的右边
            Vector3 up = Vector3.up;
            Vector3 right = Vector3.Cross(Camera_Dir, up);

            Vector3 move = Vector3.zero;
            move.x = UI_MoveDir.x;
            move.z = UI_MoveDir.y;

            Quaternion q = Quaternion.Euler(right);
            Vector3 dir = q * move;
            UI_MoveDir.Set(dir.x, dir.z);
            return UI_MoveDir;
        }
        //public static bool FixedNextPos(VInt3 vStart, VInt3 vDir, int fSpeed)
        //{
        //    return Tool.GetCurrentScene().CanMoveTo(vStart, vDir, fSpeed);
        //}
        //public static VInt3 GetFixedNextResultPos()
        //{
        //    return Tool.GetCurrentScene().GetCanMoveToPos();
        //}
        //把屏幕坐标转换成 ugui 坐标
        public static Vector2 ScreenPointToUIPoint(RectTransform tran, Vector2 screenPoint, Camera cam)
        {
            if(TransformTool.ScreenPointToLocalPointInRectangle(tran, screenPoint, cam))
            {
                return TransformTool.GetScreenPointToLocalPointInRectangleLocalPosition();
            }
            else
            {
                return Vector2.zero;   
            }
        }

        //得到unity位置可用的float最大值，因为unity对位置进行了特殊处理
        public const float FMaxValue = 10000.0f;

        public static float ConvertCM2M(int cm)
        {
            return (float)cm * 0.01f;
        }
        public static float ConvertMM2Second(int mm)
        {
            return (float)mm * 0.001f;
        }

        public static List<KeyGameObject> GetSlotConfig(GameObject go)
        {
            if (go == null)
            {
                return null;
            }
            SlotConfig cfg = go.GetComponent<SlotConfig>();
            if (cfg == null)
            {
                return null;
            }
            int count = cfg.m_ListGameObject.Count;
            bool hr = false;
            List<KeyGameObject> slots = new List<KeyGameObject>();
            for (int i = 0; i < count; ++i)
            {
                KeyGameObject tr = cfg.m_ListGameObject[i];
                if (tr != null)
                {
                    hr = true;
                    slots.Add(tr);
                }
            }
            return slots;

        }

        //public static CameraManager GetCameraManager()
        //{
        //    BattleManager batmgr = CGameProcedure.s_BattleManager;
        //    if (batmgr != null)
        //    {
        //        return batmgr.GetCurrentBattle().GetCameraManager();
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        public static IBattle GetBattle()
        {
            BattleManager batmgr = CGameProcedure.s_BattleManager;
            if (batmgr != null)
            {
                return batmgr.GetCurrentBattle();
            }
            else
            {
                return null;
            }
        }
        public static bool IsEqual(Vector3 pos1, Vector3 pos2, bool bInt)
        {
            if (bInt)
            {
                return Mathf.FloorToInt(pos1.x) == Mathf.FloorToInt(pos2.x) &&
                Mathf.FloorToInt(pos1.y) == Mathf.FloorToInt(pos2.y) &&
                Mathf.FloorToInt(pos1.z) == Mathf.FloorToInt(pos2.z);
            }
            else
            {
                return pos1.x == pos2.x && pos1.y == pos2.y && pos1.z == pos2.z;
            }
        }
        public class CircleCollideCircleParam 
        {
            public int posx1;
            public int posz1;
            public int r1;
            public int posx2;
            public int posz2;
            public int r2;
        }
        //public static bool CircleCollideCircle(CircleCollideCircleParam param)
        //{
        //    int dist = Tool.GetDist(param.posx1, param.posz1, param.posx2, param.posz2);
        //    int r1r2 = param.r1 + param.r2;
        //    if (dist <= r1r2)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public static int RandomInt(int range, int jindu = 1000)
        //{
        //    if (jindu == 0)
        //    {
        //        jindu = 1000;
        //    }
        //    return Mathf.FloorToInt(LRandom.Random(-jindu, jindu) * range / jindu);
        //}

        public static int FloorToInt(float data)
        {
            return Mathf.FloorToInt(data);
        }


        public static int FloatDot(float num0, float num1)
        {
            return Tool.FloorToInt(num0 * num1);
        }

        private static Main _Main;
        public static Main Main()
        {
            if (_Main != null)
            {
                return _Main;
            }
            else
            {
                GameObject main = GameObject.Find("GameMain");
                if (main != null)
                {
                    _Main = main.GetComponent<Main>();
                    return _Main;
                }
                else
                {
                    UnityEngine.Debug.LogError("GameMain not find");
                    return null;
                }
            }
        }

        private static EventSystem s_EventSystem = null;
        public static EventSystem GetEventSystem()
        {
            if(s_EventSystem == null)
            {
                var obj = GameObject.Find("GlobalUI/EventSystem");
                if(obj != null)
                {
                    s_EventSystem = obj.GetComponent<EventSystem>();
                }
            }
            return s_EventSystem;
        }
        private static CanvasScaler s_CanvasScaler = null;
        public static CanvasScaler GetCanvasScaler()
        {
            if (s_CanvasScaler == null)
            {
                var obj = GameObject.Find("GlobalUI/GlobalCanavs");
                if (obj != null)
                {
                    s_CanvasScaler = obj.GetComponent<CanvasScaler>();
                }
            }
            return s_CanvasScaler;
        }




       
    }
}

using System;
using System.Collections.Generic;

using System.Text;
using LCL;
using UnityEngine;

namespace GameDll
{
    public class InputManager
    {
        public static  bool m_bEnableClick3D = true;
        public static bool m_bEnableClick2D = false;

        private static bool m_Debug = true;
        private static bool m_Enable = false;

        private static bool m_bClicked = false;
        private static bool m_bLastClicked = false;
        private static bool m_bClickUI = false;


        private static GameObject m_ObjectClick = null;
        private static Vector3 m_ClickPosition = Vector3.zero;
        public static Vector2 m_JoystickValue = Vector2.zero;


        private static float m_LastX = 0;
        private static float m_LastY = 0;
        private static float m_deltX = 0;
        private static float m_deltY = 0;
        private static bool m_bMouseDraging = false;


        public static void SetEnabled(bool enable)
        {
            m_Enable = enable;
        }
        public static bool GetEnabled()
        {
            return m_Enable;
        }
        public static void ResetInput()
        {
            m_bClicked = false;
            m_bLastClicked = false;
            m_bClickUI = false;


            m_ObjectClick = null;
            m_ClickPosition = Vector3.zero;
            m_JoystickValue = Vector2.zero;

            m_LastX = 0;
            m_LastY = 0;
            m_deltX = 0;
            m_deltY = 0;
            m_bMouseDraging = false;

        }
        public static void Init()
        {

        }
        public  static void Update()
        {
            OnKeyUpTest();
            if (!m_Enable)
            {
                return;
            }
            //下一帧初始化事件属性
            m_bMouseDraging = false;

            m_bLastClicked = m_bClicked;
            
            if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor)
            {
                m_bClicked=Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2);
            }
            else
            {
                m_bClicked = Input.touchCount > 0;
            }
            if (m_bClicked)
            {
                if (m_bLastClicked)
                {
                    m_deltX = Input.mousePosition.x - m_LastX;
                    m_deltY = Input.mousePosition.y - m_LastY;
                    if (m_deltX != 0 || m_deltY != 0)
                    {
                        if (!m_bMouseDraging)
                        {
                            m_bMouseDraging = true;
                        }
                    }
                }
                else 
                {
                }

            }
            else
            {
                if (m_bLastClicked)
                {
                    if (!m_bMouseDraging)
                    {
                    }
                    ClickUI();
                    if (!m_bClickUI)
                    {
                        SceneObjSelect();
                    }
                }
                m_bMouseDraging = false;

                m_deltY = 0;
                m_deltX = 0;
            }
            m_LastX = Input.mousePosition.x;
            m_LastY = Input.mousePosition.y;
            OnKeyUp();

            UpdateRoleMove();
        }
        public static float GetDragX()
        {
            return m_deltX;
        }
        public static float GetDragY()
        {
            return m_deltY;
        }
        public static Vector2 GetJoystickValue()
        {
            return m_JoystickValue;
        }
        public static bool IsJoystickDirty()
        {
            return !Tool.IsEqual(m_JoystickValue.x, 0.01f) || !Tool.IsEqual(m_JoystickValue.y, 0.01f);
        }
        private static void OnKeyUpTest()
        {
            if (Input.GetKeyUp(KeyCode.T))
            {
                //TestManager test = new TestManager();
                //test.KeyTest();
            }
        }
        private static void OnKeyUp()
        {
            if(Input.GetKeyUp(KeyCode.A))
            {
                Timer t = new Timer();
                t.intervalMMSeconds = 1000;
                int idx = 1;
                t.perCall = (time) =>
                {
                    for (int i = 0; i < 5; ++i)
                    {
                        //Player character = CObjectManager.GetInstance().NewObject(2, idx % 3 + 1) as Player;
                        //if (character != null)
                        //{
                        //    character.InitInstance();
                        //    character.SetId(idx++);
                        //    character.SetPlayer(1);
                        //    character.SetForward(VInt3.forward);
                        //    character.SetPosition(new VInt3(1000 * (idx % 3), 0, 1000 * (idx % 3)));
                        //    character.EnterMap();
                        //    CObjectManager.GetInstance().AddObject(character, true);

                        //    CObjectManager.GetInstance().LeaveView(character);
                        //}
                    }
                };
                t.totalMMSeconds = 1000000;
                CGameProcedure.s_TimerManager.AddTimer(t);

            }

        }

        
        static void ClickUI()
        {
            //这个检测必须要有button等有Interactable的控件
            GameObject uiObj = Tool.GetEventSystem().currentSelectedGameObject;
            if (uiObj != null)
            {
                m_bClickUI = true;
            }
            else
            {
                m_bClickUI = false;
            }

        }
        public static GameObject GetClickObject()
        {
            return m_ObjectClick;
        }
        public static Vector3 GetClickPosition()
        {
            return m_ClickPosition;
        }
        public static bool isClickUI()
        {
            return m_bClickUI;
        }
        public static bool isMouseClick()
        {
            return  !m_bMouseDraging && m_bLastClicked && !m_bClicked;
        }
        public static bool isMousePress()
        {
            return !m_bMouseDraging && m_bLastClicked && m_bClicked;
        }
        public static bool isMouseDraging()
        {
            return m_bMouseDraging;
        }
        public static Vector2 GetMousePos2D()
        {
            Vector2 pos = Vector2.zero;
            if (Application.platform ==  RuntimePlatform.WindowsEditor||Application.platform==RuntimePlatform.OSXEditor)
            {
                pos.x = Input.mousePosition.x;
                pos.y = Input.mousePosition.y;
            }
            else
            {
                pos.x = Input.mousePosition.x;
                pos.y = Input.mousePosition.y;
            }
            return pos;
        }
        public static bool GetMouseOverObject(float x, float y, int layer)
        {
            if (!m_bEnableClick3D || InputManager.isClickUI())
            {
                return false;
            }
            Vector3 screenpos =new Vector3(x, y, 0);
            Ray ray = Tool.ScreenPointToRay(screenpos);


            RaycastHit hitinfo;
            Physics.Raycast(ray, out hitinfo, 10000, layer);
            if (hitinfo.collider == null)
            {
                if (m_Debug)
                {
                    DrawRay(ray);   
                }
                return false;
            }
            Vector3 point = hitinfo.point;
            m_ClickPosition = point;
            m_ObjectClick = hitinfo.collider.gameObject;
            return true;
        }
        private static  void DrawRay(Ray ray)
        {
            //这里是调试用的，所以不必用Vector3
            Vector3 end = ray.origin + 1000 * ray.direction.normalized;
            GameObject line = new GameObject("PathObj");
            LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
            //设置材质  
            lineRenderer.material = new Material(GameDll.ShaderManager.GetShader("Particles/Additive"));
            //设置颜色  
            lineRenderer.SetColors(Color.red, Color.yellow);
            //设置宽度  
            lineRenderer.SetWidth(0.02f, 0.02f);
            lineRenderer.SetVertexCount(2);
            lineRenderer.SetPosition(0, ray.origin);
            lineRenderer.SetPosition(1, end);
        }

        public static void JoystickStopMove()
        {
            //Player my = CObjectManager.GetInstance().GetMySelf();
            //if (my == null) return;

            //BattleMessage.GetInstance().ReqStopMove(my.GetID());
        }
        public static void JoystickChangeDir()
        {
            //Player my = CObjectManager.GetInstance().GetMySelf();
            //if (my == null)
            //    return;
            ////JoystickChangeDirLocal();
            //BattleMessage.GetInstance().ReqMove(my.GetID(), m_JoystickValue.x, m_JoystickValue.y);
        }

        public enum MoveState
        {
            None,
            DirStartStopMoveTest,
            TestStopMoveTime,
            Stop,
            TestStartMove,
        }
        private static MoveState m_MoveState = MoveState.None;
        private static float m_MovingDirTime = Time.timeSinceLevelLoad;
        private static float m_LastJoystickX;
        private static float m_LastJoystickY;
        public static void UpdateRoleMove()
        {
            float x = MonoTool.GetInputAxisX();
            m_JoystickValue.x = x;
            float y =  MonoTool.GetInputAxisY();
            m_JoystickValue.y = y;
            float precision = 0.01f;
            if (m_MoveState != MoveState.None && m_MoveState != MoveState.Stop)
            {
                //UnityEngine.Debug.Log(m_MoveState.ToString() + " x:" + x.ToString("F4") + "y:" + y.ToString("F4") + " lastX:" + m_LastJoystickX.ToString("F4") + " lastY:" + m_LastJoystickY.ToString("F4"));
            }

            switch (m_MoveState)
            {
                case MoveState.None:
                    {
                        if(Math.Abs(x) > precision || Math.Abs(y) > precision)
                        {
                            JoystickChangeDir();
                            m_MoveState = MoveState.DirStartStopMoveTest;
                            m_LastJoystickX = x;
                            m_LastJoystickY = y;
                        }
                        break;
                    }

                case MoveState.DirStartStopMoveTest:
                    {
                        if(Math.Abs(m_LastJoystickX - x)<precision && Math.Abs(m_LastJoystickY - y) < precision )
                        {
                            m_MoveState = MoveState.TestStopMoveTime;
                            m_MovingDirTime = Time.timeSinceLevelLoad;
                        }
                        m_LastJoystickX = x;
                        m_LastJoystickY = y;
                        if (Math.Abs(x)< precision &&  Math.Abs(y) < precision)
                        {
                            m_MoveState = MoveState.Stop;
                        } 

                        break;
                    }
                case MoveState.TestStopMoveTime:
                    {
                        if (Math.Abs(m_LastJoystickX - x) < precision && Math.Abs(m_LastJoystickY - y) < precision)
                        {
                            if(Time.timeSinceLevelLoad - m_MovingDirTime > 0.1f)
                            {
                                JoystickChangeDir();
                                //UnityEngine.Debug.Log("JoystickChangeDir");
                                m_MoveState = MoveState.TestStartMove;

                                m_LastJoystickX = x;
                                m_LastJoystickY = y;
                            }
                        }
                        else
                        {
                            m_LastJoystickX = x;
                            m_LastJoystickY = y;
                            m_MoveState = MoveState.DirStartStopMoveTest;
                        }


                        if (Math.Abs(x) < precision && Math.Abs(y) < precision)
                        {
                            m_MoveState = MoveState.Stop;
                        }
                        break;
                    }
                case MoveState.TestStartMove:
                    {
                        if (Math.Abs(m_LastJoystickX - x) > precision || Math.Abs(m_LastJoystickY - y) > precision)
                        {
                            m_MoveState = MoveState.DirStartStopMoveTest;
                            m_LastJoystickX = x;
                            m_LastJoystickY = y;
                        }

                        if (Math.Abs(x) < precision && Math.Abs(y) < precision)
                        {
                            m_MoveState = MoveState.Stop;
                        }
                        break;
                    }
                case MoveState.Stop:
                    {
                        JoystickStopMove();
                        m_MoveState = MoveState.None;
                        break;
                    }
            }
          
        }
        private static Vector2 m_MousePos = new Vector2();
        private static void SceneObjSelect()
        {
            m_MousePos = GetMousePos2D();
            int _PathObj = 1 << LayerMask.NameToLayer("PathObj");
            int _ClickAble =1 << LayerMask.NameToLayer("ClickAble");
            int layer = _PathObj | _ClickAble;
            //UnityEngine.Debug.Log("SceneObjSelect layer" + layer.ToString());
            bool hr = GetMouseOverObject(m_MousePos.x, m_MousePos.y, layer);
            if (hr)
            {
                //GameObject clickObj = GetClickObject();
                //Vector3 clickPos = GetClickPosition();
                //if (clickObj.layer == LayerMask.NameToLayer("PathObj"))
                //{
                //    ObjectSelector.CancelClickObj();
                //    ClickMoveTo(clickPos);

                //}
                //else
                //{
                //    ObjectSelector.ReceiveClickObj(clickObj);
                //}
            }
            else
            {

            }
        }
        private static void ClickMoveTo(Vector3 endpos)
        {
            bool closePathMoveTo = true;
            if (closePathMoveTo)
            {
                return;
            }
            IBattle battle = CGameProcedure.s_BattleManager.GetCurrentBattle();
            if (battle != null)
            {
                //UScene scene = battle.GetScene();
                //if (scene != null)
                //{
                //    Player my = CObjectManager.GetInstance().GetMySelf();
                //    if (my == null)
                //    {
                //        UnityEngine.Debug.LogError("my is null");
                //        return;
                //    }
                //    VInt3 start = my.GetPosition();
                    //List<VInt3> points = scene.FindPath(start, endpos);
                    //if (points != null)
                    //{
                    //    IFsm state = my.GetFsmMgr().GetState(CharacterState.MovePath);
                    //    if (state != null && state.state == CharacterState.MovePath)
                    //    {
                    //        State_WalkPath wp = (State_WalkPath)state;
                    //        if (wp != null)
                    //        {
                    //            wp.SetPos(points);
                    //            my.GetFsmMgr().ChangeState(CharacterState.MovePath);

                    //            List<float> xlist = wp.GetPosX();
                    //            List<float> zlist = wp.GetPosZ();
                    //            BattleMessage.GetInstance().ReqMovePath(my.GetID(), xlist, zlist);
                    //        }
                    //    }

                    //}
                //}

            }
        }
    }
}

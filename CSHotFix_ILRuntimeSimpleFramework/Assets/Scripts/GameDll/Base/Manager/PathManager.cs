using System;
using System.Collections.Generic;

using System.Text;
using LCL;
using UnityEngine;

namespace GameDll
{

    public class PathManager
    {
        //PathFinderInt m_PathFinder = null;

        //private bool m_bPathLoad = false;
        //public void Reset()
        //{

        //}
        //public void Destroy()
        //{
        //    if (m_PathFinder != null)
        //    {
        //        m_PathFinder.Destroy();
        //        m_PathFinder = null;
        //    }
        //}

        //public void Init()
        //{
        //    m_PathFinder = new PathFinderInt();
        //    m_PathFinder.Init();
        //    m_PathFinder.SetShowMesh(false);
        //    m_PathFinder.SetOpenHightTest(false);
        //}
        //public void LoadPathData(string path,System.Action<bool> call)
        //{
        //    m_bPathLoad = false;
        //    m_PathFinder.LoadPath(path, (ok) => 
        //     {
        //         if (call != null)
        //         {
        //             call(ok);
        //         }
        //         OnLoadPathData(ok); 
        //     });
        //}
        //public void SetPathData(TextAsset data)
        //{
        //    m_PathFinder.OnLoadPath(data.bytes);
        //    OnLoadPathData(true);
        //}
        //private void OnLoadPathData(bool result)
        //{
        //    m_bPathLoad = result;
        //}
        //public bool isPathLoad()
        //{
        //    return m_bPathLoad;
        //}
        //public List<VInt3> FindPath(VInt3 start, VInt3 end )
        //{
        //    return m_PathFinder.FindPath(start, end);
        //}
        //public int GetTriangleIndex(VInt3 pos)
        //{
        //    return m_PathFinder.GetTriangleIndex(pos);
        //}
        //public bool CanMoveTo(VInt3 vStart, VInt3 vDir, int fSpeed)
        //{
        //    if (m_PathFinder == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return m_PathFinder.MoveSide(vStart, vDir, fSpeed);
        //    }
        //}
        //public VInt3 GetMoveToPos()
        //{
        //    return m_PathFinder.GetMoveSideResultPos();
        //}
        //public void Update(float dt)
        //{

        //}

        //public VInt3 GetHeight(VInt3 pos)
        //{
        //    return pos;
        //}
    }
}

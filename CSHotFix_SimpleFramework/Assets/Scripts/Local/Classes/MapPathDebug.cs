using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace LCL
{
    public class MapPathDebug : MonoBehaviour
    {
        public Material m_Material = null;
        public string m_GridFilePath = "Config/NewPlayerCity/new_player_city.path";
        private int[,] m_MapGrid = null;
        private Vector3 m_MapStartPos = Vector3.zero;
        private float m_fCellSize = 1.0f;
        private bool m_bShowGrid = false;
        Vector3[] Points = null;
        Vector2[] UVs = null;
        int[] triangles = null;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyUp(KeyCode.L))
            {
                LoadGrid(m_GridFilePath);
            }

            if (Input.GetKeyUp(KeyCode.G))
            {
                m_bShowGrid = !m_bShowGrid;
            }

        }

        void OnPostRender()
        {
            if (m_bShowGrid && m_Material != null)
            {
                m_Material.SetPass(0);

                GL.Begin(GL.TRIANGLES);
                GL.Color(new Color(1, 1, 1, 1));
                int count = triangles.Length;
                for (int i = 0; i < count; i += 3)
                {

                    GL.Vertex(Points[triangles[i]]);
                    GL.Vertex(Points[triangles[i + 1]]);
                    GL.Vertex(Points[triangles[i + 2]]);

                }
                GL.End();


            }

        }
        private void LoadGrid(string path)
        {
            if (path.Trim() == "")
            {
                m_GridFilePath = "Config/NewPlayerCity/new_player_city.path";
            }
            string fullpath = Application.dataPath + "/../../Dev/" + m_GridFilePath;
            FileStream fs = new FileStream(fullpath, FileMode.Open);
            BinaryReader _reader = new BinaryReader(fs);
            m_MapStartPos.x = _reader.ReadSingle();
            m_MapStartPos.y = _reader.ReadSingle();
            m_MapStartPos.z = _reader.ReadSingle();

            Debug.Log("start node:" + m_MapStartPos.ToString());
            int row = _reader.ReadInt32();
            int col = _reader.ReadInt32();
            m_fCellSize = _reader.ReadSingle();
            m_MapGrid = new int[row, col];
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    m_MapGrid[i, j] = _reader.ReadInt32();
                }
            }
            _reader.Close();
            _reader = null;
            fs.Close();
            fs = null;

            MakeGridMesh();
        }
        private void MakeGridMesh()
        {
            if (m_MapGrid == null)
            {
                return;
            }

            int width = m_MapGrid.GetLength(1);
            int height = m_MapGrid.GetLength(0);
            Points = new Vector3[(width + 1) * (height + 1)];
            UVs = new Vector2[(width + 1) * (height + 1)];
            //012
            //345
            //678
            //
            for (int row = 0; row <= height; ++row)
            {
                for (int col = 0; col <= width; ++col)
                {
                    Points[row * (width + 1) + col] = new Vector3(m_MapStartPos.x + (float)col * m_fCellSize + m_fCellSize / 2.0f,
                        m_MapStartPos.y, m_MapStartPos.z + (float)row * m_fCellSize + m_fCellSize / 2.0f);
                    UVs[row * (width + 1) + col] = new Vector2(0, 0);
                }
            }
            List<int> triIndex = new List<int>();
            for (int row = 0; row < height; ++row)
            {
                for (int col = 0; col < width; ++col)
                {
                    if (m_MapGrid[row, col] == 0)
                    {
                        //得到row行，col列的那个网格是可以行走的，计算他的四个点的index
                        //0      1 .......col
                        //col+1  col+2
                        //0   one        one+1         col    >>>>> 0 one=1   1+1       col=3
                        //4   one+col+1  one+col+1+1   7      >>>>> 4 1+3+1   1+3+1+1   7

                        int one = row * (width + 1) + col;
                        int two = one + 1;
                        int three = one + width + 1;
                        int forth = three + 1;
                        triIndex.Add(three);
                        triIndex.Add(two);
                        triIndex.Add(one);

                        triIndex.Add(three);
                        triIndex.Add(forth);
                        triIndex.Add(two);
                    }
                }
            }
            triangles = triIndex.ToArray();
        }
    }
}
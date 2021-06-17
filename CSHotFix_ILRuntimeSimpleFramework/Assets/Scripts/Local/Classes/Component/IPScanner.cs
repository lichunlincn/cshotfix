using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using LITJson;
using UnityEngine;

namespace LCL
{
    public class IPScanner : MonoBehaviour
    {
        private string GetAddress(string url)
        {

            string ip = "";
            WebRequest wr = WebRequest.Create(url);
            Stream s = wr.GetResponse().GetResponseStream();
            StreamReader sr = new StreamReader(s, Encoding.Default);
            string all = sr.ReadToEnd(); //读取网站的数据 

            JsonData data = JsonMapper.ToObject(all);
            data = data["content"];
            ip = data["address"].ToString();
            sr.Close();
            s.Close();
            return ip;
        }

        void Start()
        {
            string IP = "118.116.121.156";
            string url = "http://api.map.baidu.com/location/ip?ak=f1izilalb1FFTjkXxrH7mo4U&ip=" + IP;
            Debug.Log("当前客户端地址：" + GetAddress(url));
        }
    }

}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;


public class PluginsTool
{
    public static string GetMD5HashFromFile(string fileName)
    {
        try
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }
        catch (Exception ex)
        {
            throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
        }
    }

    private static Camera m_UICamera;
    public static Camera UICamera
    {
        get
        {
            if (m_UICamera == null)
            {
                GameObject camerago  = GameObject.FindGameObjectWithTag("UICamera");
                if (camerago != null)
                {
                    m_UICamera = camerago.GetComponent<Camera>();
                }
                return m_UICamera;
            }
            return null;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace LCL
{
    class Program
    {
        private static string m_DllPath;
        private static string m_DelegatePath;
        static void Main(string[] args)
        {
            LoadCfg();
            if(args!= null && args.Length>0)
            {
                string func = args[0];
                switch(func)
                {
                    case "GenDelegate":
                        {
                            GenDelegate();
                            break;
                        }
                    case "InjectIL":
                        {
                            InjectIL();
                            break;
                        }
                    case "GenStaticField":
                        {
                            GenDelegate();
                            GenStaticField();
                            break;
                        }
                }
            }
        }


        private static void GenDelegate()
        {
            string delegatePath = "C:/GiteeSVN/ProtectGold/Research/MSILInject/Demo/Delegate";
            string dllPath = "C:/GiteeSVN/ProtectGold/Research/MSILInject/Demo/bin/Debug/Demo.exe";
            delegatePath = m_DelegatePath;
            dllPath = m_DllPath;
            try
            {
                DelegateGen delegateGen = new DelegateGen();
                delegateGen.Run(dllPath, delegatePath);
                Console.WriteLine("GenDelegate Ok!");
            }
            catch (Exception exp)
            {
                Console.WriteLine( exp.Message);
            }
        }
        private static void InjectIL()
        {
            string dllPath = "C:/GiteeSVN/ProtectGold/Research/MSILInject/Demo/bin/Debug/Demo.exe";
            dllPath = m_DllPath;
            string delegatePath = m_DelegatePath;
            try
            {
                InjectorMain inject = new InjectorMain();
                inject.Run(dllPath, delegatePath, false);
                Console.WriteLine( "Inject Ok!");
            }
            catch (Exception exp)
            {
                Console.WriteLine( exp.Message + exp.StackTrace);
            }
        }
        private static void LoadCfg()
        {
            try
            {
                string exePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
                string inipath = exePath + "/ini.txt";
                FileStream file = new FileStream(inipath, FileMode.Open);
                StreamReader reader = new StreamReader(file);
                string dllPath = reader.ReadLine();
                dllPath = dllPath.Split('=')[1];
                string delegatePath = reader.ReadLine();
                delegatePath = delegatePath.Split('=')[1];
                m_DelegatePath = exePath+"/../../../"+ delegatePath;
                Console.WriteLine("DelegatePath:" + m_DelegatePath);
                m_DllPath = exePath + "/../../../" + dllPath;
                Console.WriteLine("DllPath:" + m_DllPath);
                reader.Close();
                reader = null;
                file.Close();
                file = null;
            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message);
            }
        }
        private static void GenStaticField()
        {
            string dllPath = "C:/GiteeSVN/ProtectGold/Research/MSILInject/Demo/bin/Debug/Demo.exe";
            dllPath = m_DllPath;
            string delegatePath = m_DelegatePath;
            try
            {
                InjectorMain inject = new InjectorMain();
                inject.Run(dllPath, delegatePath, true);
                Console.WriteLine("GenStaticField Ok!");
            }
            catch (Exception exp)
            {
                Console.WriteLine( exp.Message + exp.StackTrace);
            }
        }

    }
}

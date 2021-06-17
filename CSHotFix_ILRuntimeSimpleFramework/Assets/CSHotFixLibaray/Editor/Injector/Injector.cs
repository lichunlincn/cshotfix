/*
* LCL support c# hotfix here.
*Copyright(C) LCL.All rights reserved.
* URL:https://github.com/qq576067421/cshotfix 
*QQ:576067421 
* QQ Group: 673735733 
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at 
*  
* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. 
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace LCL
{
    public class Injector
    {
        private static string m_DllPath;
        private static string m_DelegatePath;
        private static string[] m_DepDllPath;
        public static void RunGen(string func)
        {
            m_DllPath = GenConfigEditor.CSHotFixMonoDllPath;
            m_DelegatePath = GenConfigEditor.CSHotFixDelegateGenPath;
            m_DepDllPath = GenConfigEditor.CSHotFixMonoDepDllPathes;
            m_DllPath = Path.GetFullPath(m_DllPath);
            m_DelegatePath = Path.GetFullPath(m_DelegatePath);
            switch (func)
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


        private static void GenDelegate()
        {
            DelegateGen delegateGen = new DelegateGen();
            delegateGen.Run(m_DllPath, m_DelegatePath);
            UnityEngine.Debug.Log("GenDelegate Ok!");

        }
        private static void InjectIL()
        {

            InjectorMain inject = new InjectorMain();
            inject.Run(m_DllPath, m_DepDllPath, m_DelegatePath, false);
            UnityEngine.Debug.Log( "Inject Ok!");
        }
        private static void GenStaticField()
        {

            InjectorMain inject = new InjectorMain();
            inject.Run(m_DllPath, m_DepDllPath, m_DelegatePath, true);
            UnityEngine.Debug.Log("GenStaticField Ok!");
        }

    }
}

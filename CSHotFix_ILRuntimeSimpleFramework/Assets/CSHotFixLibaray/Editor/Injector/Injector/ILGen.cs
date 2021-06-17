/*
 * LCL support c# hotfix here.
 * Copyright (C) LCL. All rights reserved.
 * URL:https://github.com/qq576067421/cshotfix
 * QQ:576067421
 * QQ Group:673735733
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Editor_Mono.Cecil;
using Editor_Mono.Cecil.Cil;
namespace LCL
{
    public class ILGen
    {
        public static void GenIL(string delegateFieldName, TypeDefinition type, MethodDefinition method,TypeDefinition delegateTypeRef, TypeDefinition FieldDelegateNameTD)
        {

            //FieldDefinition item = new FieldDefinition(delegateFieldName, FieldAttributes.Static | FieldAttributes.Public, delegateTypeRef);
            //type.Fields.Add(item);
            FieldDefinition FieldDelegateName = FieldDelegateNameTD.Fields.ToList().Find((_fd) => { return _fd.Name == delegateFieldName; });
            if(FieldDelegateName == null)
            {
                return;
            }
            //找到委托的Invoke函数，并且导入到当前类
            var invokeDeclare = type.Module.ImportReference(delegateTypeRef.Methods.Single(x => x.Name == "Invoke"));

            if (!method.HasBody)
                return;

            var insertPoint = method.Body.Instructions[0];
            var ilGenerator = method.Body.GetILProcessor();

            //压入delegate变量
            ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Ldsfld, FieldDelegateName));
            //压入Null
            ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Ldnull));
            //压入比较符号
            ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Cgt_Un));

            //ilspy的误导，其实不用这么写
            //ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Stloc_0));
            //ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Ldloc_0));

            //压入Ifelse语句
            ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Brfalse, insertPoint));


            //处理if大括号内部逻辑
            ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Ldsfld, FieldDelegateName));


            if (method.IsStatic)
            {
                //压入一个null
                ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Ldnull));
            }
            else
            {
                //压入this
                ilGenerator.InsertBefore(insertPoint, CreateLoadArg(ilGenerator, 0));
            }

            for (int i = 0; i < method.Parameters.Count; i++)
            {
                //压入参数
                ilGenerator.InsertBefore(insertPoint, CreateLoadArg(ilGenerator, method.IsStatic ? i : i + 1));
            }


            //调用委托
            ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Call, invokeDeclare));

            if (method.ReturnType.Name == "Void")
            {
                ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Nop));
            }
            //else if (method.ReturnType.IsValueType)
            //{
            //    ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Unbox_Any, method.ReturnType));
            //}
            ilGenerator.InsertBefore(insertPoint, ilGenerator.Create(OpCodes.Ret));
        }

        //参数列表使用的函数
        public static Instruction CreateLoadArg(ILProcessor ilGenerator, int c)
        {
            switch (c)
            {
                case 0:
                    return ilGenerator.Create(OpCodes.Ldarg_0);
                case 1:
                    return ilGenerator.Create(OpCodes.Ldarg_1);
                case 2:
                    return ilGenerator.Create(OpCodes.Ldarg_2);
                case 3:
                    return ilGenerator.Create(OpCodes.Ldarg_3);
            }
            if (c > 0 && c < byte.MaxValue)
                return ilGenerator.Create(OpCodes.Ldarg_S, (byte)c);

            return ilGenerator.Create(OpCodes.Ldarg, c);
        }

        //常量入栈，常用于压入一个int常量等
        public static Instruction CreateLoadIntConst(ILProcessor ilGenerator, int c)
        {
            switch (c)
            {
                case 0:
                    return ilGenerator.Create(OpCodes.Ldc_I4_0);
                case 1:
                    return ilGenerator.Create(OpCodes.Ldc_I4_1);
                case 2:
                    return ilGenerator.Create(OpCodes.Ldc_I4_2);
                case 3:
                    return ilGenerator.Create(OpCodes.Ldc_I4_3);
                case 4:
                    return ilGenerator.Create(OpCodes.Ldc_I4_4);
                case 5:
                    return ilGenerator.Create(OpCodes.Ldc_I4_5);
                case 6:
                    return ilGenerator.Create(OpCodes.Ldc_I4_6);
                case 7:
                    return ilGenerator.Create(OpCodes.Ldc_I4_7);
                case 8:
                    return ilGenerator.Create(OpCodes.Ldc_I4_8);
                case -1:
                    return ilGenerator.Create(OpCodes.Ldc_I4_M1);
            }
            if (c >= sbyte.MinValue && c <= sbyte.MaxValue)
                return ilGenerator.Create(OpCodes.Ldc_I4_S, (sbyte)c);

            return ilGenerator.Create(OpCodes.Ldc_I4, c);
        }
    }

}
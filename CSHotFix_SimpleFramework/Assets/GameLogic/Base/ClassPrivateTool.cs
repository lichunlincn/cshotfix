/*
* LCL support c# hotfix here.
*Copyright(C) LCL.All rights reserved.
* URL:https://github.com/qq576067421/cshotfix 
*QQ:576067421 
* QQ Group: 673735733 
 * Licensed under the GNU License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at 
* http://fsf.org/ 
* Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


public static class ClassPrivateTool
{
    //得到私有字段的值：
    public static object GetPrivateField(this object instance, string fieldname)
    {
        BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = instance.GetType();
        FieldInfo field = type.GetField(fieldname, flag);
        return field.GetValue(instance);
    }
    //得到私有属性的值：
    public static object GetPrivateProperty(this object instance, string propertyname)
    {
        BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = instance.GetType();
        PropertyInfo field = type.GetProperty(propertyname, flag);
        return field.GetValue(instance, null);
    }

    //设置私有成员的值：
    public static void SetPrivateField(this object instance, string fieldname, object value)
    {
        BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = instance.GetType();
        FieldInfo field = type.GetField(fieldname, flag);
        field.SetValue(instance, value);
    }

    //设置私有属性的值：
    public static void SetPrivateProperty(this object instance, string propertyname, object value)
    {
        BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = instance.GetType();
        PropertyInfo field = type.GetProperty(propertyname, flag);
        field.SetValue(instance, value, null);
    }

    //调用私有方法：
    public static object CallPrivateMethod(this object instance, string name, params object[] param)
    {
        BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
        Type type = instance.GetType();
        MethodInfo method = type.GetMethod(name, flag);
        return method.Invoke(instance, param);
    }
}


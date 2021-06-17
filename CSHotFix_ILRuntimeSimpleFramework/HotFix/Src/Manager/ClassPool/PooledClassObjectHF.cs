using System;
using System.Collections.Generic;
using System.Text;

public class PooledClassObjectHF
{
    private bool m_bDelete;

    //系统内部使用
    public virtual void New(object param)
    {
        new NotImplementedException();
    }
    //外部调用
    public virtual void DestroyClass()
    {
        new NotImplementedException();
    }
    //系统内部使用
    public virtual void Delete()
    {
        new NotImplementedException();
    }
    public bool IsDelete()
    {
        return m_bDelete;
    }
    //表明这个变量New的方式
    public bool m_bPoolNew = false;
    //这个变量不熟悉的地方千万不要使用
    public void SetDelete(bool delete)
    {
        m_bDelete = delete;
    }
}
public class PooledClassManagerHF<T> where T : PooledClassObjectHF, new()
{
    private static List<T> m_ClassObjectPooledList = new  List<T>();
    public static T CreateClass(object param = null)
    {
        T hr = default(T);
        Type t = typeof(T);
        if (m_ClassObjectPooledList.Count > 0)
        {
            hr = m_ClassObjectPooledList[0];
            m_ClassObjectPooledList.RemoveAt(0);
        }
        else
        {
            hr = new T();
            hr.m_bPoolNew = true;
        }
        hr.New(param);
        hr.SetDelete(false);
        return hr;
    }

    public static void DeleteClass(T classObject)
    {
        if (classObject == null)
        {
            return;
        }
        if (classObject.IsDelete())
        {
            return;
        }
        classObject.Delete();
        classObject.SetDelete(true);
        m_ClassObjectPooledList.Add(classObject);
    }
}


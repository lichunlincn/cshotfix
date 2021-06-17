using UnityEngine;
using System.Collections;
using System.Reflection;
public abstract class IGameInterface
{
    public abstract void Start();
    public abstract void FixedUpdate();
    public abstract bool Update();
    public abstract void LateUpdate();
    public abstract bool OnGUI();
    public abstract void OnApplicationPause();
    public abstract void OnDestroy();
    public abstract void OnApplicationQuit();
    public abstract void OnPlatformMessage(string msg);
    public abstract object OnMono2GameDll(string func,object data=null);

}


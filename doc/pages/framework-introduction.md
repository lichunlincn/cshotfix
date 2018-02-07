框架介绍
1. “CSHotFixInjector”工程是注入工具，用于向指定的dll注入一些委托变量。<br>
2. “UnityDemo\CSHotFixDemo”是Unity的演示工程，该工程目前是一个比较完整的演示了CSHotFix实例的工程，工程本身在某种角度来说就是一个考虑了实际开发的工程环境，基本可以直接使用。<br>
3. “HotFixDll”工程是热更新工程，该工程生成dll、mdb和pdb到演示工程的Resources目录，平时开发界面和流程性逻辑都是在这个里面写代码。<br>
4. “pdb2mdb”这个是用于将VS生成的pdb转换成mono需要的mdb。<br>


 

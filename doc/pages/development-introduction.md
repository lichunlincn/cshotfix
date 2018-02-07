开始写你的代码
1. 打开unity工程，切换到开发模式，也就是点击ChangeToDevelopment菜单，等待编译通过。<br>
2. 点击“Open C# Project”，使用VS2015（这里所有的环境我都是用我的环境来介绍的，下同），看到有如下几个工程，如果没有“HotFixDll”，请自行添加项目。<br>
![CSHotFix工程](https://github.com/qq576067421/cshotfix/blob/master/doc/pages/20180207220331.png)<br>
3. 如果你的项目计划是一个MMORPG或者类似的风格的，那么你一定会需要把战斗放到能够提供高性能的代码里面，那么请你关注CSHotFixDemo工程，找到GameLogic/Logic,里面有几个类，这里推荐看看MainTest.cs文件。<br>
4. 打开MainTest.cs文件，看到“[CSHotFix(InjectFlag = InjectFlagEnum.Inject)]”，这个标记表明该类是需要参与代码注入的，也就是说我们觉得这个类有可能出现bug，同样NoInject标识类或者方法不需要参与注入。<br>
5. 往下看到“ref out”暂时不支持的字样，不支持怎么办，采用一个DataClass来装这两个变量。泛型貌似很少有热更新框架支持得了。<br>
6. 以上就是战斗的Mono代码，你可以在里面自由的发挥，并且有错误的话可以在我接下来说的地方进行修复。<br>
7. 找到HotFixDll工程，找到HotfixBugs目录，可以看到一个叫做“Bugs_LCL_MainTest.cs”的文件，跟踪“OnHotFixTest”方法的引用，找到HotFixBugsManager，再次跟踪HotFixBugsManager引用，找到HotFixLoop。<br>
8. 回到HotFixBugsManager，留意LCLFieldDelegateName.__LCL_MainTest__Test2_Int32_Single__Delegate， 该出的是一个委托变量，
它是一个我们认为出bug的函数的地方的委托变量，留意他的定义方式，是命名空间+类+函数等用于唯一区分该方法的，那么你也可以类推其他委托变量，
当然我建议你直接用vs自带的智能提示来输入，比较方便快捷。然后按照我是实例中的方式来处理bug。
9. 接着说下在HotFixDll工程里面写界面逻辑以及其他可全部更新的逻辑的方法。找到GameLogic，看到GameMain，然后看到了熟悉的Start，Update等，
相信再也熟悉不过了吧。

 

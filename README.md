

<h1><a id="cshotfix_0"></a>cshotfix</h1>
CSharp bug fix library <br>
<b>QQ group：673735733  （视频教程、各种资料都在qq群）</b><br>
<b>Unity3D 充分测试的版本是5.x~2019的各个版本，当前工程版本2019.2.5f1，首次运行的时候可能需要“注释掉部分代码才可以编译通过;想要看简易demo的请看分支版本1.4。”<b><br><br><br>
<b>据有关开发群介绍，如下游戏可能有用到相关技术。<br>
        腾讯代理的《妖神记》：http://ysj.qq.com/main.html;<br>
        掌趣最近的《热血足球》<br>
        腾讯代理的 《初音未来:梦幻歌姬》 http://miku.qq.com/main.html</br>
        腾讯运用宝：《萌妖出没》：https://sj.qq.com/myapp/detail.htm?apkName=com.tencent.tmgp.mycm </br>
       《我的勇者》：https://apps.apple.com/cn/app/%E6%88%91%E7%9A%84%E5%8B%87%E8%80%85-%E9%AD%94%E5%A5%B3%E7%AF%87/id1458703401</br>
        
 **一、 简介。**<br>
&nbsp; &nbsp; &nbsp; &nbsp; 一个专门用于C#热更新的工具链，使用该工具链，你可以实现两点：<br>
1、<b>使用C#来编写脚本和进行热更新。错误修复过程几乎和正常写代码一样。</b><br>
2、<b>可以对已有的dll、exe进入错误修复。</b><br>
3、<b>可以新增功能，例如常用于游戏运营活动</b>。<br>
4、<b>支持IOS、支持Android，支持mono打包方式、支持IL2CPP打包方式</b><br>

总之，本工具链提倡使用<b>c#来修复c#的bug和新增功能，极大的提高编程效率</b>。欢迎使用。


**二、使用方法。**<br>
   1、“CSHotFix”菜单：点击OneKeyGen一键生成。<br>
   2、一些配置说明：GenConfigPlugins.cs和GenConfigEditor.cs文件里面有一些关于生成适配器、黑白名单。<br>
   3、框架目录：比较重要的是有一个叫做HotFix的工程，该工程用于热更新dll的。<br>
   4、网络协议：这个大家比较关心，可以参考https://github.com/qq576067421/WfBinaryProtocol<br><br>
   5、热更新通用使用建议：将流程代码例如登录逻辑、选人逻辑、大厅（界面型）、开始战斗、结束战斗等对<br>实时性能要求不高的场合使用完全热更新；对战斗逻辑、战斗的Loop采用一个MonoBehaviour,里面包含战斗的各种状态，这些状态由热更新层控制转换，减少战斗中每帧对热更新层的访问。
&nbsp; &nbsp; &nbsp; &nbsp; 总的来说，使用方法极其简单，基本上你可以当做没有热更新来编程。因为我们的情怀就是用c#实现热更新，为的就是节约宝贵的时间，所以自动化必须有！

 
**三、已知问题或者限制。**<br>
&nbsp; &nbsp; &nbsp; &nbsp; 1、函数参数无法使用无限多个参数，目前参数扩展到可接受的个数了。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2、无法支持函数的ref和out参数，如果有用到该类参数的，请封装一个参数类（或者比较正式的叫法是实体类或者数据类）。

**四、适用项目和人群。**<br>
&nbsp; &nbsp; &nbsp; &nbsp;1、完全热更新棋牌类游戏以及其他对性能要求不高的游戏和居于C#的app；部分热更新MMO、RPG等游戏的战斗部分，全更新他们对应的界面功能、外围流程功能。<br>
&nbsp; &nbsp; &nbsp; &nbsp;2、中级以及以上水平的程序员可以很轻松将本方案投入商业使用，并且维护本方案。会C#的就可以编写程序，无法学习多种语言，项目人员成分简单。<br>
&nbsp; &nbsp; &nbsp; &nbsp;3、由于我们无法得知到底有什么项目使用了本方案，方案提供的是源代码，没有黑科技，完全透明，不存在任何so文件，所以你问有什么项目用，我只能说我也不知道。<br>
**五、开发效率和运行效率。**<br>
&nbsp; &nbsp; &nbsp; &nbsp;1、开发效率。完全取决于你对C#的了解程度，调试比lua方案方便很多，支持无差别调试。<br>
&nbsp; &nbsp; &nbsp; &nbsp;2、运行效率。总体来说访问Unity的C#接口比lua方案快，计算数学方面的比lua方案要慢些，但是都是在一个数量级，比纯粹的C#慢10到100倍之间。举个例子如果一个访问GameObject的接口，C#耗时是1ms，那么CSHotFix可能就是13ms，lua就有可能是15ms；再举个例子，在CSHotFix里面计算Vector3*float,可能耗时5ms，lua只要3ms，C#只要0.1ms 。是需要注意的是，由于种种原因，无法给出比较客观的数据，请自行按照相关文档说明进行测试。提醒一句，测试请用发布版本并且关闭所有的log等等影响因素。<br>

**六、更新情况。**<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2019年11月25日：更新unity2019，为了兼顾之前版本，2019需要手动设置HotFix工程“目标框架”为.net framework 4，对比之前版本是3.5。因为unity2019默认框架已经改为了4.0.
&nbsp; &nbsp; &nbsp; &nbsp; 2018年9月20日：更新一个实际项目使用demo。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年3月13日：更新脚本引擎，支持全自动简单菜单操作，经过一定体量项目代码量亲测，表现良好。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年2月7日：适配器自动生成。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年2月7日：优化框架结构，添加调试功能。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年2月6日22:36:38：优化CSHotFix的代码生成方式，生成方式采用一键式生成。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年2月4日11:40:57：添加注入标记，方便选择性控制哪些代码需要注入。<br>
&nbsp; &nbsp; &nbsp; &nbsp;  2018年2月3日：完成对apk等demo的验证，可以正常使用。<br>

**七、QA。**<br>
1、为什么去掉脚本引擎自带调试功能和怎么调试？<br>
     &nbsp; &nbsp;&nbsp; &nbsp;去掉脚本引擎的调试功能，是为了减少脚本引擎的复杂性，原则上只有最后发布IOS的时候才会用到该脚本引擎。<br>
     &nbsp; &nbsp;&nbsp; &nbsp;平时开发都是采用开发模式，将GameMain预制件或者脚本Main上面的UseCSHotFixDll的界面勾勾去掉，此时就是常规dll加载，调试功能完全使用的VS或者Monodevelop常规调试方式。<br>
     &nbsp; &nbsp;&nbsp; &nbsp;这里给大家讲一个附加因素，为了尽可能简单的支持Unity自带的打包Player后的真机调试功能，尽量少用黑科技，也促使了将脚本引擎的调试功能去掉<br>
2、为什么更改脚本引擎的命名空间？<br>
     &nbsp; &nbsp;&nbsp; &nbsp;MIT协议允许；便于CSHotfix统一管理代码，对原脚本引擎关于注入方面有特别的代码修改，无法一味地简单覆盖。<br>
3、如何给中后期的项目添加热更新？<br>
    &nbsp; &nbsp;&nbsp; &nbsp;中后期的项目，一般可能没有考虑到热更新，此时需要添加热更新，就往往只能添加修复bug的功能了。新增功能往往需要改动一些架构，时间消耗较大。<br>
	&nbsp; &nbsp;&nbsp; &nbsp;只是添加修复bug的功能，需要做到的将“CSHotFix入门教程之工程结构了解”中的几个和CSHotFixLibray文件夹拷贝到你的工程的对应位置；拷贝HotFix热更新工程到Assets文件夹同级目录；拷贝pdb2mdb；拷贝UnityEngineLibaray；然后了解HotFixManager.cs这个类在框架工程的使用方法，自行依葫芦画瓢，进行整合。预计消耗半天到2天的时间可以整合完毕。


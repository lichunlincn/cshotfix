

<h1><a id="cshotfix_0"></a>cshotfix</h1>
CSharp bug fix library <br>
<b>QQ group：673735733</b>

 **一、 简介。**<br>
&nbsp; &nbsp; &nbsp; &nbsp; 一个专门用于C#热更新的工具链，使用该工具链，你可以实现两点：<br>
1、<b>使用C#来编写脚本和进行热更新。错误修复过程几乎和正常写代码一样。</b><br>
2、<b>可以对已有的dll、exe进入错误修复。</b><br>
3、<b>可以新增功能，例如常用于游戏运营活动</b>。<br>
4、<b>支持IOS、支持Android，支持mono打包方式、支持IL2CPP打包方式</b><br>
&nbsp; &nbsp;IOS IL2CPP<br>
![image](https://github.com/qq576067421/cshotfix/blob/master/UnityDemo/CSHotFixDemo/CSHotFix_IPhone_IL2CPP.jpg)<br>
&nbsp; &nbsp;Android<br>
![image](https://github.com/qq576067421/cshotfix/blob/master/UnityDemo/CSHotFixDemo/cshotfix_android_il2cpp.png)
&nbsp; &nbsp; &nbsp; &nbsp; 总之，本工具链提倡使用<b>c#来修复c#的bug和新增功能，极大的提高编程效率</b>。欢迎使用。

**二、使用方法。**<br>
&nbsp; &nbsp; &nbsp; &nbsp; 详情见<a href='https://github.com/qq576067421/cshotfix/blob/master/doc/_Sidebar.md'>Wiki文档</a>。

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
&nbsp; &nbsp; &nbsp; &nbsp; 2018年3月13日：更新脚本引擎，支持全自动简单菜单操作，经过一定体量项目代码量亲测，表现良好。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年2月7日：适配器自动生成。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年2月7日：优化框架结构，添加调试功能。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年2月6日22:36:38：优化CSHotFix的代码生成方式，生成方式采用一键式生成。<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年2月4日11:40:57：添加注入标记，方便选择性控制哪些代码需要注入。<br>
&nbsp; &nbsp; &nbsp; &nbsp;  2018年2月3日：完成对apk等demo的验证，可以正常使用。<br>

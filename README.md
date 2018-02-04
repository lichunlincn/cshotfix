

<h1><a id="cshotfix_0"></a>cshotfix</h1>
CSharp bug fix library <br>
<b>QQ group：673735733</b>

 **一、 简介。**<br>
&nbsp; &nbsp; &nbsp; &nbsp; 一个专门用于C#热更新的工具链，使用该工具链，你可以实现两点：
1、<b>使用C#来编写脚本和进行热更新。错误修复过程几乎和正常写代码一样。</b>
2、<b>可以对已有的dll、exe进入错误修复。</b>
3、<b>可以新增功能，例如常用于游戏运营活动</b>（使用第三方库，例如Scorpio-CSharp,ILRuntime,以及其他脚本程序，本工具链默认支持ILRuntime方式）。
4、<b>支持IOS、支持Android，支持mono打包方式、支持IL2CPP打包方式</b>

&nbsp; &nbsp; &nbsp; &nbsp; 总之，本工具链提倡使用<b>c#来修复c#的bug和新增功能，极大的提高编程效率</b>。欢迎使用。

**二、使用方法。**<br>
&nbsp; &nbsp; &nbsp; &nbsp; 详情见我写的<a href='https://github.com/qq576067421/cshotfix/blob/master/%E5%B8%AE%E5%8A%A9%E6%96%87%E6%A1%A3/CSHotFix%E7%83%AD%E6%9B%B4%E6%96%B0%E6%A1%86%E6%9E%B6%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97.doc'>Word文档</a>。

&nbsp; &nbsp; <font size=1 color="#aaaaaa">（这里不得不说下为什么用Word，是因为鄙人实在不喜欢使用不熟悉的文档编辑器，就像你喊我用Vim来写lua代码一样难受，本来几分钟可以完成的C#编码工作，非要用lua写半个小时，熟悉的工具做相同的事情，不装不做，把装作的时间用来花到刀刃上才是有价值的。）</font>

&nbsp; &nbsp; &nbsp; &nbsp; 总的来说，使用方法极其简单，基本上你可以当做没有热更新来编程。因为我们的情怀就是用c#实现热更新，为的就是节约宝贵的时间，所以自动化必须有！

 
**三、已知问题或者限制。**<br>
&nbsp; &nbsp; &nbsp; &nbsp; 1、函数参数无法使用无限多个参数，目前受限于ILRT的Action和Func的参数个数，从原理来说，可以扩展到无限多个，需要手动写那块的扩展，详情ILRT的QQ群或者git。
&nbsp; &nbsp; &nbsp; &nbsp; 2、无法支持函数的ref和out参数，如果有用到该类参数的，请封装一个参数类（或者比较正式的叫法是实体类或者数据类）。

**四、适用项目和人群。**<br>
&nbsp; &nbsp; &nbsp; &nbsp;1、完全热更新棋牌类游戏以及其他对性能要求不高的游戏和居于C#的app；部分热更新MMO、RPG等游戏的战斗部分，全更新他们对应的界面功能、外围流程功能。
&nbsp; &nbsp; &nbsp; &nbsp;2、中级以及以上水平的程序员可以很轻松将本方案投入商业使用，并且维护本方案。
&nbsp; &nbsp; &nbsp; &nbsp;3、由于我们无法得知到底有什么项目使用了本方案，方案提供的是源代码，没有黑科技，完全透明，不存在任何so文件，所以你问有什么项目用，我只能说我也不知道。<br>
**五、更新情况。**<br>
&nbsp; &nbsp; &nbsp; &nbsp; 2018年2月4日11:40:57：添加注入标记，方便选择性控制哪些代码需要注入。
&nbsp; &nbsp; &nbsp; &nbsp;  2018年2月3日：完成对apk等demo的验证，可以正常使用。<br>

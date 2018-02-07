快速入门
1. 更新svn，打开UnityDemo\CSHotFixDemo工程。<br>
2. 确保unity工程编译通过，如果没有，请先根据提示适当注释一些代码。<br>
3. 在unity编辑器中找到Assets目录下面GameStart场景，打开。<br>
4. 找到菜单CSHotFix，点击可以看到多个子菜单。<br>
5. 在CSHotFix菜单下面找到CodeManager->ChangeToRelease,确保该菜单是处于灰色不可点击状态，该状态表明我们我们当前处于发布状态。<br>
6. 依次点击“GenHotFixDelegate”、“GenHotFixField”、“CreateAdapter”、“GenMonoType”，最后点击“GenHotFix”。<br>
    ![CSHotFix菜单](https://github.com/qq576067421/cshotfix.git/trunk/doc/pages/20180207213338.png)<br>
7. 点击运行。当你查看到的信息里面没有“红色”的error日志，就表明你的操作是正确的，否则可能不正确。<br>

 
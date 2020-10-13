namespace HotFix
{
    public class BugFixManager
    {
        public static bool IsOpenHotFix{ get; set;}
        public static void RegHotFixFunction()
        {
#if CSHotFix
            Main m = GameDll.Tool.Main();
            if (!m.m_FixBug)
            {
                return;
            }

            //LCLFieldDelegateName.__GameDll_ShaderManager__CacheShader_System_Void__Delegate += Bugs_GameDll_ShaderManager.CacheShader;
#endif
        }
    }
}
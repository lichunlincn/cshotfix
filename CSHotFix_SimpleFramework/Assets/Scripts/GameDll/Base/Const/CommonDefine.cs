using System;
using System.Collections.Generic;
using System.Text;

namespace GameDll
{
    public enum RoleStateID
    {
        //定义了一个StateId（状态ID）类型的枚举变量，所以我们接下来也要根据实际情况扩展此枚举变量。
        //小写 下划线格式
        null_state_id = 0,
        idle,
        angle,
        run,
        jump,
        MoveTo,
        MoveDir,
    }

    public class ConstString
    {
        public const char FenHao_Semicolon = ';';
        public const char JiaHao_Plus = '+';
        public const string Position = "Position";
        public const string Distance = "Distance";
        public const string Target   = "Target";
        public const string NearstEnemy = "NearstEnemy";
        public const string MinEnemy = "MinEnemy";
        public const string FollowObj = "FollowObj";
        public const string Duration = "Duration";
        public const string Speed = "Speed";
        public const string Tree = "Tree";
        public const string AddPosition = "AddPosition";
    }

    public enum AssetType
    {
        level=0,
        game_object,
        shader,
        lua_script,
        texture_set
    }
    public enum CampType
    {
        Friend = 1,
        Neutral = 2,
        Enemy = 4
    }
    public class Const
    {
        public static float DEF_CHARACTER_POS_ADJUST_DIST = 0.1f;

        public static float DEF_CLIENT_ADJUST_POS_WARP_DIST = 0.1f;
        public static int BehaviroNone = 0;
    }
}

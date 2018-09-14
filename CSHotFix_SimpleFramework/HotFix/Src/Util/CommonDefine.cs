using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HotFix
{


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

    public class Const
    {
        public static float DEF_CHARACTER_POS_ADJUST_DIST = 0.1f;

        public static float DEF_CLIENT_ADJUST_POS_WARP_DIST = 0.1f;
        public static int BehaviroNone = 0;
        public static Vector3 Vector3Max = new Vector3(10000, 10000, 10000);
    }
}

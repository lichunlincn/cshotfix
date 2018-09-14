
#if CSHotFix
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using CSHotFix.CLR.TypeSystem;
using CSHotFix.CLR.Method;
using CSHotFix.Runtime.Enviorment;
using CSHotFix.Runtime.Intepreter;
using CSHotFix.Runtime.Stack;
using CSHotFix.Reflection;
using CSHotFix.CLR.Utils;

namespace CSHotFix.Runtime.Generated
{
    unsafe class UnityEngine_KeyCode_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.KeyCode);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            field = type.GetField("Backspace", flag);
            app.RegisterCLRFieldGetter(field, get_Backspace_1);
            field = type.GetField("Delete", flag);
            app.RegisterCLRFieldGetter(field, get_Delete_2);
            field = type.GetField("Tab", flag);
            app.RegisterCLRFieldGetter(field, get_Tab_3);
            field = type.GetField("Clear", flag);
            app.RegisterCLRFieldGetter(field, get_Clear_4);
            field = type.GetField("Return", flag);
            app.RegisterCLRFieldGetter(field, get_Return_5);
            field = type.GetField("Pause", flag);
            app.RegisterCLRFieldGetter(field, get_Pause_6);
            field = type.GetField("Escape", flag);
            app.RegisterCLRFieldGetter(field, get_Escape_7);
            field = type.GetField("Space", flag);
            app.RegisterCLRFieldGetter(field, get_Space_8);
            field = type.GetField("Keypad0", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad0_9);
            field = type.GetField("Keypad1", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad1_10);
            field = type.GetField("Keypad2", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad2_11);
            field = type.GetField("Keypad3", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad3_12);
            field = type.GetField("Keypad4", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad4_13);
            field = type.GetField("Keypad5", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad5_14);
            field = type.GetField("Keypad6", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad6_15);
            field = type.GetField("Keypad7", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad7_16);
            field = type.GetField("Keypad8", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad8_17);
            field = type.GetField("Keypad9", flag);
            app.RegisterCLRFieldGetter(field, get_Keypad9_18);
            field = type.GetField("KeypadPeriod", flag);
            app.RegisterCLRFieldGetter(field, get_KeypadPeriod_19);
            field = type.GetField("KeypadDivide", flag);
            app.RegisterCLRFieldGetter(field, get_KeypadDivide_20);
            field = type.GetField("KeypadMultiply", flag);
            app.RegisterCLRFieldGetter(field, get_KeypadMultiply_21);
            field = type.GetField("KeypadMinus", flag);
            app.RegisterCLRFieldGetter(field, get_KeypadMinus_22);
            field = type.GetField("KeypadPlus", flag);
            app.RegisterCLRFieldGetter(field, get_KeypadPlus_23);
            field = type.GetField("KeypadEnter", flag);
            app.RegisterCLRFieldGetter(field, get_KeypadEnter_24);
            field = type.GetField("KeypadEquals", flag);
            app.RegisterCLRFieldGetter(field, get_KeypadEquals_25);
            field = type.GetField("UpArrow", flag);
            app.RegisterCLRFieldGetter(field, get_UpArrow_26);
            field = type.GetField("DownArrow", flag);
            app.RegisterCLRFieldGetter(field, get_DownArrow_27);
            field = type.GetField("RightArrow", flag);
            app.RegisterCLRFieldGetter(field, get_RightArrow_28);
            field = type.GetField("LeftArrow", flag);
            app.RegisterCLRFieldGetter(field, get_LeftArrow_29);
            field = type.GetField("Insert", flag);
            app.RegisterCLRFieldGetter(field, get_Insert_30);
            field = type.GetField("Home", flag);
            app.RegisterCLRFieldGetter(field, get_Home_31);
            field = type.GetField("End", flag);
            app.RegisterCLRFieldGetter(field, get_End_32);
            field = type.GetField("PageUp", flag);
            app.RegisterCLRFieldGetter(field, get_PageUp_33);
            field = type.GetField("PageDown", flag);
            app.RegisterCLRFieldGetter(field, get_PageDown_34);
            field = type.GetField("F1", flag);
            app.RegisterCLRFieldGetter(field, get_F1_35);
            field = type.GetField("F2", flag);
            app.RegisterCLRFieldGetter(field, get_F2_36);
            field = type.GetField("F3", flag);
            app.RegisterCLRFieldGetter(field, get_F3_37);
            field = type.GetField("F4", flag);
            app.RegisterCLRFieldGetter(field, get_F4_38);
            field = type.GetField("F5", flag);
            app.RegisterCLRFieldGetter(field, get_F5_39);
            field = type.GetField("F6", flag);
            app.RegisterCLRFieldGetter(field, get_F6_40);
            field = type.GetField("F7", flag);
            app.RegisterCLRFieldGetter(field, get_F7_41);
            field = type.GetField("F8", flag);
            app.RegisterCLRFieldGetter(field, get_F8_42);
            field = type.GetField("F9", flag);
            app.RegisterCLRFieldGetter(field, get_F9_43);
            field = type.GetField("F10", flag);
            app.RegisterCLRFieldGetter(field, get_F10_44);
            field = type.GetField("F11", flag);
            app.RegisterCLRFieldGetter(field, get_F11_45);
            field = type.GetField("F12", flag);
            app.RegisterCLRFieldGetter(field, get_F12_46);
            field = type.GetField("F13", flag);
            app.RegisterCLRFieldGetter(field, get_F13_47);
            field = type.GetField("F14", flag);
            app.RegisterCLRFieldGetter(field, get_F14_48);
            field = type.GetField("F15", flag);
            app.RegisterCLRFieldGetter(field, get_F15_49);
            field = type.GetField("Alpha0", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha0_50);
            field = type.GetField("Alpha1", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha1_51);
            field = type.GetField("Alpha2", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha2_52);
            field = type.GetField("Alpha3", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha3_53);
            field = type.GetField("Alpha4", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha4_54);
            field = type.GetField("Alpha5", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha5_55);
            field = type.GetField("Alpha6", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha6_56);
            field = type.GetField("Alpha7", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha7_57);
            field = type.GetField("Alpha8", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha8_58);
            field = type.GetField("Alpha9", flag);
            app.RegisterCLRFieldGetter(field, get_Alpha9_59);
            field = type.GetField("Exclaim", flag);
            app.RegisterCLRFieldGetter(field, get_Exclaim_60);
            field = type.GetField("DoubleQuote", flag);
            app.RegisterCLRFieldGetter(field, get_DoubleQuote_61);
            field = type.GetField("Hash", flag);
            app.RegisterCLRFieldGetter(field, get_Hash_62);
            field = type.GetField("Dollar", flag);
            app.RegisterCLRFieldGetter(field, get_Dollar_63);
            field = type.GetField("Ampersand", flag);
            app.RegisterCLRFieldGetter(field, get_Ampersand_64);
            field = type.GetField("Quote", flag);
            app.RegisterCLRFieldGetter(field, get_Quote_65);
            field = type.GetField("LeftParen", flag);
            app.RegisterCLRFieldGetter(field, get_LeftParen_66);
            field = type.GetField("RightParen", flag);
            app.RegisterCLRFieldGetter(field, get_RightParen_67);
            field = type.GetField("Asterisk", flag);
            app.RegisterCLRFieldGetter(field, get_Asterisk_68);
            field = type.GetField("Plus", flag);
            app.RegisterCLRFieldGetter(field, get_Plus_69);
            field = type.GetField("Comma", flag);
            app.RegisterCLRFieldGetter(field, get_Comma_70);
            field = type.GetField("Minus", flag);
            app.RegisterCLRFieldGetter(field, get_Minus_71);
            field = type.GetField("Period", flag);
            app.RegisterCLRFieldGetter(field, get_Period_72);
            field = type.GetField("Slash", flag);
            app.RegisterCLRFieldGetter(field, get_Slash_73);
            field = type.GetField("Colon", flag);
            app.RegisterCLRFieldGetter(field, get_Colon_74);
            field = type.GetField("Semicolon", flag);
            app.RegisterCLRFieldGetter(field, get_Semicolon_75);
            field = type.GetField("Less", flag);
            app.RegisterCLRFieldGetter(field, get_Less_76);
            field = type.GetField("Equals", flag);
            app.RegisterCLRFieldGetter(field, get_Equals_77);
            field = type.GetField("Greater", flag);
            app.RegisterCLRFieldGetter(field, get_Greater_78);
            field = type.GetField("Question", flag);
            app.RegisterCLRFieldGetter(field, get_Question_79);
            field = type.GetField("At", flag);
            app.RegisterCLRFieldGetter(field, get_At_80);
            field = type.GetField("LeftBracket", flag);
            app.RegisterCLRFieldGetter(field, get_LeftBracket_81);
            field = type.GetField("Backslash", flag);
            app.RegisterCLRFieldGetter(field, get_Backslash_82);
            field = type.GetField("RightBracket", flag);
            app.RegisterCLRFieldGetter(field, get_RightBracket_83);
            field = type.GetField("Caret", flag);
            app.RegisterCLRFieldGetter(field, get_Caret_84);
            field = type.GetField("Underscore", flag);
            app.RegisterCLRFieldGetter(field, get_Underscore_85);
            field = type.GetField("BackQuote", flag);
            app.RegisterCLRFieldGetter(field, get_BackQuote_86);
            field = type.GetField("A", flag);
            app.RegisterCLRFieldGetter(field, get_A_87);
            field = type.GetField("B", flag);
            app.RegisterCLRFieldGetter(field, get_B_88);
            field = type.GetField("C", flag);
            app.RegisterCLRFieldGetter(field, get_C_89);
            field = type.GetField("D", flag);
            app.RegisterCLRFieldGetter(field, get_D_90);
            field = type.GetField("E", flag);
            app.RegisterCLRFieldGetter(field, get_E_91);
            field = type.GetField("F", flag);
            app.RegisterCLRFieldGetter(field, get_F_92);
            field = type.GetField("G", flag);
            app.RegisterCLRFieldGetter(field, get_G_93);
            field = type.GetField("H", flag);
            app.RegisterCLRFieldGetter(field, get_H_94);
            field = type.GetField("I", flag);
            app.RegisterCLRFieldGetter(field, get_I_95);
            field = type.GetField("J", flag);
            app.RegisterCLRFieldGetter(field, get_J_96);
            field = type.GetField("K", flag);
            app.RegisterCLRFieldGetter(field, get_K_97);
            field = type.GetField("L", flag);
            app.RegisterCLRFieldGetter(field, get_L_98);
            field = type.GetField("M", flag);
            app.RegisterCLRFieldGetter(field, get_M_99);
            field = type.GetField("N", flag);
            app.RegisterCLRFieldGetter(field, get_N_100);
            field = type.GetField("O", flag);
            app.RegisterCLRFieldGetter(field, get_O_101);
            field = type.GetField("P", flag);
            app.RegisterCLRFieldGetter(field, get_P_102);
            field = type.GetField("Q", flag);
            app.RegisterCLRFieldGetter(field, get_Q_103);
            field = type.GetField("R", flag);
            app.RegisterCLRFieldGetter(field, get_R_104);
            field = type.GetField("S", flag);
            app.RegisterCLRFieldGetter(field, get_S_105);
            field = type.GetField("T", flag);
            app.RegisterCLRFieldGetter(field, get_T_106);
            field = type.GetField("U", flag);
            app.RegisterCLRFieldGetter(field, get_U_107);
            field = type.GetField("V", flag);
            app.RegisterCLRFieldGetter(field, get_V_108);
            field = type.GetField("W", flag);
            app.RegisterCLRFieldGetter(field, get_W_109);
            field = type.GetField("X", flag);
            app.RegisterCLRFieldGetter(field, get_X_110);
            field = type.GetField("Y", flag);
            app.RegisterCLRFieldGetter(field, get_Y_111);
            field = type.GetField("Z", flag);
            app.RegisterCLRFieldGetter(field, get_Z_112);
            field = type.GetField("Numlock", flag);
            app.RegisterCLRFieldGetter(field, get_Numlock_113);
            field = type.GetField("CapsLock", flag);
            app.RegisterCLRFieldGetter(field, get_CapsLock_114);
            field = type.GetField("ScrollLock", flag);
            app.RegisterCLRFieldGetter(field, get_ScrollLock_115);
            field = type.GetField("RightShift", flag);
            app.RegisterCLRFieldGetter(field, get_RightShift_116);
            field = type.GetField("LeftShift", flag);
            app.RegisterCLRFieldGetter(field, get_LeftShift_117);
            field = type.GetField("RightControl", flag);
            app.RegisterCLRFieldGetter(field, get_RightControl_118);
            field = type.GetField("LeftControl", flag);
            app.RegisterCLRFieldGetter(field, get_LeftControl_119);
            field = type.GetField("RightAlt", flag);
            app.RegisterCLRFieldGetter(field, get_RightAlt_120);
            field = type.GetField("LeftAlt", flag);
            app.RegisterCLRFieldGetter(field, get_LeftAlt_121);
            field = type.GetField("LeftCommand", flag);
            app.RegisterCLRFieldGetter(field, get_LeftCommand_122);
            field = type.GetField("LeftApple", flag);
            app.RegisterCLRFieldGetter(field, get_LeftApple_123);
            field = type.GetField("LeftWindows", flag);
            app.RegisterCLRFieldGetter(field, get_LeftWindows_124);
            field = type.GetField("RightCommand", flag);
            app.RegisterCLRFieldGetter(field, get_RightCommand_125);
            field = type.GetField("RightApple", flag);
            app.RegisterCLRFieldGetter(field, get_RightApple_126);
            field = type.GetField("RightWindows", flag);
            app.RegisterCLRFieldGetter(field, get_RightWindows_127);
            field = type.GetField("AltGr", flag);
            app.RegisterCLRFieldGetter(field, get_AltGr_128);
            field = type.GetField("Help", flag);
            app.RegisterCLRFieldGetter(field, get_Help_129);
            field = type.GetField("Print", flag);
            app.RegisterCLRFieldGetter(field, get_Print_130);
            field = type.GetField("SysReq", flag);
            app.RegisterCLRFieldGetter(field, get_SysReq_131);
            field = type.GetField("Break", flag);
            app.RegisterCLRFieldGetter(field, get_Break_132);
            field = type.GetField("Menu", flag);
            app.RegisterCLRFieldGetter(field, get_Menu_133);
            field = type.GetField("Mouse0", flag);
            app.RegisterCLRFieldGetter(field, get_Mouse0_134);
            field = type.GetField("Mouse1", flag);
            app.RegisterCLRFieldGetter(field, get_Mouse1_135);
            field = type.GetField("Mouse2", flag);
            app.RegisterCLRFieldGetter(field, get_Mouse2_136);
            field = type.GetField("Mouse3", flag);
            app.RegisterCLRFieldGetter(field, get_Mouse3_137);
            field = type.GetField("Mouse4", flag);
            app.RegisterCLRFieldGetter(field, get_Mouse4_138);
            field = type.GetField("Mouse5", flag);
            app.RegisterCLRFieldGetter(field, get_Mouse5_139);
            field = type.GetField("Mouse6", flag);
            app.RegisterCLRFieldGetter(field, get_Mouse6_140);
            field = type.GetField("JoystickButton0", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton0_141);
            field = type.GetField("JoystickButton1", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton1_142);
            field = type.GetField("JoystickButton2", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton2_143);
            field = type.GetField("JoystickButton3", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton3_144);
            field = type.GetField("JoystickButton4", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton4_145);
            field = type.GetField("JoystickButton5", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton5_146);
            field = type.GetField("JoystickButton6", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton6_147);
            field = type.GetField("JoystickButton7", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton7_148);
            field = type.GetField("JoystickButton8", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton8_149);
            field = type.GetField("JoystickButton9", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton9_150);
            field = type.GetField("JoystickButton10", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton10_151);
            field = type.GetField("JoystickButton11", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton11_152);
            field = type.GetField("JoystickButton12", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton12_153);
            field = type.GetField("JoystickButton13", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton13_154);
            field = type.GetField("JoystickButton14", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton14_155);
            field = type.GetField("JoystickButton15", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton15_156);
            field = type.GetField("JoystickButton16", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton16_157);
            field = type.GetField("JoystickButton17", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton17_158);
            field = type.GetField("JoystickButton18", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton18_159);
            field = type.GetField("JoystickButton19", flag);
            app.RegisterCLRFieldGetter(field, get_JoystickButton19_160);
            field = type.GetField("Joystick1Button0", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button0_161);
            field = type.GetField("Joystick1Button1", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button1_162);
            field = type.GetField("Joystick1Button2", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button2_163);
            field = type.GetField("Joystick1Button3", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button3_164);
            field = type.GetField("Joystick1Button4", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button4_165);
            field = type.GetField("Joystick1Button5", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button5_166);
            field = type.GetField("Joystick1Button6", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button6_167);
            field = type.GetField("Joystick1Button7", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button7_168);
            field = type.GetField("Joystick1Button8", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button8_169);
            field = type.GetField("Joystick1Button9", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button9_170);
            field = type.GetField("Joystick1Button10", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button10_171);
            field = type.GetField("Joystick1Button11", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button11_172);
            field = type.GetField("Joystick1Button12", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button12_173);
            field = type.GetField("Joystick1Button13", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button13_174);
            field = type.GetField("Joystick1Button14", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button14_175);
            field = type.GetField("Joystick1Button15", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button15_176);
            field = type.GetField("Joystick1Button16", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button16_177);
            field = type.GetField("Joystick1Button17", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button17_178);
            field = type.GetField("Joystick1Button18", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button18_179);
            field = type.GetField("Joystick1Button19", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick1Button19_180);
            field = type.GetField("Joystick2Button0", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button0_181);
            field = type.GetField("Joystick2Button1", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button1_182);
            field = type.GetField("Joystick2Button2", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button2_183);
            field = type.GetField("Joystick2Button3", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button3_184);
            field = type.GetField("Joystick2Button4", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button4_185);
            field = type.GetField("Joystick2Button5", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button5_186);
            field = type.GetField("Joystick2Button6", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button6_187);
            field = type.GetField("Joystick2Button7", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button7_188);
            field = type.GetField("Joystick2Button8", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button8_189);
            field = type.GetField("Joystick2Button9", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button9_190);
            field = type.GetField("Joystick2Button10", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button10_191);
            field = type.GetField("Joystick2Button11", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button11_192);
            field = type.GetField("Joystick2Button12", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button12_193);
            field = type.GetField("Joystick2Button13", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button13_194);
            field = type.GetField("Joystick2Button14", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button14_195);
            field = type.GetField("Joystick2Button15", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button15_196);
            field = type.GetField("Joystick2Button16", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button16_197);
            field = type.GetField("Joystick2Button17", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button17_198);
            field = type.GetField("Joystick2Button18", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button18_199);
            field = type.GetField("Joystick2Button19", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick2Button19_200);
            field = type.GetField("Joystick3Button0", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button0_201);
            field = type.GetField("Joystick3Button1", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button1_202);
            field = type.GetField("Joystick3Button2", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button2_203);
            field = type.GetField("Joystick3Button3", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button3_204);
            field = type.GetField("Joystick3Button4", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button4_205);
            field = type.GetField("Joystick3Button5", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button5_206);
            field = type.GetField("Joystick3Button6", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button6_207);
            field = type.GetField("Joystick3Button7", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button7_208);
            field = type.GetField("Joystick3Button8", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button8_209);
            field = type.GetField("Joystick3Button9", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button9_210);
            field = type.GetField("Joystick3Button10", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button10_211);
            field = type.GetField("Joystick3Button11", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button11_212);
            field = type.GetField("Joystick3Button12", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button12_213);
            field = type.GetField("Joystick3Button13", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button13_214);
            field = type.GetField("Joystick3Button14", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button14_215);
            field = type.GetField("Joystick3Button15", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button15_216);
            field = type.GetField("Joystick3Button16", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button16_217);
            field = type.GetField("Joystick3Button17", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button17_218);
            field = type.GetField("Joystick3Button18", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button18_219);
            field = type.GetField("Joystick3Button19", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick3Button19_220);
            field = type.GetField("Joystick4Button0", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button0_221);
            field = type.GetField("Joystick4Button1", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button1_222);
            field = type.GetField("Joystick4Button2", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button2_223);
            field = type.GetField("Joystick4Button3", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button3_224);
            field = type.GetField("Joystick4Button4", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button4_225);
            field = type.GetField("Joystick4Button5", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button5_226);
            field = type.GetField("Joystick4Button6", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button6_227);
            field = type.GetField("Joystick4Button7", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button7_228);
            field = type.GetField("Joystick4Button8", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button8_229);
            field = type.GetField("Joystick4Button9", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button9_230);
            field = type.GetField("Joystick4Button10", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button10_231);
            field = type.GetField("Joystick4Button11", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button11_232);
            field = type.GetField("Joystick4Button12", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button12_233);
            field = type.GetField("Joystick4Button13", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button13_234);
            field = type.GetField("Joystick4Button14", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button14_235);
            field = type.GetField("Joystick4Button15", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button15_236);
            field = type.GetField("Joystick4Button16", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button16_237);
            field = type.GetField("Joystick4Button17", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button17_238);
            field = type.GetField("Joystick4Button18", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button18_239);
            field = type.GetField("Joystick4Button19", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick4Button19_240);
            field = type.GetField("Joystick5Button0", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button0_241);
            field = type.GetField("Joystick5Button1", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button1_242);
            field = type.GetField("Joystick5Button2", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button2_243);
            field = type.GetField("Joystick5Button3", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button3_244);
            field = type.GetField("Joystick5Button4", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button4_245);
            field = type.GetField("Joystick5Button5", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button5_246);
            field = type.GetField("Joystick5Button6", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button6_247);
            field = type.GetField("Joystick5Button7", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button7_248);
            field = type.GetField("Joystick5Button8", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button8_249);
            field = type.GetField("Joystick5Button9", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button9_250);
            field = type.GetField("Joystick5Button10", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button10_251);
            field = type.GetField("Joystick5Button11", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button11_252);
            field = type.GetField("Joystick5Button12", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button12_253);
            field = type.GetField("Joystick5Button13", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button13_254);
            field = type.GetField("Joystick5Button14", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button14_255);
            field = type.GetField("Joystick5Button15", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button15_256);
            field = type.GetField("Joystick5Button16", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button16_257);
            field = type.GetField("Joystick5Button17", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button17_258);
            field = type.GetField("Joystick5Button18", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button18_259);
            field = type.GetField("Joystick5Button19", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick5Button19_260);
            field = type.GetField("Joystick6Button0", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button0_261);
            field = type.GetField("Joystick6Button1", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button1_262);
            field = type.GetField("Joystick6Button2", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button2_263);
            field = type.GetField("Joystick6Button3", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button3_264);
            field = type.GetField("Joystick6Button4", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button4_265);
            field = type.GetField("Joystick6Button5", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button5_266);
            field = type.GetField("Joystick6Button6", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button6_267);
            field = type.GetField("Joystick6Button7", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button7_268);
            field = type.GetField("Joystick6Button8", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button8_269);
            field = type.GetField("Joystick6Button9", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button9_270);
            field = type.GetField("Joystick6Button10", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button10_271);
            field = type.GetField("Joystick6Button11", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button11_272);
            field = type.GetField("Joystick6Button12", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button12_273);
            field = type.GetField("Joystick6Button13", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button13_274);
            field = type.GetField("Joystick6Button14", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button14_275);
            field = type.GetField("Joystick6Button15", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button15_276);
            field = type.GetField("Joystick6Button16", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button16_277);
            field = type.GetField("Joystick6Button17", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button17_278);
            field = type.GetField("Joystick6Button18", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button18_279);
            field = type.GetField("Joystick6Button19", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick6Button19_280);
            field = type.GetField("Joystick7Button0", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button0_281);
            field = type.GetField("Joystick7Button1", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button1_282);
            field = type.GetField("Joystick7Button2", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button2_283);
            field = type.GetField("Joystick7Button3", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button3_284);
            field = type.GetField("Joystick7Button4", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button4_285);
            field = type.GetField("Joystick7Button5", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button5_286);
            field = type.GetField("Joystick7Button6", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button6_287);
            field = type.GetField("Joystick7Button7", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button7_288);
            field = type.GetField("Joystick7Button8", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button8_289);
            field = type.GetField("Joystick7Button9", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button9_290);
            field = type.GetField("Joystick7Button10", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button10_291);
            field = type.GetField("Joystick7Button11", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button11_292);
            field = type.GetField("Joystick7Button12", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button12_293);
            field = type.GetField("Joystick7Button13", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button13_294);
            field = type.GetField("Joystick7Button14", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button14_295);
            field = type.GetField("Joystick7Button15", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button15_296);
            field = type.GetField("Joystick7Button16", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button16_297);
            field = type.GetField("Joystick7Button17", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button17_298);
            field = type.GetField("Joystick7Button18", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button18_299);
            field = type.GetField("Joystick7Button19", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick7Button19_300);
            field = type.GetField("Joystick8Button0", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button0_301);
            field = type.GetField("Joystick8Button1", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button1_302);
            field = type.GetField("Joystick8Button2", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button2_303);
            field = type.GetField("Joystick8Button3", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button3_304);
            field = type.GetField("Joystick8Button4", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button4_305);
            field = type.GetField("Joystick8Button5", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button5_306);
            field = type.GetField("Joystick8Button6", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button6_307);
            field = type.GetField("Joystick8Button7", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button7_308);
            field = type.GetField("Joystick8Button8", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button8_309);
            field = type.GetField("Joystick8Button9", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button9_310);
            field = type.GetField("Joystick8Button10", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button10_311);
            field = type.GetField("Joystick8Button11", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button11_312);
            field = type.GetField("Joystick8Button12", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button12_313);
            field = type.GetField("Joystick8Button13", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button13_314);
            field = type.GetField("Joystick8Button14", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button14_315);
            field = type.GetField("Joystick8Button15", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button15_316);
            field = type.GetField("Joystick8Button16", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button16_317);
            field = type.GetField("Joystick8Button17", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button17_318);
            field = type.GetField("Joystick8Button18", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button18_319);
            field = type.GetField("Joystick8Button19", flag);
            app.RegisterCLRFieldGetter(field, get_Joystick8Button19_320);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.KeyCode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.KeyCode[s]);


        }

        static void WriteBackInstance(CSHotFix.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref UnityEngine.KeyCode instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.KeyCode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.KeyCode.None;
        }
        static object get_Backspace_1(ref object o)
        {
            return UnityEngine.KeyCode.Backspace;
        }
        static object get_Delete_2(ref object o)
        {
            return UnityEngine.KeyCode.Delete;
        }
        static object get_Tab_3(ref object o)
        {
            return UnityEngine.KeyCode.Tab;
        }
        static object get_Clear_4(ref object o)
        {
            return UnityEngine.KeyCode.Clear;
        }
        static object get_Return_5(ref object o)
        {
            return UnityEngine.KeyCode.Return;
        }
        static object get_Pause_6(ref object o)
        {
            return UnityEngine.KeyCode.Pause;
        }
        static object get_Escape_7(ref object o)
        {
            return UnityEngine.KeyCode.Escape;
        }
        static object get_Space_8(ref object o)
        {
            return UnityEngine.KeyCode.Space;
        }
        static object get_Keypad0_9(ref object o)
        {
            return UnityEngine.KeyCode.Keypad0;
        }
        static object get_Keypad1_10(ref object o)
        {
            return UnityEngine.KeyCode.Keypad1;
        }
        static object get_Keypad2_11(ref object o)
        {
            return UnityEngine.KeyCode.Keypad2;
        }
        static object get_Keypad3_12(ref object o)
        {
            return UnityEngine.KeyCode.Keypad3;
        }
        static object get_Keypad4_13(ref object o)
        {
            return UnityEngine.KeyCode.Keypad4;
        }
        static object get_Keypad5_14(ref object o)
        {
            return UnityEngine.KeyCode.Keypad5;
        }
        static object get_Keypad6_15(ref object o)
        {
            return UnityEngine.KeyCode.Keypad6;
        }
        static object get_Keypad7_16(ref object o)
        {
            return UnityEngine.KeyCode.Keypad7;
        }
        static object get_Keypad8_17(ref object o)
        {
            return UnityEngine.KeyCode.Keypad8;
        }
        static object get_Keypad9_18(ref object o)
        {
            return UnityEngine.KeyCode.Keypad9;
        }
        static object get_KeypadPeriod_19(ref object o)
        {
            return UnityEngine.KeyCode.KeypadPeriod;
        }
        static object get_KeypadDivide_20(ref object o)
        {
            return UnityEngine.KeyCode.KeypadDivide;
        }
        static object get_KeypadMultiply_21(ref object o)
        {
            return UnityEngine.KeyCode.KeypadMultiply;
        }
        static object get_KeypadMinus_22(ref object o)
        {
            return UnityEngine.KeyCode.KeypadMinus;
        }
        static object get_KeypadPlus_23(ref object o)
        {
            return UnityEngine.KeyCode.KeypadPlus;
        }
        static object get_KeypadEnter_24(ref object o)
        {
            return UnityEngine.KeyCode.KeypadEnter;
        }
        static object get_KeypadEquals_25(ref object o)
        {
            return UnityEngine.KeyCode.KeypadEquals;
        }
        static object get_UpArrow_26(ref object o)
        {
            return UnityEngine.KeyCode.UpArrow;
        }
        static object get_DownArrow_27(ref object o)
        {
            return UnityEngine.KeyCode.DownArrow;
        }
        static object get_RightArrow_28(ref object o)
        {
            return UnityEngine.KeyCode.RightArrow;
        }
        static object get_LeftArrow_29(ref object o)
        {
            return UnityEngine.KeyCode.LeftArrow;
        }
        static object get_Insert_30(ref object o)
        {
            return UnityEngine.KeyCode.Insert;
        }
        static object get_Home_31(ref object o)
        {
            return UnityEngine.KeyCode.Home;
        }
        static object get_End_32(ref object o)
        {
            return UnityEngine.KeyCode.End;
        }
        static object get_PageUp_33(ref object o)
        {
            return UnityEngine.KeyCode.PageUp;
        }
        static object get_PageDown_34(ref object o)
        {
            return UnityEngine.KeyCode.PageDown;
        }
        static object get_F1_35(ref object o)
        {
            return UnityEngine.KeyCode.F1;
        }
        static object get_F2_36(ref object o)
        {
            return UnityEngine.KeyCode.F2;
        }
        static object get_F3_37(ref object o)
        {
            return UnityEngine.KeyCode.F3;
        }
        static object get_F4_38(ref object o)
        {
            return UnityEngine.KeyCode.F4;
        }
        static object get_F5_39(ref object o)
        {
            return UnityEngine.KeyCode.F5;
        }
        static object get_F6_40(ref object o)
        {
            return UnityEngine.KeyCode.F6;
        }
        static object get_F7_41(ref object o)
        {
            return UnityEngine.KeyCode.F7;
        }
        static object get_F8_42(ref object o)
        {
            return UnityEngine.KeyCode.F8;
        }
        static object get_F9_43(ref object o)
        {
            return UnityEngine.KeyCode.F9;
        }
        static object get_F10_44(ref object o)
        {
            return UnityEngine.KeyCode.F10;
        }
        static object get_F11_45(ref object o)
        {
            return UnityEngine.KeyCode.F11;
        }
        static object get_F12_46(ref object o)
        {
            return UnityEngine.KeyCode.F12;
        }
        static object get_F13_47(ref object o)
        {
            return UnityEngine.KeyCode.F13;
        }
        static object get_F14_48(ref object o)
        {
            return UnityEngine.KeyCode.F14;
        }
        static object get_F15_49(ref object o)
        {
            return UnityEngine.KeyCode.F15;
        }
        static object get_Alpha0_50(ref object o)
        {
            return UnityEngine.KeyCode.Alpha0;
        }
        static object get_Alpha1_51(ref object o)
        {
            return UnityEngine.KeyCode.Alpha1;
        }
        static object get_Alpha2_52(ref object o)
        {
            return UnityEngine.KeyCode.Alpha2;
        }
        static object get_Alpha3_53(ref object o)
        {
            return UnityEngine.KeyCode.Alpha3;
        }
        static object get_Alpha4_54(ref object o)
        {
            return UnityEngine.KeyCode.Alpha4;
        }
        static object get_Alpha5_55(ref object o)
        {
            return UnityEngine.KeyCode.Alpha5;
        }
        static object get_Alpha6_56(ref object o)
        {
            return UnityEngine.KeyCode.Alpha6;
        }
        static object get_Alpha7_57(ref object o)
        {
            return UnityEngine.KeyCode.Alpha7;
        }
        static object get_Alpha8_58(ref object o)
        {
            return UnityEngine.KeyCode.Alpha8;
        }
        static object get_Alpha9_59(ref object o)
        {
            return UnityEngine.KeyCode.Alpha9;
        }
        static object get_Exclaim_60(ref object o)
        {
            return UnityEngine.KeyCode.Exclaim;
        }
        static object get_DoubleQuote_61(ref object o)
        {
            return UnityEngine.KeyCode.DoubleQuote;
        }
        static object get_Hash_62(ref object o)
        {
            return UnityEngine.KeyCode.Hash;
        }
        static object get_Dollar_63(ref object o)
        {
            return UnityEngine.KeyCode.Dollar;
        }
        static object get_Ampersand_64(ref object o)
        {
            return UnityEngine.KeyCode.Ampersand;
        }
        static object get_Quote_65(ref object o)
        {
            return UnityEngine.KeyCode.Quote;
        }
        static object get_LeftParen_66(ref object o)
        {
            return UnityEngine.KeyCode.LeftParen;
        }
        static object get_RightParen_67(ref object o)
        {
            return UnityEngine.KeyCode.RightParen;
        }
        static object get_Asterisk_68(ref object o)
        {
            return UnityEngine.KeyCode.Asterisk;
        }
        static object get_Plus_69(ref object o)
        {
            return UnityEngine.KeyCode.Plus;
        }
        static object get_Comma_70(ref object o)
        {
            return UnityEngine.KeyCode.Comma;
        }
        static object get_Minus_71(ref object o)
        {
            return UnityEngine.KeyCode.Minus;
        }
        static object get_Period_72(ref object o)
        {
            return UnityEngine.KeyCode.Period;
        }
        static object get_Slash_73(ref object o)
        {
            return UnityEngine.KeyCode.Slash;
        }
        static object get_Colon_74(ref object o)
        {
            return UnityEngine.KeyCode.Colon;
        }
        static object get_Semicolon_75(ref object o)
        {
            return UnityEngine.KeyCode.Semicolon;
        }
        static object get_Less_76(ref object o)
        {
            return UnityEngine.KeyCode.Less;
        }
        static object get_Equals_77(ref object o)
        {
            return UnityEngine.KeyCode.Equals;
        }
        static object get_Greater_78(ref object o)
        {
            return UnityEngine.KeyCode.Greater;
        }
        static object get_Question_79(ref object o)
        {
            return UnityEngine.KeyCode.Question;
        }
        static object get_At_80(ref object o)
        {
            return UnityEngine.KeyCode.At;
        }
        static object get_LeftBracket_81(ref object o)
        {
            return UnityEngine.KeyCode.LeftBracket;
        }
        static object get_Backslash_82(ref object o)
        {
            return UnityEngine.KeyCode.Backslash;
        }
        static object get_RightBracket_83(ref object o)
        {
            return UnityEngine.KeyCode.RightBracket;
        }
        static object get_Caret_84(ref object o)
        {
            return UnityEngine.KeyCode.Caret;
        }
        static object get_Underscore_85(ref object o)
        {
            return UnityEngine.KeyCode.Underscore;
        }
        static object get_BackQuote_86(ref object o)
        {
            return UnityEngine.KeyCode.BackQuote;
        }
        static object get_A_87(ref object o)
        {
            return UnityEngine.KeyCode.A;
        }
        static object get_B_88(ref object o)
        {
            return UnityEngine.KeyCode.B;
        }
        static object get_C_89(ref object o)
        {
            return UnityEngine.KeyCode.C;
        }
        static object get_D_90(ref object o)
        {
            return UnityEngine.KeyCode.D;
        }
        static object get_E_91(ref object o)
        {
            return UnityEngine.KeyCode.E;
        }
        static object get_F_92(ref object o)
        {
            return UnityEngine.KeyCode.F;
        }
        static object get_G_93(ref object o)
        {
            return UnityEngine.KeyCode.G;
        }
        static object get_H_94(ref object o)
        {
            return UnityEngine.KeyCode.H;
        }
        static object get_I_95(ref object o)
        {
            return UnityEngine.KeyCode.I;
        }
        static object get_J_96(ref object o)
        {
            return UnityEngine.KeyCode.J;
        }
        static object get_K_97(ref object o)
        {
            return UnityEngine.KeyCode.K;
        }
        static object get_L_98(ref object o)
        {
            return UnityEngine.KeyCode.L;
        }
        static object get_M_99(ref object o)
        {
            return UnityEngine.KeyCode.M;
        }
        static object get_N_100(ref object o)
        {
            return UnityEngine.KeyCode.N;
        }
        static object get_O_101(ref object o)
        {
            return UnityEngine.KeyCode.O;
        }
        static object get_P_102(ref object o)
        {
            return UnityEngine.KeyCode.P;
        }
        static object get_Q_103(ref object o)
        {
            return UnityEngine.KeyCode.Q;
        }
        static object get_R_104(ref object o)
        {
            return UnityEngine.KeyCode.R;
        }
        static object get_S_105(ref object o)
        {
            return UnityEngine.KeyCode.S;
        }
        static object get_T_106(ref object o)
        {
            return UnityEngine.KeyCode.T;
        }
        static object get_U_107(ref object o)
        {
            return UnityEngine.KeyCode.U;
        }
        static object get_V_108(ref object o)
        {
            return UnityEngine.KeyCode.V;
        }
        static object get_W_109(ref object o)
        {
            return UnityEngine.KeyCode.W;
        }
        static object get_X_110(ref object o)
        {
            return UnityEngine.KeyCode.X;
        }
        static object get_Y_111(ref object o)
        {
            return UnityEngine.KeyCode.Y;
        }
        static object get_Z_112(ref object o)
        {
            return UnityEngine.KeyCode.Z;
        }
        static object get_Numlock_113(ref object o)
        {
            return UnityEngine.KeyCode.Numlock;
        }
        static object get_CapsLock_114(ref object o)
        {
            return UnityEngine.KeyCode.CapsLock;
        }
        static object get_ScrollLock_115(ref object o)
        {
            return UnityEngine.KeyCode.ScrollLock;
        }
        static object get_RightShift_116(ref object o)
        {
            return UnityEngine.KeyCode.RightShift;
        }
        static object get_LeftShift_117(ref object o)
        {
            return UnityEngine.KeyCode.LeftShift;
        }
        static object get_RightControl_118(ref object o)
        {
            return UnityEngine.KeyCode.RightControl;
        }
        static object get_LeftControl_119(ref object o)
        {
            return UnityEngine.KeyCode.LeftControl;
        }
        static object get_RightAlt_120(ref object o)
        {
            return UnityEngine.KeyCode.RightAlt;
        }
        static object get_LeftAlt_121(ref object o)
        {
            return UnityEngine.KeyCode.LeftAlt;
        }
        static object get_LeftCommand_122(ref object o)
        {
            return UnityEngine.KeyCode.LeftCommand;
        }
        static object get_LeftApple_123(ref object o)
        {
            return UnityEngine.KeyCode.LeftApple;
        }
        static object get_LeftWindows_124(ref object o)
        {
            return UnityEngine.KeyCode.LeftWindows;
        }
        static object get_RightCommand_125(ref object o)
        {
            return UnityEngine.KeyCode.RightCommand;
        }
        static object get_RightApple_126(ref object o)
        {
            return UnityEngine.KeyCode.RightApple;
        }
        static object get_RightWindows_127(ref object o)
        {
            return UnityEngine.KeyCode.RightWindows;
        }
        static object get_AltGr_128(ref object o)
        {
            return UnityEngine.KeyCode.AltGr;
        }
        static object get_Help_129(ref object o)
        {
            return UnityEngine.KeyCode.Help;
        }
        static object get_Print_130(ref object o)
        {
            return UnityEngine.KeyCode.Print;
        }
        static object get_SysReq_131(ref object o)
        {
            return UnityEngine.KeyCode.SysReq;
        }
        static object get_Break_132(ref object o)
        {
            return UnityEngine.KeyCode.Break;
        }
        static object get_Menu_133(ref object o)
        {
            return UnityEngine.KeyCode.Menu;
        }
        static object get_Mouse0_134(ref object o)
        {
            return UnityEngine.KeyCode.Mouse0;
        }
        static object get_Mouse1_135(ref object o)
        {
            return UnityEngine.KeyCode.Mouse1;
        }
        static object get_Mouse2_136(ref object o)
        {
            return UnityEngine.KeyCode.Mouse2;
        }
        static object get_Mouse3_137(ref object o)
        {
            return UnityEngine.KeyCode.Mouse3;
        }
        static object get_Mouse4_138(ref object o)
        {
            return UnityEngine.KeyCode.Mouse4;
        }
        static object get_Mouse5_139(ref object o)
        {
            return UnityEngine.KeyCode.Mouse5;
        }
        static object get_Mouse6_140(ref object o)
        {
            return UnityEngine.KeyCode.Mouse6;
        }
        static object get_JoystickButton0_141(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton0;
        }
        static object get_JoystickButton1_142(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton1;
        }
        static object get_JoystickButton2_143(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton2;
        }
        static object get_JoystickButton3_144(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton3;
        }
        static object get_JoystickButton4_145(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton4;
        }
        static object get_JoystickButton5_146(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton5;
        }
        static object get_JoystickButton6_147(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton6;
        }
        static object get_JoystickButton7_148(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton7;
        }
        static object get_JoystickButton8_149(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton8;
        }
        static object get_JoystickButton9_150(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton9;
        }
        static object get_JoystickButton10_151(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton10;
        }
        static object get_JoystickButton11_152(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton11;
        }
        static object get_JoystickButton12_153(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton12;
        }
        static object get_JoystickButton13_154(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton13;
        }
        static object get_JoystickButton14_155(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton14;
        }
        static object get_JoystickButton15_156(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton15;
        }
        static object get_JoystickButton16_157(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton16;
        }
        static object get_JoystickButton17_158(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton17;
        }
        static object get_JoystickButton18_159(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton18;
        }
        static object get_JoystickButton19_160(ref object o)
        {
            return UnityEngine.KeyCode.JoystickButton19;
        }
        static object get_Joystick1Button0_161(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button0;
        }
        static object get_Joystick1Button1_162(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button1;
        }
        static object get_Joystick1Button2_163(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button2;
        }
        static object get_Joystick1Button3_164(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button3;
        }
        static object get_Joystick1Button4_165(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button4;
        }
        static object get_Joystick1Button5_166(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button5;
        }
        static object get_Joystick1Button6_167(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button6;
        }
        static object get_Joystick1Button7_168(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button7;
        }
        static object get_Joystick1Button8_169(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button8;
        }
        static object get_Joystick1Button9_170(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button9;
        }
        static object get_Joystick1Button10_171(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button10;
        }
        static object get_Joystick1Button11_172(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button11;
        }
        static object get_Joystick1Button12_173(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button12;
        }
        static object get_Joystick1Button13_174(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button13;
        }
        static object get_Joystick1Button14_175(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button14;
        }
        static object get_Joystick1Button15_176(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button15;
        }
        static object get_Joystick1Button16_177(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button16;
        }
        static object get_Joystick1Button17_178(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button17;
        }
        static object get_Joystick1Button18_179(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button18;
        }
        static object get_Joystick1Button19_180(ref object o)
        {
            return UnityEngine.KeyCode.Joystick1Button19;
        }
        static object get_Joystick2Button0_181(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button0;
        }
        static object get_Joystick2Button1_182(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button1;
        }
        static object get_Joystick2Button2_183(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button2;
        }
        static object get_Joystick2Button3_184(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button3;
        }
        static object get_Joystick2Button4_185(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button4;
        }
        static object get_Joystick2Button5_186(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button5;
        }
        static object get_Joystick2Button6_187(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button6;
        }
        static object get_Joystick2Button7_188(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button7;
        }
        static object get_Joystick2Button8_189(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button8;
        }
        static object get_Joystick2Button9_190(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button9;
        }
        static object get_Joystick2Button10_191(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button10;
        }
        static object get_Joystick2Button11_192(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button11;
        }
        static object get_Joystick2Button12_193(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button12;
        }
        static object get_Joystick2Button13_194(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button13;
        }
        static object get_Joystick2Button14_195(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button14;
        }
        static object get_Joystick2Button15_196(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button15;
        }
        static object get_Joystick2Button16_197(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button16;
        }
        static object get_Joystick2Button17_198(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button17;
        }
        static object get_Joystick2Button18_199(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button18;
        }
        static object get_Joystick2Button19_200(ref object o)
        {
            return UnityEngine.KeyCode.Joystick2Button19;
        }
        static object get_Joystick3Button0_201(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button0;
        }
        static object get_Joystick3Button1_202(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button1;
        }
        static object get_Joystick3Button2_203(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button2;
        }
        static object get_Joystick3Button3_204(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button3;
        }
        static object get_Joystick3Button4_205(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button4;
        }
        static object get_Joystick3Button5_206(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button5;
        }
        static object get_Joystick3Button6_207(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button6;
        }
        static object get_Joystick3Button7_208(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button7;
        }
        static object get_Joystick3Button8_209(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button8;
        }
        static object get_Joystick3Button9_210(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button9;
        }
        static object get_Joystick3Button10_211(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button10;
        }
        static object get_Joystick3Button11_212(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button11;
        }
        static object get_Joystick3Button12_213(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button12;
        }
        static object get_Joystick3Button13_214(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button13;
        }
        static object get_Joystick3Button14_215(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button14;
        }
        static object get_Joystick3Button15_216(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button15;
        }
        static object get_Joystick3Button16_217(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button16;
        }
        static object get_Joystick3Button17_218(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button17;
        }
        static object get_Joystick3Button18_219(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button18;
        }
        static object get_Joystick3Button19_220(ref object o)
        {
            return UnityEngine.KeyCode.Joystick3Button19;
        }
        static object get_Joystick4Button0_221(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button0;
        }
        static object get_Joystick4Button1_222(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button1;
        }
        static object get_Joystick4Button2_223(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button2;
        }
        static object get_Joystick4Button3_224(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button3;
        }
        static object get_Joystick4Button4_225(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button4;
        }
        static object get_Joystick4Button5_226(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button5;
        }
        static object get_Joystick4Button6_227(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button6;
        }
        static object get_Joystick4Button7_228(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button7;
        }
        static object get_Joystick4Button8_229(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button8;
        }
        static object get_Joystick4Button9_230(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button9;
        }
        static object get_Joystick4Button10_231(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button10;
        }
        static object get_Joystick4Button11_232(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button11;
        }
        static object get_Joystick4Button12_233(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button12;
        }
        static object get_Joystick4Button13_234(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button13;
        }
        static object get_Joystick4Button14_235(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button14;
        }
        static object get_Joystick4Button15_236(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button15;
        }
        static object get_Joystick4Button16_237(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button16;
        }
        static object get_Joystick4Button17_238(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button17;
        }
        static object get_Joystick4Button18_239(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button18;
        }
        static object get_Joystick4Button19_240(ref object o)
        {
            return UnityEngine.KeyCode.Joystick4Button19;
        }
        static object get_Joystick5Button0_241(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button0;
        }
        static object get_Joystick5Button1_242(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button1;
        }
        static object get_Joystick5Button2_243(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button2;
        }
        static object get_Joystick5Button3_244(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button3;
        }
        static object get_Joystick5Button4_245(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button4;
        }
        static object get_Joystick5Button5_246(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button5;
        }
        static object get_Joystick5Button6_247(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button6;
        }
        static object get_Joystick5Button7_248(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button7;
        }
        static object get_Joystick5Button8_249(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button8;
        }
        static object get_Joystick5Button9_250(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button9;
        }
        static object get_Joystick5Button10_251(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button10;
        }
        static object get_Joystick5Button11_252(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button11;
        }
        static object get_Joystick5Button12_253(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button12;
        }
        static object get_Joystick5Button13_254(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button13;
        }
        static object get_Joystick5Button14_255(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button14;
        }
        static object get_Joystick5Button15_256(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button15;
        }
        static object get_Joystick5Button16_257(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button16;
        }
        static object get_Joystick5Button17_258(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button17;
        }
        static object get_Joystick5Button18_259(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button18;
        }
        static object get_Joystick5Button19_260(ref object o)
        {
            return UnityEngine.KeyCode.Joystick5Button19;
        }
        static object get_Joystick6Button0_261(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button0;
        }
        static object get_Joystick6Button1_262(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button1;
        }
        static object get_Joystick6Button2_263(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button2;
        }
        static object get_Joystick6Button3_264(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button3;
        }
        static object get_Joystick6Button4_265(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button4;
        }
        static object get_Joystick6Button5_266(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button5;
        }
        static object get_Joystick6Button6_267(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button6;
        }
        static object get_Joystick6Button7_268(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button7;
        }
        static object get_Joystick6Button8_269(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button8;
        }
        static object get_Joystick6Button9_270(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button9;
        }
        static object get_Joystick6Button10_271(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button10;
        }
        static object get_Joystick6Button11_272(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button11;
        }
        static object get_Joystick6Button12_273(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button12;
        }
        static object get_Joystick6Button13_274(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button13;
        }
        static object get_Joystick6Button14_275(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button14;
        }
        static object get_Joystick6Button15_276(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button15;
        }
        static object get_Joystick6Button16_277(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button16;
        }
        static object get_Joystick6Button17_278(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button17;
        }
        static object get_Joystick6Button18_279(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button18;
        }
        static object get_Joystick6Button19_280(ref object o)
        {
            return UnityEngine.KeyCode.Joystick6Button19;
        }
        static object get_Joystick7Button0_281(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button0;
        }
        static object get_Joystick7Button1_282(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button1;
        }
        static object get_Joystick7Button2_283(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button2;
        }
        static object get_Joystick7Button3_284(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button3;
        }
        static object get_Joystick7Button4_285(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button4;
        }
        static object get_Joystick7Button5_286(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button5;
        }
        static object get_Joystick7Button6_287(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button6;
        }
        static object get_Joystick7Button7_288(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button7;
        }
        static object get_Joystick7Button8_289(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button8;
        }
        static object get_Joystick7Button9_290(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button9;
        }
        static object get_Joystick7Button10_291(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button10;
        }
        static object get_Joystick7Button11_292(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button11;
        }
        static object get_Joystick7Button12_293(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button12;
        }
        static object get_Joystick7Button13_294(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button13;
        }
        static object get_Joystick7Button14_295(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button14;
        }
        static object get_Joystick7Button15_296(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button15;
        }
        static object get_Joystick7Button16_297(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button16;
        }
        static object get_Joystick7Button17_298(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button17;
        }
        static object get_Joystick7Button18_299(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button18;
        }
        static object get_Joystick7Button19_300(ref object o)
        {
            return UnityEngine.KeyCode.Joystick7Button19;
        }
        static object get_Joystick8Button0_301(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button0;
        }
        static object get_Joystick8Button1_302(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button1;
        }
        static object get_Joystick8Button2_303(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button2;
        }
        static object get_Joystick8Button3_304(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button3;
        }
        static object get_Joystick8Button4_305(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button4;
        }
        static object get_Joystick8Button5_306(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button5;
        }
        static object get_Joystick8Button6_307(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button6;
        }
        static object get_Joystick8Button7_308(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button7;
        }
        static object get_Joystick8Button8_309(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button8;
        }
        static object get_Joystick8Button9_310(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button9;
        }
        static object get_Joystick8Button10_311(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button10;
        }
        static object get_Joystick8Button11_312(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button11;
        }
        static object get_Joystick8Button12_313(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button12;
        }
        static object get_Joystick8Button13_314(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button13;
        }
        static object get_Joystick8Button14_315(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button14;
        }
        static object get_Joystick8Button15_316(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button15;
        }
        static object get_Joystick8Button16_317(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button16;
        }
        static object get_Joystick8Button17_318(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button17;
        }
        static object get_Joystick8Button18_319(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button18;
        }
        static object get_Joystick8Button19_320(ref object o)
        {
            return UnityEngine.KeyCode.Joystick8Button19;
        }

        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.KeyCode();
            ins = (UnityEngine.KeyCode)o;
            return ins;
        }


    }
}
#endif

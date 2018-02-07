
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
    unsafe class UnityEngine_Networking_Match_NetworkMatch_Binding
    {
        public static void Register(CSHotFix.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Networking.Match.NetworkMatch);
            args = new Type[]{};
            method = type.GetMethod("get_baseUri", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_baseUri_0);
            args = new Type[]{typeof(System.Uri)};
            method = type.GetMethod("set_baseUri", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_baseUri_1);
            args = new Type[]{typeof(System.String), typeof(System.UInt32), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo>)};
            method = type.GetMethod("CreateMatch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateMatch_2);
            args = new Type[]{typeof(UnityEngine.Networking.Types.NetworkID), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo>)};
            method = type.GetMethod("JoinMatch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinMatch_3);
            args = new Type[]{typeof(UnityEngine.Networking.Types.NetworkID), typeof(System.Int32), typeof(UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate)};
            method = type.GetMethod("DestroyMatch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyMatch_4);
            args = new Type[]{typeof(UnityEngine.Networking.Types.NetworkID), typeof(UnityEngine.Networking.Types.NodeID), typeof(System.Int32), typeof(UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate)};
            method = type.GetMethod("DropConnection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DropConnection_5);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<System.Collections.Generic.List<UnityEngine.Networking.Match.MatchInfoSnapshot>>)};
            method = type.GetMethod("ListMatches", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ListMatches_6);
            args = new Type[]{typeof(UnityEngine.Networking.Types.NetworkID), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate)};
            method = type.GetMethod("SetMatchAttributes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetMatchAttributes_7);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Networking.Match.NetworkMatch());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Networking.Match.NetworkMatch[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_baseUri_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.NetworkMatch instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.NetworkMatch)typeof(UnityEngine.Networking.Match.NetworkMatch).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.baseUri;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_baseUri_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Uri value = (System.Uri)typeof(System.Uri).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Networking.Match.NetworkMatch instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.NetworkMatch)typeof(UnityEngine.Networking.Match.NetworkMatch).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.baseUri = value;

            return __ret;
        }

        static StackObject* CreateMatch_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo> callback = (UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo>)typeof(UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 requestDomain = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 eloScoreForMatch = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String privateClientAddress = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String publicClientAddress = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.String matchPassword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Boolean matchAdvertise = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.UInt32 matchSize = (uint)ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.String matchName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Networking.Match.NetworkMatch instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.NetworkMatch)typeof(UnityEngine.Networking.Match.NetworkMatch).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateMatch(matchName, matchSize, matchAdvertise, matchPassword, publicClientAddress, privateClientAddress, eloScoreForMatch, requestDomain, callback);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* JoinMatch_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo> callback = (UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo>)typeof(UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<UnityEngine.Networking.Match.MatchInfo>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 requestDomain = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 eloScoreForClient = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String privateClientAddress = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String publicClientAddress = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.String matchPassword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Networking.Types.NetworkID netId = (UnityEngine.Networking.Types.NetworkID)typeof(UnityEngine.Networking.Types.NetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Networking.Match.NetworkMatch instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.NetworkMatch)typeof(UnityEngine.Networking.Match.NetworkMatch).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.JoinMatch(netId, matchPassword, publicClientAddress, privateClientAddress, eloScoreForClient, requestDomain, callback);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DestroyMatch_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate callback = (UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate)typeof(UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 requestDomain = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Networking.Types.NetworkID netId = (UnityEngine.Networking.Types.NetworkID)typeof(UnityEngine.Networking.Types.NetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Networking.Match.NetworkMatch instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.NetworkMatch)typeof(UnityEngine.Networking.Match.NetworkMatch).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DestroyMatch(netId, requestDomain, callback);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DropConnection_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate callback = (UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate)typeof(UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 requestDomain = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Networking.Types.NodeID dropNodeId = (UnityEngine.Networking.Types.NodeID)typeof(UnityEngine.Networking.Types.NodeID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Networking.Types.NetworkID netId = (UnityEngine.Networking.Types.NetworkID)typeof(UnityEngine.Networking.Types.NetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Networking.Match.NetworkMatch instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.NetworkMatch)typeof(UnityEngine.Networking.Match.NetworkMatch).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DropConnection(netId, dropNodeId, requestDomain, callback);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ListMatches_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<System.Collections.Generic.List<UnityEngine.Networking.Match.MatchInfoSnapshot>> callback = (UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<System.Collections.Generic.List<UnityEngine.Networking.Match.MatchInfoSnapshot>>)typeof(UnityEngine.Networking.Match.NetworkMatch.DataResponseDelegate<System.Collections.Generic.List<UnityEngine.Networking.Match.MatchInfoSnapshot>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 requestDomain = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 eloScoreTarget = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean filterOutPrivateMatchesFromResults = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String matchNameFilter = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 resultPageSize = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 startPageNumber = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Networking.Match.NetworkMatch instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.NetworkMatch)typeof(UnityEngine.Networking.Match.NetworkMatch).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ListMatches(startPageNumber, resultPageSize, matchNameFilter, filterOutPrivateMatchesFromResults, eloScoreTarget, requestDomain, callback);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetMatchAttributes_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate callback = (UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate)typeof(UnityEngine.Networking.Match.NetworkMatch.BasicResponseDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 requestDomain = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean isListed = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Networking.Types.NetworkID networkId = (UnityEngine.Networking.Types.NetworkID)typeof(UnityEngine.Networking.Types.NetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Networking.Match.NetworkMatch instance_of_this_method;
            instance_of_this_method = (UnityEngine.Networking.Match.NetworkMatch)typeof(UnityEngine.Networking.Match.NetworkMatch).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SetMatchAttributes(networkId, isListed, requestDomain, callback);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            CSHotFix.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Networking.Match.NetworkMatch();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

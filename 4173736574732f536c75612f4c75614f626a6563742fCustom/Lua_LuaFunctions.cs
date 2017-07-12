using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_LuaFunctions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			LuaFunctions o;
			o=new LuaFunctions();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HasFunction(IntPtr l) {
		try {
			LuaFunctions self=(LuaFunctions)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasFunction(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HasConstructor(IntPtr l) {
		try {
			LuaFunctions self=(LuaFunctions)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasConstructor(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadScript(IntPtr l) {
		try {
			LuaFunctions self=(LuaFunctions)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			var ret=self.LoadScript(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CallWithError(IntPtr l) {
		try {
			LuaFunctions self=(LuaFunctions)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object[] a2;
			checkParams(l,3,out a2);
			var ret=self.CallWithError(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Call(IntPtr l) {
		try {
			LuaFunctions self=(LuaFunctions)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object[] a2;
			checkParams(l,3,out a2);
			var ret=self.Call(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateInstance(IntPtr l) {
		try {
			LuaFunctions self=(LuaFunctions)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.CreateInstance(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RegisterType(IntPtr l) {
		try {
			LuaFunctions self=(LuaFunctions)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			self.RegisterType(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"LuaFunctions");
		addMember(l,HasFunction);
		addMember(l,HasConstructor);
		addMember(l,LoadScript);
		addMember(l,CallWithError);
		addMember(l,Call);
		addMember(l,CreateInstance);
		addMember(l,RegisterType);
		createTypeMetatable(l,constructor, typeof(LuaFunctions));
	}
}

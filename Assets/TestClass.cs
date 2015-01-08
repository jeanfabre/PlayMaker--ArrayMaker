using System.Collections;

using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;

public class TestClass : FsmStateAction {
	
	public FsmVar yo;
	
	public bool oneBool;
	
	public bool[] manyBools;
	
	[UIHint(UIHint.Variable)]
	public FsmString hello;
	
}
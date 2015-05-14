using UnityEngine;
using System.Collections;

using HutongGames.PlayMaker;

public class SendData : MonoBehaviour {
	
	public PlayMakerFSM fsm;
	
	public string eventName = "MY EVENT";
	public string myData = "hello";
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.anyKeyDown)
		{
			SendEvent();
		}
	}
	
	void SendEvent()
	{
		FsmEventData eventData= new FsmEventData();
		eventData.StringData = myData;
		
		HutongGames.PlayMaker.Fsm.EventData = eventData;
		
		
		FsmEventTarget _eventTarget = new FsmEventTarget();
		_eventTarget.excludeSelf = false;
		FsmOwnerDefault owner = new FsmOwnerDefault();
		owner.OwnerOption = OwnerDefaultOption.SpecifyGameObject;
		owner.GameObject = new FsmGameObject();
		owner.GameObject.Value = fsm.gameObject;
		_eventTarget.gameObject = owner;
		_eventTarget.fsmComponent = fsm;
		_eventTarget.target = FsmEventTarget.EventTarget.GameObjectFSM;	
			
		_eventTarget.sendToChildren = false;
		
		fsm.Fsm.Event(_eventTarget,eventName);
	}
}

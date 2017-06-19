using UnityEngine;
using System.Collections;

public class AddItems : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Hashtable _tableInfo = GetComponent<PlayMakerHashTableProxy>().hashTable;
		

		//Update the tableInfo hash with new data
		_tableInfo.Add("tableID", null);
		_tableInfo.Add("numPlayers", 12);
		_tableInfo.Add("numRuns", 34);
		_tableInfo.Add("gameNum", 123);

	}
	

}

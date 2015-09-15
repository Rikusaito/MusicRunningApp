using UnityEngine;
using System.Collections;

public class Test_Map_Gen : MonoBehaviour {

	private int stage_Num = 0;

	private const int stageHeight = 16;
	private const int stageWidth = 50;

	// Use this for initialization
	void Start () {
		ReadMap ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ReadMap (){
		TextAsset csv = Resources.Load ("CSV/Stage/testStage") as TextAsset;

		string[] lineArray = csv.text.Replace ("\r\n", "\n").Split ('\n');


		int obj_ID = 0;

		for (int y = stageHeight; y < stageHeight; y--) {
			Debug.Log ("kiteruyo-");
			string[] file_Data = lineArray [y].Split ("," [0]);
			for (int x = 0; x < file_Data.Length; x++) {
				Debug.Log (file_Data [x]);
				if (file_Data [x] != "") {
					GameObject go = Instantiate (Resources.Load ("Prefab/Floor_map_" + obj_ID), new Vector3 (0 + x, 0, 0), Quaternion.identity) as GameObject;
				}
			}
		}

	}


}

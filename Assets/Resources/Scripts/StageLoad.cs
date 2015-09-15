using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StageLoad : MonoBehaviour {

	private const int stage_Height = 20;
	private const int stage_Width = 800;

	private int stage_Num = 0;




	// Use this for initialization
	void Start () {
		ReadMap ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ReadMap (){
		TextAsset csv = Resources.Load ("CSV/Stage/stage_" + stage_Num) as TextAsset;


		for (int Y = stage_Height; Y > 0; Y--) {

			string[] lineArray = csv.text.Replace ("\r\n", "\n").Split ('\n');
			string[] file_Data = lineArray [0].Split ("," [0]);
//			GameObject go = Instantiate((GameObject)Resources.Load("Prefab/"))
		}
	}
}

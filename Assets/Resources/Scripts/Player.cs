using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private float BPM = 150f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate ((Vector3.right * BPM * 0.5f) * Time.deltaTime); 
	}
}

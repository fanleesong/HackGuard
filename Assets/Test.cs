using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		HGObject aa;
		HGInt m = new HGInt (10);
		HGInt n = new HGInt (5);
		Debug.Log(m + n);
		Debug.Log(3 + m);
		Debug.Log(m + 2);
		Debug.Log(m - n);
		Debug.Log(m - 3);
	}

	// Update is called once per frame
	void Update () {
	
	}
}

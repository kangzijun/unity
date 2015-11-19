using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        // 缩放
        transform.localScale -= new Vector3( 0.5f, 0.0f, 0.2f );
	}
}

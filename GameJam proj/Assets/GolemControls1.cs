using UnityEngine;
using System.Collections;

public class GolemControls1 : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey("A"))
        {
            this.transform.position += new Vector3 ()
        }
	}
}

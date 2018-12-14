using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour {

    public GameObject other;

	// Use this for initialization
	void Start () {
        transform.rotation = other.transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(Vector3.up * 50 * Time.deltaTime);
        
	}
}

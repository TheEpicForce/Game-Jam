using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polyController : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.localRotation.z <= 1 && transform.localRotation.z > -80)
            {
                transform.Rotate(Vector3.back * 90f * Time.deltaTime, Space.Self);
            }
            
            
        }
        else
        {
            if (transform.localRotation.z < 0 && transform.localRotation.z > -80)
            {
                transform.Rotate(Vector3.forward * 90f * Time.deltaTime, Space.Self);
            }

        }


    }
}

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
        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(Vector3.back * 90f * Time.deltaTime, Space.Self);
            //Debug.Log("D key pressed");


        }
        else if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(Vector3.forward * 90f * Time.deltaTime, Space.Self);

            //Debug.Log("A Key Pressed");

        }
        else if ((!Input.GetKey(KeyCode.A) || (!Input.GetKey(KeyCode.D)) && transform.localRotation.z > 0 && transform.localRotation.z < 180))
        {
           // Debug.Log(transform.localRotation.eulerAngles.magnitude);
            if (!(transform.localRotation.eulerAngles.magnitude < 1 && transform.localRotation.eulerAngles.magnitude > -1))
            {
                transform.Rotate(Vector3.back * 90f * Time.deltaTime, Space.Self);

            }
        }
        
    }
}

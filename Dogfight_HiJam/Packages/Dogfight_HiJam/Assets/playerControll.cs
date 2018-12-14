using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControll : MonoBehaviour {

    public float speed = 5f;
    public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);

        Quaternion toHere = Quaternion.AngleAxis(0, Vector3.forward);

        //transform.position = Vector3.MoveTowards(transform.position, Vector3.up, speed * Time.deltaTime);
        transform.Translate(Vector3.up * speed * Time.deltaTime);



        if (Input.GetKeyDown(KeyCode.Space))
        {
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * 500f * Time.deltaTime);
                //= Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.back * 500f * Time.deltaTime);
            //= Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            
        }
    }

}

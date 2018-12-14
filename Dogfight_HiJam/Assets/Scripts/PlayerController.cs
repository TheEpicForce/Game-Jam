using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float moveSpeed;

    private Rigidbody rb;

    private Vector3 moveInput;

    private Vector3 moveVelocity;

    private Camera mainCamera;

    public GunController theGun;
    public GunController theGun1;
    

    // Use this for initialization
    void Start () {

        //rb = GetComponent<Rigidbody>();

        moveInput = transform.position;
        mainCamera = FindObjectOfType<Camera>();

	}
	
	// Update is called once per frame
	void Update () {
        
        //moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));
        //moveVelocity = moveInput * moveSpeed;
        /*float rayLength;

        

        if (groundPlane.Raycast(cameraRay, out rayLength)) {

            Vector3 pointToLook = cameraRay.GetPoint(rayLength);

            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

            transform.LookAt(new Vector3(pointToLook.x,transform.position.y, pointToLook.z));

            moveInput = new Vector3(pointToLook.x, pointToLook.y, pointToLook.z);

            transform.position = Vector3.Lerp(transform.position, moveInput, moveSpeed);

            
        }
        */
        /* if (Input.GetMouseButtonDown(0))
        {
            theGun.isFiring = true;
            theGun1.isFiring = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            theGun.isFiring = false;
            theGun1.isFiring = false;
        }*/

        //moveVelocity = moveInput * moveSpeed;

        //Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);

        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

        


        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

       
        
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.up * 200f * Time.deltaTime, Space.World);
            theGun.isFiring = false;
            theGun1.isFiring = false;
            
            
        }
        else {
            theGun.isFiring = true;
            theGun1.isFiring = true;
            

        }
        
    }

    private void FixedUpdate()
    {
        //rb.velocity = Vector3.zero;

        //Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        //Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

        //float rayLength;

        //if (groundPlane.Raycast(ray, out rayLength))
        //{

        //    Vector3 pointToLook = ray.GetPoint(rayLength);
        //    moveInput = new Vector3(pointToLook.x, transform.position.y, pointToLook.z);

        //    transform.position = moveInput;


        //}

    }
}

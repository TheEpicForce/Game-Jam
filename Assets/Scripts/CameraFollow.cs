using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float xMax;
    [SerializeField] private float yMax;
    [SerializeField] private float xMin;
    [SerializeField] private float yMin;
    [SerializeField] private float yoffSet;
    [SerializeField] private float xoffSet;
    private Transform player;


    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = new Vector3(Mathf.Clamp(player.position.x + xoffSet, xMin, xMax), Mathf.Clamp(player.position.y + yoffSet, yMin, yMax), transform.position.z);
    }

}
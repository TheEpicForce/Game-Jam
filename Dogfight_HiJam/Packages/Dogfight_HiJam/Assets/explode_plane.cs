using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode_plane : MonoBehaviour
{
    public GameObject effect;
    public float Time;
    // Use this for initialization
    void Start()
    {
        Invoke("Explode", 5);
    }
    public void Explode()
    {
        GameObject explosion = Instantiate(effect, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(explosion, 3.0f);
    }
}

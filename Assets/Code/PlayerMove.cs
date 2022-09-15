using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{   
    public float speed = 10;
    Rigidbody _rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        float zspeed = Input.GetAxis("Vertical") * speed;
        float xspeed = Input.GetAxis("Horizontal") * speed;
        _rigidBody.AddForce(new Vector3(xspeed,0,zspeed));
    }
}

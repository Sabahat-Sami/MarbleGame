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
        if(Input.GetAxis("Horizontal") != 0){
            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
                print("Rotating");
                transform.Rotate(new Vector3(transform.rotation.x, 270, transform.rotation.z));
            }
            else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
                transform.Rotate(new Vector3(transform.rotation.x, 90, transform.rotation.z));
            }
    }
    }
}

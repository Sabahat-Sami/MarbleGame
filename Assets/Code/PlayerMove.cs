using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{   
    public float speed = 500;
    Rigidbody _rigidBody;
    public GameObject focalPoint;
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
        // _rigidBody.AddForce(new Vector3(xspeed,0,zspeed));
        _rigidBody.AddForce(focalPoint.transform.forward * zspeed);
        print(        focalPoint.transform.forward * zspeed);
        _rigidBody.AddForce(focalPoint.transform.right * xspeed);

        if(transform.position.y < -5){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
    
}

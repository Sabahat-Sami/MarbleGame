using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTrans;
    Vector3 offSet;
    float turnSpeed = 5;
    bool wasSpacePressed = false;
    // Start is called before the first frame update
    void Start()
    {
     playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
     offSet = transform.position - playerTrans.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTrans.position +  offSet;
        
        if(Input.GetKeyDown(KeyCode.A)){
            transform.Rotate(new Vector3(0, 90, 0));
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            transform.Rotate(new Vector3(0, 180, 0));
            wasSpacePressed = true;
        }
        if(Input.GetKeyUp(KeyCode.Space) && wasSpacePressed){
            transform.Rotate(new Vector3(0, 180, 0));
            wasSpacePressed = false;
        }
    }

}

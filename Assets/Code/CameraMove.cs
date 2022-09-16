using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTrans;
    Transform frontCameraTrans;
    Transform rearCameraTrans;

    GameObject mainCamera;
    GameObject rearCamera;
    Vector3 offSet;
    float smoothSpeed = 0.1f;
    bool wasSpacePressed = false;
  
    // Start is called before the first frame update
    void Start()
    {
     playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
     frontCameraTrans = GameObject.FindGameObjectWithTag("MainCamera").transform;
     rearCameraTrans = GameObject.FindGameObjectWithTag("RearCamera").transform;
     mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
     rearCamera = GameObject.FindGameObjectWithTag("RearCamera");
     rearCamera.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = playerTrans.position;
        rearCameraTrans.position = playerTrans.position;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + Input.GetAxis("Horizontal") * 1f, 0);
       
        if(Input.GetKeyDown(KeyCode.Space)){
            rearCamera.SetActive(true);
            mainCamera.SetActive(false);
            wasSpacePressed = true;
        }
        if(Input.GetKeyUp(KeyCode.Space) && wasSpacePressed){
            rearCamera.SetActive(false);
            mainCamera.SetActive(true);
            wasSpacePressed = false;
        }
    }
      
}

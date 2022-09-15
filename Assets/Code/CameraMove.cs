using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTrans;
    Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
     playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerTrans.position;
    }
}

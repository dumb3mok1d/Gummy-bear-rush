using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{


    //what we are following
    public Transform target;

    //zeros out velocity
    Vector3 velocity = Vector3.zero;
    Vector3 offset = new Vector3(0,7f,0);

    //time to follow target
    public float smoothTime = .15f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.position + offset;

        //align the camera and the target z position
        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}

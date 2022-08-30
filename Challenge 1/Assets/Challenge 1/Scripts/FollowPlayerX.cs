using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(35, -1, -7);

    // Start is called before the first frame update
    void Start()
    {

    }

    
    void LateUpdate()
    {
        // offset the position of the camera at the side of the plane
        transform.position = plane.transform.position + offset;
    }
}

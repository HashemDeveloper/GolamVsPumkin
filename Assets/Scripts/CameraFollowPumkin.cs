using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPumkin : MonoBehaviour
{
    private Transform pumkinPosition;
    private float yDistance = 4f;
    private float zDistance = 10f;
    // Start is called before the first frame update
    void Awake()
    {
        this.pumkinPosition = GameObject.Find("Pumkin").transform;
    }

    // Update is called once per frame
    void Update()
    {
        followCamera();
    }
    private void followCamera() {
        Vector3 temPosition = transform.position;
        temPosition.y = this.pumkinPosition.position.y + this.yDistance;
        temPosition.z = this.pumkinPosition.position.z - this.zDistance; // minus because we want camera to be behind pumkin
        // reassign the value of transposition to default
        transform.position = temPosition;
    }
}

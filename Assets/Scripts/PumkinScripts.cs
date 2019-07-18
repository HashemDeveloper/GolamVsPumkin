using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumkinScripts : MonoBehaviour
{
    public float moveForce = 10.0F;
    private Rigidbody rigidBody;
    // Start is called before the first frame update

    /**
     /// Awake is called when the script instance is being loaded.
     // this function is gonna be called first before start() method
     */
    void Awake()
    {
        this.rigidBody = GetComponent<Rigidbody>();
    }
    // start() is for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -20 && transform.position.y < -20) {
            Time.timeScale = 0.0f;
        }
    }
    /**
        thie following method FixedUpdate() gets called at the moment of every 15 frame gets executed
     */
    void FixedUpdate() {
        movePumkin();
    }
    private void movePumkin() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // Vector3 represents 3D vectors and points. it moves object in x-axis, y-axis and z-axis
        // x-axis is move left to right, y-axis is move up and down while z-axis moves back and forward
        // therefore, Vector3 takes these 3 parameters(x, y, z)
        this.rigidBody.AddForce(new Vector3(horizontal * moveForce, 0.0F, vertical * moveForce));
    }
    
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "GOLAM" || target.tag == "GATES") {
            Time.timeScale = 0f;
        }
    }
}

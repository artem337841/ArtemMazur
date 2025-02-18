using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public string id;
    public float speed;
    public float turnSpeed;
    public float verticalInput;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
     
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical" + id);
        horizontalInput = Input.GetAxis("Horizontal" + id);

        transform.Translate(Vector3.forward*speed * Time.deltaTime *verticalInput);
        transform.Rotate(Vector3.up , turnSpeed * Time.deltaTime * horizontalInput);
    }
}

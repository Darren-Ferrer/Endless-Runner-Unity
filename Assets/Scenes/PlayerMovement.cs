using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float leftRightSpeed;
    public Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector3.forward * speed * Time.deltaTime); // Forever moving forward

        if (Input.GetKeyDown(KeyCode.A)) 
        {
            rigid.velocity = new Vector3(0,0,-leftRightSpeed);
        }

        if (Input.GetKeyDown(KeyCode.D)) 
        {
            rigid.velocity = new Vector3(0,0,leftRightSpeed);
        }
    }
}

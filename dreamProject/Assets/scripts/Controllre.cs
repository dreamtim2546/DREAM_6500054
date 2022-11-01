using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(transform.position);

        //transform.position = new Vector3(0, 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        //print("hello");
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(0, 5, 0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(0, -5, 0);
        }      
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(-5, 0, 0);
        }        
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(5, 0, 0);
        }      
        else if(Input.GetKeyUp(KeyCode.W)|| Input.GetKeyUp(KeyCode.S)||Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D))
        {
            transform.position = new Vector3(0, 0, 0);
        }*/
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.001f, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y -0.001f,0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - 0.001f, transform.position.y, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + 0.001f, transform.position.y, 0);
        }
    }
}

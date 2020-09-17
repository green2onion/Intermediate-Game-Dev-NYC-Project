using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Walking direction: 0 = idle, 1 = verticle, 2 = left, 3 = right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed);
            GetComponent<Animator>().SetInteger("Walking Direction", 3);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed);
            GetComponent<Animator>().SetInteger("Walking Direction", 2);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed);
            GetComponent<Animator>().SetInteger("Walking Direction", 1);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed);
            GetComponent<Animator>().SetInteger("Walking Direction", 1);
        }
        else
        {
            GetComponent<Animator>().SetInteger("Walking Direction", 0);
        }
    }
}

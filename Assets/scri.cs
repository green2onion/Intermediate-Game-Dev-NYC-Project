using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    public GameObject[] listOfObjects;
    // Start is called before the first frame update
    void Start()
    {
        
        listOfObjects = GameObject.FindGameObjectsWithTag("item");
        int items = listOfObjects.Length;
        Debug.Log(items);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

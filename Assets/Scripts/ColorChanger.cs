using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{


    public Color streetLightColor;
    // Start is called before the first frame update
    void Start()
    {
        streetLightColor = new Color();
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<SpriteRenderer>().color = streetLightColor;


    }
}

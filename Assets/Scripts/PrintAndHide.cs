using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PrintAndHide : MonoBehaviour
{
    private int i, targetNum;

    private string objName;

    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        targetNum = 150 + (int)(Random.value * 100); 
        objName = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {  
       Debug.Log(objName + ":" + ++i);
       if (this.gameObject.tag.Equals("Red") && i == 100)
       {
           Destroy(this);
       }else if (this.gameObject.tag.Equals("Blue") && i == targetNum)
       {
           Destroy(this);
       }
    }
}

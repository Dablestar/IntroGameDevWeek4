using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;

    private string objName;

    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        objName = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {  
       Debug.Log(objName + ":" + ++i); 
    }
}

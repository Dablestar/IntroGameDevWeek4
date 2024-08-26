using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;

    [SerializeField] GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        redObj.transform.position = new Vector3(2, 0, 0);
        GameObject.Instantiate(redObj);

        blueObj.transform.position = new Vector3(-2, 0, 0);
        GameObject.Instantiate(blueObj);
        
        QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

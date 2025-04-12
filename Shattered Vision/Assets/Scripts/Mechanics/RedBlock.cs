using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlock : MonoBehaviour
{
    public bool redOn;
    public GameObject RedBlockTest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (redOn)
        {
            RedBlockTest.SetActive(true);
        }
        else if (!redOn)
        {
            RedBlockTest.SetActive(false);
        }
    }
}

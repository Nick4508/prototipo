using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBlock : MonoBehaviour
{
    public bool greenOn;
    public GameObject GreenBlockTest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (greenOn)
        {
            GreenBlockTest.SetActive(true);
        }
        else if (!greenOn)
        {
            GreenBlockTest.SetActive(false);
        }
    }
}

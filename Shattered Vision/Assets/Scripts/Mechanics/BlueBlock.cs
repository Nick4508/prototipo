using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBlock : MonoBehaviour
{
    public bool blueOn;
    public GameObject BlueBlockTest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (blueOn)
        {
            BlueBlockTest.SetActive(true);
        }
        else if (!blueOn)
        {
            BlueBlockTest.SetActive(false);
        }
    }
}

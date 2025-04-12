using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBlock : MonoBehaviour
{
    public bool yellowOn;
    public GameObject YellowBlockTest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (yellowOn)
        {
            YellowBlockTest.SetActive(true);
        }
        else if (!yellowOn)
        {
            YellowBlockTest.SetActive(false);
        }
    }
}

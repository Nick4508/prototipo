using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaconDisableatSpawn : MonoBehaviour
{
    public GameObject block;
    private RedBlock redColor;
    private BlueBlock blueColor;
    private GreenBlock greenColor;
    bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        redColor = block.GetComponent<RedBlock>();
        greenColor = block.GetComponent<GreenBlock>();
        blueColor = block.GetComponent<BlueBlock>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isColliding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isColliding = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isColliding)
        {
            redColor.redOn = false;
            greenColor.greenOn = false;
            blueColor.blueOn = false;
            Debug.Log("Beacons inactivas");
        }
    }
}

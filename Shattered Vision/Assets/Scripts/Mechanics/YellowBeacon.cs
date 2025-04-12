using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBeacon : MonoBehaviour
{
    public GameObject block;
    private YellowBlock yellowColor;
    bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        yellowColor = block.GetComponent<YellowBlock>();
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
        if (isColliding && Input.GetKeyDown(KeyCode.E) && !yellowColor.yellowOn)
        {
            yellowColor.yellowOn = true;
            Debug.Log("Amarillo activado");
        }
        else if (isColliding && Input.GetKeyDown(KeyCode.E) && yellowColor.yellowOn)
        {
            yellowColor.yellowOn = false;
            Debug.Log("Amarillo desactivado");
        }
    }
}
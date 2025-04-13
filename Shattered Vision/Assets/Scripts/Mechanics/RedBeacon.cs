using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBeacon : MonoBehaviour
{
    public GameObject block;
    private RedBlock redColor;
    bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        redColor = block.GetComponent<RedBlock>();
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
        if (isColliding && Input.GetKeyDown(KeyCode.E) && !redColor.redOn)
        {
            redColor.redOn = true;
            Debug.Log("Rojo activado");
        }
        else if (isColliding && Input.GetKeyDown(KeyCode.E) && redColor.redOn)
        {
            redColor.redOn = false;
            Debug.Log("Rojo desactivado");
        }
    }
}

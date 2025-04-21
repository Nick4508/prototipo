using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class GreenBeacon : MonoBehaviour
{
    public GameObject block;
    public AudioClip greenUp;
    public AudioClip greenDown;
    private GreenBlock greenColor;
    bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        greenColor = block.GetComponent<GreenBlock>();
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
        if (isColliding && Input.GetKeyDown(KeyCode.E) && !greenColor.greenOn)
        {
            greenColor.greenOn = true;
            Debug.Log("Verde activado");
            AudioSource.PlayClipAtPoint(greenUp, transform.position);
        }
        else if (isColliding && Input.GetKeyDown(KeyCode.E) && greenColor.greenOn)
        {
            greenColor.greenOn = false;
            Debug.Log("Verde desactivado");
            AudioSource.PlayClipAtPoint(greenDown, transform.position);
        }
    }
}
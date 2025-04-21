using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class BlueBeacon : MonoBehaviour
{
    public GameObject block;
    public AudioClip blueUp;
    public AudioClip blueDown;
    private BlueBlock blueColor;
    bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
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
        if (isColliding && Input.GetKeyDown(KeyCode.E) && !blueColor.blueOn)
        {
            blueColor.blueOn = true;
            Debug.Log("Azul activado");
            AudioSource.PlayClipAtPoint(blueUp, transform.position);
        }
        else if (isColliding && Input.GetKeyDown(KeyCode.E) && blueColor.blueOn)
        {
            blueColor.blueOn = false;
            Debug.Log("Azul desactivado");
            AudioSource.PlayClipAtPoint(blueDown, transform.position);
        }
    }
}

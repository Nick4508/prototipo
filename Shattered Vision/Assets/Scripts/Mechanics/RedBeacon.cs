using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEditor;
using UnityEngine;

public class RedBeacon : MonoBehaviour
{
    public GameObject block;
    public AudioClip redUp;
    public AudioClip redDown;
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
            AudioSource.PlayClipAtPoint(redUp, transform.position);
        }
        else if (isColliding && Input.GetKeyDown(KeyCode.E) && redColor.redOn)
        {
            redColor.redOn = false;
            Debug.Log("Rojo desactivado");
            AudioSource.PlayClipAtPoint(redDown, transform.position);
        }
    }
}

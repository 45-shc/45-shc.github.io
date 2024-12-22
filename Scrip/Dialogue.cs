using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject dialogue;
    void Start()
    {
        dialogue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        dialogue.SetActive(true);
        Player.speed = 3f;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        dialogue.SetActive(false);
        Player.speed = 8f;
    }
}

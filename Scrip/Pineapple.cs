using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pineapple : MonoBehaviour
{
    int  player;
    public static bool havePineapple = false;
    void Start()
    {
        player=LayerMask.NameToLayer("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision .gameObject .layer ==player)
        {
            gameObject.SetActive(false);
             havePineapple = true;
        }
    }
}

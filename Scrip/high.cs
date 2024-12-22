using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class high : MonoBehaviour
{
    public GameObject gaotieui;
    private LayerMask player;
    EdgeCollider2D edge;
    void Start()
    {
        gaotieui.SetActive(false);
        player = LayerMask.GetMask("Player");
        edge = GetComponent<EdgeCollider2D>();
    }

   
    void Update()
    {
        if (edge.IsTouchingLayers(player))
            gaotieui.SetActive(true);
        else
        {
            gaotieui.SetActive(false);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class fire : MonoBehaviour
{
      float speed=6;
    public CinemachineVirtualCamera vcam;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                vcam.m_Lens.OrthographicSize += (speed * Time.deltaTime);
                if (vcam.m_Lens.OrthographicSize >17)
                {
                    speed = 0;
                }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        speed = 6;
    }
}

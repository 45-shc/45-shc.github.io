using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class nofire : MonoBehaviour
{
    float speed=8;
    public CinemachineVirtualCamera vcam;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vcam.m_Lens.OrthographicSize -= (speed * Time.deltaTime);
            if (vcam.m_Lens.OrthographicSize <7)
            {
                speed = 0;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        speed = 8;
    }
}

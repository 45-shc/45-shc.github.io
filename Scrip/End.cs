using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject r;
    public GameObject _duihuakuang;
    void Start()
    {
        _duihuakuang.SetActive(false);  
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&&r.activeSelf)
        {
            r.SetActive(false);
            _duihuakuang.SetActive(true);
        }
    }
}

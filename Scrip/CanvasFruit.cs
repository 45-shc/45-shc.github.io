using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFruit : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickTest()
    {
        canvas.SetActive(true);
    }

    public void ClickTest2()
    {
        canvas.SetActive(false);
    }
}
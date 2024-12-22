using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueSlider : MonoBehaviour
{
    public Slider sliderred;
    public Slider sliderblue;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        sliderblue.value = Player.boostChance;
        sliderred.value = waterMelon.Love;
    }
}

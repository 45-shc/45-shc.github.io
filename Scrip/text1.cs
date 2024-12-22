using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class text1 : MonoBehaviour
{
    [Header("ui组件")]
    public TextMeshProUGUI text;
    
    public TextAsset textAsset;
    public int index=0;
    List<string> textList = new List<string>();
    bool textFinished=false;
    
    // Start is called before the first frame update
    void Awake()
    {
        GetTextFromFile(textAsset);
    }

    private void OnEnable()
    {
        StartCoroutine(SetTextUI());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }
        if (Input.GetKeyDown(KeyCode.W)&&textFinished)
        {
            StartCoroutine(SetTextUI());
        }
    }

    void GetTextFromFile(TextAsset textAsset)
    {
        textList.Clear();
        index = 0;
        var lineDate= textAsset.text.Split('\n');
        foreach (var line in lineDate)
        {
            textList.Add(line);
        }
    }

    IEnumerator SetTextUI()
    {
        textFinished = false;
        text.text = "";
        for (int i = 0; i < textList[index].Length; i++)
        {
            text.text += textList[index][i];
            yield return new WaitForSeconds(0.07f);
        }
        textFinished = true;
        index++;
    }
}

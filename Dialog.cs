using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    private string fullContent;
    private int letterOrder = 0;
    private string content;
    private Text dialog;
    public float speed;

    public void Show()
    {
        if (letterOrder >= fullContent.Length) return;
        content += fullContent[letterOrder];
        dialog.text = content;
        letterOrder++;
    }

    public void Start()
    {
        content = "";
        letterOrder = 0;
        dialog = GetComponent<Text>();
        fullContent = dialog.text;
        InvokeRepeating("Show", 0, speed);
    }
}
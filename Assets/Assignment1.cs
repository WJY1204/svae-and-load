using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
public class Assignment1 : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreTxt, nameTxt, numerTxt, scoreTxt;

    [SerializeField] private TMP_InputField nameInput, numberInput, scoreInput;
    
    public void Save(){
        PlayerPrefs.SetString("name", nameInput.text);
        PlayerPrefs.SetString("number", numberInput.text);
        
        int temp = Int32.Parse(scoreInput.text);
        if(temp>= Int32.Parse(PlayerPrefs.GetString("score", "0"))){
            PlayerPrefs.SetString("score", scoreInput.text);
            highScoreTxt.text = "最高分數: " + scoreInput .text;
        }

    }

    public void Load(){
        highScoreTxt.text = "最高分數: " + PlayerPrefs.GetString("score", "");
        nameInput.text = PlayerPrefs.GetString("name", "");
        numberInput.text = PlayerPrefs.GetString("number", "");
        scoreInput.text = PlayerPrefs.GetString("score", "");
    }

    
    private void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

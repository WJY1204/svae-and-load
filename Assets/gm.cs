using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class gm : MonoBehaviour
{
    [SerializeField] private TMP_Text highscoreTxt, nameTxt, numberTxt, scoreTxt;

    [SerializeField] private TMP_InputField nameInput, numberInput, scoreInput;

    public void Save(){
        
        PlayerPrefs.SetString("name", nameInput.text);
        PlayerPrefs.SetString("number", numberInput.text);
        

        int temp = Int32.Parse (scoreInput.text); //Parse資料轉型成int32，因為要比大小所以轉成整數
        int highscore = Int32.Parse (PlayerPrefs.GetString("score", "0"));
        if (temp >= highscore){
            PlayerPrefs.SetString("score", scoreInput.text);
            highscoreTxt.text = "最高分數 : " + scoreInput.text;
        }
        Debug.Log("儲存成功");
    }

    public void Load(){
        highscoreTxt.text = "最高分數 : " + PlayerPrefs.GetString("score", "");
        nameInput.text = PlayerPrefs.GetString("name", "");
        numberInput.text = PlayerPrefs.GetString("number", "");
        scoreInput.text = PlayerPrefs.GetString("score", "");
    }
   
}

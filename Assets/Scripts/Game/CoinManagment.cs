using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinManagment : MonoBehaviour
{
    public int gold;
    public Text money;

    void Start()
    {
        /*gold=0;
        PlayerPrefs.SetInt("Money" , gold);*/
        gold = PlayerPrefs.GetInt("Money" , 0);
    }

    void Update()
    {
        money.text = PlayerPrefs.GetInt("Money" , 0).ToString();
    }

    public void Addmoney() {
        gold++;
        PlayerPrefs.SetInt("Money" , gold);
    }

    public void Moremoney() {
        gold+=20;
        PlayerPrefs.SetInt("Money" , gold);
    }
}
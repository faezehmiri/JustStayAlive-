using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLose : MonoBehaviour
{
    public void LoadLoseScenes(){
        SceneManager.LoadScene("LoseScence");
    }
}

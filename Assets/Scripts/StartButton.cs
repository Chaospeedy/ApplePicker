using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    public void NextScene(){
        SceneManager.LoadScene("_Scene_0");
    }
    
}

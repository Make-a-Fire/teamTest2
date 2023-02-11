using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    private bool firstPush = false;

    // スタートボタンを押されたら呼ばれる
    public void PressStart()
    {
        Debug.Log("push");
        if (!firstPush)
        {
            Debug.Log("Go Next Scene");
            SceneManager.LoadScene("SampleScene");
            firstPush = true;
        }
    }
}

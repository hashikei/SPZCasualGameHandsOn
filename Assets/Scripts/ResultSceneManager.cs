using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultSceneManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            SceneManager.LoadScene("Title");
        }
    }
}

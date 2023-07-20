using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainScreen : MonoBehaviour
{
    public void LoadScene(int sceneIndex = 0)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_sc : MonoBehaviour
{

    private UIManager_sc uiManager;



    void Start()
    {
        uiManager = FindObjectOfType<UIManager_sc>();


        uiManager.HideGameOverPanel();
        uiManager.HideWinPanel();
    }


    public void RestartGameScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }


}

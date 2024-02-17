using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_sc : MonoBehaviour
{

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject winPanel;

    [SerializeField] private Image[] lives;
    [SerializeField] private TextMeshProUGUI deads;
    private int actualLivesLost;

    [SerializeField] private Button restartButton;

    private GameManager_sc gameManager;

    void Start()
    {
        actualLivesLost = 0;

        gameManager = FindObjectOfType<GameManager_sc>();
        

        restartButton.onClick.AddListener(() => { gameManager.RestartGameScene(); });

    }


    public void UpdateLifesText()
    {
        
        lives[actualLivesLost].gameObject.SetActive(false);
        actualLivesLost += 1;

    }

    public void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
    }
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

   
    public void HideWinPanel()
    {
        winPanel.SetActive(false);
    }

    public void ShowWinPanel(int lifes, int maxLifes)
    {
        int lostLives = maxLifes - lifes;

        deads.text = $"You died {lostLives} times";
        winPanel.SetActive(true);

    }

  
}

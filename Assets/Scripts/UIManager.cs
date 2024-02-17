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
    [SerializeField] private Button restartButton;

    private int actualLivesLost;

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

    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    public void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
    }

    public void ShowWinPanel(int lifes, int maxLifes)
    {

        deads.text = "Times Died: " + (maxLifes - lifes);
        winPanel.SetActive(true);

    }

    public void HideWinPanel()
    {
        gameOverPanel.SetActive(false);
    }

}

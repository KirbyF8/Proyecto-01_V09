using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_sc : MonoBehaviour
{


    [SerializeField] private float verticalSpeed = 15f;
    [SerializeField] private float lateralSpeed = 5f;

    public int lives = 3;
    public int maxLives = 3;

    [SerializeField] private Vector3 offset = new Vector3(0, 20, -10);

    private float verticalInput;
    private float horizontalInput;

    private GameManager_sc gameManager;
    private UIManager_sc uiManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager_sc>();
        uiManager = FindObjectOfType<UIManager_sc>();
    }


    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

      
        transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime * verticalInput);


        transform.Rotate(Vector3.up, lateralSpeed * Time.deltaTime * horizontalInput);

      

        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, -0.03f, transform.position.z);
            transform.rotation = Quaternion.identity;
            

            UpdateLifes(lives);

        }

        if (transform.position.z > 241)
        {
            uiManager.ShowWinPanel(lives, maxLives);
        }

    }

    public void UpdateLifes(int lives)
    {
        lives--;

       

        if (lives <= 0)
        {
            
            uiManager.ShowGameOverPanel();

        }

        uiManager.UpdateLifesText();
    }

}

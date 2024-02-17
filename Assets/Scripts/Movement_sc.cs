using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_sc : MonoBehaviour
{


    [SerializeField] private float verticalSpeed = 50f;
    [SerializeField] private float lateralSpeed = 30f;

    public int lives = 3;
    public int maxLives = 3;

    private float verticalInput;
    private float horizontalInput;

    private GameManager_sc gameManager;
    private UIManager_sc uiManager;

    private void Start()
    {

        lives = maxLives;


        gameManager = FindObjectOfType<GameManager_sc>();
        uiManager = FindObjectOfType<UIManager_sc>();
    }


    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

      
        transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime * verticalInput);

        transform.Rotate(Vector3.up, lateralSpeed * Time.deltaTime * horizontalInput);


        if (transform.position.y < -5)
        {
            transform.position = new Vector3(0, -0.03f, transform.position.z);
            transform.rotation = Quaternion.identity;

       
            UpdateLifes();

        }

        if (transform.position.z > 180)
        {
            uiManager.ShowWinPanel(lives, maxLives);
        }

    }

    public void UpdateLifes()
    {
       
        lives--;

        if (lives <= 0)
        {
            
            uiManager.ShowGameOverPanel();

        }

        uiManager.UpdateLifesText();
    }

}

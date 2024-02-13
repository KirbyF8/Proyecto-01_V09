using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 15.0f; // Velocidad del vehículo
    private float lateralSpeed = 5f; // Velocidad de rotación

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        // La detección de inputs debe ir en el Update
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        /* Recomendación: si trabajamos con direcciones, que sean vectores unitarios (su módulo es 1)
            * Vector3.right se corresponde con (1, 0, 0)
            * Vector3.left se corresponde con (-1, 0, 0)
            * Vector3.up se corresponde con (0, 1, 0)
            * Vector3.down se corresponde con (0, -1, 0)
            * Vector3.forward se corresponde con (0, 0, 1)
            * Vector3.back se corresponde con (0, 0, -1)
        */
        
        // Usando transform.Translate, el movimiento es en función del sistema de coordenadas local (el del objeto)
        // Movimiento hacia adelante automático (no depende del input del usuario)
        // transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        // Movimiento hacia adelante afectado por el input vertical del usuario 
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        
        // Movimiento lateral afectado por el input horizontal del usuario
        // transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horizontalInput);
        
        // Rotación afectada por el input horizontal del usuario
        transform.Rotate(Vector3.up, lateralSpeed * Time.deltaTime * horizontalInput);
    }
}

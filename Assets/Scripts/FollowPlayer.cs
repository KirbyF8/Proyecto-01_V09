using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player; // Asignamos la referencia desde el inspector
    
    private Vector3 offset = new Vector3(0, 5, -10);

    private void LateUpdate()
    {
        /* Cambiamos la posición de la cámara en el LateUpdate para que primero se mueva el player y luego,
            en función a ese movimiento, se mueva la cámara para perseguirlo. De este modo evitamos que la 
            cámara vaya a trompicones
         */
        transform.position = player.transform.position + offset; // La cámara modifica su posición para seguir al player
        transform.rotation = player.transform.rotation; // Cámara modifica su rotación para mirar al player
    }
}

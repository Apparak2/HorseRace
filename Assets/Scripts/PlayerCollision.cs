using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovementScript; 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log($"Vous avez touché {collisionInfo.collider.name}");
            playerMovementScript.enabled = false;
        }

    }
}

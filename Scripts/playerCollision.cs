using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour 
{
    public delegate void HitObstacle(Collision collisionInfo);
    public static event HitObstacle OnHitObstacle;
    public playerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //movement.enabled = false;
            //FindObjectOfType<gameManager>().endGame();
            OnHitObstacle?.Invoke(collisionInfo);
        }
    }

}

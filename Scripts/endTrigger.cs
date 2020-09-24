using UnityEngine;

public class endTrigger : MonoBehaviour
{

    public gameManager GameManager;
  
    void OnTriggerEnter()
    {
        GameManager.completeLevel();
    }

}

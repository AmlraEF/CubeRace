using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public bool triggered = false;

    void OnTriggerEnter ()
    {
        triggered = true;
        gameManager.CompleteLevel();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    private bool isHit;
    public PlayerController playerScore;
    void Start()
    {
      
        isHit = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Floor") && !isHit)
        {
            isHit = true;
            Debug.Log("Pin has fallen");
            playerScore.score = playerScore.score + 5;
            playerScore.SetScoreText();
        }
    }
}

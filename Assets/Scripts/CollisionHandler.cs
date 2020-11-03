using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1f;
    [SerializeField] GameObject explotion;
    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        explotion.SetActive(true);
        Invoke("reloadLevelScene",levelLoadDelay);
    }

    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDead");
        
    }

    private void reloadLevelScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

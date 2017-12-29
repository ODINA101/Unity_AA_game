using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public rotator rotator;
    public spawner spawner;

    public Animator animator;




    public void EndGame()
    {
        if (gameHasEnded)
            return;
        gameHasEnded = true;
        rotator.enabled = false;
        spawner.enabled = false;
        Debug.Log("End game");
        animator.SetTrigger("EndGame");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

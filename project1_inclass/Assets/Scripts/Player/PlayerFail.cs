using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerFail : MonoBehaviour
{
    public float maxiumFallDepth = -50f;
    bool gameFailed = false;
    // Start is called before the first frame update
    void Start()
    {
        gameFailed = false;
    }

    // Update is called once per frame
    void Update()
    {
        // IF PLAYER FALL OFF
        if(transform.position.y < maxiumFallDepth && !gameFailed)
        {   
            gameFailed = true;
            Debug.Log("Game Over");
            UIController.instance.GameOver();
            StartCoroutine(WaitAfterFail(1f));
            
        }        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        // IF PLAYER COLLIDE WITH ENEMY
        if(collision.gameObject.tag == "enemy" && !gameFailed)
        {
            gameFailed = true;
            Debug.Log("Game Over");
            UIController.instance.GameOver();
            StartCoroutine(WaitAfterFail(1f));
        }
       
    }
    IEnumerator WaitAfterFail(float delay)
    {
        yield return new WaitForSeconds(delay);
        ResetGame();
    }
    public void ResetGame()
    {
        Debug.Log("Game Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

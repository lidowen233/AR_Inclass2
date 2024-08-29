using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallWin : MonoBehaviour
{
    public float maxiumFallDepth = -10f;
    bool gameFailed = false;
    // Start is called before the first frame update
    void Start()
    {
        gameFailed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < maxiumFallDepth && !gameFailed)
        {   
            Debug.Log("Game Over");
            gameFailed = true;
            UIController.instance.GameOver();
            StartCoroutine(WaitAfterFail(1f));
        }  
    }
     void OnCollisionEnter(Collision collision)
    {
        // if player on the platform
        if(collision.gameObject.tag == "destination")
        {
            Debug.Log("Game Win");
            UIController.instance.GameWin();
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
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

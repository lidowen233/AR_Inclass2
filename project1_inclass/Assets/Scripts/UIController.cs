using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text uiText;
    public static UIController instance; // singelton
    

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        uiText.text = "Game Start";
        StartCoroutine(HideTextAfterDelay(2f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        // hide text
        uiText.gameObject.SetActive(false); 
    }
    public void GameOver()
    {
       
        uiText.gameObject.SetActive(true); 
        uiText.text = "Game Over";
        
    }
    public void GameWin()
    {
        uiText.gameObject.SetActive(true); 
        uiText.text = "Game Win";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;


    public bool isGameActive;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            scoreText.gameObject.SetActive(true);
            scoreText.text = "Score: " + score + "/20";
        }
        if (score >= 20) 
        {

            StartCoroutine(win());

        }
        
    }

    IEnumerator win()
    {
        scoreText.text = "YOU WIN!!!1!";
        yield return new WaitForSeconds(2f);
        scoreText.gameObject.SetActive(false);
        isGameActive = false;

    }
}

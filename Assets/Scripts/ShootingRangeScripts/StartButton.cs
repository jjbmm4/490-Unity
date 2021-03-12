using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartButton : MonoBehaviour
{
    public TextMeshProUGUI interactText;
    public GameObject startButton;
    public GameObject scoreManager;
    bool triggering;

    void Start()
    {
        triggering = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggering)
        {

            
            if (Input.GetKeyDown(KeyCode.E))
            {
                interactText.gameObject.SetActive(false);
                Destroy(startButton);
                scoreManager.GetComponent<ScoreManager>().isGameActive = true;

            }
        }
        else
        {
            
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            interactText.gameObject.SetActive(true);
            triggering = true;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            triggering = false;
            interactText.gameObject.SetActive(false);
        }
    }
}

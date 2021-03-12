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

            interactText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                interactText.gameObject.SetActive(false);
                Destroy(startButton);
                scoreManager.GetComponent<ScoreManager>().isGameActive = true;

            }
        }
        else
        {
            interactText.gameObject.SetActive(false);
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            triggering = true;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            triggering = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScript : MonoBehaviour
{
    public TextMeshProUGUI interactText;
    public GameObject door;
    public TextMeshProUGUI winText;
    public GameObject key1;
    public GameObject key2;
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


            if (Input.GetKeyDown(KeyCode.E) && key1.activeSelf && key2.activeSelf)
            {
                interactText.gameObject.SetActive(false);
                winText.gameObject.SetActive(true);

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

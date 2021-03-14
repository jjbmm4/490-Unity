using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeverScript : MonoBehaviour
{
    //public List<GameObject> gates;
    public List<Animator> gateAnimators;
    public Animator leverAnimator;
    public TextMeshProUGUI interactText;
    public ParticleSystem[] dustParticles;
    private bool triggering;
    private bool leverFlipped = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (triggering)
        {


            if (Input.GetKeyDown(KeyCode.E))
            {
                if (leverFlipped)
                {
                    leverFlipped = false;
                    leverAnimator.SetBool("IsFlicked", true);
                    foreach(ParticleSystem particle in dustParticles)
					{
                        particle.Play();
					}
                    foreach (Animator gate in gateAnimators)
                    {
                        gate.SetBool("IsOpen", true);
                    }
                }
                else
                {
                    leverFlipped = true;
                    leverAnimator.SetBool("IsFlicked", false);
                    foreach (Animator gate in gateAnimators)
                    {
                        gate.SetBool("IsOpen", false);
                    }
                }

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
            triggering = true;
            interactText.gameObject.SetActive(true);



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

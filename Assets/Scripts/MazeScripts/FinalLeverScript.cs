using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLeverScript : MonoBehaviour
{
    public Animator leverAnimator;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (leverAnimator.GetBool("IsFlicked"))
		{
            key.SetActive(true);
		}
    }
}

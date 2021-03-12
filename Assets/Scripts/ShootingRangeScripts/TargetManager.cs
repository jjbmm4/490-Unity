using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour

{
    public Animator targetAnimation;
    public GameObject scoreManager;
    public GameObject TargetPosition;
    

    public int leftBound;
    public int rightBound;
    public float speed;
    public int score = 1;

    private float xPos;
    private float yPos;
    private float zPos;

    public bool movingLeft = false;
    // Start is called before the first frame update
    void Start()
    {
        xPos = TargetPosition.transform.position.x;
        yPos = TargetPosition.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager.GetComponent<ScoreManager>().isGameActive)
        {
            zPos = TargetPosition.transform.position.z;
            if (zPos > leftBound)
            {
                movingLeft = false;
            }
            else if(zPos < rightBound)
            {
                movingLeft = true;
            }
            if (movingLeft)
            {
                TargetPosition.transform.position = new Vector3(xPos, yPos, zPos + speed);
            }
            else
            {
                TargetPosition.transform.position = new Vector3(xPos, yPos, zPos - speed);
            }
            Debug.Log(zPos);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            if (scoreManager.GetComponent<ScoreManager>().isGameActive && targetAnimation.GetBool("IsAlive"))
            {
                targetAnimation.SetBool("IsAlive", false);
                StartCoroutine(resetTarget());

            }
        }
    }

    IEnumerator resetTarget()
    {
        scoreManager.GetComponent<ScoreManager>().score += score;
        yield return new WaitForSeconds(2f);
        targetAnimation.SetBool("IsAlive", true);
    }
}

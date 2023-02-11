using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    [SerializeField]
    public GameObject YouWinText; // setting up win text var

    // Start is called before the first frame update
    void Start()
    {
        YouWinText.SetActive(false); //text is turned off
    }


    // Update is called once per frame
    void Update()
    {
    }
        //detects if we collide with another object
        void OnCollisionEnter2D(Collision2D collision)
        {

            if(collision.gameObject.name == "FinishLine") //if we touch the finnish line
            {
                YouWinText.SetActive(true); //text is turned off
            }

        }
      
    
}

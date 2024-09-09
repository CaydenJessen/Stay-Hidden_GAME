using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject[] openMechanisms;
    public GameObject[] closeMechanisms;
    //public GameObject lever;
    //public GameObject leverControl;
    public bool inRange = false;
    public bool status = false;
    public int numberOfMechanisms;
    public Player_Movement pM;
    public Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if ((inRange == true) && (status == true))
            {
                for (int i = 0; i < numberOfMechanisms; i++)
                {
                    openMechanisms[i].SetActive(false);
                    closeMechanisms[i].SetActive(true);
                }

                // leverControl.transform.Rotate(0.0f, 0.0f, -41.0f);
                animator.SetBool("LeverOn", false);
                status = false;
                pM.view.SetActive(true);
            }
            else if ((inRange == true) && (status == false))
                {
                for (int i = 0; i < numberOfMechanisms; i++)
                {
                    openMechanisms[i].SetActive(true);
                    closeMechanisms[i].SetActive(false);
                }
                //leverControl.transform.Rotate(0.0f, 0.0f, 41.0f);
                    status = true;
                animator.SetBool("LeverOn", true);
                pM.view.SetActive(true);
            }
            else
            {
                pM.view.SetActive(false);
            }
         
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            inRange = true;          
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRange = false;
        }

    }
}

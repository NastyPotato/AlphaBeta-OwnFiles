using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerTestingScript : MonoBehaviour
{
    CharacterController controller;

    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        controller=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //When the script tells the spider to walk
        if(Input.GetKey(KeyCode.Q))
        {
            anim.SetInteger("State", 1);
        }

        //When the script tells the spider to attack
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetInteger("State", 2);
        }

        //When the script tells the spider to die
        if (Input.GetKey(KeyCode.R))
        {
            anim.SetInteger("State", 3);
        }

        //When the script tells the spider to idle
        if (Input.GetKey(KeyCode.E))
        {
            anim.SetInteger("State", 0);
        }
    }

}

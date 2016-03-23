using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoveCharacter();
	}

    void MoveCharacter()
    {
        // Set parameter value for jump in animator based on W key.
        if(Input.GetKeyDown(KeyCode.W))
            anim.SetBool("jump", true);
        else if(Input.GetKeyUp(KeyCode.W))
            anim.SetBool("jump", false);
        
        // Set parameter value for slide in animator based on S key.
        if(Input.GetKeyDown(KeyCode.S))
            anim.SetBool("slide", true);
        if(Input.GetKeyUp(KeyCode.S))
            anim.SetBool("slide", false);


    }
}

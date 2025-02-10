using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            anim.SetTrigger("body");
        }
         if (Input.GetKeyDown(KeyCode.W)){
            anim.SetTrigger("punch");
        }
         if (Input.GetKeyDown(KeyCode.E)){
            anim.SetTrigger("elbow");
        }
    }
}

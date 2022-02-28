using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Movement(); 
    }

    private void Movement()
    {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");

        anim.SetFloat("Horizontal", horInput);
        anim.SetFloat("Vertical", verInput);
    }

    public void ResetCharacterPosition()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}

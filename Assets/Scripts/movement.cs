using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private float sprintspeed;

    // Update is called once per frame
    private void Update()
    {

        float Hori = Input.GetAxisRaw("Horizontal");
        float Vert = Input.GetAxisRaw("Vertical");

        if (Hori > 0)
        {

            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, 90f, 0f), Time.deltaTime * 20f); //Rotate player 90 degrees left
        }
        else if(Hori < 0)
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, 260f, 0f), Time.deltaTime * 20f); //Rotate player 90 degrees left

        }

        transform.position += new Vector3(Hori * sprintspeed * Time.deltaTime,0f,0f); // player momentum movemnt
        
        playerAnimator.SetFloat("sprintspeed", Mathf.Abs(Hori));
        
    }

    
}

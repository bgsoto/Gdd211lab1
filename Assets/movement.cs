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

        float input = Input.GetAxisRaw("Horizontal");

        if (input > 0)
        {

            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, 90f, 0f), Time.deltaTime * 20f);
        }
        else if(input < 0)
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, 260f, 0f), Time.deltaTime * 20f);

        }
        transform.position += new Vector3(input * sprintspeed * Time.deltaTime,0f,0f);

        playerAnimator.SetFloat("sprintspeed", Mathf.Abs(input));
        }





    
}

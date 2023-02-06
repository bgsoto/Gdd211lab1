using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altmovement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5f;

    camera cameraController;



    private void Awake()
    {

        cameraController = Camera.main.GetComponent<camera>();
    
    }
    
    
    
    public void Update()
    {
        float H = Input.GetAxisRaw("Horizontal");
        float V = Input.GetAxisRaw("Vertical");

        var moveInput = (new Vector3(H,0,V)).normalized;

        var moveDir = cameraController.transform.rotation * moveInput;

        transform.position += moveDir * moveSpeed * Time.deltaTime;



    }

}

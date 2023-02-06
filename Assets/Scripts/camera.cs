using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] Transform followtarget; //Variable type transform called followtarget
    [SerializeField] float distance = 5; //Variable type float called distance
    [SerializeField] float minVerticalAngle = -35;
    [SerializeField] float maxVerticalAngle = 35;
    
    
    float rotationX; //Radius following player around X axis *Vertical*
    float rotationY; //Radius following player around Y axis *Horzontal*
   
    private void Update()
    {

        rotationY += Input.GetAxis("Mouse X");// Taking X axis of mouse input and placing it in variable called rotationY
        rotationX += Input.GetAxis("Mouse Y");// Taking Y axis of mouse input and placing it in variable called rotationY
        rotationX = Mathf.Clamp(rotationX,minVerticalAngle,maxVerticalAngle);//Creates limits to camera vertical rotation


        var targetrotation = Quaternion.Euler(rotationX, rotationY, 0f);// Makes a variable to store a rotation
        
        transform.position = followtarget.position - targetrotation * new Vector3(0,-2,distance); //Moves position of camera using target roatation which is mouse x  and multiplying the vector3 to determine new psoition
       
        transform.rotation = targetrotation;//Moves camera rotation by usuing variable targetrotation
    
    
    
    }



}

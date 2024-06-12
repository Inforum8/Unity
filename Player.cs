using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Numerics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed ;
    
    [SerializeField]
    private GameObject weapon ;

    [SerializeField]
    private Transform shootTransform ;

    [SerializeField]
    private float shootInterval = 0.05f ;
    private float lastShotTime = 0f ;

    void Update()
    {
        // float horizontalInput = Input.GetAxisRaw("Horizontal") ;
        // float verticalInput = Input.GetAxisRaw("Vertical") ;
        // Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0);
        // transform.position += moveTo * moveSpeed * Time.deltaTime ;

        // Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0, 0) ;
        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     transform.position -= moveTo ;
        // }

        // else if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     transform.position += moveTo ;
        // }
        
        UnityEngine.Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float toX = Mathf.Clamp(mousePos.x, -2.35f, 2.35f) ;
        transform.position = new UnityEngine.Vector3(toX, transform.position.y, transform.position.z);

        Shoot();

    }

    void Shoot()
    {
        if (Time.time - lastShotTime > shootInterval)
        {
            Instantiate(weapon, shootTransform.position, UnityEngine.Quaternion.identity);
            lastShotTime = Time.time ;
        }
        
    }

}


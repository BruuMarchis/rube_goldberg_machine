using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour
{

    public GameObject[] targets;
    public GameObject lastTarget;
    public int speed = 5;
    public static int bolaAtual;
    ////////////////////////////////////////////////////////////////////
    public Vector3 Offset;
    public Vector3 originalOffset;
    public float SmoothTime = 0.3f;
    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;


    private void Start()
    {
        bolaAtual = 0;
        originalOffset = this.transform.position - targets[bolaAtual].transform.position;
        Offset = originalOffset;
    }

     void Update()
     {
        if(bolaAtual > 5)
        {
            bolaAtual = 5;
        }


        if (lastTarget != targets[bolaAtual])
        {
            if(Offset.x > originalOffset.x)
            {
                originalOffset.x++;
            }
            else
            {
                Offset.x = originalOffset.x;
            }

            if (Offset.y > originalOffset.y)
            {
                originalOffset.y++;
            }
            else
            {
                Offset.y = originalOffset.y;
            }
                        
            if(Offset.x == originalOffset.x && Offset.y == originalOffset.y)
            {
                lastTarget = targets[bolaAtual];
            }

        }


         var targetRotation = Quaternion.LookRotation(targets[bolaAtual].transform.position - transform.position);
     
         // Smoothly rotate towards the target point.
         transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
     }


    private void LateUpdate()
    {
        // update position
        Vector3 targetPosition = targets[bolaAtual].transform.position + Offset;
        this.transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);

    }


}

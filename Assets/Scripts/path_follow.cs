using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class path_follow : MonoBehaviour
{
    public Transform[] target;

    public float vel;
    public int atual=0;

    public bool check = false;

    public Vector3 targetAtual;
    public Vector3 bloco;

    public Vector3 pos;

    public bool ativo = true;


    void Start()
    {
        
    }

    void Update()
    {


        if (ativo)
        {

        }

        targetAtual = target[atual].position;
        bloco = transform.position;

        if (transform.position != target[atual].position)   
        {
            check = true;
            pos = Vector3.MoveTowards(transform.position, target[atual].position, vel * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            check = false;
            atual = (atual + 1) % target.Length;
        }
    }
}
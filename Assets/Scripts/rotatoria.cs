using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class rotatoria : MonoBehaviour
{
    public float min;
    public float max;
    public float vel;
    public GameObject bola = null;

    public bool ativo = true;
    public bool limite = false;


    // Start is called before the first frame update

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (ativo)
        {
            transform.Rotate(0.0f, 0.0f, vel, Space.World);
            if ((transform.rotation.eulerAngles.z > max && transform.rotation.eulerAngles.z < min && vel > 0.0f))
            {
                vel = -1.0f;
            }
            else if ((transform.rotation.eulerAngles.z < min && transform.rotation.eulerAngles.z > max && vel < 0.0f))
            {
                vel = 1.0f;
            }
        }      


    }

    void OnTriggerEnter(Collider Coll)
    {
        if(bola != null)
        {
            if (Coll.gameObject.name == bola.name)
            {
                ativo = true;
            }
        }
        

    }
    void OnTriggerExit(Collider Coll)
    {
        if (limite && ativo)
        {
            ativo = false;
        }

    }
}



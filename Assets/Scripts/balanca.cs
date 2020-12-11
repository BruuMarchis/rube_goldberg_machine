using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class balanca : MonoBehaviour
{
    public float peso;
    public Text pesoTxt;
    public bool ativo;
    public Vector3 posicao;
    public float vel;
    public Vector3 target;

    void Start()
    {
        posicao = transform.position;
        peso = 0.0f;
        vel =  5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (ativo)
        {
            if (pesoTxt)
            {
                pesoTxt.text = "" + peso + "/ 6";
            }
        }
        else
        {
            if (pesoTxt)
            {
                pesoTxt.text = "" + peso;
            }
        }





    }

    void OnTriggerEnter(Collider Coll)
    {
        if (Coll.GetComponent<Rigidbody>())
        {
            peso += Coll.GetComponent<Rigidbody>().mass;
        }
    }

    void OnTriggerExit(Collider Coll)
    {
        if (Coll.GetComponent<Rigidbody>())
        {
            peso -= Coll.GetComponent<Rigidbody>().mass;
        }
    }
}

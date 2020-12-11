using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;


public class movimento : MonoBehaviour
{
    public float inicio;
    public float fim;
    public Vector3 vel;
    public bool ativo = true;
    public bool recorrente = true;

    public GameObject bola;

    public Vector3 target;

    public Vector3 posicao;

    // Start is called before the first frame update
    void Start()
    {
        posicao = transform.position;
        //vel = Vector3.left;
        if (recorrente)
        {
            vel.x = 0.05f;
            vel.y = 0.0f;
            vel.z = 0.0f;

        }
    }

    // Update is called once per frame
    void Update()
    {


        if (ativo)
        {

            if (recorrente)
            {
                transform.Translate(vel);

                if (transform.position.x > (transform.position.x + inicio) && transform.position.x > (transform.position.x + fim))
                {
                    vel.x = -0.05f;
                }
                else if (transform.position.x < (transform.position.x + inicio))
                {
                    vel.x = 0.05f;
                }
            }
            else
            {
                target = Vector3.MoveTowards(transform.position, new Vector3(posicao.x + fim, posicao.y, posicao.z), vel.x * Time.deltaTime);
                GetComponent<Rigidbody>().MovePosition(target);
            }


            
        }

    }


    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == bola.name)
        {
            ativo = true;
        }
    }

}

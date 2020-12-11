using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bola;
    public Vector3 intencidade;

    //private void OnCollisionEnter(Collision coll)
    //{
    //    //Debug.Log(gameObject.name);
    //    //Debug.Log(coll.gameObject.name);
    //    //Debug.Log(bola.name);
    //    if (coll.gameObject.name == bola.name)
    //    {
    //        bola.GetComponent<Rigidbody>().AddForce(intencidade.x, intencidade.y, intencidade.z, ForceMode.Impulse);            
    //    }                
    //}

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == bola.name)
        {
            bola.GetComponent<Rigidbody>().AddForce(intencidade.x, intencidade.y, intencidade.z, ForceMode.Impulse);            
        }   
    }

}

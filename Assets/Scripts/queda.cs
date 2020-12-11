using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class queda : MonoBehaviour
{
    // Start is called before the first frame update
    public bool ok=false;

    void Update()
    {
        if (ok)
        {
           // GetComponent<Rigidbody>().isKinematic = false;
            ok = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        //.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        ok = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }

}

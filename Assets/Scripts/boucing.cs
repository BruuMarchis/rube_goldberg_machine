using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boucing : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 iniPos;
    public Vector3 targetPos;
    public Vector3 pos;
    public Vector3 aPos;
    public float vel;
    public bool active;


    void Start()
    {
        iniPos = transform.position;
        active = false;
        vel = 6.0f;
        targetPos = iniPos;
        targetPos.y = iniPos.y - 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        aPos = transform.position;

        if (active)
        {
            pos = Vector3.MoveTowards(transform.position, targetPos, vel * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            pos = Vector3.MoveTowards(transform.position, iniPos, vel * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }


    }

    void OnTriggerEnter(Collider Coll)
    {
        active = true;

    }
    void OnTriggerExit(Collider Coll)
    {
        active = false;

    }


}

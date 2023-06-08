using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class buu : MonoBehaviour
{
    public GameObject obj;


    public GameObject bl;

    public GameObject[] tr = new GameObject[4];

    private int a = 0;

    private int b = 0;

    [Obsolete]
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.name == "Cube"){
            Debug.Log(b);
            b+=1;
            Destroy(bl);
            obj.transform.Translate(0,5,10);
            tr[0].transform.Translate(new Vector3(0,2,0));
            tr[1].transform.Translate(new Vector3(0,2,0));
            tr[2].transform.Translate(new Vector3(0,2,0));
            tr[3].transform.Translate(new Vector3(0,2,0));
        }
        if (other.gameObject.name == "op" || other.gameObject.name == "op (1)" || other.gameObject.name == "op (2)" ||other.gameObject.name == "op (3)")
        {
            Destroy(tr[0]);
            Destroy(tr[1]);
            Destroy(tr[2]);
            Destroy(tr[3]);
            Destroy(obj);

        }
    }

}

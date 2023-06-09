using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bu : MonoBehaviour
{
    public AudioClip aud;

    public AudioSource sour;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Cube"){
            sour.clip = aud;
            sour.Play();
        }
    }
}

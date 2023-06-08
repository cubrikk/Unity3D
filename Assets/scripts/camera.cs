using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private float X;
    private float Y;
    public float sensa = 200f;
    public Transform player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        X = Input.GetAxis("Mouse X") * sensa * Time.deltaTime;
        Y = Input.GetAxis("Mouse Y") * sensa * Time.deltaTime;
        player.Rotate(X * new Vector3(0, 1, 0));
        transform.Rotate(-Y * new Vector3(1,0,0));
    }
}

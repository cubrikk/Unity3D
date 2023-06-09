using System;
using System.Threading;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField]public bool ground;
    public Rigidbody PLAYer;
    public float JumpPow = 5f;
    public Vector3 jump;

    private void Start()
    {
        jump = new Vector3(0f, 1f, 0f);
    }

    private void input()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.Space) && ground == true)
        {
            PLAYer.AddForce(jump * JumpPow, ForceMode.Impulse);
        }
    }
    private void FixedUpdate()
    {
        input();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = false;
        }
    }
}
using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody bod;
    public float speed = 50f;
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal")*speed*Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical")*speed*Time.fixedDeltaTime;

        bod.transform.Translate(new Vector3(h,0,v));
    }



}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveer : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public Material mt;
    // Update is called once per frame
    void FixedUpdate()
    {
        mt.mainTextureOffset = new Vector2(Time.time * 10 * Time.deltaTime, 0f);
        Vector3 pos = rb.position;
        rb.position += Vector3.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(pos);
    }
}

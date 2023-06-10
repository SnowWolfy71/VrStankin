using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
        public float xAngle, yAngle, zAngle;


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            transform.Rotate(0.0f, yAngle, 0.0f);
        }
    }
}
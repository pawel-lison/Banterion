using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float Speed = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {              
            float h = Input.GetAxis("Horizontal") * Speed;

            this.transform.Translate(h * Time.deltaTime, 0, 0);      

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cloud")
        {
            //InvokeRepeating(Frustration.Rest(5,false),1,3);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickTime : MonoBehaviour
{
    public Image SpriteUp;
    public Image SpriteDown;
    public Image SpriteLeft;
    public Image SpriteRight;
    public Image SpriteBG;
    public GameObject car;

    //hide the buttons
    public void Start()
    {
        SpriteUp.enabled = false;
        SpriteDown.enabled = false;
        SpriteLeft.enabled = false;
        SpriteRight.enabled = false;
        SpriteBG.enabled = false;
    }

    //detect cars in the a hitch area, does not currently work
    private void OnTriggerEnter(Collider other)
    {

        print("Is anything even happening?");

        //unity is being a collision-bitch as always, here lays the problem
        if (other.gameObject.tag == "Car")
        {
            SpriteBG.enabled = true;
            Getcombination();
            
        }
    }

    //get a random int to determine what button appears and what button the player has to press.
    public void Getcombination()
    {
        int n = Random.Range(0, 4);

        if (n == 0)
        {
            SpriteUp.enabled = true;
            
            if (Input.GetButtonDown("up"))
            {
                SpriteUp.enabled = false;
                SpriteBG.enabled = false;
                return;
            }
        }

       else if (n == 1)
        {
            SpriteDown.enabled = true;

            if (Input.GetButtonDown("down"))
            {
                SpriteDown.enabled = false;
                SpriteBG.enabled = false;
                return;
            }
        }

       else  if (n == 2)
       {
            SpriteLeft.enabled = true;

            if (Input.GetButtonDown("left"))
            {
                SpriteLeft.enabled = false;
                SpriteBG.enabled = false;
                return;
            }
       }

        else if (n == 3)
        {
            SpriteRight.enabled = true;

            if (Input.GetButtonDown("right"))
            {
                SpriteRight.enabled = false;
                SpriteBG.enabled = false;
                return;
            }
        }

    }

}

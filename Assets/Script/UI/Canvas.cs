using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
  //private GameObject star;
   // private Star starScript;
    public Transform playerTransform;
    public Text scoreText;
    public int scoretodisplay;
    public new CapsuleCollider2D collider;
    public Rigidbody2D myBody;
    private bool isFalling = false;





    // Start is called before the first frame update
    void Start()
    {
       // star = GameObject.Find("Star");
        //starScript = star.GetComponent<Star>();
       // scoretodisplay = 0;

    }

    // Update is called once per frame
    void Update()
    {
       // scoretodisplay = (int)playerTransform.position.y + starScript.starScore;
       // scoreText.text = "Score : " + scoretodisplay;

        if (myBody.velocity.y < -0.1)
        {
            isFalling = true;
        }
        else
        {
            isFalling = false;
        }

        if (isFalling)
        {
            collider.isTrigger = false;
        }
        else
        {
            collider.isTrigger = true;
        }


    }
}

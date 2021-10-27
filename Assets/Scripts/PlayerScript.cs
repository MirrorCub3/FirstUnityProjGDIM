using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 20f;
    public float floatForce = 6f;
    public bool isJumping = false;

    public Rigidbody2D myRigidbody;
    public Animator anim;
    public bool wings;

    private bool faceRight;

    void Start()
    {
        wings = false;
        anim = this.GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        
        faceRight = true;
        isJumping = false;
    }

    void Update()
    {

        float xtrans = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        if (xtrans > 0) // determines which way the player is facing
        {
            faceRight = true;
        }
        else if (xtrans < 0)
        {
            faceRight = false;
        }

        transform.Translate(xtrans, 0, 0);
        if (transform.position.x > GeneralScript.right)
        {
            transform.position = new Vector3(GeneralScript.right, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < GeneralScript.left)
        {
            transform.position = new Vector3(GeneralScript.left, transform.position.y, transform.position.z);
        }

        isJumping = false;

        if (Input.GetButtonDown("Jump") && (Mathf.Abs(myRigidbody.velocity.y) < 0.001f || wings)) // only allows jumping if not already up or if you have wings
        {
            if(wings)
                myRigidbody.AddForce(new Vector2(0f, floatForce), ForceMode2D.Impulse);
            else
                myRigidbody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }

        anim.SetFloat("Speed", xtrans);
        anim.SetBool("FaceRight", faceRight);
    }

    public void GetWings()
    {
        wings = true;
        anim.SetTrigger("Wings");
    }

}

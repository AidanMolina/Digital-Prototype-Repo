using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Character
{
    public override void Speak()
    {
        if(Input.GetKeyDown("space")){
            Debug.Log("Am Orc!");
        }
    }
    public override void Move()
    {
        if(Input.GetKey("left") || Input.GetKey("right")){
            float direction = Input.GetAxis("Horizontal") * 4.0f * Time.deltaTime;
            transform.Translate(Vector3.right * direction);
        }
        if(Input.GetKey("up") || Input.GetKey("down")){
            float amtToMove = Input.GetAxisRaw("Vertical") * 4.0f * Time.deltaTime;
            transform.Translate(Vector3.up * amtToMove);
        }
    }
    public override void Teleport()
    {
        if(Input.GetKeyDown("x")){
            Debug.Log("I dun know how to do that.");
        }
    }
    private void Update(){
        Speak();
        Move();
        Teleport();
    }
}

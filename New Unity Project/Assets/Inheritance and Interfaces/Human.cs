using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Character
{
    public override void Speak()
    {
        if(Input.GetKeyDown("space")){
            Debug.Log("I'm the human.");
        }    }
    public override void Move()
    {
        if(Input.GetKey("left") || Input.GetKey("right")){
            float direction = Input.GetAxis("Horizontal") * 3.0f * Time.deltaTime;
            transform.Translate(Vector3.right * direction);
        }
        if(Input.GetKey("up") || Input.GetKey("down")){
            float amtToMove = Input.GetAxisRaw("Vertical") * 3.0f * Time.deltaTime;
            transform.Translate(Vector3.up * amtToMove);
        }
    }
    public override void Teleport()
    {
        if(Input.GetKeyDown("x")){
            transform.position = new Vector3(3.0f, 2.0f, 0.0f);
        }
    }
    private void Update(){
        Speak();
        Move();
        Teleport();
    }
}

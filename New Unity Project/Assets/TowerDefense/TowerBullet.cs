using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBullet : MonoBehaviour
{
    bool moveToTarget;
    Vector3 Target;
    public TowerType type;
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        moveToTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveToTarget){
            var step =  speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, Target, step);

            // Check if the position of the cube and sphere are approximately equal.
            if (Vector3.Distance(transform.position, Target) < 0.001f)
            {
                // Swap the position of the cylinder.
                moveToTarget = false;
                gameObject.SetActive(false);
            }
        }
    }

    public void createBullet(TowerType towerType, Vector3 target, Vector3 startPos){
        gameObject.transform.position = startPos;
        gameObject.SetActive(true);
        Target = target;
        type = towerType;
        moveToTarget = true;
    }
}

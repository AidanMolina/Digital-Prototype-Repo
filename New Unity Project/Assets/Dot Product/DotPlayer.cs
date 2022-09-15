using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotPlayer : MonoBehaviour
{
    public float moveSpeed = 5f;
    [SerializeField] GameObject Interactable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0f));

        Vector3 direction = transform.position - Interactable.transform.position;
        float distance = Vector3.Distance(Interactable.transform.position, transform.position);
        float dot = Vector3.Dot(-transform.right, direction);
        float dotOverMag = dot / (Vector3.Magnitude(-transform.right) * Vector3.Magnitude(direction));
        float vision = Mathf.Cos(Mathf.Deg2Rad * (45.0f / 2.0f));
        if (dotOverMag> vision && distance < 2.5f){
            Debug.Log("In range to interact");
        }
    }
}

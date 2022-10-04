using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
    [SerializeField] GameObject cube1;
    [SerializeField] GameObject cube2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void drawLines(Vector3 firstSpot, Vector3 secondSpot, Color color, float duration){
        Debug.DrawLine(cube1.transform.position, cube2.transform.position, Color.red, 10.0f);
    }
}

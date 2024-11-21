using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdownPlatform : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
    private bool movingDown;
    private float lowerEdge;
    private float upperEdge;

    private void Awake()
    {
        lowerEdge = transform.position.y - movementDistance;
        upperEdge = transform.position.y + movementDistance;
    }
    
    private void Update()
    {
        if(movingDown)
        {
            if (transform.position.y > lowerEdge)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y- speed * Time.deltaTime, transform.position.z); 
            }
            else{
                movingDown = false;
            }
        }
        else
        {
            if (transform.position.y < upperEdge)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y+ speed * Time.deltaTime, transform.position.z);
            }
            else
            {
                movingDown = true;
            }
        }
    }
}

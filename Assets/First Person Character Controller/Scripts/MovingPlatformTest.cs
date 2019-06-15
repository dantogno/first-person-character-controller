using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovingPlatformTest : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    [SerializeField]
    private float maxMoveDistance = 10.0f;

    private Vector3 startingPosition;
    new Rigidbody rigidbody;
    private bool movingForward = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        startingPosition = transform.position;
    }

    void FixedUpdate()
    {
        if (movingForward)
        {
            rigidbody.MovePosition(rigidbody.position + Vector3.forward * speed);
            if (rigidbody.position.z > startingPosition.z + maxMoveDistance)
            {
                movingForward = false;
            }
        }
        else
        {
            rigidbody.MovePosition(rigidbody.position + Vector3.forward * -speed);
            if (rigidbody.position.z < startingPosition.z)
            {
                movingForward = true;
            }
        }
    }
}

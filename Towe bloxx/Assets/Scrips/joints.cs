using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joints : MonoBehaviour
{
    [SerializeField] private float leftAngle;
    [SerializeField] private float rightAngle;
    bool movingClockwise;

    void Start()
    {
        movingClockwise = true;

    }

    void Update()
    {
        Move();
    }

    public void ChangeMoveDir()
    {
        Debug.Log(transform.rotation.z);

        if (transform.rotation.z > rightAngle)
        {
            movingClockwise = false;
        }

        if (transform.rotation.z < leftAngle)
        {
            movingClockwise = true;
        }

    }

    public void Move()
    {
        ChangeMoveDir();

        if (movingClockwise)
        {
            transform.Rotate(new Vector3(0, 0, 20) * Time.deltaTime);
        }

        if (!movingClockwise)
        {
            transform.Rotate(new Vector3(0, 0, -20) * Time.deltaTime);
        }
    }
}

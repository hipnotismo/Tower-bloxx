using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joints : MonoBehaviour
{
    [SerializeField] private float leftAngle;
    [SerializeField] private float rightAngle;
    [SerializeField] private int speed;

    bool movingClockwise;

    void Start()
    {
        movingClockwise = true;

    }

    void Update()
    {
        move();
        speedIncrease();
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

    public void move()
    {
        ChangeMoveDir();

        if (movingClockwise)
        {
            transform.Rotate(new Vector3(0, 0, speed) * Time.deltaTime);
        }

        if (!movingClockwise)
        {
            transform.Rotate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
    }

    public void speedIncrease()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed += 10;
        }
    }
}

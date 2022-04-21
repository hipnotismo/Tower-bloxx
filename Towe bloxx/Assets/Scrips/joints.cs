using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joints : MonoBehaviour
{
    [SerializeField] private float leftAngle;
    [SerializeField] private float rightAngle;
    [SerializeField] private int speed;
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject rope;
    [SerializeField] private MeshRenderer rn;
    [SerializeField] private float camRopeUp;

    private float pieceSize;
    bool movingClockwise;

    void Start()
    {
        movingClockwise = true;

    }

    void Update()
    {
        move();
        speedIncrease();
        moveUp();
    }

    public void ChangeMoveDir()
    {


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

    public void moveUp()
    {
        rn.material.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rope.transform.Translate(0f, camRopeUp, 0f);
            cam.transform.Translate(0f, camRopeUp, 0f);
        }
    }
}

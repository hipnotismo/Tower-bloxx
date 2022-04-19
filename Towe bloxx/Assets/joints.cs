using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joints : MonoBehaviour
{
    // [SerializeField] private GameObject cube;

    [SerializeField] private float leftAngle;
    [SerializeField] private float rightAngle;
    bool movingClockwise;

    void Start()
    {
        movingClockwise = true;

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("d"))
        //{
        //    Debug.Log("d");         
        //    transform.Rotate(new Vector3(0, 0, 20) * Time.deltaTime);
        //}

        //if (Input.GetKey("a"))
        //{
        //    Debug.Log("a");          
        //    transform.Rotate(new Vector3(0, 0, -20) * Time.deltaTime);
        //}

        Move();
    }

    public void ChangeMoveDir()
    {
        Debug.Log(transform.rotation.z);

        if (transform.rotation.z > rightAngle)
        {
            Debug.Log("change");
            movingClockwise = false;
        }
        if (transform.rotation.z < leftAngle)
        {
            Debug.Log("change2");
            movingClockwise = true;
        }

    }

    public void Move()
    {
        ChangeMoveDir();

        if (movingClockwise)
        {
            //Debug.Log("pos");

            transform.Rotate(new Vector3(0, 0, 20) * Time.deltaTime);
        }

        if (!movingClockwise)
        {
            Debug.Log("nega");

            transform.Rotate(new Vector3(0, 0, -20) * Time.deltaTime);
        }
    }
}

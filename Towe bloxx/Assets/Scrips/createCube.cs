using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCube : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private Transform spawnPoint;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cube, spawnPoint.position, Quaternion.identity);

        }
    }

}

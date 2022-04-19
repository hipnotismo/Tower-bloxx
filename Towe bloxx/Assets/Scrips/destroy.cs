using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cube.transform.position.y < 0)
        {
            Destroy(cube);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            cube.transform.RotateAround(cube.transform.position, new Vector3(0, 0, 1), (float)(.2));
        }
        if (Input.GetKey(KeyCode.D))
        {
            cube.transform.RotateAround(cube.transform.position, new Vector3(0, 0, 1), (float)(-.2));
        }
    }
}

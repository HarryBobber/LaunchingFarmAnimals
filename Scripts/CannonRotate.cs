using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotate : MonoBehaviour
{

    Rigidbody cannon;
    // Start is called before the first frame update
    void Start()
    {
        cannon = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            cannon.transform.RotateAround(cannon.transform.position, new Vector3(0, 0, 1), (float).2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cannon.transform.RotateAround(cannon.transform.position, new Vector3(0, 0, 1), (float)-.2);
        }
    }
}

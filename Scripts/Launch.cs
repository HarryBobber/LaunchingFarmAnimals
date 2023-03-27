using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Launch : MonoBehaviour
{
    Rigidbody SpawnPoint;
    public Rigidbody l1;
    public Rigidbody l2;
    public Rigidbody l3;
    public Rigidbody l4;
    public Rigidbody l5;
    public Rigidbody launchable = null;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPoint = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        System.Random randGenerator = new System.Random();
        int rand = randGenerator.Next(5);

        if (Input.GetKeyDown(KeyCode.Alpha1)||Input.GetKeyDown(KeyCode.Alpha2)||Input.GetKeyDown(KeyCode.Alpha3)||Input.GetKeyDown(KeyCode.Alpha4)||Input.GetKeyDown(KeyCode.Alpha5)) {
            rand = 6;
            if (Input.GetKeyDown(KeyCode.Alpha1) || (int)rand == 0)
                launchable = l1;
            if (Input.GetKeyDown(KeyCode.Alpha2) || (int)rand == 1)
                launchable = l2;
            if (Input.GetKeyDown(KeyCode.Alpha3) || (int)rand == 2)
                launchable = l3;
            if (Input.GetKeyDown(KeyCode.Alpha4) || (int)rand == 3)
                launchable = l4;
            if (Input.GetKeyDown(KeyCode.Alpha5) || (int)rand == 4)
                launchable = l5;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) || (int)rand == 0)
                launchable = l1;
            if (Input.GetKeyDown(KeyCode.Alpha2) || (int)rand == 1)
                launchable = l2;
            if (Input.GetKeyDown(KeyCode.Alpha3) || (int)rand == 2)
                launchable = l3;
            if (Input.GetKeyDown(KeyCode.Alpha4) || (int)rand == 3)
                launchable = l4;
            if (Input.GetKeyDown(KeyCode.Alpha5) || (int)rand == 4)
                launchable = l5;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody projectile; 
            projectile = Instantiate(launchable, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
            projectile.AddRelativeForce(Vector3.forward*40, ForceMode.Impulse);
        } 
    }
}

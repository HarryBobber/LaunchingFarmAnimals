using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour
{
    public Rigidbody brick;
    GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        wall = this.gameObject;
        for(int i=0; i<10; i++)
        {
            for(int j=0; j<10; j++)
            {
                Rigidbody brickI = Instantiate(brick, wall.transform.position + new Vector3(0, i, j), wall.transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

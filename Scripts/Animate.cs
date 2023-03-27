using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{

    Animation fireEffect;
    // Start is called before the first frame update
    void Start()
    {
        fireEffect = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fireEffect.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            fireEffect.Stop();  
        }
    }
}

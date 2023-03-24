using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private float scaleSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(scaleSpeed, scaleSpeed, 0);
        if (transform.localScale.x >= 5)
        {
            Destroy(gameObject);
        }
    }
}

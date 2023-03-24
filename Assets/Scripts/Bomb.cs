using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate<GameObject>(explosion, gameObject.transform.position, explosion.transform.rotation);
        Destroy(gameObject);
    }
}

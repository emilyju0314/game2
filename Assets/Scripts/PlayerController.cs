using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 5f;
    private float jump = 12f;
    private float BoundY = -5f;
    private bool gameover = false;
    public string PlayerWin;
    public bool collideFloor = true;
    public bool powerup = false;
    public KeyCode left, right, up;
    public GameObject power;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(right))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if(Input.GetKey(up) && collideFloor)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            collideFloor = false;
        }

        if (transform.position.y < BoundY)
        {
            Destroy(gameObject);
            gameover = true;
            Debug.Log(PlayerWin);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            collideFloor = true;
        }

        if (collision.gameObject.CompareTag("Explosion"))
        {
            Vector3 distance = gameObject.transform.position - collision.gameObject.transform.position;
            gameObject.GetComponent<Rigidbody2D>().AddForce(distance * 7, ForceMode2D.Impulse);
        }

        if (collision.gameObject.CompareTag("Powerup"))
        {
            powerup = true;
            power.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Player") && powerup)
        {
            Vector3 playerDistance = collision.gameObject.transform.position - gameObject.transform.position;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(playerDistance * 10, ForceMode2D.Impulse);
            power.SetActive(false);
            powerup = false;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    private const float V = +2.15f;
    public GameObject Ground1, Ground2, Ground3, Ground4, Ground5, Ground6, Ground7, Ground8, Ground9, Ground10, Ground11, Ground12;
    bool hasGround = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasGround)
        {
            SpawnGround();
            hasGround = true;
        }
    }

    public void SpawnGround()
    {
        int randomNum = Random.Range(1, 12);
        
        if (randomNum == 1)
        {
            Instantiate(Ground1, new Vector3( -1.311291f, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 2)
        {
            Instantiate(Ground2, new Vector3( 1.308709f, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 3)
        {
            Instantiate(Ground3, new Vector3( -1.2f, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 4)
        {
            Instantiate(Ground4, new Vector3( -3.37f, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 5)
        {
            Instantiate(Ground5, new Vector3( 2.84f, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 6)
        {
            Instantiate(Ground6, new Vector3( 2.84f, transform.position.y + V, 0), Quaternion.identity);
        }
        if(randomNum == 7)
        {
            Instantiate(Ground7, new Vector3( 0.55f, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 8)
        {
            Instantiate(Ground8, new Vector3( -2.42f, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 9)
        {
            Instantiate(Ground9, new Vector3( -2.43f, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 10)
        {
            Instantiate(Ground10, new Vector3( 3.94f, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 11)
        {
            Instantiate(Ground11, new Vector3( 0, transform.position.y + V, 0), Quaternion.identity);
        }
        if (randomNum == 12)
        {
            Instantiate(Ground12, new Vector3( 2.84f, transform.position.y + V, 0), Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            hasGround = false;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public GameObject GroundSpawner;

    Transform mytransform;
    public Vector3 direction;
    public bool isGameStop = false;

    // Start is called before the first frame update
    void Start()
    {
        mytransform = GetComponent<Transform>();
        direction = new Vector3(0, 0.004f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0)
            mytransform.position += direction;
        else
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene("Game");

        }

       // transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }
}

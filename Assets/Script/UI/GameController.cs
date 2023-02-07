using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
 // private float stepSpace = 10f, height = 0;
 // int stepNumber = 6;
  //private GameObject[] steps;

    [SerializeField] private GameObject  playerObj, cameraObj; //stepPrefab, wallObj, rightBoundaryObj, leftBoundaryObj, frontBoundaryObj
    [SerializeField] private GameObject popupObj;
    [SerializeField] private Text scoreText, timeText;

    private PlayerController playerCom;
    private CameraController cameraCom;
    private GamePopups popupCom;
    
 // private float midWallHeight = 15f, wallHeight = 30f, addBoundaryHeight; 
    public bool isGameEnd = false;
    public bool isGamePause = false;
   
    // Start is called before the first frame update
    // the function add the first steps
    void Start()
    {
        playerCom = playerObj.GetComponent<PlayerController>();
        cameraCom = cameraObj.GetComponent<CameraController>();
        popupCom = popupObj.GetComponent<GamePopups>();
      //AddSteps();
    }

    // Update is called once per frame
    // the function check if the game end and update the game tags 
    // if the player reaches wallHeight height, adding new steps to the game
    void Update()
    {
        isGameEnd = playerCom.isGameEnd;
     // setTime();

        if (isGameEnd)
        {
            EndGame();
        }

        //scoreText.text = "SCORE: " + playerCom.score;

      //if(cameraObj.transform.position.y >= wallHeight)
        {
          //IncreaseBoundaries();
          //AddSteps();
        }
    }


    // the function add steps to the game
    void AddSteps()
    {
        //steps = new GameObject[stepNumber];
       // for(int i = 0; i < stepNumber; i++)
        {
           // steps[i] = (GameObject)Instantiate(stepPrefab);
           // height += stepSpace;
           // steps[i].GetComponent<StepController>().stepHeight = height;
        }
    }

    // the funcion increase the boundaries after the camera move
    void IncreaseBoundaries()
    {
       // addBoundaryHeight = midWallHeight;
       // wallObj.transform.position += Vector3.up * addBoundaryHeight;
       // rightBoundaryObj.transform.position += Vector3.up * addBoundaryHeight;
       // leftBoundaryObj.transform.position += Vector3.up * addBoundaryHeight;
      //  frontBoundaryObj.transform.position += Vector3.up * addBoundaryHeight;

     //   wallHeight += midWallHeight;
    }

    // the function called when the game end
    void EndGame()
    {
        cameraCom.isGameStop = true;
      //  popupCom.SetUp(playerCom.score);
    }

     // the function called when the game pause
    public void GamePause()
    {
        isGamePause = true;
        cameraCom.isGameStop = true;
        playerCom.isGamePause = true;
        popupCom.SetUp(cameraCom, playerCom);
    }

    // the function change the time tag
    void setTime()
    {
       /* int time = (int)cameraCom.leftTime;
        if(time < 10f)
        {
            timeText.text = "00:0" + time;
            if(time <= 3)
            {
                timeText.color = Color.red;
            }
            else
            {
                timeText.color = Color.white;
            }
        }
        else
        {
            timeText.text = "00:" + time;
            timeText.color = Color.white;
        } */
    }
}

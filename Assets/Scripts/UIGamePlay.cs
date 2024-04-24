using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGamePlay : MonoBehaviour
{
    //Refernce to the text showing the HEALTH
    //Refernce to the text showing the SCORE
    //Refernce to the text showing the HIGH SCORE
    //reference to this screen "game over"

    //reference to this screen "game over"

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Player>().GetHealth().currenthealth:
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //METHOD to UpdateHealth(int health)

    //METHOD to UpdateScore(int score)

    //METHOD TO UpdateHighestScore (int score)

    //METHOD ShowGameOVerScreen()
        //Needs to set Active a game over screen

    //METHOD for button to ReturnToMainMenu()

    //METHOD for Button TryAgain
}

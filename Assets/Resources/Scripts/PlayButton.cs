using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Play Game was pressed");

        //Moves to the game scene. Has to spelled same as the target scene name
        SceneManager.LoadScene("Game");
    }
}

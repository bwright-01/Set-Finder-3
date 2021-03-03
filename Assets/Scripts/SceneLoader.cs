// This class handles switching between scenes in the program
// In this particular program that means it handles switching between the title screen
// and the main program and also handles quiting the game when neccesary
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // switch to the next scene on call
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // load the title screen
    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }

    // quit game
    public void QuitGame()
    {
        Application.Quit();
    }





}

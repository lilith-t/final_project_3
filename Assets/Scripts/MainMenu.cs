using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //function to change scene to main game scene
    public void startGame()
    {
        //loads game scene
        SceneManager.LoadScene("shooterGame");
    }
    //function to quit application
    public void exitGame()
    {
        Application.Quit();
    }
}
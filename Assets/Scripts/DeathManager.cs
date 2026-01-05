using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{   
    //creating a variable for score display
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //making the cursor visible and usable 
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //displaying the score on the end screen
        scoreText.text = "Your Score: " + Shooter.score.ToString();
    }
    //function to restart game 
    public void RestartGame()
    {
        //loads game scene
        Shooter.score = 0 ;
        SceneManager.LoadScene("MainMenu");
    }
    //function to quit application
    public void ExitGame()
    {
        //quits application
        Application.Quit();
    }
}

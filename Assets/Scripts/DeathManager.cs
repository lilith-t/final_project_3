using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class DeathManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        scoreText.text = "Your Score: " + Shooter.score.ToString();
    }
    //function to change scene to main game scene

    public void RestartGame()
    {
        //loads game scene
        Shooter.score = 0 ;
        SceneManager.LoadScene("MainMenu");
    }
    //function to quit application
    public void ExitGame()
    {
        Application.Quit();
    }
}

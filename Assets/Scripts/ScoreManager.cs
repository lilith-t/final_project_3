using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public static float score = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }
}

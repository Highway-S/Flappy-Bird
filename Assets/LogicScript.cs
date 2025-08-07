using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();

        PipeMoveScript.globalSpeed += 5f; // เพิ่มความเร็วทุกคะแนน
    }

    public void restartGame()
    {
        PipeMoveScript.globalSpeed = 5f; // รีเซตความเร็วกลับค่าเริ่มต้น
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}

using UnityEngine;
using UnityEngine.UI; // UI関連のために必要
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;  // 現在のスコア
    public Text scoreText;  // スコアを表示するためのUIテキスト

    private void Start()
    {
        score = 0;
    }
    // スコアを加算するメソッド
    public void AddScore(int points)
    {
        score += points;  // ポイントを加算
        UpdateScoreUI();  // UIを更新
    }

    private void Update()
    {
        UpdateScoreUI();
    }
    // スコアUIを更新するメソッド
    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();  // スコアをテキストで表示
        }
        if(score>9)
        {
            SceneManager.LoadScene("GameClear");
        }
    }
    
}

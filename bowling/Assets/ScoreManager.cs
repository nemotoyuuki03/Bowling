using UnityEngine;
using UnityEngine.UI; // UI�֘A�̂��߂ɕK�v
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;  // ���݂̃X�R�A
    public Text scoreText;  // �X�R�A��\�����邽�߂�UI�e�L�X�g

    private void Start()
    {
        score = 0;
    }
    // �X�R�A�����Z���郁�\�b�h
    public void AddScore(int points)
    {
        score += points;  // �|�C���g�����Z
        UpdateScoreUI();  // UI���X�V
    }

    private void Update()
    {
        UpdateScoreUI();
    }
    // �X�R�AUI���X�V���郁�\�b�h
    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();  // �X�R�A���e�L�X�g�ŕ\��
        }
        if(score>9)
        {
            SceneManager.LoadScene("GameClear");
        }
    }
    
}

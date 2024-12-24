using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
    public ScoreManager scoreManager;  // スコアマネージャーを参照

    // ピンがボールに衝突したときに呼ばれる
    void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトがボールかどうかをチェック
        if (collision.gameObject.CompareTag("ball"))
        {
            // ピンを倒したのでスコアを1点加算
            scoreManager.AddScore(1);
            Destroy(gameObject); // ピンを破壊
        }
    }
    public void ResetPins()
    {
        // 現在のピンを全て破壊
        foreach (var pin in FindObjectsOfType<Pin>())
        {
            Destroy(pin.gameObject);
        }

        // 新しいピンを配置
        // ピンの初期位置をここで設定（ピンのレイアウトを再生成）
    }

}

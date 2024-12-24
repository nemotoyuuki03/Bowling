using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject BallPrefab;  // ボールのPrefab
    private Vector3 mousePos;  // マウス位置
    public Text scoreText;  // UIのスコア表示用テキスト
    public ScoreManager scoreManager;  // スコアマネージャーの参照

    // 更新処理（毎フレーム実行）
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // マウスの左クリックでボールを生成
        {
            mousePos = Input.mousePosition;  // マウス位置を取得
            mousePos.z = 5f;  // カメラとの距離を設定（適宜調整）

            // ボールを画面上のマウス位置に生成
            GameObject ball = Instantiate(BallPrefab, Camera.main.ScreenToWorldPoint(mousePos), Quaternion.identity);

            // Rigidbodyコンポーネントを取得（なければ追加）
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            if (rb == null) rb = ball.AddComponent<Rigidbody>();

            // ボールに力を加える（方向や強さを調整）
            rb.AddForce(Vector3.forward * 20);
        }
    }
}

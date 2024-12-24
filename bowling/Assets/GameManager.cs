using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject BallPrefab;  // �{�[����Prefab
    private Vector3 mousePos;  // �}�E�X�ʒu
    public Text scoreText;  // UI�̃X�R�A�\���p�e�L�X�g
    public ScoreManager scoreManager;  // �X�R�A�}�l�[�W���[�̎Q��

    // �X�V�����i���t���[�����s�j
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // �}�E�X�̍��N���b�N�Ń{�[���𐶐�
        {
            mousePos = Input.mousePosition;  // �}�E�X�ʒu���擾
            mousePos.z = 5f;  // �J�����Ƃ̋�����ݒ�i�K�X�����j

            // �{�[������ʏ�̃}�E�X�ʒu�ɐ���
            GameObject ball = Instantiate(BallPrefab, Camera.main.ScreenToWorldPoint(mousePos), Quaternion.identity);

            // Rigidbody�R���|�[�l���g���擾�i�Ȃ���Βǉ��j
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            if (rb == null) rb = ball.AddComponent<Rigidbody>();

            // �{�[���ɗ͂�������i�����⋭���𒲐��j
            rb.AddForce(Vector3.forward * 20);
        }
    }
}

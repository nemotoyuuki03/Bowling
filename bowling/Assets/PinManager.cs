using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
    public ScoreManager scoreManager;  // �X�R�A�}�l�[�W���[���Q��

    // �s�����{�[���ɏՓ˂����Ƃ��ɌĂ΂��
    void OnCollisionEnter(Collision collision)
    {
        // �Փ˂����I�u�W�F�N�g���{�[�����ǂ������`�F�b�N
        if (collision.gameObject.CompareTag("ball"))
        {
            // �s����|�����̂ŃX�R�A��1�_���Z
            scoreManager.AddScore(1);
            Destroy(gameObject); // �s����j��
        }
    }
    public void ResetPins()
    {
        // ���݂̃s����S�Ĕj��
        foreach (var pin in FindObjectsOfType<Pin>())
        {
            Destroy(pin.gameObject);
        }

        // �V�����s����z�u
        // �s���̏����ʒu�������Őݒ�i�s���̃��C�A�E�g���Đ����j
    }

}

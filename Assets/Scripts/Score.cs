using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text hageScoreText;

    // �X�R�A
    public static int _hageScore = 0;


    /// <summary>
    /// �X�R�A�����֐�
    /// </summary>
    public void HageScoreManager()
    {

        // �X�R�A�{���ݒ�
        if (_hageScore >= 20000)
        {
            _hageScore += 3873;
        }
        else if (_hageScore >= 5000)
        {
            _hageScore += 1358;
        }
        else if (_hageScore >= 1000)
        {
            _hageScore += 500;
        }
        else if (_hageScore >= 100)
        {
            _hageScore += 200;
        }
        else if (_hageScore <= 99)
        {
            _hageScore += 20;
        }

        // �X�R�A�𕶎��\��
        hageScoreText.text = _hageScore.ToString();
    }
}

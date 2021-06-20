using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ModelRoot;
    [SerializeField] GameObject HageOriginal;
    [SerializeField] GameObject Hage;
    private Vector3 hagePos = Vector3.zero;

    // 生成管理フラグ
    public bool isGenerate = false;

    // スコア
    private int hageScore = 0;
    [SerializeField] private Text hageScoreText;

    // Start is called before the first frame update
    void Awake()
    {
        hagePos = HageOriginal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HageCreate();
    }

    /// <summary>
    /// ハゲ生成関数
    /// </summary>
    void HageCreate()
    {
        if (isGenerate)
        {
            HageScoreManager();

            GameObject hageClone = Instantiate(Hage,hagePos,Quaternion.identity);
            hageClone.transform.parent = ModelRoot.transform;
            
            isGenerate = false;
        }
    }

    /// <summary>
    /// スコア生成関数
    /// </summary>
    void HageScoreManager()
    {

        // スコア倍率設定
        if (hageScore >= 20000)
        {
            hageScore += 3873;
        }
        else if (hageScore >= 5000)
        {
            hageScore += 1358;
        }
        else if (hageScore >= 1000)
        {
            hageScore += 500;
        }
        else if (hageScore >= 100)
        {
            hageScore += 200;
        }
        else if (hageScore <= 99)
        {
            hageScore += 20;
        }
        
        // スコアを文字表示
        hageScoreText.text = hageScore.ToString();
    }
}

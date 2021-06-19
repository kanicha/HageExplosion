using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ModelRoot;
    [SerializeField] GameObject HageOriginal;
    [SerializeField] GameObject Hage;
    private Vector3 hagePos = Vector3.zero;

    // �����Ǘ��t���O
    public bool isGenerate = false;

    // �X�R�A
    private int hageScore = 0;

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
    /// �n�Q�����֐�
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
    /// �X�R�A�����֐�
    /// </summary>
    void HageScoreManager()
    {

        if (hageScore >= 20000)
        {
            hageScore += 3000;
        }
        else if (hageScore >= 5000)
        {
            hageScore += 1000;
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
    }
}

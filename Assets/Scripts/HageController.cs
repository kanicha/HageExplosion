using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HageController : MonoBehaviour
{
    private GameObject gameManager;
    private GameManager gm = null;

    [SerializeField] GameObject ExplosionEffects;
    private Vector3 explosionPos = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        HageDestroy();
    }

    private void Start()
    {
        // �T�[�`���ČĂяo��
        gameManager = GameObject.Find("GameManager");
        gm = gameManager.GetComponent<GameManager>();
    }

    private void HageDestroy()
    {
        // �n�Q�̍��W�Ɣ���effect�����|�W�V��������
        explosionPos = this.transform.position;
        explosionPos.y += 1;

        // �G���^�[�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Return))
        {
            gm.isGenerate = true;
            // ����!!!!!!!!!!!
            Instantiate(ExplosionEffects,explosionPos,Quaternion.identity);
            // �n�Q�폜
            Destroy(this);
        }
    }
}

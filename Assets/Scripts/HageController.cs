using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HageController : MonoBehaviour
{
    private GameObject gameManager;
    private GameManager gm = null;
    GameObject _exprosion;
    [SerializeField] GameObject ExplosionEffects;
    private Vector3 explosionPos = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        HageDestroy();
    }

    private void Start()
    {
        // サーチして呼び出し
        gameManager = GameObject.Find("GameManager");
        gm = gameManager.GetComponent<GameManager>();
    }

    private void HageDestroy()
    {
        // ハゲの座標と爆発effect発生ポジション同期
        explosionPos = this.transform.position;
        explosionPos.y += 1;

        // エンターキーを押されたら
        if (Input.GetKeyDown(KeyCode.Return))
        {
            gm.isGenerate = true;
            // 爆発!!!!!!!!!!!
            _exprosion = Instantiate(ExplosionEffects, explosionPos, Quaternion.identity);

            Destroy(_exprosion, 2);
        }
    }
}

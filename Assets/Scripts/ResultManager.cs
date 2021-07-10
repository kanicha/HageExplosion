using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ResultScore();
        SceneChanger();
    }

    void ResultScore()
    {
        ScoreText.text = Score._hageScore.ToString();
    }

    void SceneChanger()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("TitleScene");
    }
}

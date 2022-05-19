using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    private SpriteRenderer pRenderer;     // プレイヤーのレンダラー取得


    private void Start()
    {
        pRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Button_B"))
        {
            SceneManager.LoadScene("StageSelectScene", LoadSceneMode.Single);
        }

        if (Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadScene("StageSelectScene", LoadSceneMode.Single);
        }

        Blink();
    }

    public void Blink()
    {
        float level = Mathf.Abs(Mathf.Sin(Time.time * 2));
        pRenderer.color = new Color(1f, 1f, 1f, level); // 透明にする
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnGameover : MonoBehaviour
{
    private SpriteRenderer pRenderer;     // プレイヤーのレンダラー取得


    private void Start()
    {
        pRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButtonDown("Button_X"))
        {
            SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
        }
        if (Input.GetKey(KeyCode.X))
        {
            SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
        }

        Blink();
    }

    public void Blink()
    {
        float level = Mathf.Abs(Mathf.Sin(Time.time * 2));
        pRenderer.color = new Color(1f, 1f, 1f, level); // 透明にする
    }
}

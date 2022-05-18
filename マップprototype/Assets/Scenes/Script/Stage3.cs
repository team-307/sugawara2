//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Stage3 : MonoBehaviour
//{
//    private SpriteRenderer pRenderer;     // プレイヤーのレンダラー取得


//    private void Start()
//    {
//        pRenderer = gameObject.GetComponent<SpriteRenderer>();
//    }

//    void Update()
//    {
//        //if (Input.GetButtonDown("Button_B"))
//        //{
//        //    SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
//        //}
//        if (Input.GetKeyDown(KeyCode.Alpha1))
//        {
//            SceneManager.LoadScene("map3-1", LoadSceneMode.Single);
//        }
//        if (Input.GetKeyDown(KeyCode.Alpha2))
//        {
//            SceneManager.LoadScene("map3-2", LoadSceneMode.Single);
//        }
//        if (Input.GetKeyDown(KeyCode.Alpha3))
//        {
//            SceneManager.LoadScene("map3-3", LoadSceneMode.Single);
//        }


//        //Blink();
//    }

//    //public void Blink()
//    //{
//    //    float level = Mathf.Abs(Mathf.Sin(Time.time * 2));
//    //    pRenderer.color = new Color(1f, 1f, 1f, level); // 透明にする
//    //}

//}

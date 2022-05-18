using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Zako2 : MonoBehaviour
{
    #region//インスペクターで設定する
    [Header("移動速度")] public float speed;
    [Header("重力")] public float gravity;
    [Header("画面外でも行動する")] public bool nonVisibleAct;
    [Header("接触判定")] public EnemyCollisionCheck checkCollision;
    #endregion

    #region//プライベート変数
    private Rigidbody2D rb = null;
    private SpriteRenderer sr = null;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    private Vector2 pos;
    public int num = 1;

    void Update()
    {

        if (checkCollision.isOn)
        {
            this.rb.AddForce(transform.up * 55.0f);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            this.rb.AddForce(transform.up * 128.0f);
            this.rb.AddForce(transform.right * 110.0f);

            //Destroy(collision.gameObject);
            //Destroy(gameObject);
        }
    }
}

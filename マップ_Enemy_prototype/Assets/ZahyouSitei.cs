using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZahyouSitei : MonoBehaviour
{
    #region//インスペクターで設定する
    [Header("移動速度")] public float speed;
    [Header("重力")] public float gravity;
    [Header("画面外でも行動する")] public bool nonVisibleAct;
    [Header("接触判定")] public EnemyCollisionCheck checkCollision;
    [Header("移動範囲")] public float POS_Min;
    public float POS_Max;

    #endregion

    #region//プライベート変数
    private Rigidbody2D rb = null;
    private SpriteRenderer sr = null;
    private bool rightTleftF = false;
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
        pos = transform.position;

        // （ポイント）マイナスをかけることで逆方向に移動する。
        transform.Translate(transform.right * Time.deltaTime * 3 * num);

        if (pos.x > POS_Max)
        {
            transform.localScale = new Vector3(+1, 1, 1);

            num = -1;
        }
        if (pos.x < POS_Min)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            num = 1;
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

    [SerializeField]
    private float speed;

    [SerializeField]
    private int attack;

    private float direction;

    private GameObject Enemy;
    // Use this for initialization
    void Start ()
    {

        //プレイヤーオブジェクトを取得
        var player = GameObject.FindWithTag("Player");

        direction = player.transform.localScale.x;
        //プレイヤーの情報を取得
        Enemy = GameObject.FindWithTag("Enemy");
        //5秒後に消滅
        Destroy(gameObject, 5.0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        //左に飛んでいく
        if (direction < 0)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        //右に飛んでいく
        else
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

    }
        void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "Enemy")
        {
            //プレイヤーにダメージを与える
            Enemy.GetComponent<Enemy>().SetHp(Enemy.GetComponent<Enemy>().GetHp() - attack);
            //5秒後に消滅
            Destroy(gameObject);
            print("BlletAttack : Hit");
        }
    }    
}

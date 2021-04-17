using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    [SerializeField]
    private float speed; //スピード

    [SerializeField]
    private Camera charaCamera; //キャラ追従カメラ

    [SerializeField]
    private GameObject bulletPrefab; //弾のプレファブ

    [SerializeField]
    private GameObject attackPrefab; //格闘攻撃のプレファブ

    [SerializeField]
    private GameObject dethPrefab; //死亡時エフェクト

    private float shootTime = 0.0f; //ショットタイム

    private float attackTime = 0.0f; //アタックタイム

    public int hp = 20; //hp

    private int MaxHp = 20; //MaxHP

    public Slider slider;//体力ゲージのUI

    [SerializeField]
    private string shootSE;

    [SerializeField]
    private string deathSE;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        //キャラの移動
        Move();

        //カメラの移動
        charaCamera.transform.position = new Vector3(transform.position.x, 0.0f, -10.0f);

        //弾のリロード時間
        shootTime += Time.deltaTime;
        if (shootTime > 1.0f)
        {
            //遠距離攻撃
            //Shoot();
        }

        //if (transform.position.y <= -8.0f)
        //{
        //    gameObject.SetActive(false);
        //}

        attackTime += Time.deltaTime;
        //格闘のリロード時間
        if (attackTime > 0.8f)
        {
            //格闘攻撃
            Attack();
        }

        //UIにhpとかを伝える。
        //slider.maxValue = MaxHp;
        //slider.value = hp;

        ////死亡
        //if (hp <= 0)
        //{
        //    Instantiate(dethPrefab, transform.position, Quaternion.identity);
        //    // Destroy(gameObject);
        //    gameObject.SetActive(false);
        //}
    }

    //キャラの左右移動
    void Move()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);

        if (translation < 0)
        {
            //localScale.xを-1にすると画像が反転する
            Vector2 temp = transform.localScale;
            temp.x = -1.0f;
            transform.localScale = temp;
        }
        else if (translation > 0)
        {
            //localScale.xを1にすると画像が反転する
            Vector2 temp = transform.localScale;
            temp.x = 1.0f;
            transform.localScale = temp;
        }
    }

    //弾を発射
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            shootTime = 0.0f;
        }
    }

    //格闘攻撃
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            var pos = transform.position;
            pos.x += transform.localScale.x * 1.25f;
            Instantiate(attackPrefab, pos, Quaternion.identity);
            attackTime = 0.0f;
        }
    }


}

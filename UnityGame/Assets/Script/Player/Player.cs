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

    Vector3 MOVEX = new Vector3(0.64f, 0, 0); // x軸方向に１マス移動するときの距離
    Vector3 MOVEY = new Vector3(0, 0.64f, 0); // y軸方向に１マス移動するときの距離

    float step = 2f;     // 移動速度
    Vector3 target;      // 入力受付時、移動後の位置を算出して保存 
    Vector3 prevPos;     // 何らかの理由で移動できなかった場合、元の位置に戻すため移動前の位置を保存

    // Use this for initialization
    void Start() {
        target = transform.position;
    }

    // Update is called once per frame
    void Update() {

        //キャラの移動
        // ① 移動中かどうかの判定。移動中でなければ入力を受付
        if (transform.position == target)
        {
            SetTargetPosition();
        }
        Moves();

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

    void SetTargetPosition()
    {

        prevPos =target;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            target = transform.position + MOVEX;
            //localScale.xを1にすると画像が反転する
            Vector2 temp = transform.localScale;
            temp.x = 1.0f;
            transform.localScale = temp;
            return;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            target = transform.position - MOVEX;
            //localScale.xを-1にすると画像が反転する
            Vector2 temp = transform.localScale;
            temp.x = -1.0f;
            transform.localScale = temp;
            return;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            target = transform.position + MOVEY;
            return;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            target = transform.position - MOVEY;
            return;
        }
    }

    void Moves()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, step * Time.deltaTime);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CreateMap : MonoBehaviour
{
    [SerializeField]///マップチップ変数
    private TextAsset _mapchip;

    [SerializeField]//マップデータのプレハブ変数
    private GameObject[] mapdatePrefab;

   // [HideInInspector]//スケール用変数
    public float scaling = 1.0f;

    public float scal = 0.0f;
    enum BlockNumber : int
    {
        Prefab_0,
        Prefab_1,
        Prefab_2,
        Prefab_3,
        Prefab_4,
        Prefab_5,
        Prefab_6,
        Prefab_7,
        Prefab_8,
        Prefab_9,
        Prefab_10,
        Prefab_11,
        Prefab_12,
        Prefab_13,
        Prefab_14,
        Prefab_15,
        Prefab_16,
        Prefab_17,
        Prefab_18,
        Prefab_19,
        Prefab_20,

    };

   const int prefab_0 = (int)BlockNumber.Prefab_0;
   const int prefab_1 = (int)BlockNumber.Prefab_1;
   const int prefab_2 = (int)BlockNumber.Prefab_2;
   const int prefab_3 = (int)BlockNumber.Prefab_3;
   const int prefab_4 = (int)BlockNumber.Prefab_4;
   const int prefab_5 = (int)BlockNumber.Prefab_5;
   const int prefab_6 = (int)BlockNumber.Prefab_6;
   const int prefab_7 = (int)BlockNumber.Prefab_7;
   const int prefab_8 = (int)BlockNumber.Prefab_8;
   const int prefab_9 = (int)BlockNumber.Prefab_9;
   const int prefab_10 = (int)BlockNumber.Prefab_10;
   const int prefab_11 = (int)BlockNumber.Prefab_11;
   const int prefab_12 = (int)BlockNumber.Prefab_12;
   const int prefab_13 = (int)BlockNumber.Prefab_13;
   const int prefab_14 = (int)BlockNumber.Prefab_14;
   const int prefab_15 = (int)BlockNumber.Prefab_15;
   const int prefab_16 = (int)BlockNumber.Prefab_16;
   const int prefab_17 = (int)BlockNumber.Prefab_17;
   const int prefab_18 = (int)BlockNumber.Prefab_18;
   const int prefab_19 = (int)BlockNumber.Prefab_19;
   const int prefab_20 = (int)BlockNumber.Prefab_20;

    private void Start()
    {
        Make();//作る処理
    }

    public void Make()
    {

        Vector3 sub = Vector3.zero;//初期化

        // テキストからマップデータを読み込み
        StringReader reader = new StringReader(_mapchip.text);
        while (reader.Peek() > -1)
        {
            // カンマ区切りで読み込んで行ごとにマップを作成
            string line = reader.ReadLine();
            string[] values = line.Split(',');

            foreach (string value in values)
            {
                // 読み込んだからマップを作成
                int integer = int.Parse(value);
                if (integer >= 0 && integer < mapdatePrefab.Length)
                {
                    //オブジェクトを一個ずつ
                    GameObject obj = null;
                    switch (integer)
                    {
                        //prefab_0だったら
                        case prefab_0:
                            if (mapdatePrefab[prefab_0] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                                break;
                            }
                            break;
                        //prefab_1だったら
                        case prefab_1:
                            if (mapdatePrefab[prefab_1] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;
                        //prefab_2だったら
                        case prefab_2:
                            if (mapdatePrefab[prefab_2] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_3だったら
                        case prefab_3:
                            if (mapdatePrefab[prefab_3] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_4だったら
                        case prefab_4:
                            if (mapdatePrefab[prefab_4] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_5だったら
                        case prefab_5:
                            if (mapdatePrefab[prefab_5] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_6だったら
                        case prefab_6:
                            if (mapdatePrefab[prefab_6] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;
                        
                        //prefab_7だったら
                        case prefab_7:
                            if (mapdatePrefab[prefab_7] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_8だったら
                        case prefab_8:
                            if (mapdatePrefab[prefab_8] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_9だったら
                        case prefab_9:
                            if (mapdatePrefab[prefab_9] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;
                        
                        //prefab_10だったら
                        case prefab_10:
                            if (mapdatePrefab[prefab_10] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_11だったら
                        case prefab_11:
                            if (mapdatePrefab[prefab_11] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_12だったら
                        case prefab_12:
                            if (mapdatePrefab[prefab_12] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;
                        
                        //prefab_13だったら
                        case prefab_13:
                            if (mapdatePrefab[prefab_13] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;
                        
                        //prefab_14だったら
                        case prefab_14:
                            if (mapdatePrefab[prefab_14] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_15だったら
                        case prefab_15:
                            if (mapdatePrefab[prefab_15] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_16だったら
                        case prefab_16:
                            if (mapdatePrefab[prefab_16] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_17だったら
                        case prefab_17:
                            if (mapdatePrefab[prefab_17] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;
                        
                        //prefab_18だったら
                        case prefab_18:
                            if (mapdatePrefab[prefab_18] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //prefab_19だったら
                        case prefab_19:
                            if (mapdatePrefab[prefab_19] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;
                        
                        //prefab_20だったら
                        case prefab_20:
                            if (mapdatePrefab[prefab_20] != null)
                            {
                                obj = Instantiate(mapdatePrefab[integer], transform);
                            break;
                            }
                            break;

                        //空白
                        default:
                            break;
                    }
                    if (obj != null)
                    {
                        //オブジェクトの移動と拡大
                        obj.transform.position = transform.position + sub;
                        obj.transform.localScale *= scaling;
                    }
                }
               
                sub.x += scaling * scal;
            }
            sub.x = 0; sub.y -= scaling * scal;
        }
    }

    public void Remove()
    {
        for (var num = 0; num < transform.childCount; num++)
        {
            Destroy(transform.GetChild(num).gameObject);
        }
    }
}

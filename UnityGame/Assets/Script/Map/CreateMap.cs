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
    };

   const int  prefab_0 = (int)BlockNumber.Prefab_0;
   const int  prefab_1 = (int)BlockNumber.Prefab_1;
   const int  prefab_2 = (int)BlockNumber.Prefab_2;
   const int  prefab_3 = (int)BlockNumber.Prefab_3;
    const int prefab_4 = (int)BlockNumber.Prefab_4;
    const int prefab_5 = (int)BlockNumber.Prefab_5;


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

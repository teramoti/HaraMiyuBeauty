using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senser : MonoBehaviour
{

    private bool SenserFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void  OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            SenserFlag =true;
            print("あたり");
        }
    }
    
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SenserFlag = false;
            print("はずれ");
        }
    }

    public bool GetSenser()
    {
        return SenserFlag;   
    }
}

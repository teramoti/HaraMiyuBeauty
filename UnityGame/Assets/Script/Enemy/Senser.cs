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

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            SenserFlag =true;
        }
    }
    
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SenserFlag = false;
        }
    }

    public bool GetSenser()
    {
        return SenserFlag;   
    }
}

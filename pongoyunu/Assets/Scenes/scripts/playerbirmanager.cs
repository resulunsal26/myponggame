using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbirmanager : MonoBehaviour
{
    public float hiz;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, hiz * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f,-hiz * Time.deltaTime, 0f);
        }

    }
}

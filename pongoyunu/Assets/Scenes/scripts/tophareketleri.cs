using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class tophareketleri : MonoBehaviour
{
    public Rigidbody2D toprb;
    public float xhizi, yhizi;
     int birskor, ikiskor;
    public TextMeshProUGUI birtext, ikitext,skortext,tekrartext;
    public AudioSource a;
    public int maxskor;
    public AudioClip kazanmasesi, skorsesi;
    void Start()
    {
        
    }

   
    void Update()
    {
        birtext.text = birskor.ToString();
        ikitext.text = ikiskor.ToString();
        if(birskor==maxskor)
        {
            skortext.text = "player 1 win";
            tekrartext.text = "Tekrar Oynamak İcin Enter'a Basınız";
            a.PlayOneShot(kazanmasesi);
            Time.timeScale = 0f;
           
          
        }
        else if(ikiskor==maxskor)
        {
            skortext.text = "player 2 win";
            tekrartext.text = "Tekrar Oynamak İcin Enter'a Basınız";
            a.PlayOneShot(kazanmasesi);
            Time.timeScale = 0f;
          

        }
        if(Time.timeScale==0)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                SceneManager.LoadScene("SampleScene");
                Time.timeScale = 1f;
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="playerbir")
        {
            toprb.velocity = new Vector2(-xhizi, Random.Range(-3f,3f));
        }
        else if (temas.gameObject.tag == "playeriki")
        {
            toprb.velocity = new Vector2(xhizi, Random.Range(-3f, 3f));
        }

        if(temas.gameObject.tag=="ustduvar")
        {
            toprb.velocity = new Vector2(toprb.velocity.x, -yhizi);
        }
        else if (temas.gameObject.tag == "altduvar")
        {
            toprb.velocity = new Vector2(toprb.velocity.x, yhizi);
        }

        if (temas.gameObject.tag == "solduvar")
        {
            birskor++;
            transform.position = new Vector2(-8.35f, 0f);
            a.PlayOneShot(skorsesi);
           
        }
        else if (temas.gameObject.tag == "sagduvar")
        {
            ikiskor++;
            transform.position = new Vector2(8.35f, 0f);
            a.PlayOneShot(skorsesi);

        }
    }
}

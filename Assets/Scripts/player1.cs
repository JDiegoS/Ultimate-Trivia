using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player1 : MonoBehaviour
{
    public bool state = false;
    public GameObject canvas;
    public GameObject empty;
    private int cturno;
    private int cp1;
    public GameObject opp;
    public GameObject oppg;
    private bool oppE;
    public GameObject g1;
    public GameObject g2;
    public GameObject g3 = null;
    public GameObject g4 = null;
    private int next = 0;
    private BoxCollider2D bx;
    private SpriteRenderer spr;
    private Animator anim;
    private Animator animg;
    private bool first;
    private float tem1 = 10.00f;
    private float tem = 10.00f;
    private AudioSource suck;


    void Start()
    {
        empty.SendMessage("SetBoard");
        spr = gameObject.GetComponent<SpriteRenderer>();
        //canvas = GameObject.Find("Canvas");
        bx = gameObject.GetComponent<BoxCollider2D>();
        anim = gameObject.GetComponent<Animator>();
        animg = oppg.GetComponent<Animator>();
        suck = gameObject.GetComponent<AudioSource>();


    }
    void Update()
    {
        if (first == true)
        {
            animg.enabled = true;
            //suck.Play();
            if (tem1 < 9.00f)
            {
                state = true;
                spr.enabled = true;
                anim.enabled = true;
                if (tem < 8.00f)
                {

                    
                    empty.SendMessage("Punto1");
                    empty.SendMessage("CambioEstado");
                    turnoEmp.midanim = false;
                    SceneManager.LoadScene("OpcMultiple");
                }
                else
                {
                    tem -= Time.deltaTime;
                }

            }
            else
            {
                tem1 -= Time.deltaTime;
            }

            
           
            
        }
        if (state == true)
        {
            spr.enabled = true;
        }
        else if (state == false)
        {
            Deactivate();
        }
        cturno = canvas.GetComponent<host>().turno;
        if (cturno == 2)
        {
            bx.enabled = false;
        }
        else
        {
            bx.enabled = true;
        }
    }
    private void OnMouseDown()
    {
        if (turnoEmp.midanim == false)
        {
            turnoEmp.chosen = gameObject;
            empty.SendMessage("printN");
            oppE = opp.GetComponent<player2>().state;

            cp1 = canvas.GetComponent<host>().puntos1;
            next = 0;

            if (cturno == 1)
            {
                if (g1.GetComponent<player1>().state == true)
                {
                    next += 1;
                }
                if (g2.GetComponent<player1>().state == true)
                {
                    next += 1;
                }
                if (g3.GetComponent<player1>().state == true)
                {
                    next += 1;
                }
                if (g4.GetComponent<player1>().state == true)
                {
                    next += 1;
                }
                Debug.Log(state);
                Debug.Log(next);
                Debug.Log(cp1);
                if (state == false && (next > 0 || cp1 == 0))
                {
                    if (oppE == true)
                    {
                        SceneManager.LoadScene("Categories");
                    }
                    else
                    {
                        turnoEmp.midanim = true;
                        anim.enabled = false;
                        animg.enabled = false;
                        suck.Play();
                        first = true;

                    }
                }
            }
        }
        
        

    }
    public void Deactivate()
    {
        state = false;
        spr.enabled = false;
    }

}

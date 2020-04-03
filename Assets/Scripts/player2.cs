using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player2 : MonoBehaviour
{
    public bool state = false;
    public GameObject canvas;
    public GameObject empty;
    private int cturno;
    private int cp1;
    public GameObject g1;
    public GameObject g2;
    public GameObject g3 = null;
    public GameObject g4 = null;
    private int next = 0;
    private SpriteRenderer spr;
    private BoxCollider2D bx;
    public GameObject opp;
    private bool oppE;
    private Animator anim;
    private Animator animg;
    private bool first;
    private float tem1 = 10.00f;
    private float tem = 10.00f;
    public GameObject oppg;
    private AudioSource suck;
    

    void Start()
    {
        //canvas = GameObject.Find("Canvas");
        if (turnoEmp.gano == true && state != true)
        {
            if (turnoEmp.choosen == gameObject.name)
            {
                state = true;
            }
        }
        spr = gameObject.GetComponent<SpriteRenderer>();
        bx = gameObject.GetComponent<BoxCollider2D>();
        anim = gameObject.GetComponent<Animator>();
        animg = oppg.GetComponent<Animator>();
        suck = gameObject.GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (first == true)
        {
            animg.enabled = true;
            if (tem1 < 9.00f)
            {
                state = true;
                spr.enabled = true;
                anim.enabled = true;
                if (tem < 8.00f)
                {

                    
                    empty.SendMessage("Punto2");
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
        if (cturno == 1)
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
            oppE = opp.GetComponent<player1>().state;


            cturno = canvas.GetComponent<host>().turno;
            cp1 = canvas.GetComponent<host>().puntos2;
            next = 0;

            if (cturno == 2)
            {
                if (g1.GetComponent<player2>().state == true)
                {
                    next += 1;
                }
                if (g2.GetComponent<player2>().state == true)
                {
                    next += 1;
                }
                if (g3.GetComponent<player2>().state == true)
                {
                    next += 1;
                }
                if (g4.GetComponent<player2>().state == true)
                {
                    next += 1;
                }

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

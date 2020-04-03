using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class turnoEmp : MonoBehaviour
{
    static public int turno = 1;
    public int tu = 1;
    public GameObject canvas;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject b9;
    public GameObject r1;
    public GameObject r2;
    public GameObject r3;
    public GameObject r4;
    public GameObject r5;
    public GameObject r6;
    public GameObject r7;
    public GameObject r8;
    public GameObject r9;
    static public GameObject chosen;
    static public string choosen = "";
    static public bool gano = false;

    public GameObject inst;
    public GameObject boar;
    public GameObject back;
    public GameObject bks;
    public GameObject canv;
    public GameObject win;
    public GameObject ba;
    public UnityEngine.UI.Text txtW;

    static public int puntos1 = 0;
    static public int puntos2 = 0;

    static public bool br1 = false;
    static public bool br2 = false;
    static public bool br3 = false;
    static public bool br4 = false;
    static public bool br5 = false;
    static public bool br6 = false;
    static public bool br7 = false;
    static public bool br8 = false;
    static public bool br9 = false;
    static public bool bb1 = false;
    static public bool bb2 = false;
    static public bool bb3 = false;
    static public bool bb4 = false;
    static public bool bb5 = false;
    static public bool bb6 = false;
    static public bool bb7 = false;
    static public bool bb8 = false;
    static public bool bb9 = false;


    static public List<int> prev = new List<int>();
    static public List<int> prev1 = new List<int>();
    static public bool midanim = false;

    public AudioSource cheer;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
        Screen.fullScreen = false;
        
    }
    private void Update()
    {
        tu = turno;
        if (puntos1 == 9 || puntos2 == 9)
        {
            Win();
        }
    }

    public void t1()
    {
        turno = 1;
    }
    public void t2()
    {
        turno = 2;
    }
    public void SetBoard()
    {
        if (bb1 == true)
        {
            b1.GetComponent<player1>().state = true;
        }
        if (bb2 == true)
        {
            b2.GetComponent<player1>().state = true;
        }
        if (bb3 == true)
        {
            b3.GetComponent<player1>().state = true;
        }
        if (bb4 == true)
        {
            b4.GetComponent<player1>().state = true;
        }
        if (bb5 == true)
        {
            b5.GetComponent<player1>().state = true;
        }
        if (bb6 == true)
        {
            b6.GetComponent<player1>().state = true;
        }
        if (bb7 == true)
        {
            b7.GetComponent<player1>().state = true;
        }
        if (bb8 == true)
        {
            b8.GetComponent<player1>().state = true;
        }
        if (bb9 == true)
        {
            b9.GetComponent<player1>().state = true;
        }


        if (br1 == true)
        {
            r1.GetComponent<player2>().state = true;
        }
        if (br2 == true)
        {
            r2.GetComponent<player2>().state = true;
        }
        if (br3 == true)
        {
            r3.GetComponent<player2>().state = true;
        }
        if (br4 == true)
        {
            r4.GetComponent<player2>().state = true;
        }
        if (br5 == true)
        {
            r5.GetComponent<player2>().state = true;
        }
        if (br6 == true)
        {
            r6.GetComponent<player2>().state = true;
        }
        if (br7 == true)
        {
            r7.GetComponent<player2>().state = true;
        }
        if (br8 == true)
        {
            r8.GetComponent<player2>().state = true;
        }
        if (br9 == true)
        {
            r9.GetComponent<player2>().state = true;
        }
    }
    public void CambioEstado()
    {
        if (b1.GetComponent<player1>().state == true)
        {
            bb1 = true;
        }
        if (b2.GetComponent<player1>().state == true)
        {
            bb2 = true;
        }
        if (b3.GetComponent<player1>().state == true)
        {
            bb3 = true;
        }
        if (b4.GetComponent<player1>().state == true)
        {
            bb4 = true;
        }
        if (b5.GetComponent<player1>().state == true)
        {
            bb5 = true;
        }
        if (b6.GetComponent<player1>().state == true)
        {
            bb6 = true;
        }
        if (b7.GetComponent<player1>().state == true)
        {
            bb7 = true;
        }
        if (b8.GetComponent<player1>().state == true)
        {
            bb8 = true;
        }
        if (b9.GetComponent<player1>().state == true)
        {
            bb9 = true;
        }


        if (r1.GetComponent<player2>().state == true)
        {
            br1 = true;
        }
        if (r2.GetComponent<player2>().state == true)
        {
            br2 = true;
        }
        if (r3.GetComponent<player2>().state == true)
        {
            br3 = true;
        }
        if (r4.GetComponent<player2>().state == true)
        {
            br4 = true;
        }
        if (r5.GetComponent<player2>().state == true)
        {
            br5 = true;
        }
        if (r6.GetComponent<player2>().state == true)
        {
            br6 = true;
        }
        if (r7.GetComponent<player2>().state == true)
        {
            br7 = true;
        }
        if (r8.GetComponent<player2>().state == true)
        {
            br8 = true;
        }
        if (r9.GetComponent<player2>().state == true)
        {
            br9 = true;
        }
    }
    public void Punto1()
    {
        puntos1 += 1;
    }
    public void Punto2()
    {
        puntos2 += 1;
    }
    public void printN()
    {
        choosen = chosen.name;
        Debug.Log(choosen);
    }
    public void Instrucciones()
    {
        back.SetActive(true);
        inst.SetActive(true);
        canv.SetActive(false);
        boar.SetActive(false);
        bks.SetActive(false);
    }
    public void Regresar()
    {
        back.SetActive(false);
        inst.SetActive(false);
        canv.SetActive(true);
        boar.SetActive(true);
        bks.SetActive(true);
    }
    public void Win()
    {
        cheer.Play();
        if (puntos1 == 9)
        {
            txtW.text = "Felicidades Jugador 1!";
        }
        else
        {
            txtW.text = "Felicidades Jugador 2!";
        }

        win.SetActive(true);
        back.SetActive(true);
        inst.SetActive(false);
        canv.SetActive(false);
        boar.SetActive(false);
        ba.SetActive(false);
    }
    public void menu()
    {
        br1 = false;
        br2 = false;
        br3 = false;
        br4 = false;
        br5 = false;
        br6 = false;
        br7 = false;
        br8 = false;
        br9 = false;
        bb1 = false;
        bb2 = false;
        bb3 = false;
        bb4 = false;
        bb5 = false;
        bb6 = false;
        bb7 = false;
        bb8 = false;
        bb9 = false;
        puntos1 = 0;
        puntos2 = 0;
        turno = 1;
        prev.Clear();
        prev1.Clear();
        SceneManager.LoadScene("Menu");
    }
}

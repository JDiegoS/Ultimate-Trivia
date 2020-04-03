using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class host : MonoBehaviour
{
    public int turno = 1;
    public int puntos1 = 0;
    public int puntos2 = 0;
    public GameObject txt1;
    public GameObject txt2;
    public GameObject empty;
    
    public int turnos;

    // Start is called before the first frame update
    void Start()
    {
        turno = turnoEmp.turno;
        puntos1 = turnoEmp.puntos1;
        puntos2 = turnoEmp.puntos2;
    }

    // Update is called once per frame
    void Update()
    {
        if (turno == 1)
        {
            txt1.SetActive(true);
            txt2.SetActive(false);
        }
        else
        {
            txt1.SetActive(false);
            txt2.SetActive(true);
        }

    }
    public void turno1()
    {
        turno = 1;
    }
    public void turno2()
    {
        turno = 2;
    }
    public void CambioTurno()
    {
        if (turno == 1)
        {
            turno = 2;
            
        }
        else
        {
            turno = 1;
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
    
}

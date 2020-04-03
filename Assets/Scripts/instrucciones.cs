using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instrucciones : MonoBehaviour
{
    public GameObject inst;
    public GameObject back;
    public GameObject canv;


    public void Instrucciones()
    {
        back.SetActive(false);
        inst.SetActive(true);
        canv.SetActive(false);
  
    }
    public void Regresar()
    {
        back.SetActive(true);
        inst.SetActive(false);
        canv.SetActive(true);
      
    }
}

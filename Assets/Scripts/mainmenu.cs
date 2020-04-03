using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject inst;
    public GameObject back;
    public GameObject canv;
    public GameObject backi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Instrucciones()
    {
        back.SetActive(false);
        inst.SetActive(true);
        canv.SetActive(false);
        backi.SetActive(true);

    }
    public void Regresar()
    {
        back.SetActive(true);
        inst.SetActive(false);
        canv.SetActive(true);
        backi.SetActive(false);

    }
    public void play()
    {
        SceneManager.LoadScene("Board");
    }
}

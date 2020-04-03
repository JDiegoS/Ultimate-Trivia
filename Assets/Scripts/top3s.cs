using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top3s : MonoBehaviour
{
    public UnityEngine.UI.Text ans1;
    public UnityEngine.UI.Text ans2;
    public UnityEngine.UI.Text ans3;
    public UnityEngine.UI.Text question;
    private int correct;
    private int selection;

    
    void Select()
    {
        selection = Random.Range(1, 5);
        if (selection == 1)
        {
            question.text = "Rasones por las que una persona se levanta a las 2 a.m";
            ans1.text = "";
        }
    }
}

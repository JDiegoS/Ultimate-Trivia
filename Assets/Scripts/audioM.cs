using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioM : MonoBehaviour
{
    public AudioSource suck;
    public AudioClip intro1;
    public AudioClip intro2;
    private int cual = 1;
    // Start is called before the first frame update
    void Start()
    {
        suck.Play();
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (!suck.isPlaying)
        {
            if (cual == 1)
            {
                suck.clip = intro2;
                suck.Play();
                cual = 2;
            }
            else
            {
                suck.clip = intro1;
                suck.Play();
                cual = 1;
            }
        }
    }
}

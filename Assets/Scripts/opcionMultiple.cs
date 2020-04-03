using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opcionMultiple : MonoBehaviour
{
    public int elec = 0;
    private float time = 15.00f;
    public UnityEngine.UI.Text timer;
    public UnityEngine.UI.Text ques;

    public UnityEngine.UI.Text ans1;
    public UnityEngine.UI.Text ans2;
    public UnityEngine.UI.Text ans3;
    public UnityEngine.UI.Text ans4;
    private int correct;
    private int selection;
    private List<int> prev1;
    private bool notp = false;
    private bool cross = false;
    private bool check = false;
    public Animator animCh;
    public Animator animCr;
    public AudioSource snCh;
    public AudioSource snCr;
    private float tem1 = 10.00f;
    private float tem = 10.00f;
    private bool defeated = false;

    // Start is called before the first frame update
    void Start()
    {
        
        selection = Random.Range(1, 41);
        
        if (turnoEmp.prev1.Count > 0)
        {
            while (notp == false)
            {
                int cont = 0;
                for (int i = 0; i < turnoEmp.prev1.Count; i++)
                    if (turnoEmp.prev1[i] == selection)
                    {
                        cont += 1;
                        i = 100;
                    }
                if (cont > 0)
                {
                    selection = Random.Range(1, 41);
                }
                else
                {
                    notp = true;
                }

            }
        }
        
        if (selection == 1)
            {
                ques.text = "En donde se llevo a cabo la Copa Mundial en el 2010?";
                ans1.text = "Alemania";
                ans2.text = "Italia";
                ans3.text = "Sudafrica";
                ans4.text = "Brasil";
                correct = 3;
            }
        else if (selection == 2)
        {
            ques.text = "Quien fue el primer presidente de los Estados Unidos?";
            ans1.text = "Abraham Lincoln";
            ans2.text = "George Bush";
            ans3.text = "George Washington";
            ans4.text = "Barack Obama";
            correct = 3;
        }
        else if (selection == 3)
        {
            ques.text = "NHL es una liga en donde se juega que deporte?";
            ans1.text = "Futbol";
            ans2.text = "Futbol Americano";
            ans3.text = "Hockey";
            ans4.text = "Baloncesto";
            correct = 3;
        }
        else if (selection == 4)
        {
            ques.text = "Que obra no fue escrita por William Shakespeare?";
            ans1.text = "La Guerra de los Gigantes";
            ans2.text = "Macbeth";
            ans3.text = "Julio Cesar";
            ans4.text = "Noche de Reyes";
            correct = 1;
        }
        else if (selection == 5)
        {
            ques.text = "Que país no es frontera de Etiopía?";
            ans1.text = "Somalia";
            ans2.text = "Sudan";
            ans3.text = "Kenya";
            ans4.text = "Nigeria";
            correct = 4;
        }
        else if (selection == 6)
        {
            ques.text = "Que equipo de baloncesto ha ganado mas campeonatos?";
            ans1.text = "Miami Heat";
            ans2.text = "Los Angeles Lakers";
            ans3.text = "Boston Celtics";
            ans4.text = "Golden State Warriors";
            correct = 3;
        }
        else if (selection == 7)
        {
            ques.text = "En que pais nacio el dictador Adolf Hitler?";
            ans1.text = "Austria";
            ans2.text = "Polonia";
            ans3.text = "Guatemala";
            ans4.text = "Alemania";
            correct = 1;
        }
        else if (selection == 8)
        {
            ques.text = "El nombre de la empresa IBM es un acrónimo para:";
            ans1.text = "Internal Business Model";
            ans2.text = "International Business Machines";
            ans3.text = "International Business Media";
            ans4.text = "Internet Based Machines";
            correct = 2;
        }
        else if (selection == 9)
        {
            ques.text = "Leonardo DiCaprio ganó un premio Oscar por su rol en que pelicula?";
            ans1.text = "The Great Gatsby";
            ans2.text = "The Wolf of Wall Street";
            ans3.text = "Inception";
            ans4.text = "The Revenant";
            correct = 4;
        }
        else if (selection == 10)
        {
            ques.text = "Que país de America del Sur es el mas poblado?";
            ans1.text = "Brasil";
            ans2.text = "Argentina";
            ans3.text = "Colombia";
            ans4.text = "Uruguay";
            correct = 1;
        }
        else if (selection == 11)
        {
            ques.text = "En mitología griega, quién es el díos de la guerra?";
            ans1.text = "Ares";
            ans2.text = "Afrodita";
            ans3.text = "Apolo";
            ans4.text = "Hades";
            correct = 1;
        }
        else if (selection == 12)
        {
            ques.text = "Cual es la canción mas escuchada de todos los tiempos en Spotify?";
            ans1.text = "Despacito Remix - Luis Fonsi";
            ans2.text = "One Dance - Drake";
            ans3.text = "Shape of You - Ed Sheeran";
            ans4.text = "Sorry - Justin Bieber";
            correct = 3;
        }
        else if (selection == 13)
        {
            ques.text = "Que jugador utiliza el numero 7 en su uniforme?";
            ans1.text = "Lionel Messi";
            ans2.text = "Cristiano Ronaldo";
            ans3.text = "Pelé";
            ans4.text = "Iker Casillas";
            correct = 2;
        }
        else if (selection == 14)
        {
            ques.text = "Cual es la ciudad mas poblada del mundo?";
            ans1.text = "Tokyo";
            ans2.text = "Delhi";
            ans3.text = "Sao Paulo";
            ans4.text = "Shanghai";
            correct = 1;
        }
        else if (selection == 15)
        {
            ques.text = "Cual es el país mas poblado del mundo?";
            ans1.text = "India";
            ans2.text = "China";
            ans3.text = "Estados Unidos";
            ans4.text = "Rusia";
            correct = 2;
        }
        else if (selection == 16)
        {
            ques.text = "Que jugador de la NFL tiene el record de mas touchdowns?";
            ans1.text = "Tom Brady";
            ans2.text = "Peyton Manning";
            ans3.text = "Drew Brees";
            ans4.text = "Brett Favre";
            correct = 3;
        }
        else if (selection == 17)
        {
            ques.text = "Que país declaro su independencia en el 2011?";
            ans1.text = "Sudan del Sur";
            ans2.text = "Namibia";
            ans3.text = "Angola";
            ans4.text = "Zimbabwe";
            correct = 1;
        }
        else if (selection == 18)
        {
            ques.text = "Cual es el juego con mas ventas de la historia?";
            ans1.text = "Tetris";
            ans2.text = "Grand Theft Auto V";
            ans3.text = "Grand Theft Auto IV";
            ans4.text = "Minecraft";
            correct = 4;
        }
        else if (selection == 19)
        {
            ques.text = "Que película gano el premio Oscar de Mejor Película en el 2020?";
            ans1.text = "Parasite";
            ans2.text = "1917";
            ans3.text = "Joker";
            ans4.text = "The Irishman";
            correct = 1;
        }
        else if (selection == 20)
        {
            ques.text = "La Guerra Fría involucraba principalmente a que países?";
            ans1.text = "Estados Unidos y Alemania";
            ans2.text = "Estados Unidos y Corea del Norte";
            ans3.text = "Estados Unidos y Corea del Sur";
            ans4.text = "Estados Unidos y La Union Sovietica";
            correct = 4;
        }
     
        else if (selection == 21)
        {
            ques.text = "Que restaurante de comida rapida tiene la mayor cantidad de restaurantes en el mundo?";
            ans1.text = "Subway";
            ans2.text = "McDonald's";
            ans3.text = "Starbucks";
            ans4.text = "KFC";
            correct = 1;
        }
        else if (selection == 22)
        {
            ques.text = "Que banda es conocida como una de las mejores de todos los tiempos y se formo en Liverpool, Reino Unido?";
            ans1.text = "Maroon 5";
            ans2.text = "The Rolling Stones";
            ans3.text = "The Beatles";
            ans4.text = "Nirvana";
            correct = 3;
        }
        else if (selection == 23)
        {
            ques.text = "Quien es el unico jugador de la NBA que gano un Oscar?";
            ans1.text = "Michael Jordan";
            ans2.text = "Kobe Bryant";
            ans3.text = "LeBron James";
            ans4.text = "Kyrie Irving";
            correct = 2;
        }
        else if (selection == 24)
        {
            ques.text = "Como se llama la serie de videojuegos de futbol americano publicada por EA desde 1988?";
            ans1.text = "Madden";
            ans2.text = "FIFA";
            ans3.text = "Grand Slam";
            ans4.text = "Ultimate Touchdown";
            correct = 1;
        }
        else if (selection == 25)
        {
            ques.text = "Que artista de Hip Hop se nombro tras las iniciales de su nombre completo y tiene un alter ego llamado Slim Shady?";
            ans1.text = "Justin Bieber";
            ans2.text = "Eminem";
            ans3.text = "MGK";
            ans4.text = "2Pac";
            correct = 2;
        }
        else if (selection == 26)
        {
            ques.text = "Quien descubrio America?";
            ans1.text = "Francisco Pizarro";
            ans2.text = "Hernan Cortes";
            ans3.text = "Cristobal Colon";
            ans4.text = "John Cabot";
            correct = 3;
        }
        else if (selection == 27)
        {
            ques.text = "Que equipo no juega en La Liga Española?";
            ans1.text = "Real Madrid";
            ans2.text = "FC Barcelona";
            ans3.text = "Getafe Club";
            ans4.text = "Parma FC";
            correct = 4;
        }
        else if (selection == 28)
        {
            ques.text = "Como se llama el personaje y amigo rojo de Sonic?";
            ans1.text = "Tails";
            ans2.text = "Knuckles";
            ans3.text = "Shadow";
            ans4.text = "Blaze";
            correct = 2;
        }
        else if (selection == 29)
        {
            ques.text = "Quien es el presidente de la Republica Popular China?";
            ans1.text = "Xi Jinping";
            ans2.text = "Shinzo Abe";
            ans3.text = "Moon Jae-in";
            ans4.text = "Kim Jong-un";
            correct = 1;
        }
        else if (selection == 30)
        {
            ques.text = "En que año termino la Segunda Guerra Mundial?";
            ans1.text = "1942";
            ans2.text = "1939";
            ans3.text = "1947";
            ans4.text = "1945";
            correct = 4;
        }

        else if (selection == 31)
        {
            ques.text = "Rihanna es la artista con mas ventas digitales de la historia, en que pais nacio?";
            ans1.text = "Barbados";
            ans2.text = "Jamaica";
            ans3.text = "Republica Dominicana";
            ans4.text = "Estados Unidos";
            correct = 1;
        }
        else if (selection == 32)
        {
            ques.text = "Que filosofo chino escribio 'El Arte de la Guerra'?";
            ans1.text = "Confucius";
            ans2.text = "Lao Tzu";
            ans3.text = "Sun Tzu";
            ans4.text = "Mencius";
            correct = 3;
        }
        else if (selection == 33)
        {
            ques.text = "Quien es el artista de Corea del Sur que canta Gangnam Style?";
            ans1.text = "BTS";
            ans2.text = "PSY";
            ans3.text = "G-Dragon";
            ans4.text = "BoA";
            correct = 2;
        }
        else if (selection == 34)
        {
            ques.text = "En 1992, Deion Sanders se volvio el unico atleta en jugar dos partidos profesionales en que dos ligas distintas en un dia?";
            ans1.text = "NFL y MLB";
            ans2.text = "NHL y MLB";
            ans3.text = "NFL y NHL";
            ans4.text = "NFL y NBA";
            correct = 1;
        }
        else if (selection == 35)
        {
            ques.text = "En 1886, que pais regalo la Estatua de la Libertad a los Estados Unidos?";
            ans1.text = "Alemania";
            ans2.text = "Francia";
            ans3.text = "Inglaterra";
            ans4.text = "Italia";
            correct = 2;
        }
        else if (selection == 36)
        {
            ques.text = "Freddie Mercury es miembro de cual banda?";
            ans1.text = "The Beatles";
            ans2.text = "Coldplay";
            ans3.text = "Queen";
            ans4.text = "AC/DC";
            correct = 3;
        }
        else if (selection == 37)
        {
            ques.text = "Cual es la franquicia cinematica mas exitosa de la historia?";
            ans1.text = "Harry Potter";
            ans2.text = "James Bond";
            ans3.text = "Star Wars";
            ans4.text = "Marvel Cinematic Universe";
            correct = 4;
        }
        else if (selection == 38)
        {
            ques.text = "Cual de los siguientes no es un personaje de 'Friends'?";
            ans1.text = "Joey";
            ans2.text = "Mathew";
            ans3.text = "Rachel";
            ans4.text = "Chandler";
            correct = 2;
        }
        else if (selection == 39)
        {
            ques.text = "Cual es el evento deportivo mas visto en la historia?";
            ans1.text = "Olimpiadas 2012";
            ans2.text = "Olimpiadas 2016";
            ans3.text = "Copa Mundial 2018";
            ans4.text = "Olimpiadas 2008";
            correct = 1;
        }
        else if (selection == 40)
        {
            ques.text = "En que año salio la primera pelicula de Toy Story?";
            ans1.text = "1992";
            ans2.text = "1999";
            ans3.text = "2000";
            ans4.text = "1995";
            correct = 4;
        }

        turnoEmp.prev1.Add(selection);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            timer.text = "" + time.ToString("f0");
        }
        else
        {
            if (defeated == false)
            {
                defeat();
                defeated = true;
            }
            
        }

        if (check == true)
        {
            animCh.enabled = true;
            
            if (tem1 < 7.50f)
            {
                SceneManager.LoadScene("Board");

            }
            else
            {
                tem1 -= Time.deltaTime;
            }
        }
        if (cross == true)
        {
            animCr.enabled = true;
            
            if (tem1 < 7.50f)
            {
                SceneManager.LoadScene("Board");

            }
            else
            {
                tem1 -= Time.deltaTime;
            }
        }
        

    }
    public void answer()
    {
        if (elec == correct)
        {
            Debug.Log("1");
            Debug.Log("Selec " + elec + " corr " + correct);
            victoria();
        }
        else
        {
            Debug.Log("Selec " + elec + " corr " + correct);
            defeat();
            Debug.Log("2");
        }
    }
    public void victoria()
    {
        if (turnoEmp.turno == 1)
        {
            turnoEmp.turno = 2;
        }
        else
        {
            turnoEmp.turno = 1;
        }
        animCh.enabled = false;
        snCh.Play();
        check = true;
    }
    public void defeat()
    {
        if (turnoEmp.turno == 1)
        {
            Debug.Log("tuno" + 1);
            if (turnoEmp.choosen == "Blue Square 1")
            {
             
                turnoEmp.bb1 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 2")
            {
              
                turnoEmp.bb2 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 3")
            {
                
                turnoEmp.bb3 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 4")
            {
                
                turnoEmp.bb4 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 5")
            {
                
                turnoEmp.bb5 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 6")
            {
                
                turnoEmp.bb6 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 7")
            {
                
                turnoEmp.bb7 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 8")
            {
                
                turnoEmp.bb8 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 9")
            {
                
                turnoEmp.bb9 = false;
            }
            turnoEmp.gano = false;
            turnoEmp.puntos1 -= 1;
            turnoEmp.turno = 2;
        }
        else
        {
            Debug.Log("tuno" + 2);
            if (turnoEmp.choosen == "Red Square 1")
            {
              
                turnoEmp.br1 = false;
            }
            else if (turnoEmp.choosen == "Red Square 2")
            {
            
                turnoEmp.br2 = false;
            }
            else if (turnoEmp.choosen == "Red Square 3")
            {
               
                turnoEmp.br3 = false;
            }
            else if (turnoEmp.choosen == "Red Square 4")
            {
              
                turnoEmp.br4 = false;
            }
            else if (turnoEmp.choosen == "Red Square 5")
            {
              
                turnoEmp.br5 = false;
            }
            else if (turnoEmp.choosen == "Red Square 6")
            {
              
                turnoEmp.br6 = false;
            }
            else if (turnoEmp.choosen == "Red Square 7")
            {
                turnoEmp.br7 = false;
            }
            else if (turnoEmp.choosen == "Red Square 8")
            {
              
                turnoEmp.br8 = false;
            }
            else if (turnoEmp.choosen == "Red Square 9")
            {
              
                turnoEmp.br9 = false;
            }
            turnoEmp.gano = false;
            turnoEmp.puntos2 -= 1;
            turnoEmp.turno = 1;
        }
        animCr.enabled = false;
        snCr.Play();
        cross = true;
        
    }
    public void Opcion1()
    {
        elec = 1;
        answer();
    }
    public void Opcion2()
    {
        elec = 2;
        answer();
    }
    public void Opcion3()
    {
        elec = 3;
        answer();
    }
    public void Opcion4()
    {
        elec = 4;
        answer();
    }
}

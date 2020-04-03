using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class categorias : MonoBehaviour
{
    private float time = 20.00f;
    public UnityEngine.UI.Text timer;
    public UnityEngine.UI.Text ques;

    public GameObject j1;
    public GameObject j2;
    public GameObject sig;
    public UnityEngine.UI.Text contad;
    public GameObject contado;
    private int cj1 = 0;
    private int cj2 = 0;
    private int max = 0;
    private int cont = 0;
    private int turno = 1;
    private int emp = 0;
    public UnityEngine.UI.Text set;
    public UnityEngine.UI.Text question;
    private GameObject oppD;
    private bool begun = false;
    private int selection = 0;
    private int prev = 0;
    private bool notp = false;
   


    private void Start()
    {
        
        emp = turnoEmp.turno;
        if (emp == 1)
        {
            j1.SetActive(true);
            j2.SetActive(false);
        }
        else
        {
            j2.SetActive(true);
            j1.SetActive(false);
        }

        selection = Random.Range(1, 41);
        notp = false;

        if (turnoEmp.prev1.Count > 0)
        {
            while (notp == false)
            {
                int cont = 0;
                for (int i = 0; i < turnoEmp.prev.Count; i++)
                    if (turnoEmp.prev[i] == selection)
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
            ques.text = "Deportes";
        }
        else if (selection == 2)
        {
            ques.text = "Idiomas";
        }
        else if (selection == 3)
        {
            ques.text = "Países de Africa";
        }
        else if (selection == 4)
        {
            ques.text = "Países de Asia";
        }
        else if (selection == 5)
        {
            ques.text = "Países de Norte America";
        }
        else if (selection == 6)
        {
            ques.text = "Países de America del Sur";
        }
        else if (selection == 7)
        {
            ques.text = "Departamentos de Guatemala";
        }
        else if (selection == 8)
        {
            ques.text = "Estados de los Estados Unidos";
        }
        else if (selection == 9)
        {
            ques.text = "Equipos de Futbol (Soccer)";
        }
        else if (selection == 10)
        {
            ques.text = "Equipos de Futbol Americano";
        }
        else if (selection == 11)
        {
            ques.text = "Peliculas de Horror";
        }
        else if (selection == 12)
        {
            ques.text = "Presidentes Actuales";
        }
        else if (selection == 13)
        {
            ques.text = "Numeros";
        }
        else if (selection == 14)
        {
            ques.text = "Colores";
        }
        else if (selection == 15)
        {
            ques.text = "Libros Infantiles";
        }
        else if (selection == 16)
        {
            ques.text = "Series en Netflix";
        }
        else if (selection == 17)
        {
            ques.text = "Peliculas de Disney";
        }
        else if (selection == 18)
        {
            ques.text = "Marcas de Automoviles";
        }
        else if (selection == 19)
        {
            ques.text = "Instrumentos";
        }
        else if (selection == 20)
        {
            ques.text = "Nombres Femeninos";
        }
        if (selection == 21)
        {
            ques.text = "Animales Terrestres";
        }
        else if (selection == 22)
        {
            ques.text = "Continentes";
        }
        else if (selection == 23)
        {
            ques.text = "Tiendas";
        }
        else if (selection == 24)
        {
            ques.text = "Actores de Pelicula";
        }
        else if (selection == 25)
        {
            ques.text = "Videojuegos";
        }
        else if (selection == 26)
        {
            ques.text = "Aplicaciones Moviles";
        }
        else if (selection == 27)
        {
            ques.text = "Canciones de Michael Jackson";
        }
        else if (selection == 28)
        {
            ques.text = "Series de Cartoon Network";
        }
        else if (selection == 29)
        {
            ques.text = "Canales de Television";
        }
        else if (selection == 30)
        {
            ques.text = "Superheroes de Marvel y DC";
        }
        else if (selection == 31)
        {
            ques.text = "Autores Reconocidos";
        }
        else if (selection == 32)
        {
            ques.text = "Artistas de Hip-Hop";
        }
        else if (selection == 33)
        {
            ques.text = "Restaurantes de Comida Rapida";
        }
        else if (selection == 34)
        {
            ques.text = "Cosas que se encuentran en un estuche";
        }
        else if (selection == 35)
        {
            ques.text = "Consolas de Videojuegos";
        }
        else if (selection == 36)
        {
            ques.text = "Aplicaciones Moviles";
        }
        else if (selection == 37)
        {
            ques.text = "Series de Comedia";
        }
        else if (selection == 38)
        {
            ques.text = "Deportes Vistos en Olimpiadas";
        }
        else if (selection == 39)
        {
            ques.text = "Aplicaciones de iPhone";
        }
        else if (selection == 40)
        {
            ques.text = "Marcas de Vomputadoras";
        }
        turnoEmp.prev.Add(selection);
        
    }
    void Update()
    {
        if (time > 0)
        {
            if (begun == true)
            {
                time -= Time.deltaTime;
                timer.text = "" + time.ToString("f0");
            }
        }
        else
        {
            defeat();
        }

    }
    public void Begin()
    {
        if (cj1 != 0 || cj2 != 0)
        {
            transform.Find("begin").gameObject.SetActive(false);
            transform.Find("count").gameObject.SetActive(true);
            if (cj1 > cj2)
            {
                set.text = "Jugador 1 \n Nombra: " + cj1;
                max = cj1;
                turno = 1;
            }
            else
            {
                set.text = "Jugador 2 \n Nombra: " + cj2;
                max = cj2;
                turno = 2;
            }
            begun = true;
            j1.SetActive(false);
            j2.SetActive(false);
            contado.SetActive(false);
            sig.SetActive(true);
        }
        
        
    }
    public void Inc1()
    {
        Debug.Log(emp);
        if (begun == false && emp == 1)
        {
            cj1 = cj2 + 1;
            contad.text = "" + cj1;
            j1.SetActive(false);
            j2.SetActive(true);
            emp = 2;
        }
    }
    public void Inc2()
    {
        if (begun == false && emp == 2)
        {
            cj2 = cj1 + 1;
            contad.text = "" + cj2;
            j1.SetActive(true);
            j2.SetActive(false);
            emp = 1;
        }
    }
    public void next()
    {
        if (begun == true)
        {
            cont += 1;
            set.text = "Nombrar: " + (max -cont);
            if (cont == max)
            {
                victoria();
            }
        }
    }
    public void victoria()
    {

        if (turnoEmp.turno == 1 && max == cj1)
        {

            if (turnoEmp.choosen == "Blue Square 1")
            {
                turnoEmp.bb1 = true;
                turnoEmp.br1 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 2")
            {
                turnoEmp.bb2 = true;
                turnoEmp.br2 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 3")
            {
                turnoEmp.bb3 = true;
                turnoEmp.br3 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 4")
            {
                turnoEmp.bb4 = true;
                turnoEmp.br4 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 5")
            {
                turnoEmp.bb5 = true;
                turnoEmp.br5 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 6")
            {
                turnoEmp.bb6 = true;
                turnoEmp.br6 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 7")
            {
                turnoEmp.bb7 = true;
                turnoEmp.br7 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 8")
            {
                turnoEmp.bb8 = true;
                turnoEmp.br8 = false;
            }
            else if (turnoEmp.choosen == "Blue Square 9")
            {
                turnoEmp.bb9 = true;
                turnoEmp.br9 = false;
            }
            turnoEmp.gano = true;
            turnoEmp.puntos2 -= 1;
            turnoEmp.puntos1 += 1;
            turnoEmp.turno = 2;
        }
        else if (turnoEmp.turno == 2 && max == cj2)
        {

            if (turnoEmp.choosen == "Red Square 1")
            {
                turnoEmp.br1 = true;
                turnoEmp.bb1 = false;
            }
            else if (turnoEmp.choosen == "Red Square 2")
            {
                turnoEmp.br2 = true;
                turnoEmp.bb2 = false;
            }
            else if (turnoEmp.choosen == "Red Square 3")
            {
                turnoEmp.br3 = true;
                turnoEmp.bb3 = false;
            }
            else if (turnoEmp.choosen == "Red Square 4")
            {
                turnoEmp.br4 = true;
                turnoEmp.bb4 = false;
            }
            else if (turnoEmp.choosen == "Red Square 5")
            {
                turnoEmp.br5 = true;
                turnoEmp.bb5 = false;
            }
            else if (turnoEmp.choosen == "Red Square 6")
            {
                turnoEmp.br6 = true;
                turnoEmp.bb6 = false;
            }
            else if (turnoEmp.choosen == "Red Square 7")
            {
                turnoEmp.br7 = true;
                turnoEmp.bb7 = false;
            }
            else if (turnoEmp.choosen == "Red Square 8")
            {
                turnoEmp.br8 = true;
                turnoEmp.bb8 = false;
            }
            else if (turnoEmp.choosen == "Red Square 9")
            {
                turnoEmp.br9 = true;
                turnoEmp.bb9 = false;
            }
            turnoEmp.gano = true;
            turnoEmp.puntos1 -= 1;
            turnoEmp.puntos2 += 1;
            turnoEmp.turno = 1;
        }
        else if (turnoEmp.turno == 1 && max == cj2)
        {

            turnoEmp.gano = false;
            turnoEmp.turno = 2;
        }
        else if (turnoEmp.turno == 2 && max == cj1)
        {

            turnoEmp.gano = false;
            turnoEmp.turno = 1;
        }

        SceneManager.LoadScene("Board");
    }
    public void defeat() {
        if (turnoEmp.turno == 1 && max == cj2)
        {
            max = cj1;
            victoria();
        }
        else if (turnoEmp.turno == 2 && max == cj1)
        {

            max = cj2;
            victoria();
        }
        else if (turnoEmp.turno == 1 && max == cj1)
        {

            turnoEmp.gano = false;
            turnoEmp.turno = 2;
        }
        else if (turnoEmp.turno == 2 && max == cj2)
        {

            turnoEmp.gano = false;
            turnoEmp.turno = 1;
        }
        SceneManager.LoadScene("Board");
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMana : MonoBehaviour
{
   
    int turno = 0; // 0 --> JUGADOR
                   // 1 --> IA

    // DATOS DE LA PARTIDA
    int ronda = 1;
    int victoriasJugador = 0;
    int empates = 0;
    int victoriasIA = 0;

    // DATOS DE LA RONDA
    int tiradaJugador;
    int tiradaIA;

    GameObject botones;
    GameObject volver;
    public TextMeshProUGUI texto;

    bool seguir = false;


    // Start is called before the first frame update
    void Start()
    {

        botones = GameObject.Find("Botones");
        volver = GameObject.Find("Volver");

        volver.SetActive(false);

        StartCoroutine("Bienvenida");

    }

    // Update is called once per frame
    void Update()
    {

        if (seguir == true)
        {
            if (turno == 0) // TIRADA JUGADOR
            {
                turno++;
            }
            else // TIRADA IA
            {
                TiradaIA();

                //  CALCULAR QUIEN HA GANADO
               
            }

        }


        if(victoriasJugador == 3 || victoriasIA == 3)
        {

            if (victoriasJugador > victoriasIA)
            {
                texto.text =
         "Ganas la Partida:\nJugador = " + victoriasJugador + "\nIA = " + victoriasIA + "\nEmpates = " + empates;

            }
            else
            {
                texto.text =
         "Pierdes la Partida:\nJugador = " + victoriasJugador + "\nIA = " + victoriasIA + "\nEmpates = " + empates;
            }

            seguir = false;
            volver.SetActive(true);
            Time.timeScale = 0;

        }

    }

    // TIRADA JUGADOR:
    // 0 -- piedra
    // 1 -- papel
    // 2 -- tijera
    public void TiradaJugador(int tirada)
    {
        tiradaJugador = tirada;
        turno = 1;
        seguir = true;

    }

    public void TiradaIA()
    {
        tiradaIA = Random.Range(0, 3);

        CalculoGanador();
    }

    void CalculoGanador()
    {

        if (tiradaJugador == tiradaIA)
        {
            empates++;
            texto.text = "Empate:\nJugador = " + victoriasJugador + "\nIA = " + victoriasIA;
        }

        if (victoriasJugador < 3 || victoriasIA < 3)
        {
            ronda++;

            if (tiradaJugador == 0 && tiradaIA == 2 || tiradaJugador == 1 && tiradaIA == 0 || tiradaJugador == 2 && tiradaIA == 1)
            {
                victoriasJugador++;
              
                texto.text = "Ganas la Ronda:\nJugador = " + victoriasJugador + "\nIA = " + victoriasIA;
            }
            else if(tiradaJugador == 2 && tiradaIA == 0 || tiradaJugador == 0 && tiradaIA == 1 || tiradaJugador == 1 && tiradaIA == 2)
            {
                victoriasIA++;
                texto.text = "Pierdes la Ronda:\nJugador = " + victoriasJugador + "\nIA = " + victoriasIA;
            }
            seguir = false;

            StartCoroutine("Bienvenida");
        }
    }

    public void Volver()
    {
        ronda = 1;
        victoriasJugador = 0;
        empates = 0;
        victoriasIA = 0;
        seguir = false;
        Time.timeScale = 1;
        volver.SetActive(false);
    }

    IEnumerator Bienvenida()
    {
        // 1 -- BIENVENIDA AL JUEGO

        botones.SetActive(false);

        // VAMOS A PARAR DE EJECUTAR LA FUNCI?N
        // DURANTE 2.5 SEGUNDOS
        // UNA VEZ PASADOS, LA FUNCI?N CONTINUAR? EJECUTANDOSE
        yield return new WaitForSeconds(2.5f);



        // 2 -- ANUNCIAR LA RONDA
        texto.text =
            "RONDA " + ronda;
        yield return new WaitForSeconds(2.5f);


        // 3 -- MOSTRAMOS LOS BOTONES
        texto.text = "ELIGE:";
        botones.SetActive(true);
    }

}


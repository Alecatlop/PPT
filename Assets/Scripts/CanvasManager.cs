using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    GameMana gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameMana>();
    }


    public void BotonPiedra()
    {
        gameManagerScript.TiradaJugador(0);
        
    }

    public void BotonPapel()
    {
        gameManagerScript.TiradaJugador(1);
    }

    public void BotonTijera()
    {
        gameManagerScript.TiradaJugador(2);
    }
}

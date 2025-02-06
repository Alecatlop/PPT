using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    string[] arrayboton;
    int contadorboton;
    GameObject rojoia;
    GameObject azulia;
    GameObject verdeia;
    GameObject amarilloia;
    GameObject coloria;

    // Start is called before the first frame update
    void Start()
    {
        arrayboton = new string[20];
        rojoia = GameObject.Find("rojoia");
        azulia = GameObject.Find("azulia");
        verdeia = GameObject.Find("verdeia");
        amarilloia = GameObject.Find("amarilloia");
        coloria = GameObject.Find("Textocolor");

        rojoia.SetActive(false);
        azulia.SetActive(false);
        verdeia.SetActive(false);
        amarilloia.SetActive(false);
        coloria.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (contadorboton == 20)
        {
            print("Límite alcanzado");
            contadorboton = 0;
        }
    }

    public void Rojo()
    {
        arrayboton[contadorboton] = "rojo";
        contadorboton++;
    }

    public void Azul()
    {
        arrayboton[contadorboton] = "azul";
        contadorboton++;
    }

    public void Verde()
    {
        arrayboton[contadorboton] = "verde";
        contadorboton++;
    }

    public void Amarillo()
    {
        arrayboton[contadorboton] = "amarillo";
        contadorboton++;
    }

    public void Terminar()
    {
        StartCoroutine(Coloria());
    }

    IEnumerator Coloria()
    {

        for (int a = 0; a < contadorboton; a++)
        {
            if (arrayboton[a] == "rojo")
            {
                rojoia.SetActive(true);
                coloria.GetComponentInChildren<TextMeshProUGUI>().text = arrayboton[a];
            }
            else if (arrayboton[a] == "azul")
            {
                azulia.SetActive(true);
                coloria.GetComponentInChildren<TextMeshProUGUI>().text = arrayboton[a];
            }
            else if (arrayboton[a] == "verde")
            {
                verdeia.SetActive(true);
                coloria.GetComponentInChildren<TextMeshProUGUI>().text = arrayboton[a];
            }
            else if (arrayboton[a] == "amarillo")
            {
                amarilloia.SetActive(true);
                coloria.GetComponentInChildren<TextMeshProUGUI>().text = arrayboton[a];

            }

            coloria.SetActive(true);
            yield return new WaitForSeconds(0.5f);

            rojoia.SetActive(false);
            azulia.SetActive(false);
            verdeia.SetActive(false);
            amarilloia.SetActive(false);
            coloria.SetActive(false);
        }

        contadorboton = 0;
    }
}

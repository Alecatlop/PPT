using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    string[] arrayboton;
    int contadorboton;
    int contadorcolor;
    GameObject rojoia;
    GameObject azulia;
    GameObject verdeia;
    GameObject amarilloia;
    bool seguir = true;

    // Start is called before the first frame update
    void Start()
    {
        arrayboton = new string[20];
        rojoia = GameObject.Find("rojoia");
        azulia = GameObject.Find("azulia");
        verdeia = GameObject.Find("verdeia");
        amarilloia = GameObject.Find("amarilloia");

        rojoia.SetActive(false);
        azulia.SetActive(false);
        verdeia.SetActive(false);
        amarilloia.SetActive(false);
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
        for (int a = 0; a < contadorboton; a++)
        {
            if (arrayboton[a] == "rojo" && seguir == true)
            {
                contadorcolor = 1;
                seguir = false;
            }
            else if (arrayboton[a] == "azul" && seguir == true)
            {
                contadorcolor = 2;
                seguir = false;
            }
            else if (arrayboton[a] == "verde" && seguir == true)
            {
                contadorcolor = 3;
                seguir = false;
            }
            else if (arrayboton[a] == "amarillo" && seguir == true)
            {
                contadorcolor = 4;
                seguir = false;
            }

            StartCoroutine(Coloria());

        }

        contadorboton = 0;
        
    }

    IEnumerator Coloria()
    {

        if (contadorcolor == 1)
        {
            rojoia.SetActive(true);
            print("Color: rojo");
        }
        else if (contadorcolor == 2)
        {
            azulia.SetActive(true);
            print("Color: azul");
        }
        else if (contadorcolor == 3)
        {
            verdeia.SetActive(true);
            print("Color: verde");
        }
        else if (contadorcolor == 4)
        {
            amarilloia.SetActive(true);
            print("Color: amarillo");
        }

        yield return new WaitForSeconds(0.5f);

        seguir = true;

        rojoia.SetActive(false);
        azulia.SetActive(false);
        verdeia.SetActive(false);
        amarilloia.SetActive(false);

        
    }
}

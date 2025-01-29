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
            if (arrayboton[a] == "rojo")
            {
                contadorcolor = 1;
                
            }
            else if (arrayboton[a] == "azul")
            {
                contadorcolor = 2;
               
            }
            else if (arrayboton[a] == "verde")
            {
                contadorcolor = 3;
               
            }
            else if (arrayboton[a] == "amarillo")
            {
                contadorcolor = 4;
                
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
            yield return new WaitForSeconds(0.5f);
            rojoia.SetActive(false);
        }
        else if (contadorcolor == 2)
        {
            azulia.SetActive(true);
            print("Color: azul");
            yield return new WaitForSeconds(0.5f);
            azulia.SetActive(false);
        }
        else if (contadorcolor == 3)
        {
            verdeia.SetActive(true);
            print("Color: verde");
            yield return new WaitForSeconds(0.5f);
            verdeia.SetActive(false);
        }
        else if (contadorcolor == 4)
        {
            amarilloia.SetActive(true);
            print("Color: amarillo");
            yield return new WaitForSeconds(0.5f);
            amarilloia.SetActive(false);
        }
            

        

        //rojoia.SetActive(false);
        //azulia.SetActive(false);
        //verdeia.SetActive(false);
        //amarilloia.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PPT : MonoBehaviour
{
    public TextMeshProUGUI texto;
    int ronda = 1;
    GameObject botones;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ContadorRonda");
        botones = GameObject.Find("Botones");
        botones.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ContadorRonda()
    {

        yield return new WaitForSeconds(2f);

        texto.text = ("Ronda " + ronda);

        yield return new WaitForSeconds(2f);

        botones.SetActive(true);

    }
}

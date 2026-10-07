using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class script_placar : MonoBehaviour
{
    private static int placar;
    private static GameObject texto;

    // Start is called before the first frame update
    void Start()
    {
        placar = 0;
        texto = GameObject.Find("placar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void pontuar(int a)
    {
        placar += a;
        texto.GetComponent<TMP_Text>().text = "" + placar;
    }
}

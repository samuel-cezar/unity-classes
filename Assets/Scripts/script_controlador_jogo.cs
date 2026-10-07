using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_controlador_jogo : MonoBehaviour
{
    private bool pausado;
    void Start()
    {
        pausado = false;
        SceneManager.UnloadSceneAsync(3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(2);
            } else
            {
                Time.timeScale = 0;
                SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
            }
            pausado = !pausado;
        }
    }
}

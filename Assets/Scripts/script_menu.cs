using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_menu : MonoBehaviour
{
    // Start is called before the first frame update

    public void iniciar()
    {
        SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1;
    }

    public void sair()
    {
        Application.Quit();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_pc : MonoBehaviour
{
    private float altura;
    private float largura;
    private float alturaNave;

    private Rigidbody2D rbd;
    public float vel;
    public GameObject tiro;

    private AudioSource som_tiro;

    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        vel = 10;
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
        som_tiro = this.GetComponent<AudioSource>();
        alturaNave = (GetComponent<SpriteRenderer>().bounds.size.y)/2;

    }

    // Update is called once per frame
    void Update()
    {
        float x_axis = Input.GetAxisRaw("Horizontal");
        float y_axis = Input.GetAxisRaw("Vertical");
        rbd.velocity = new Vector2(x_axis, y_axis) * vel;

        if (this.transform.position.x > largura) 
        {
            this.transform.position = new Vector2(-largura, this.transform.position.y);
        } else if(this.transform.position.x < -largura)
        {
            this.transform.position = new Vector2(largura, this.transform.position.y);
        }

        if(this.transform.position.y > 0)
        {
            this.transform.position = new Vector2(this.transform.position.x, 0);
        } else if (this.transform.position.y < -5 + alturaNave) 
        {
            this.transform.position = new Vector2(this.transform.position.x, -5 + alturaNave);
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Vector2 pos = new Vector2(transform.position.x, transform.position.y + alturaNave);
            som_tiro.Play();
            Instantiate(tiro, pos, Quaternion.identity);
        }
    }
}

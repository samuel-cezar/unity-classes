using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class script_enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rbd;
    public float vel = 5;
    public int ponto_base = 1;

    private void OnTriggerEnter2D(Collider2D col)
    {
        script_placar.pontuar(ponto_base);
        Destroy(col.gameObject);
        Destroy(gameObject);
    }

    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -vel);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}

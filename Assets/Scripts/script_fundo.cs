using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_fundo : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel;
    public int bg_size;

    // Start is called before the first frame update
    void Start()
    {
        bg_size = 6;
        vel = 2;
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -vel);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -bg_size)
        {
            transform.position = new Vector2(0, bg_size);
        }
    }
}

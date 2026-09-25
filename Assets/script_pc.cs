using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_pc : MonoBehaviour
{
    private float height;
    private float width;

    private Rigidbody2D rbd;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        speed = 10;
        height = Camera.main.orthographicSize;
        width = height * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        float x_axis = Input.GetAxisRaw("Horizontal");
        float y_axis = Input.GetAxisRaw("Vertical");
        rbd.velocity = new Vector2(x_axis, y_axis) * speed;

        if (this.transform.position.x > width) 
        {
            this.transform.position = new Vector2(-width, this.transform.position.y);
        } else if(this.transform.position.x < -width)
        {
            this.transform.position = new Vector2(width, this.transform.position.y);
        }

        if(this.transform.position.y > 0)
        {
            this.transform.position = new Vector2(this.transform.position.x, 0);
        } else if (this.transform.position.y < -5) 
        {
            this.transform.position = new Vector2(this.transform.position.x, -5);
        }
    }
}

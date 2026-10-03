using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_tiro : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rbd;
    public float vel = 11;
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, vel);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}

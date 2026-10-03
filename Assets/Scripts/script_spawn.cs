using UnityEngine;

public class spawn_script : MonoBehaviour
{
    public GameObject enemy;
    private float width;

    void Start()
    {
        width = Camera.main.orthographicSize * Camera.main.aspect;
        InvokeRepeating("respawn", 0, 1);
    }

    private void respawn()
    {
        float posX;
        posX = Random.Range(-width, width);
        Instantiate(enemy, new Vector2(posX, 5), Quaternion.identity);
    }
}
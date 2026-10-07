using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_bg_animado : MonoBehaviour
{
    [SerializeField] private float amplitude = 100f;
    [SerializeField] private float speed = 20f;

    private RectTransform rect;
    private Vector2 startPos;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        startPos = rect.anchoredPosition;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * amplitude;
        rect.anchoredPosition = startPos + new Vector2(0f, offset);
    }
}

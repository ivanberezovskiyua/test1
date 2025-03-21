using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColor : MonoBehaviour
{
    public Text textComponent; 
    public float colorChangeSpeed = 1.0f; 

    private Color[] colors = { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan }; // Массив цветов
    private int currentColorIndex = 0;
    private float timeSinceLastChange = 0f;

    void Start()
    {
        if (textComponent == null)
        {
            textComponent = GetComponent<Text>();
        }

        if (textComponent == null)
        {
            Debug.LogError("Text component not found!");
            enabled = false;
        }
    }

    void Update()
    {
        timeSinceLastChange += Time.deltaTime;

        if (timeSinceLastChange >= colorChangeSpeed)
        {
            timeSinceLastChange = 0f;
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            textComponent.color = colors[currentColorIndex];
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float amplitude = 0.5f;  // How high it moves
    public float frequency = 1f;    // How fast it moves

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // Save starting position
    }

    void Update()
    {
        // Sine wave for smooth up and down movement
        float newY = startPos.y + Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_02 : MonoBehaviour
{
    [SerializeField] private string name;
    [SerializeField] private string city;

    private void Start()
    {
        Debug.Log($"Hello, {name}! Welcome to {city}.");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_03 : MonoBehaviour
{
    [SerializeField] private int age;
    [SerializeField] private string name;

    private void Start()
    {
        Debug.Log($"Hello {name}, you are {age} years old.");
    }
}

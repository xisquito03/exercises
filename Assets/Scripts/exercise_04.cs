using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_04 : MonoBehaviour
{
    [SerializeField] private int birthyear;
    [SerializeField] private int currentyear;
    private float age;

    private void Start()
    {
        age = currentyear - birthyear;
        Debug.Log($"If we are in {currentyear}, and you were born in {birthyear}, you are {age} years old");
    }

}

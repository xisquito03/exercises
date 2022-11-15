using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_05 : MonoBehaviour
{
    [SerializeField] public int x=5;
    [SerializeField] public int y=6;
    private bool isGreater;

    private void Start()
    {
        isGreater = x > y;
        Debug.Log(isGreater);
    }


}

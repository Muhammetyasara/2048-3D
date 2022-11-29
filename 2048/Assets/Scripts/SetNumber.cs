using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNumber : MonoBehaviour
{
    public static SetNumber Instance;

    public int[] cubeNumber;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}

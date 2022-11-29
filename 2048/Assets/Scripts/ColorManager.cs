using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager Instance;

    public Color[] colors;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public Color GetColor(int value)
    {
        if (value == 2)
        {
            return colors[0];
        }
        else if (value == 4)
        {
            return colors[1];
        }
        else if (value == 8)
        {
            return colors[2];
        }
        else if (value == 16)
        {
            return colors[3];
        }
        else if (value == 32)
        {
            return colors[4];
        }
        else if (value == 64)
        {
            return colors[5];
        }
        else if (value == 128)
        {
            return colors[6];
        }
        else if (value == 256)
        {
            return colors[7];
        }
        else if (value == 512)
        {
            return colors[8];
        }
        else if (value == 1024)
        {
            return colors[9];
        }
        else
        {
            return colors[10];
        }
    }
}

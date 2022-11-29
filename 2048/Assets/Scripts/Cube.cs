using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{
    public TextMeshPro[] cubeTMPro;

    public Color color;

    public int value;
    private void Start()
    {
        TMProStarter();
    }
    private void Update()
    {
        TMProChanger();
    }
    public void TMProChanger()
    {
        foreach (TextMeshPro item in cubeTMPro)
        {
            if (value == 2)
            {
                item.text = SetNumber.Instance.cubeNumber[0].ToString();
            }
            else if (value == 4)
            {
                item.text = SetNumber.Instance.cubeNumber[1].ToString();
            }
            else if (value == 8)
            {
                item.text = SetNumber.Instance.cubeNumber[2].ToString();
            }
            else if (value == 16)
            {
                item.text = SetNumber.Instance.cubeNumber[3].ToString();
            }
            else if (value == 32)
            {
                item.text = SetNumber.Instance.cubeNumber[4].ToString();
            }
            else if (value == 64)
            {
                item.text = SetNumber.Instance.cubeNumber[5].ToString();
            }
            else if (value == 128)
            {
                item.text = SetNumber.Instance.cubeNumber[6].ToString();
            }
            else if (value == 256)
            {
                item.text = SetNumber.Instance.cubeNumber[7].ToString();
            }
            else if (value == 512)
            {
                item.text = SetNumber.Instance.cubeNumber[8].ToString();
            }
            else if (value == 1024)
            {
                item.text = SetNumber.Instance.cubeNumber[9].ToString();
            }
            else if (value == 2048)
            {
                item.text = SetNumber.Instance.cubeNumber[10].ToString();
            }
        }
    }
    public void TMProStarter()
    {
        foreach (TextMeshPro item in cubeTMPro)
        {
            item.text = SetNumber.Instance.cubeNumber[0].ToString();
        }
    }

}

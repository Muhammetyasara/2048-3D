using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Slider slider;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            slider.GetComponent<Slider>().value = 0;
        }
    }
}

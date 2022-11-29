using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CubeSpawner : MonoBehaviour
{
    public static CubeSpawner Instance;

    public GameObject cube;
    public GameObject cubeSpawner;

    public bool isCubeCreated;

    int randomNumber;

    public Transform cubeSpawnerTransform;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        CubeController.Instance.target = Instantiate(cube, cubeSpawnerTransform).transform;
        CubeController.Instance.target.GetComponent<Renderer>().material.color = ColorManager.Instance.GetColor(SetNumber.Instance.cubeNumber[randomNumber]);
    }
    private void Update()
    {
        OnClick();
    }
    public void OnClick()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (isCubeCreated == false)
            {
                StartCoroutine(CubeSpawnerDelay());
            }
            if (isCubeCreated == true)
            {
                StartCoroutine(WaitForArrive());
                Debug.Log("asd");
            }
        }
        IEnumerator CubeSpawnerDelay()
        {
            randomNumber = Random.Range(0, 6);
            isCubeCreated = true;
            yield return new WaitForSeconds(1f);
            CubeController.Instance.target = Instantiate(cube, cubeSpawnerTransform).transform;
            int randomValue = SetNumber.Instance.cubeNumber[randomNumber];
            CubeController.Instance.target.GetComponent<Cube>().value = randomValue;
            Color randomColor = ColorManager.Instance.GetColor(randomValue);
            CubeController.Instance.target.GetComponent<Renderer>().material.color = randomColor;
        }
        IEnumerator WaitForArrive()
        {
            yield return new WaitForSeconds(1.2f);
            isCubeCreated = false;
        }
    }
}

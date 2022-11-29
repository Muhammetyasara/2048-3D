using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{
    public static CubeController Instance;

    public Vector3 firstPos;
    public Vector3 lastPos;

    public float moveSpeed;
    public float forceSpeed;

    public Transform target;
    public Transform vectorRight;
    public Transform vectorLeft;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Update()
    {
        BoundsControl();

        if (Input.GetMouseButtonDown(0) && CubeSpawner.Instance.isCubeCreated == false)
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            firstPos = Camera.main.ScreenToWorldPoint(pos);
        }
        if (Input.GetMouseButton(0) && CubeSpawner.Instance.isCubeCreated == false)
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            lastPos = Camera.main.ScreenToWorldPoint(pos);
            Vector3 dif = lastPos - firstPos;
            target.transform.position += new Vector3(0, 0, dif.z) * Time.deltaTime * moveSpeed;
            firstPos = lastPos;
        }
        if (Input.GetMouseButtonUp(0) && CubeSpawner.Instance.isCubeCreated == false)
        {
            target.GetComponent<Rigidbody>().AddForce(transform.right * forceSpeed, ForceMode.Impulse);
        }
    }

    void BoundsControl()
    {
        Vector3 bounds = target.transform.position;
        bounds.z = Mathf.Clamp(bounds.z, vectorRight.transform.position.z, vectorLeft.transform.position.z);
        target.transform.position = bounds;
    }
}
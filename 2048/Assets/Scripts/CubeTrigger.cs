using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeTrigger : MonoBehaviour
{
    Transform collisionPosition;

    public GameObject createdCube;

    int collisionValue;

    public float upForceSpeed;
    public float backForceSpeed;

    private void OnCollisionEnter(Collision collision)
    {
        if (GetInstanceID() < collision.gameObject.GetInstanceID())
        {
            if (gameObject.GetComponent<Cube>().value == collision.gameObject.GetComponent<Cube>().value)
            {
                collisionValue = gameObject.GetComponent<Cube>().value;
                collisionPosition = gameObject.transform;
                // StartCoroutine(InstantiateDelay());
                Transform target2 = Instantiate(createdCube, (gameObject.transform.position + collision.gameObject.transform.position) / 2, Quaternion.identity).transform;
                target2.GetComponent<BoxCollider>().enabled = true;
                target2.GetComponent<Cube>().value = collisionValue * 2;
                target2.GetComponent<Renderer>().material.color = ColorManager.Instance.GetColor(collisionValue * 2);
                Destroy(gameObject);
                Destroy(collision.gameObject);
                target2.GetComponent<Rigidbody>().AddForce(transform.up * upForceSpeed, ForceMode.Impulse);
                target2.GetComponent<Rigidbody>().AddForce(transform.right * -1 * backForceSpeed, ForceMode.Impulse);
                gameObject.GetComponent<BoxCollider>().enabled = false;
                collision.gameObject.GetComponent<BoxCollider>().enabled = false;
                Debug.Log("value");
            }
        }
    }
    /*IEnumerator InstantiateDelay()
    {
        yield return new WaitForSeconds(0.2f);
        
        Debug.Log("Coroutine");
        yield return new WaitForSeconds(1f);
    }*/
}
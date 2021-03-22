using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rondkijker : MonoBehaviour
{
    float X;
    float Y;
    public float MouseSens;
    Ray ray;
    RaycastHit objectHit;
    public float rayLength = 10;
    public int objectToFindIndex;
    public List<GameObject> objectsToFind = new List<GameObject>();
    [Header ("Display")]
    public GameObject display;
    public List<Texture> objectToFindMaterial = new List<Texture>();



    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Y = 90;
        display.GetComponent<Renderer>().material = objectToFindMaterial[1];
    }

    void Update()
    {
        muisKijk();
        clickObjects();
    }

    void muisKijk()
    {
        X += MouseSens * Input.GetAxis("Mouse X") * Time.deltaTime;
        Y -= MouseSens * Input.GetAxis("Mouse Y") * Time.deltaTime;

        Y = Mathf.Clamp(Y, -60f, 90f);

        transform.eulerAngles = new Vector3(Y, X, 0);
    }

    void clickObjects()
    {
        if (Input.GetMouseButtonUp(0))
        {
            rayCast();
        }
        Debug.DrawRay(transform.position, transform.forward * rayLength, Color.green);
    }
    void rayCast()
    {
        if (Physics.Raycast(transform.position, transform.forward, out objectHit, rayLength))
        {
            if (objectHit.collider.gameObject == objectsToFind[objectToFindIndex])
            {
                objectToFindIndex++;
            }
        }
    }
}
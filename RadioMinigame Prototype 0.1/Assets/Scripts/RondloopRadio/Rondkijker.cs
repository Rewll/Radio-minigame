using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rondkijker : MonoBehaviour
{
    float X;
    float Y;
    public float MouseSens;
    Ray ray;
    RaycastHit objectHit;

    public AudioSource soundSource;
    public AudioClip good;
    public AudioClip bad;

    public float rayLength = 10;
    public int objectToFindIndex;
    public List<GameObject> objectsToFind = new List<GameObject>();

    public GameObject display;
    public GameObject winScreen;
    public GameObject helpscreen;

    public GameObject rodeLamp;
    public GameObject groeneLamp;
    [Space]
    public Material Neutraal;
    public Material roodLicht;
    public Material groenLicht;

    void Start()
    {
        Time.timeScale = 0;
        X = 90;
        display.GetComponent<Renderer>().material = objectsToFind[objectToFindIndex].GetComponent<Renderer>().material;
    }

    void Update()
    {
        muisKijk();
        if (objectToFindIndex != objectsToFind.Count)
        {
            clickObjects();
        }
        else 
        {
            win();
        }
    }

    void rodeKnipper()
    {
        StartCoroutine(knipperDePipper(rodeLamp, Neutraal, roodLicht, bad));
    }
    void groeneKnipper()
    {
        StartCoroutine(knipperDePipper(groeneLamp, Neutraal, groenLicht, good));
    }

    IEnumerator knipperDePipper(GameObject lampje, Material normaal, Material licht, AudioClip sound)
    {
        soundSource.PlayOneShot(sound);
        var renderer = lampje.GetComponent<Renderer>();
        renderer.material = licht;
        yield return new WaitForSeconds(.3f);
        renderer.material = normaal;
    }
 
    void muisKijk()
    {
        X += MouseSens * Input.GetAxis("Mouse X") * Time.deltaTime;
        Y -= MouseSens * Input.GetAxis("Mouse Y") * Time.deltaTime;

        Y = Mathf.Clamp(Y, -90f, 90f);

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
                groeneKnipper();
                objectToFindIndex++;
                display.GetComponent<Renderer>().material = objectsToFind[objectToFindIndex].GetComponent<Renderer>().material;
            }
            else
            {
                rodeKnipper();
            }
        }
    }

    void win()
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        winScreen.SetActive(true);
    }

    public void terug()
    {
        SceneManager.LoadScene(0);
    }

    public void start()
    {
        helpscreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }
}
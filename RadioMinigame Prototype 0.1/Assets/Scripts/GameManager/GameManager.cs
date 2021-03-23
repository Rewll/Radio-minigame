using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingleTon<GameManager>
{
    public List<string> knopVolgorde = new List<string>();
    public int index;
    public int knopScore;
    public GameObject radioDraaier;

    public bool roodEmission;
    public bool geelEmission;
    public bool bruinEmission;
    public bool oranjeEmission;

    [Header("Audio")]
    public AudioSource bronVanGeluid;
    public AudioClip click;
    public AudioClip wrong;


    Ray ray;
    RaycastHit clickHit;
    float rayLength = 100f;

    private void Awake()
    {
        Instance = this;
        radioDraaier.SetActive(false);
    }

    private void Update()
    {
        clickObjects();
        if (knopScore >= 4)
        {
            Debug.Log("yoooooooooooooooooooooo");
            StartCoroutine(reset(.5f));
            radioDraaier.SetActive(true);

        }
    }

    void checkVolgorde(string knop, int indexP)
    {
        if (knop == knopVolgorde[indexP])
        {
            bronVanGeluid.PlayOneShot(click);
            index++;
            knopScore += 1;
        }
        else
        {
            bronVanGeluid.PlayOneShot(wrong);
            StartCoroutine(reset(.5f));
            StartCoroutine(blink());
            Debug.Log("FOUT");
        }
    }

    IEnumerator reset(float delay)
    {
        yield return new WaitForSeconds(delay);
        knopScore = 0;
        index = 0;
        roodEmission = false;
        geelEmission = false;
        bruinEmission = false;
        oranjeEmission = false;
        yield return new WaitForSeconds(delay);
    }

    IEnumerator blink()
    {
        roodEmission = false;
        geelEmission = false;
        bruinEmission = false;
        oranjeEmission = false;
        yield return new WaitForSeconds(.2f);
        roodEmission = true;
        geelEmission = true;
        bruinEmission = true;
        oranjeEmission = true;
        yield return new WaitForSeconds(.2f);
        roodEmission = false;
        geelEmission = false;
        bruinEmission = false;
        oranjeEmission = false;
        yield return new WaitForSeconds(.2f);
        roodEmission = true;
        geelEmission = true;
        bruinEmission = true;
        oranjeEmission = true;
        yield return new WaitForSeconds(.2f);
        roodEmission = false;
        geelEmission = false;
        bruinEmission = false;
        oranjeEmission = false;
    }

    void clickObjects()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonUp(0))
        {
            rayCast();
        }
        Debug.DrawRay(ray.origin, ray.direction, Color.green);
    }
    void rayCast()
    {
        if (Physics.Raycast(ray, out clickHit, rayLength))
        {
            IclickAble click = clickHit.collider.transform.GetComponent<IclickAble>();
            if (click != null)
            {
                click.click();
                checkVolgorde(click.knopKleur, index);
            }
        }
    }
}
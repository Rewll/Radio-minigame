using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingleTon<GameManager>
{
    [Header("UI")]
    public GameObject selectionScreen;
    public selection GameSelection;

    [Header("Knoppen")]
    public List<GameObject> knoppen = new List<GameObject>();

    [Header("Linker knoppen")]
    public bool knopL1 = false;
    public bool knopL1Emission = false;
    public bool knopL2 = false;
    public bool knopL2Emission = false;
    public bool knopL3 = false;
    public bool knopL3Emission = false;
    public bool knopL4 = false;
    public bool knopL4Emission = false;

    [Header("Rechter knoppen")]
    public bool knopR1 = false;
    public bool knopR1Emission = false;
    public bool knopR2 = false;
    public bool knopR2Emission = false;
    public bool knopR3 = false;
    public bool knopR3Emission = false;
    public bool knopR4 = false;
    public bool knopR4Emission = false;

    public enum selection
    {
        selectionScreen,
        Game1,
        Game2,
        Game3,
        Game4
    }

    private void Start()
    {
        StartCoroutine(lichtjesBoel());
    }

    private void Awake()
    {
        Instance = this;
        
        selectionScreen.SetActive(false);
    }


    IEnumerator lichtjesBoel()
    {
        knopR1Emission = true;
        yield return new WaitUntil(() => knopR1);
        knopR1Emission = false;

        knopR2Emission = true;
        yield return new WaitUntil(() => knopR2);
        knopR2Emission = false;

        knopR3Emission = true;
        yield return new WaitUntil(() => knopR3);
        knopR3Emission = false;

        knopR4Emission = true;
        yield return new WaitUntil(() => knopR4);
        knopR4Emission = false;

        knopL1Emission = true;
        yield return new WaitUntil(() => knopL1);
        knopL1Emission = false;

        knopL2Emission = true;
        yield return new WaitUntil(() => knopL2);
        knopL2Emission = false;

        knopL3Emission = true;
        yield return new WaitUntil(() => knopL3);
        knopL3Emission = false;

        knopL4Emission = true;
        yield return new WaitUntil(() => knopL4);
        knopL4Emission = false;
    }
}
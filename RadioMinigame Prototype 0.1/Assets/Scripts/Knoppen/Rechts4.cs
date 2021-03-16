using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rechts4 : MonoBehaviour, IclickAble
{
    public Material knopR4Mat;
    public Material knopR4EmissionMat;
    public Renderer knopRenderer;

    public void click()
    {
        Debug.Log(gameObject + " has been pressed");
        GameManager.Instance.knopR4 = true;
    }

    private void Update()
    {
        checkEmission();
    }

    void checkEmission()
    {
        if (GameManager.Instance.knopR4Emission)
        {
            knopRenderer.material = knopR4EmissionMat;
        }
        else if (!GameManager.Instance.knopR4Emission)
        {
            knopRenderer.material = knopR4Mat;
        }
    }
}

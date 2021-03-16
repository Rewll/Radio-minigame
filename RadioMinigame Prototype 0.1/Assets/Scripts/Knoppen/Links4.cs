using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links4 : MonoBehaviour, IclickAble
{
    public Material knopL4Mat;
    public Material knopL4EmissionMat;
    public Renderer knopRenderer;

    public void click()
    {
        Debug.Log(gameObject + " has been pressed");
        GameManager.Instance.knopL4 = true;
    }

    private void Update()
    {
        checkEmission();
    }

    void checkEmission()
    {
        if (GameManager.Instance.knopL4Emission)
        {
            knopRenderer.material = knopL4EmissionMat;
        }
        else if (!GameManager.Instance.knopL4Emission)
        {
            knopRenderer.material = knopL4Mat;
        }
    }
}

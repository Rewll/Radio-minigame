using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oranje : MonoBehaviour, IclickAble
{
    public void click()
    {
        Debug.Log(gameObject + "is clicked");
    }
}
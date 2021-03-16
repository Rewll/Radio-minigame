using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rood : MonoBehaviour, IclickAble
{
    public void click()
    {
        Debug.Log(gameObject + "is clicked");
    }
}
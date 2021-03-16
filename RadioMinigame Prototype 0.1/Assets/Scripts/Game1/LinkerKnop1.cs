using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkerKnop1 : MonoBehaviour, IclickAble
{
    public void click()
    {
        Debug.Log(gameObject + " has been pressed");
    }
}

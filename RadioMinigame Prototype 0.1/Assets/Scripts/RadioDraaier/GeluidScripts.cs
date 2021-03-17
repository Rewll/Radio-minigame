using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeluidScripts : MonoBehaviour
{
    public GameObject DraaiKnop;
    public float RotationSpeed = 30;
    public AudioSource constantNoise;
    public AudioSource noiseLayer;
    public AudioSource noiseWorking;
    public int workingRotation;
    public float Yrotation;
    public float rotatieDelta;
    public float calculatedVolume;

    private void Start()
    {
        workingRotation = (int)Random.Range(10, 310);
        Debug.Log(67f / 10f);
        Debug.Log(67f * .1f);
    }

    void Update()
    {
        DraaiKnop.transform.Rotate(0, (Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), 0, Space.World);
        //noiseSound();
        noiseSound(); 
        if (calculatedVolume >= 1)
        {
            win();
        }
    }
    void win()
    {
        Debug.Log("Win");
    }


    void noiseSound()
    {
        Yrotation = DraaiKnop.transform.rotation.eulerAngles.y;
        rotatieDelta = workingRotation - Yrotation;
        calculatedVolume = Mathf.Abs(10 / rotatieDelta);
        constantNoise.volume = calculatedVolume;
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeluidScripts : MonoBehaviour
{
    public GameObject DraaiKnop;
    public GameObject KOMPLEET;
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
    }

    void Update()
    {
        DraaiKnop.transform.Rotate(0, (Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), 0, Space.World);
        noiseSound(); 
        if (calculatedVolume >= 1)
        {
            Time.timeScale = 0f;
            win();
        }
    }
    void win()
    {
        Debug.Log("Win");
        KOMPLEET.SetActive(true);
    }

    void noiseSound()
    {
        Yrotation = DraaiKnop.transform.rotation.eulerAngles.y;
        rotatieDelta = workingRotation - Yrotation;
        calculatedVolume = Mathf.Abs(10 / rotatieDelta);
        constantNoise.volume = calculatedVolume;
    }

    public void terug()
    {
        SceneManager.LoadScene("Login");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LoginGameManager : MonoBehaviour
{
    public TMPro.TMP_InputField codeLogin;
    public string Code;
    public string rondLoopCode;
    public string geluidsRadioCode;
    public AudioSource speaker;
    public AudioClip goodCode;
    public AudioClip badcode;
    int radioIndex = 1;
    int rondloopIndex = 2;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        Code = codeLogin.text;
    }

    IEnumerator loadScene(AudioClip sound, int index)
    {
        speaker.PlayOneShot(sound);
        yield return new WaitForSeconds(.7f);
        SceneManager.LoadScene(index);
    }

    public void checkCode()
    {
        if (Code == rondLoopCode)
        {
            StartCoroutine(loadScene(goodCode, rondloopIndex));
        }
        else if (Code == geluidsRadioCode)
        {
            StartCoroutine(loadScene(goodCode, radioIndex));
        }
        else
        {
            speaker.PlayOneShot(badcode);
        }
    }
}

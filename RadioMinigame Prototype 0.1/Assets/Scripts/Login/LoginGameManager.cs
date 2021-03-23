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
    public string temperatuurCode;
    public string whackAMoleCode;

    private void Start()
    {
        codeLogin = gameObject.GetComponent<TMPro.TMP_InputField>();
        codeLogin.characterValidation = TMPro.TMP_InputField.CharacterValidation.Integer;
        codeLogin.characterLimit = 4;
    }
    private void Update()
    {
        Code = codeLogin.text;
        if (Code == rondLoopCode)
        {
            SceneManager.LoadScene("RondloopRadio");
        }
        else if (Code == geluidsRadioCode)
        {
            SceneManager.LoadScene("Radio");
        }
        else if (Code == temperatuurCode)
        {
            SceneManager.LoadScene("TemperatuurRadio");
        }
        else if (Code == whackAMoleCode)
        {
            SceneManager.LoadScene("MollenRadio");
        }
    }
}

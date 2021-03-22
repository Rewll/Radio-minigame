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
    public string RightCode1;
    public string RightCode2;
    public string RightCode3;
    public string RightCode4;

    private void Start()
    {
        codeLogin = gameObject.GetComponent<TMPro.TMP_InputField>();
        codeLogin.characterValidation = TMPro.TMP_InputField.CharacterValidation.Integer;
        codeLogin.characterLimit = 4;
    }
    private void Update()
    {
        Code = codeLogin.text;
        if (Code == RightCode1)
        {
            SceneManager.LoadScene(1);
        }
        else if (Code == RightCode2)
        {
            SceneManager.LoadScene(2);
        }
        else if (Code == RightCode3)
        {
            SceneManager.LoadScene(3);
        }
        else if (Code == RightCode4)
        {
            SceneManager.LoadScene(4);
        }
    }
}

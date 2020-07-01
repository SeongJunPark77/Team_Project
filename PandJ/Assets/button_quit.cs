using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_quit : MonoBehaviour
{
    public void OnClick()
    {
        Application.Quit();
    }
}

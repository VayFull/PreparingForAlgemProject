using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public AudioSource Click;
    public void DocumentBtn()
    {
        Application.OpenURL("https://trello.com/b/Edn9l37I/%D0%BF%D1%80%D0%BE%D0%B5%D0%BA%D1%82%D0%BD%D0%B0%D1%8F-%D0%B4%D0%B5%D1%8F%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D1%8C");
    }

    public void ExitBtn()
    {
        Click.Play();
        Application.Quit();
    }

    public void StartGameBtn()
    {
        Click.Play();
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenu()
    {
        Click.Play();
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScene : MonoBehaviour
{

    public GameObject txt_how;
    public GameObject btn_howoff;
    public GameObject btn_howon;

    private void Start()
    {
        txt_how.SetActive(false);
        btn_howoff.SetActive(false);
    }
    public void Btn_Start()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Btn_Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void Btn_Howon()
    {
        txt_how.SetActive(true);
        btn_howoff.SetActive(true);
        btn_howon.SetActive(false);
    }

    public void Btn_Howoff()
    {
        txt_how.SetActive(false);
        btn_howoff.SetActive(false);
        btn_howon.SetActive(true);
    }
}

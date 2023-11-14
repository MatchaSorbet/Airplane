using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class optionUI : MonoBehaviour
{
    [SerializeField]  GameManager gamemanager;

    [SerializeField] private GameObject optmenu;
    [SerializeField] private GameObject opt;


    private void Start()
    {

        opt.SetActive(true);
        optmenu.SetActive(false);
    }


    public void Btn_option()
    {
        optmenu.SetActive(true);
        Time.timeScale = 0;
    }


    public void Btn_GoTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void Btn_ReStart()
    {
        StartCoroutine(gamemanager.Count(0));
    }
    public void Btn_GoGame()
    {
        optmenu.SetActive(false);
        Time.timeScale = 1;
    }

}

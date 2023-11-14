using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject success;
    public GameObject destroy;
    public GameObject message;
    public Text txt_message;

    GameObject airplaneAmount;

    void Start()
    {
        this.airplaneAmount = GameObject.Find("airplaneAmount");
        destroy.SetActive(false);
        success.SetActive(false);
        message.SetActive(false);
        this.airplaneAmount.GetComponent<Image>().fillAmount = 0f;
    }

    public void IncreaseAirPlane()
    {
        this.airplaneAmount.GetComponent<Image>().fillAmount += 0.2f;

        if (this.airplaneAmount.GetComponent<Image>().fillAmount == 1.0f)
        {
            destroy.SetActive(false);
            success.SetActive(true);

            //  3초 후에 리플레이 알림 
            StartCoroutine(Count(3));
            //  5초 후에 리플레이 (총 8초)
            //Invoke("RePlay", 8f);
        }
    }

    public void DecreaseAirPlane()
    {
        this.airplaneAmount.GetComponent<Image>().fillAmount -= 0.2f;
        destroy.SetActive(true);
        Invoke("SetHideDestory", 3f);
    }


    private void SetHideDestory()
    {
        destroy.SetActive(false);
    }

    private void SetHideSuccess()
    {
        success.SetActive(false);
    }

    private void SetSendMessage()
    {
        success.SetActive(false);
        message.SetActive(true);

    }
    //public void RePlay()
    //{
    //    message.SetActive(false);
    //    destroy.SetActive(false);
    //    success.SetActive(false);

    //    this.airplaneAmount.GetComponent<Image>().fillAmount = 0f;


    //    foreach (var item in GameObject.FindGameObjectsWithTag("Box"))
    //    {
    //        Destroy(item);
    //    }

    //    foreach (var item in GameObject.FindGameObjectsWithTag("Plane"))
    //    {
    //        Destroy(item);
    //    }

    //    foreach (var item in GameObject.FindGameObjectsWithTag("Player"))
    //    {
    //        Destroy(item);
    //    }

    //    //Destroy(GameObject.FindWithTag("Box"));
    //    //Destroy(GameObject.FindWithTag("Plane"));
    //    //Destroy(GameObject.FindWithTag("Player"));
    //}

    public IEnumerator Count(float sec)
    {
        yield return new WaitForSecondsRealtime(sec);
        success.SetActive(false);
        message.SetActive(true);
        txt_message.text = "Restart 5s...";
        yield return new WaitForSecondsRealtime(1.0f);
        txt_message.text = "Restart 4s...";
        yield return new WaitForSecondsRealtime(1.0f);
        txt_message.text = "Restart 3s...";
        yield return new WaitForSecondsRealtime(1.0f);
        txt_message.text = "Restart 2s...";
        yield return new WaitForSecondsRealtime(1.0f);
        txt_message.text = "Restart 1s...";

        yield return new WaitForSecondsRealtime(0.2f);

        message.SetActive(false);
        destroy.SetActive(false);
        success.SetActive(false);

        this.airplaneAmount.GetComponent<Image>().fillAmount = 0f;


        foreach (var item in GameObject.FindGameObjectsWithTag("Box"))
        {
            Destroy(item);
        }

        foreach (var item in GameObject.FindGameObjectsWithTag("Plane"))
        {
            Destroy(item);
        }

        foreach (var item in GameObject.FindGameObjectsWithTag("Player"))
        {
            Destroy(item);
        }
    }
}
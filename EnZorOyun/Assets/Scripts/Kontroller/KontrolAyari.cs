using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KontrolAyari : MonoBehaviour
{
    public string kontrol;
    public string BosKontrol;

    public GameObject butonkontrolobj;
    public GameObject joystickkontrolobj;
    // Start is called before the first frame update
    void Start()
    {
        kontrol = PlayerPrefs.GetString("Kontrol");
        if (PlayerPrefs.HasKey("Kontrol") == false)
        {
            BosKontrolAtamasi();
            PlayerPrefs.SetString("Kontrol", BosKontrol);
        }
        kontrol = PlayerPrefs.GetString("Kontrol");
        if(kontrol=="buton")
        {
            joystickkontrolobj.GetComponent<Button>().interactable = true;
            butonkontrolobj.GetComponent<Button>().interactable = false;
        }
        else if(kontrol=="Joystick")
        {
            joystickkontrolobj.GetComponent<Button>().interactable = false;
            butonkontrolobj.GetComponent<Button>().interactable = true;
        }
    }
    // Update is called once per frame

    public void ButonKontrol()
    {
        kontrol = "buton";
        PlayerPrefs.SetString("Kontrol", kontrol);
        joystickkontrolobj.GetComponent<Button>().interactable = true;
        butonkontrolobj.GetComponent<Button>().interactable = false;

    }
    public void JoysctickKontrol()
    {
        kontrol = "Joystick";
        PlayerPrefs.SetString("Kontrol", kontrol);
        joystickkontrolobj.GetComponent<Button>().interactable = false;
        butonkontrolobj.GetComponent<Button>().interactable = true;

    }
    void BosKontrolAtamasi()
    {
        BosKontrol = "Joystick";
    }
}

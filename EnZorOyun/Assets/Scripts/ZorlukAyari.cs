using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZorlukAyari : MonoBehaviour
{
    public GameObject BasitZorlukBtn;
    public GameObject OrtaZorlukBtn;
    public GameObject ZorlukUyariPanel;

    public string zorluk;
   
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Zorluk") == false)
        {
            BasitZorluk();
            PlayerPrefs.SetString("Zorluk", zorluk);
        }
        zorluk = PlayerPrefs.GetString("Zorluk");
        PanelKapat();
    }

    // Update is called once per frame
    void Update()
    {
        //Seçili zorlupa göre buton açma kapatma
        if (zorluk == "Basit" ||  zorluk=="basit")
        {
            BasitZorlukBtn.GetComponent<Button>().interactable = false;
            OrtaZorlukBtn.GetComponent<Button>().interactable = true;
        }

        if (zorluk == "Orta")
        {
            BasitZorlukBtn.GetComponent<Button>().interactable = true;
            OrtaZorlukBtn.GetComponent<Button>().interactable = false;
        }
    }
    //Zorluk değiştirme işlemi
    public void ZorlukDegistir()
    {
        if (zorluk == "Basit" || zorluk == "basit")
        {
            OrtaZorluk();
            Start();
        }
        else if (zorluk == "Orta") 
        {
            BasitZorluk();
            Start();
        }
    }
    //Zorluk degistirme panelini açıp kapatma
    public void PanelAc()
    {
        ZorlukUyariPanel.SetActive(true);
    }
    public void PanelKapat()
    {
        ZorlukUyariPanel.SetActive(false);
    }
    //Zorluk değiştiğinde yapılacak işlemler
     void BasitZorluk()
    { 
        zorluk = "Basit";
        PlayerPrefs.SetString("Zorluk", zorluk);
        PlayerPrefs.DeleteKey("Bolum");
        PlayerPrefs.DeleteKey("ToplamOlumSayi");
        PlayerPrefs.DeleteKey("BolumSeri");
        PlayerPrefs.DeleteKey("SonBolum");
        PanelKapat();
    }
     void OrtaZorluk()
    {
        zorluk = "Orta";
        PlayerPrefs.SetString("Zorluk", zorluk);
        PlayerPrefs.DeleteKey("Bolum");
        PlayerPrefs.DeleteKey("ToplamOlumSayi");
        PlayerPrefs.DeleteKey("BolumSeri");
        PlayerPrefs.DeleteKey("SonBolum");
        PanelKapat();
    }

}

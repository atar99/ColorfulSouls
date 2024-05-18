using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunMekanikDil : MonoBehaviour
{
    //ADIM 1 :Burada butonların içindeki textleri atmak için gameobjecct oluştur
    //OE =OLUM EKRANI AE=ARA EKRAN BE=BITIS EKRANI
    public GameObject OEKaybettinTxt;
    public GameObject OETekrarDeneTxt;
    public GameObject OEAnaMenuTxt;
    public GameObject OEBolumSecimiTxt;

    public GameObject AEDurdurlduTxt;
    public GameObject AEDevamEtTxt;
    public GameObject AEAnaMenuTxt;
    public GameObject AEBolumSecimiTxt;

    public GameObject BEBolumBittiTxt;
    public GameObject BETekrarOynaTxt;
    public GameObject BEAnaMenuTxt;
    public GameObject BESonrakiBolumTxt;

    public string dil;
    //ADIM 2 :Burada kelimeleri oluştur
    //******************KELİMLER***********************
    string OEKaybettin;
    string OETekrarDene;
    string OEAnaMenu;
    string OEBolumSecimi;

    string AEDurduruldu;
    string AEDevamEt;
    string AEAnaMenu;
    string AEBolumSecimi;

    string BEBolumBitti;
    string BETekrarOyna;
    string BEAnaMenu;
    string BESonrakiBolum;


    //******************KELİMLER SON*******************


   
    public void Start()
    {
        dil = PlayerPrefs.GetString("Dil");
    }
    public void FixedUpdate()
    {
        //Burada çeviri işlemlerini yap
        if (dil == "Turkce")
        {
            OEKaybettin = "Kaybettin";
            OETekrarDene = "Tekrar Dene";
            OEAnaMenu = "Ana Menü";
            OEBolumSecimi = "Bölüm Seçimi";

            AEDurduruldu = "Durduruldu";
            AEDevamEt = "Devam Et";
            AEAnaMenu = "Ana Menü";
            AEBolumSecimi = "Bölüm Seçimi";

            BEBolumBitti = "Bölüm Bitti";
            BETekrarOyna = "Tekrar Oyna";
            BEAnaMenu = "Ana Menü";
            BESonrakiBolum = "Sonraki Bölüm";
        }
        if (dil == "English")
        {
            OEKaybettin = "Game Over";
            OETekrarDene = "Try Again";
            OEAnaMenu = "Main Menu";
            OEBolumSecimi = "Stage Selection";

            AEDurduruldu = "Paused";
            AEDevamEt = "Resume";
            AEAnaMenu = "Main menu";
            AEBolumSecimi = "Stage Selection";

            BEBolumBitti = "Stage Complete";
            BETekrarOyna = "Play Again";
            BEAnaMenu = "Main Menu";
            BESonrakiBolum = "Next Stage";
        }
        if (dil == "français")
        {
            OEKaybettin = "Jeu terminé";
            OETekrarDene = "Réessaie";
            OEAnaMenu = "Accueil";
            OEBolumSecimi = "Sélection D’étape ";

            AEDurduruldu = "Arrêté";
            AEDevamEt = "Continue";
            AEAnaMenu = "Le Menu D'accueil";
            AEBolumSecimi = "Sélection D’étape";

            BEBolumBitti = " L’étape Est Terminée ";
            BETekrarOyna = "Rejoue";
            BEAnaMenu = "Le Menu D'accueil";
            BESonrakiBolum = " L’étape Suivante";
        }
        if (dil == "Deutsche")
        {
            OEKaybettin = "Game Over";
            OETekrarDene = "Versuch es nochmal";
            OEAnaMenu = "Hautpmenü";
            OEBolumSecimi = "Abschnittsauswahl";

            AEDurduruldu = "Gestoppt";
            AEDevamEt = "Mach weiter";
            AEAnaMenu = "Hautpmenü";
            AEBolumSecimi = "Abschnittsauswahl";

            BEBolumBitti = "Spiel Ende";
            BETekrarOyna = "Spiel  nuestarten";
            BEAnaMenu = "Hautpmenü";
            BESonrakiBolum = "Nächste Folge";
        }
        

        //ADIM 4: Burada GameObject'e  oluşturulan textleri bağla
        OEKaybettinTxt.GetComponent<Text>().text = OEKaybettin;
        OETekrarDeneTxt.GetComponent<Text>().text = OETekrarDene;
        OEAnaMenuTxt.GetComponent<Text>().text = OEAnaMenu;
        OEBolumSecimiTxt.GetComponent<Text>().text = OEBolumSecimi;

        AEDurdurlduTxt.GetComponent<Text>().text = AEDurduruldu;
        AEDevamEtTxt.GetComponent<Text>().text = AEDevamEt;
        AEAnaMenuTxt.GetComponent<Text>().text = AEAnaMenu;
        AEBolumSecimiTxt.GetComponent<Text>().text = AEBolumSecimi;

        BEBolumBittiTxt.GetComponent<Text>().text = BEBolumBitti;
        BETekrarOynaTxt.GetComponent<Text>().text = BETekrarOyna;
        BEAnaMenuTxt.GetComponent<Text>().text = BEAnaMenu;
        BESonrakiBolumTxt.GetComponent<Text>().text = BESonrakiBolum;

}
}

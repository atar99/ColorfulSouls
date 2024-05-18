using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DilAyari : MonoBehaviour
{
    //ADIM 1 :Burada butonların içindeki textleri atmak için gameobjecct oluştur
    //AE= AYAR EKRANI DE=DİL EKRANI ANME=ANAMENU EKRANI
    public GameObject AEAyarlarTxt;
    public GameObject AEİlerlemeSifirlaTxt;
    public GameObject AEGizlilikPolitikaTxt;
    public GameObject AEDiliDegistirTxt;
    public GameObject AEGeriDonTxt;
    public GameObject DEDilAyariTxt;
    public GameObject DEGeriDonTxt;
   // public GameObject ANMEOyunaBaslaTxt;
    public GameObject KAKontrolAyariTxt;
    public GameObject KAKontrolleriDegistirTxt;
    public GameObject KAGeriDonTxt;



    public GameObject ZABasitZorlukTxt;
    public GameObject ZAOrtaZorlukTxt;
    public GameObject ZAZorlukUyariTxt;
    public GameObject ZAKabulEtTxt;
    public GameObject ZAVazgecTxt;
    public GameObject ZAZorlukAyariTxt;
    public GameObject ZAGeriDonTxt;
    public GameObject ZAZorlukDegistirTxt;

    public string dil;
    public string SistemDili;
    public string zorluk;

    //ADIM 2 :Burada kelimeleri oluştur
    //******************KELİMLER***********************
    string AEAyarlar;
    string AEİlerlemeSifirla;
    string AEGizlilikPolitikasi;
    string AEDiliDegistir;
    string AEGeriDon;
    string DEDilAyari;
    string DEGeriDon;
   // string ANMEOyunaBasla;
    string KAKontrolAyari;
    string KAKontrolleriDegistir;
    string KAGeriDon;



    string ZABasitZorluk;
    string ZAOrtaZorluk;
    string ZAZorlukUyari;
    string ZAKabulEt;
    string ZAVazgec;
    string ZAZorlukAyari;
    string ZAGeriDon;
    string ZAZorlukDegistir;
    //******************KELİMLER SON*******************


    public void SistemDilikomutu()
    {
        //Sistem Dili Türkçe ise
        if (Application.systemLanguage == SystemLanguage.Turkish)
        {
            Debug.Log("This system is in Turkish. ");
            SistemDili = "Turkce";
        }
        //Sistem Dili İngilizce ise
        else if (Application.systemLanguage == SystemLanguage.English)
        {
            Debug.Log("This system is in English. ");
            SistemDili = "English";
        }
        //Sistem Dili Fransızca ise
        else if (Application.systemLanguage == SystemLanguage.French)
        {
            Debug.Log("This system is in French. ");
            SistemDili = "français";
        }
        //Sistem Dili Almanca ise
        else if (Application.systemLanguage == SystemLanguage.German)
        {
            Debug.Log("This system is in German. ");
            SistemDili = "Deutsche";
        }
        //Sistem Dili Bunlardan Biri Değil İse İngilizce Yap
        else
        {
            Debug.Log("This system is in Unknown ");
            SistemDili = "English";
        }

    }
    public void Start()
    {
        if (PlayerPrefs.HasKey("Dil") == false)
        {
            SistemDilikomutu();
            PlayerPrefs.SetString("Dil", SistemDili);
        }
        dil = PlayerPrefs.GetString("Dil");
        zorluk = PlayerPrefs.GetString("Zorluk");
    }
    public void FixedUpdate()
    {
        zorluk = PlayerPrefs.GetString("Zorluk");
        //Burada çeviri işlemlerini yap
        if (dil == "Turkce")
        {
            AEAyarlar = "Ayarlar";
            AEİlerlemeSifirla = "İlerleme Sıfırla";
            AEGizlilikPolitikasi = "Gizlilik Politikası";
            AEDiliDegistir = "Dili Değiştir";
            AEGeriDon = "Geri Dön";

            DEDilAyari = "Dil Ayarı";
            DEGeriDon = "Geri Dön";

            //   ANMEOyunaBasla = "Oyuna Başlamak İçin Dokunun";

            KAKontrolAyari = "Kontrol Ayarları";
            KAKontrolleriDegistir = "Kontrolleri Değiştir";
            KAGeriDon = "Geri Dön";

            ZABasitZorluk = "Normal";
            ZAOrtaZorluk = "Zor";
            ZAZorlukUyari = "Zorluk ayarının değiştirilmesi ilerlemeyi sıfırlar.";
            ZAKabulEt = "KabulEt";
            ZAVazgec = "Vazgec";
            ZAZorlukAyari = "Zorluk Ayarı";
            ZAGeriDon = "Geri Dön";
            ZAZorlukDegistir = "Zorluk Değiştir";
        }
        if (dil == "English")
        {
            AEAyarlar = "Settings";
            AEİlerlemeSifirla = "Reset Progress";
            AEGizlilikPolitikasi = "Privacy Policy";
            AEDiliDegistir = "Change the language";
            AEGeriDon = "Back";

            DEDilAyari = "Language Settings";
            DEGeriDon = "Back";

            //   ANMEOyunaBasla = "Tap To Start Game";

            KAKontrolAyari = "Control Settings";
            KAKontrolleriDegistir = "Change Controls";
            KAGeriDon = "Back";


            ZABasitZorluk = "Normal";
            ZAOrtaZorluk = "Hard";
            ZAZorlukUyari = "Your progress will be reset when you change the difficulty.";
            ZAKabulEt = "Confirm";
            ZAVazgec = "Cancel";
            ZAZorlukAyari = "Difficulty Settings";
            ZAGeriDon = "Back";
            ZAZorlukDegistir = "Change difficulty";
        }
        if (dil == "français")
        {
            AEAyarlar = "Paramètres";
            AEİlerlemeSifirla = "Remets L’avancement";
            AEGizlilikPolitikasi = "Politique De Condifentialité";
            AEDiliDegistir = "Change la langue";
            AEGeriDon = "Retourne";

            DEDilAyari = "Paramètres De Langue";
            DEGeriDon = "Retourne";
           
            //    ANMEOyunaBasla = "Touche Pour Commencer";

            KAKontrolAyari = "Paramètres de contrôle";
            KAKontrolleriDegistir = "Modifier les contrôles";
            KAGeriDon = "Retourne";


            ZABasitZorluk = "Normal";
            ZAOrtaZorluk = "Ardu";
            ZAZorlukUyari = "Modification des paramètres de difficulté remet l’avancement.";
            ZAKabulEt = "Accepte";
            ZAVazgec = "Abandonne";

            ZAZorlukAyari = "Réglage de la difficulté";
            ZAGeriDon = "Retourne";
            ZAZorlukDegistir = "Changer la difficulté";
        }
        if (dil == "Deutsche")
        {
            AEAyarlar = "Einstellungen";
            AEİlerlemeSifirla = "Fortschritt zurücksetzen";
            AEGizlilikPolitikasi = "Datenschutzerklärung";
            AEDiliDegistir = "Sprache  Änderung";
            AEGeriDon = "Zurück";

            DEDilAyari = " Spracheinstellungen";
            DEGeriDon = "Zurück";

            //    ANMEOyunaBasla = "Tippen Sie auf,  um das Spiel zu starten";

            KAKontrolAyari = "Kontroll Einstellungen";
            KAKontrolleriDegistir = "Kontrolle Ändern";
            KAGeriDon = "Zurück";




            ZABasitZorluk = "Normal";
            ZAOrtaZorluk = "Schwer";
            ZAZorlukUyari = " Durch Ändern der Schwierigkeitsstufe wird der Fortschritt zurücksetzen.";
            ZAKabulEt = "Gib es zu";
            ZAVazgec = "Gib auf";
            ZAZorlukAyari = "Schwierigkeitseinstellung";
            ZAGeriDon = "Zurück";
            ZAZorlukDegistir = "Schwierigkeitseinstellung  Ändern";
        }
        //ADIM 4: Burada GameObject'e  oluşturulan textleri bağla
        AEAyarlarTxt.GetComponent<Text>().text = AEAyarlar;
        AEİlerlemeSifirlaTxt.GetComponent<Text>().text = AEİlerlemeSifirla;
        AEGizlilikPolitikaTxt.GetComponent<Text>().text = AEGizlilikPolitikasi;
        AEDiliDegistirTxt.GetComponent<Text>().text = AEDiliDegistir;
        AEGeriDonTxt.GetComponent<Text>().text =AEGeriDon;

        DEDilAyariTxt.GetComponent<Text>().text =DEDilAyari;
        DEGeriDonTxt.GetComponent<Text>().text = DEGeriDon;

     //   ANMEOyunaBaslaTxt.GetComponent<Text>().text = ANMEOyunaBasla;

        KAKontrolAyariTxt.GetComponent<Text>().text = KAKontrolAyari;
        KAKontrolleriDegistirTxt.GetComponent<Text>().text = KAKontrolleriDegistir;
        KAGeriDonTxt.GetComponent<Text>().text = KAGeriDon;


        ZABasitZorlukTxt.GetComponent<Text>().text = ZABasitZorluk;
        ZAOrtaZorlukTxt.GetComponent<Text>().text = ZAOrtaZorluk;
        ZAZorlukUyariTxt.GetComponent<Text>().text = ZAZorlukUyari;
        ZAKabulEtTxt.GetComponent<Text>().text = ZAKabulEt;
        ZAVazgecTxt.GetComponent<Text>().text = ZAVazgec;
        ZAZorlukAyariTxt.GetComponent<Text>().text = ZAZorlukAyari;
        ZAGeriDonTxt.GetComponent<Text>().text = ZAGeriDon;
        ZAZorlukDegistirTxt.GetComponent<Text>().text = ZAZorlukDegistir;
    }

    //DİL DEĞİŞTİRME BUTONLARI
    public void EngDil()
    {
        dil = "English";
        PlayerPrefs.SetString("Dil", dil);
        FixedUpdate();
    }
    public void TrDil()
    {
        dil = "Turkce";
        PlayerPrefs.SetString("Dil", dil);
        FixedUpdate();
    }
    public void FraDil()
    {
        dil = "français";
        PlayerPrefs.SetString("Dil", dil);
        FixedUpdate();
    }
    public void AlmDil()
    {
        dil = "Deutsche";
        PlayerPrefs.SetString("Dil", dil);
        FixedUpdate();
    }
    //DİL DEĞİŞTİRME BUTONLARI SON

    public void VeriSil()
    {
        PlayerPrefs.DeleteAll();
    }
}

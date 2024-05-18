using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolumSecimiDil : MonoBehaviour
{
    //ADIM 1 :Burada butonların içindeki textleri atmak için gameobjecct oluştur
    //OE =OLUM EKRANI AE=ARA EKRAN BE=BITIS EKRANI
    public GameObject BSAnaMenuTxt;
    public string dil;


    //ADIM 2 :Burada kelimeleri oluştur
    //******************KELİMLER***********************

    string BSAnaMenu;
    //******************KELİMLER SON*******************



    public void Start()
    {
        dil = PlayerPrefs.GetString("Dil");
    }
    public void Update()
    {
        dil = PlayerPrefs.GetString("Dil");

        //Burada çeviri işlemlerini yap
        if (dil == "Turkce")
        {
            BSAnaMenu = "Ana Menüye Dön";
        }
        if (dil == "English")
        {
            BSAnaMenu = "Main Menu";
        }

        if (dil == "français")
        {
            BSAnaMenu = "Retourne Au Menu D'accueil";
        }
        if (dil == "Deutsche")
        {
            BSAnaMenu = "Zurück zum Hauptmenü";
        }
        //ADIM 4: Burada GameObject'e  oluşturulan textleri bağla
        BSAnaMenuTxt.GetComponent<Text>().text = BSAnaMenu;

    }
}
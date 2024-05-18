using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BolumKilit : MonoBehaviour
{

    public GameObject Seri1Obj;
    public GameObject Seri2Obj;
    public GameObject Seri1Btn;
    public GameObject Seri2Btn;
    public GameObject Seri3Obj;
    public GameObject Seri3Btn;
    public GameObject Seri3ten2yegecBtn;

    int BolumSeri;
    // Start is called before the first frame update
    void Start()
    {
        KilitSistemi();
        if (PlayerPrefs.HasKey("BolumSeri") == false)
        {
            PlayerPrefs.SetInt("BolumSeri", 1);
        }
        BolumSerisi();

    }
  
    public Button[] buttonlar;

    void FixedUpdate()
    {
        KilitSistemi();
        BolumSerisi();
    }
    public void BolumSerisi()
    {
        BolumSeri = PlayerPrefs.GetInt("BolumSeri");
        if (BolumSeri==1) Seri1Gec();
        if(BolumSeri==2) Seri2Gec();
        if (BolumSeri == 3) Seri3Gec();
    }
    public void KilitSistemi()
    {
        int bolumler = PlayerPrefs.GetInt("Bolum");

        for (int i = 1; i < buttonlar.Length; i++)
        {
            if (bolumler>= int.Parse(buttonlar[i].name))
            {
                buttonlar[i].interactable = true;
            }
            else
            {
                buttonlar[i].interactable = false;
            }
        }
    }

    public void Seri1Gec()
    {
        PlayerPrefs.SetInt("BolumSeri", 1);
        Seri1Obj.SetActive(true);
        Seri2Obj.SetActive(false);
        Seri3Obj.SetActive(false);
        Seri1Btn.GetComponent<Button>().interactable = false;
        Seri2Btn.GetComponent<Button>().interactable = true;
        Seri3Btn.GetComponent<Button>().interactable = false;
        Seri3ten2yegecBtn.GetComponent<Button>().interactable = false;
        Seri1Btn.SetActive(false);
        Seri2Btn.SetActive(true);
        Seri3Btn.SetActive(false);
        Seri3ten2yegecBtn.SetActive(false);
    }
    public void Seri2Gec()
    {
        PlayerPrefs.SetInt("BolumSeri",2);
        Seri1Obj.SetActive(false);
        Seri2Obj.SetActive(true);
        Seri3Obj.SetActive(false);
        Seri2Btn.GetComponent<Button>().interactable = false;
        Seri1Btn.GetComponent<Button>().interactable = true;
        Seri3Btn.GetComponent<Button>().interactable = true;
        Seri3ten2yegecBtn.GetComponent<Button>().interactable = false;
        Seri1Btn.SetActive(true);
        Seri2Btn.SetActive(false);
        Seri3Btn.SetActive(true);
        Seri3ten2yegecBtn.SetActive(false);
    }

    public void Seri3Gec()
    {
        PlayerPrefs.SetInt("BolumSeri", 3);
        Seri1Obj.SetActive(false);
        Seri2Obj.SetActive(false);
        Seri3Obj.SetActive(true);
        Seri2Btn.GetComponent<Button>().interactable = false;
        Seri1Btn.GetComponent<Button>().interactable = false;
        Seri3Btn.GetComponent<Button>().interactable = false;
        Seri3ten2yegecBtn.GetComponent<Button>().interactable = true;
        Seri1Btn.SetActive(false);
        Seri2Btn.SetActive(false);
        Seri3Btn.SetActive(false);
        Seri3ten2yegecBtn.SetActive(true);
    }
    public void BolumAc(string Bolumİsmi)
    {
        SceneManager.LoadScene(Bolumİsmi);
    }
}

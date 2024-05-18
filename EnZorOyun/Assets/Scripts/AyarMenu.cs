using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AyarMenu : MonoBehaviour
{
    public GameObject AyarMenuobj;
    public GameObject AyarBtnobj;
    public GameObject AnaMenuBtnPanelobj;
    public GameObject DurdurMenuPanelobj;

    public bool AyarMenuAcik;
    public bool AyarBtnobjAcik;
    public bool AnaMenuBtnPanelAcik;
    public bool DurdurMenuPanelAcik;

    public void Start()
    {
        AyarMenuAcik = false;
        AyarBtnobjAcik = true;
        AnaMenuBtnPanelAcik=true;
      
     
    }

    void FixedUpdate()
    {
        if (AyarMenuAcik)
        {
            AyarMenuobj.SetActive(true);
            AyarBtnobj.SetActive(false);
            AnaMenuBtnPanelobj.SetActive(false);

        }
        else
        {
            AyarMenuobj.SetActive(false);
            AyarBtnobj.SetActive(true);
            AnaMenuBtnPanelobj.SetActive(true);
        }
    }
    
    public void ayar()
    {
        AyarMenuAcik = true;
        AyarBtnobjAcik = false;
        AnaMenuBtnPanelAcik = false;
    }

    public void devam()
    {
        AyarMenuAcik = false;
        AyarBtnobjAcik = true;
        AnaMenuBtnPanelAcik = true;
        DurdurMenuPanelAcik = true;
        DurdurMenuPanelobj.SetActive(true);
    }
}

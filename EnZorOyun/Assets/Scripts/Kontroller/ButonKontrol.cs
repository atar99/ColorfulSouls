using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonKontrol : MonoBehaviour
{
    float hiz = 7;
    float eksihiz = -7;

    void Update()
    {
        //Yukarı Hereket
        if (Input.GetKey(KeyCode.W) || Yukarigit == true)
        {
            transform.Translate(new Vector3(0, hiz, 0) * Time.deltaTime, Space.World);
        }
        //Aşağı Hereket
        if (Input.GetKey(KeyCode.S) || Asagigit == true)
        {
            transform.Translate(new Vector3(0, eksihiz, 0) * Time.deltaTime, Space.World);
        }

        //Sağa Hereket
        if (Input.GetKey(KeyCode.A) || Solagit == true)
        {
            transform.Translate(new Vector3(eksihiz, 0, 0) * Time.deltaTime, Space.World);
        }
        //Sola Hereket
        if (Input.GetKey(KeyCode.D) || Sagagit == true)
        {
            transform.Translate(new Vector3(hiz, 0, 0) * Time.deltaTime, Space.World);
        }
    }
    
    bool Yukarigit, Asagigit, Sagagit, Solagit;

    public void YukariGit()
    {

        Yukarigit = true;
    }
    public void YukariGitme()
    {
        Yukarigit = false;
    }
    public void AsagiGit()
    {
        Asagigit = true;
    }
    public void AsagiGitme()
    {
        Asagigit = false;
    }
    public void SagaGit()
    {
        Sagagit = true;
    }
    public void SagaGitme()
    {
        Sagagit = false;
    }
    public void SolaGit()
    {
        Solagit = true;
    }
    public void SolaGitme()
    {
        Solagit = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Seri2ButonKontrolu : MonoBehaviour
{
   public int hiz;
    public Rigidbody2D Oyuncu;

    void Update()
    {
        //Yukarı Hereket
        if (Input.GetKey(KeyCode.W) || Yukarigit == true)
        {
             Oyuncu.AddForce(Vector2.up * hiz * Time.deltaTime);
            //Oyuncu.velocity = Vector2.up * hiz * Time.deltaTime;
            
        }
        //Aşağı Hereket
        if (Input.GetKey(KeyCode.S) || Asagigit == true)
        {
            Oyuncu.AddForce(Vector2.down * hiz * Time.deltaTime);
           // Oyuncu.velocity = Vector2.down * hiz * Time.deltaTime;
        }

        //Sağa Hereket
        if (Input.GetKey(KeyCode.A) || Solagit == true)
        {
            Oyuncu.AddForce(Vector2.left * hiz * Time.deltaTime);
         //   Oyuncu.velocity = Vector2.left * hiz * Time.deltaTime;
        }
        //Sola Hereket
        if (Input.GetKey(KeyCode.D) || Sagagit == true)
        {
            Oyuncu.AddForce(Vector2.right * hiz * Time.deltaTime);
           // Oyuncu.velocity = Vector2.right * hiz * Time.deltaTime;
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

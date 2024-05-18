using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip Olum, Bitis, Anahtar, MenuAcik, MenuKapali;
    static AudioSource auidoSrc;
    void Start()
    {
        Olum = Resources.Load<AudioClip>("Olum");
        Bitis = Resources.Load<AudioClip>("Bitis");
        Anahtar = Resources.Load<AudioClip>("Anahtar");
        MenuAcik = Resources.Load<AudioClip>("MenuAcik"); 
        MenuKapali = Resources.Load<AudioClip>("MenuKapali");

        auidoSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Olum":
                auidoSrc.PlayOneShot(Olum);
                break;
            case "Bitis":
                auidoSrc.PlayOneShot(Bitis);
                break;
            case "Anahtar":
                auidoSrc.PlayOneShot(Anahtar);
                break;
            case "MenuAcik":
                auidoSrc.PlayOneShot(MenuAcik);
                break;
            case "MenuKapali":
                auidoSrc.PlayOneShot(MenuKapali);
                break;
        }
    }
}

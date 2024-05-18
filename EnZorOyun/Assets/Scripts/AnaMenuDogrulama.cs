using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaMenuDogrulama : MonoBehaviour
{
    string Kontrol, Zorluk;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Zorluk") == false)
        {
            PlayerPrefs.SetString("Zorluk", "basit");
        }
        Zorluk = PlayerPrefs.GetString("Zorluk");

        if (PlayerPrefs.HasKey("Kontrol") == false)
        {
            PlayerPrefs.SetString("Kontrol", "Joystick");
        }
         Kontrol= PlayerPrefs.GetString("Kontrol");  
    }

    // Update is called once per frame
    void Update()
    {
        Start();
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoystickKontrol : MonoBehaviour
{
    public int speed;

    float vertical, horizontal;   
    public Joystick jy;
   
   private void Update()
    {
        vertical = jy.Vertical;
        horizontal = jy.Horizontal;
        if (vertical != 0 || horizontal != 0)
        {
            //OYUNCUNUN DÖNMESINI SAĞLAMA   transform.up = new Vector3(horizontal * speed, vertical * speed,0);
            transform.Translate(new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime, Space.World);
        }

    }
}
 
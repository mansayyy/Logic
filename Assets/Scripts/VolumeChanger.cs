using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    // int isMute;
    public Sprite OffSprite;
    public Sprite OnSprite;
    public Button but;

    public void Start()
    {
        int consmute=PlayerPrefs.GetInt("Muted",0);
        if(consmute==1)
        {
            but.image.sprite = OffSprite;
            AudioListener.volume =0;
        }
        else{
            but.image.sprite = OnSprite;
            AudioListener.volume =1;
        }
    }
    public void Mute (){
        int isMute=PlayerPrefs.GetInt("Muted",0);
        if(isMute==1)
         {
            isMute = 0;
            AudioListener.volume =1;
            PlayerPrefs.SetInt("Muted",0);
        }
        else
        {
            isMute =1;
            AudioListener.volume =0;
            PlayerPrefs.SetInt("Muted",1);
        }
    //  if(isMute=1)
    //  AudioListener.volume =  isMute ? 0 : 1;
     Debug.Log(isMute);
     
    }

     
    public void ChangeImage(){
        if (but.image.sprite == OnSprite)
            but.image.sprite = OffSprite;
        else {
            but.image.sprite = OnSprite;
        }
    }
}

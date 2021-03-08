using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLogic : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    // Start is called before the first frame update
    public void GetLog(){
        int points=PlayerPrefs.GetInt("FinalScore", 0);
        if (points > 30)
        {
            PlayerPrefs.SetInt("FinalScore", points-30);
            PlayerPrefs.Save();
       
        }
        else
        {
            Panel1.SetActive(false); 
            Panel2.SetActive(false);  
            Panel3.SetActive(true);
        }
         
    }
}

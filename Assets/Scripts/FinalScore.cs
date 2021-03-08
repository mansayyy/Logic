using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text fscore;

    
    // Start is called before the first frame update
    void Start()
    {        
        fscore.text = PlayerPrefs.GetInt("FinalScore", 0).ToString(); 
    }

}

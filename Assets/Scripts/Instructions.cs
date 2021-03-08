using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using UnityEngine.SceneManagement;
 
public class Instructions : MonoBehaviour
{
    
    public GameObject[] objectToDisable01;
 
    void Awake()
    {
        // objectToDisable01.SetActive(false);
    }
 
     void Start()
    {       
        objectToDisable01[0].SetActive(true);
        // if(i<5)
        // {
        // LoadNextInst(i+1);
        // }
    }
    public void LoadNextInst(int x)
    {
        objectToDisable01[x-1].SetActive(false);
        objectToDisable01[x].SetActive(true);
       
    }

    public void LastInst()
    {
        objectToDisable01[5].SetActive(false);
    }

}
 
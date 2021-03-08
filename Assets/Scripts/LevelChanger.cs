using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    int levelsunlocked;
    int levelsunlockednew;

    public Button[] buttons;
    public Button[] buttonstwo;
    public GameObject Level_Panel;

    void Start(){        
        //Debug.Log(m);

        // PlayerPrefs.SetInt("levelsunlocked",1);
        // PlayerPrefs.SetInt("levelsunlocked11",11);
        // PlayerPrefs.SetInt("FinalScore",0);
        levelsunlocked=PlayerPrefs.GetInt("levelsunlocked",1);
        levelsunlockednew=PlayerPrefs.GetInt("levelsunlocked11",11);
        int sc=SceneManager.GetActiveScene().buildIndex;

        if(sc==1)
        {
            if(buttons.Length>0)
            {
                for(int i=0; i<buttons.Length ;i++)
                {
                    Debug.Log(i);
                    buttons[i].interactable=false;
                    //nextbuttons[i].interactable=false;
                }
                for(int j=0; j<levelsunlocked; j++)
                {
                Debug.Log(levelsunlocked);           
                buttons[j].interactable=true;
                }
            }
        }
        else if(sc==2)
        {
            if(buttons.Length>0)
            {
                for(int i=0; i<buttons.Length ;i++)
                {
                    Debug.Log(i);
                    buttons[i].interactable=false;
                    //nextbuttons[i].interactable=false;
                }
                if(levelsunlocked>=10)
                {
                    for(int l=0; l<(levelsunlocked%10); l++)
                    {
                    Debug.Log(levelsunlocked);           
                    buttons[l].interactable=true;
                    }
                }
            }
        }

        
        // if(levelsunlocked>10)
        // {
        //   for(int j=0; j<levelsunlockednew; j++)
        //     {
        //     Debug.Log(levelsunlockednew);           
        //     buttons[j].interactable=true;
        //     }

        // }
        // else
        // {
        


    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        if(Level_Panel != null)
        {
            bool isActive = Level_Panel.activeSelf;

            Level_Panel.SetActive(!isActive);
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
        if(Level_Panel != null)
        {
            bool isActive = Level_Panel.activeSelf;

            Level_Panel.SetActive(!isActive);
        }
    }

    public void LoadNextLevel()
    {
        int l= PlayerPrefs.GetInt("CurrentLevel",1);
        Debug.Log(l);
        SceneManager.LoadScene(l+3);
    }
}

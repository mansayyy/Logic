using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using UnityEngine.SceneManagement;
// internal System.Windows.Forms.RichTextBox Document;
// internal NetSpell.SpellChecker.Spelling SpellChecker;

public class endingwithS : MonoBehaviour
{
    public string theName;
    public GameObject textDisplay;
    public InputField  inputfieldname;
    public Text attempts;
    private int att;
    private int correctAns = 0;
    public Text fword;
    //private const string URL = "https://raw.githubusercontent.com/lorenbrichter/Words/master/Words/en.txt";
    public Transform contentWindow;
    public Text recallTextObject;
    
    public Button Gethints;

//finalscore
    int points;
    int tempf;
    int currentscore;
    int dl;

    List<string> temp = new List<string>();
    List<string> anstemp = new List<string>();

    
    public void Start()
    {
        temp.Clear();
        anstemp.Clear();
        PlayerPrefs.SetInt("Attempt", 0);
        PlayerPrefs.SetInt("Score", 0);
        GivefirstWord();
        
    }
      public void GivefirstWord(){
        System.Random random = new System.Random();
        int i = random.Next(0, 500);
        fword.text = Constant9.ews[i];
        temp.Add(Constant9.ews[i]);

        att=PlayerPrefs.GetInt("Attempt",1);
        if(att<5)
        {
            Gethints.interactable=false;
        }
        else if(att==6)
        {
            Gethints.interactable=true;
        }
        }


    public void GetHint()
    {
        Instantiate(recallTextObject , contentWindow);
        
        for (int i = 0; i < temp.Count; i++)
        {
            recallTextObject.text += temp[i] + "\n";
        }   
        Gethints.interactable=false;
    }

public void LevelNine()

    {   
        PlayerPrefs.SetInt("CurrentLevel", 9);
        theName =  inputfieldname.text;
        string s = theName.ToLower();
        int n = s.Length;
        if(Constant9.ews.Contains(s))
        {
            for (int i = 0; i < n; i++)
            {
                if (s[n-1]=='s')
                {
                    if(temp.Contains(s))
                    {                    
                        textDisplay.GetComponent<Text>().text = "Word already occured!";  
                        correctAns=0;
                        GivefirstWord();

                    }
                    else if(anstemp.Contains(s))
                    {
                        textDisplay.GetComponent<Text>().text = "Word entered once!";  
                        correctAns=0;
                        GivefirstWord(); 
                    }
                    else
                    {
                        textDisplay.GetComponent<Text>().text = "Correct answer!";
                        GivefirstWord();
                        anstemp.Add(s);

                        if (correctAns < 2)
                        {
                            correctAns += 1;
                            break;
                        }
                        else if (correctAns == 2)
                        {
                            textDisplay.GetComponent<Text>().text = "Level cleared!";
                            
                            points=PlayerPrefs.GetInt("FinalScore", 0); //gets previous levels score
                            tempf = PlayerPrefs.GetInt("Attempt", 0);
                            
                            int flag=PlayerPrefs.GetInt("Attemptedornot9",0);
                            if(flag==0)
                            {
                                if (tempf <= 5)
                                {
                                    currentscore=30;
                                }
                                else if (tempf <= 10)
                                {
                                    currentscore=20;
                                }
                                else
                                {
                                    currentscore=10;
                                }
                                PlayerPrefs.SetInt("Attemptedornot9",1);
                            }
                            else
                            {
                                currentscore=0;
                            }
                            PlayerPrefs.SetInt("FinalScore",points+currentscore);//adds this level score to final score
                            PlayerPrefs.Save();
                            Debug.Log(PlayerPrefs.GetInt("FinalScore"));
                            Debug.Log(currentscore);
                            //for unlocking the next level
                            int currentlevel= PlayerPrefs.GetInt("levelsunlocked",1);
                            if(currentlevel<=10)
                            {
                                PlayerPrefs.SetInt("levelsunlocked",10);
                            }
                            else
                            {
                                PlayerPrefs.SetInt("levelsunlocked",currentlevel);
                            }
                            PlayerPrefs.Save();
                            SceneManager.LoadScene("Level_Completed");

                            break;
                        }
                        else
                        {
                            correctAns = 0;
                        }
                    }

                }               
            
            }   
        }
        else if (s == "")
            {
                    textDisplay.GetComponent<Text>().text = "Enter text";
                    correctAns = 0;
                    GivefirstWord();
                    

            }
        else
        {
            textDisplay.GetComponent<Text>().text = "Oops, Wrong Logic !";
            correctAns = 0;
            GivefirstWord();
        }

        att = PlayerPrefs.GetInt("Attempt", 0);
        PlayerPrefs.SetInt("Attempt", att + 1);//increment the number of attempts
        attempts.text = PlayerPrefs.GetInt("Attempt", 0).ToString(); 
         inputfieldname.text = "";       
    }

    public void AfterBack()
    {
            SceneManager.LoadScene(1);
    }

}
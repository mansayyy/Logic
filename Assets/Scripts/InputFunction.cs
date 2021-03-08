using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using UnityEngine.SceneManagement;
// internal System.Windows.Forms.RichTextBox Document;
// internal NetSpell.SpellChecker.Spelling SpellChecker;

public class InputFunction : MonoBehaviour
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
    public GameObject LevelCompleted_Panel;

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
        int i = random.Next(0, 1000);
        fword.text = Constant.awords[i];
        temp.Add(Constant.awords[i]);

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

public void LevelOne()

    {   
        PlayerPrefs.SetInt("CurrentLevel", 1);
        theName =  inputfieldname.text;
        string s = theName.ToLower();
        int n = s.Length;
        if(Constant.awords.Contains(s))
        {
            for (int i = 0; i < n; i++)
            {
                if (s[0] == 'a')
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
                            int flag=PlayerPrefs.GetInt("Attemptedornot",0);
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
                                PlayerPrefs.SetInt("Attemptedornot",1);
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
                            if(currentlevel<=2)
                            {
                                PlayerPrefs.SetInt("levelsunlocked",2);
                            }
                            else
                            {
                                PlayerPrefs.SetInt("levelsunlocked",currentlevel);
                            }
                            PlayerPrefs.Save();
                            SceneManager.LoadScene("Level_Completed");

                            // AfterClearingLevel("startingWithA");
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



//     public void LevelSix()
//     {
//         level.text = "6";
//         theName =  inputfieldname.text;
//         string s = theName.ToLower();
//         int n = s.Length;
//         GetWords();
//         if (exist == true)
//         {
            
//             for (int i = 0; i < n; i++)
//             {
//                 for(int y=0; y<n;y++)
//                 {
//                     char m=s[y];
//                     char nn=s[y+1];
//                     if(m==nn)
//                     {
//                         dl=1;
//                         break;
//                     }
                    
//                 }
                
                
//                 if (dl==1)
//                 {

//                     textDisplay.GetComponent<Text>().text = "Correct answer!";
//                     f=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpDoubleLetters>();
//                     f.GiveWord();
                 

//                 if (correctAns < 2)
//                 {
//                     correctAns += 1;
//                     AddInUserTempRemoveFromUserWords();
//                     RemoveFromLevelFile("doubleletters");
//                 }
//                 else if (correctAns == 2)
//                 {
//                     textDisplay.GetComponent<Text>().text = "Level cleared!";
                    
//                     int points=PlayerPrefs.GetInt("FinalScore", 0); //gets previous levels score
//                     int tempf = PlayerPrefs.GetInt("Attempt", 0);
//                     int currentscore;
//                     if (tempf <= 5)
//                     {
//                         currentscore=30;
//                     }
//                     else if (tempf <= 10)
//                     {
//                         currentscore=20;
//                     }
//                     else
//                     {
//                         currentscore=10;
//                     }
//                     PlayerPrefs.SetInt("FinalScore",points+currentscore);//adds this level score to final score
//                     PlayerPrefs.Save();
//                     //for unlocking the next level
//                     int currentlevel= PlayerPrefs.GetInt("levelsunlocked",1);
//                     if(currentlevel<=7)
//                     {
//                         PlayerPrefs.SetInt("levelsunlocked",7);
//                     }
//                     else{
//                         PlayerPrefs.SetInt("levelsunlocked",currentlevel);
//                     }
//                     PlayerPrefs.Save();
//                     LevelCompleted_Panel.SetActive(true);

//                     AfterClearingLevel("doubleletters");
//                 }
//                 else
//                 {
//                     correctAns = 0;
//                 }
                
//                 break;
//                 }

//                 else if (dl!=1)
//                 {
//                     textDisplay.GetComponent<Text>().text = "Oops wrong logic!";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     f=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpDoubleLetters>();
//                     f.GiveWord();
//                     break;

//                 }
//                 else if (s == " ")
//                 {
//                     textDisplay.GetComponent<Text>().text = "Enter text";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     f=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpDoubleLetters>();
//                     f.GiveWord();
//                     break;

//                 }
                
//             }
//         }
//         else
//         {
//             textDisplay.GetComponent<Text>().text = "Word does not exist!";
//             //scoreSave(0);
//             correctAns = 0;
//             f=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpDoubleLetters>();
//             f.GiveWord();
//         }

//         att = PlayerPrefs.GetInt("Attempt", 0);
//         PlayerPrefs.SetInt("Attempt", att + 1);//increment the number of attempts
//         attempts.text = PlayerPrefs.GetInt("Attempt", 0).ToString();                  
        
//         // string ObjText = inputField.GetComponent<InputField>();
//         //theName = string.Empty;
//          inputfieldname.text = "";       
//     }

//     public void LevelSeven()
//     {
//         level.text = "7";
//         theName =  inputfieldname.text;
//         string s = theName.ToLower();
//         int n = s.Length;
//         GetWords();
//         if (exist == true)
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 if (n==5)
//                 {

//                     textDisplay.GetComponent<Text>().text = "Correct answer!";
//                     g=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpLength5>();
//                     g.GiveWord();
                 

//                 if (correctAns < 2)
//                 {
//                     correctAns += 1;
//                     AddInUserTempRemoveFromUserWords();
//                     RemoveFromLevelFile("length5");
//                 }
//                 else if (correctAns == 2)
//                 {
//                     textDisplay.GetComponent<Text>().text = "Level cleared!";
                    
//                     int points=PlayerPrefs.GetInt("FinalScore", 0); //gets previous levels score
//                     int tempf = PlayerPrefs.GetInt("Attempt", 0);
//                     int currentscore;
//                     if (tempf <= 5)
//                     {
//                         currentscore=30;
//                     }
//                     else if (tempf <= 10)
//                     {
//                         currentscore=20;
//                     }
//                     else
//                     {
//                         currentscore=10;
//                     }
//                     PlayerPrefs.SetInt("FinalScore",points+currentscore);//adds this level score to final score
//                     PlayerPrefs.Save();
//                     //for unlocking the next level
//                     int currentlevel= PlayerPrefs.GetInt("levelsunlocked",1);
//                     if(currentlevel<=8)
//                     {
//                         PlayerPrefs.SetInt("levelsunlocked",8);
//                     }
//                     else{
//                         PlayerPrefs.SetInt("levelsunlocked",currentlevel);
//                     }
//                     PlayerPrefs.Save();
//                     LevelCompleted_Panel.SetActive(true);

//                     AfterClearingLevel("length5");
//                 }
//                 else
//                 {
//                     correctAns = 0;
//                 }
                
//                 break;
//                 }

//                 else if (n!=5)
//                 {
//                     textDisplay.GetComponent<Text>().text = "Oops wrong logic!";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     g=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpLength5>();
//                     g.GiveWord();
//                     break;

//                 }
//                 else if (s == " ")
//                 {
//                     textDisplay.GetComponent<Text>().text = "Enter text";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     g=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpLength5>();
//                     g.GiveWord();
//                     break;

//                 }
//             }
//         }
//         else
//         {
//             textDisplay.GetComponent<Text>().text = "Word does not exist!";
//             //scoreSave(0);
//             correctAns = 0;
//             g=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpLength5>();
//             g.GiveWord();
//         }

//         att = PlayerPrefs.GetInt("Attempt", 0);
//         PlayerPrefs.SetInt("Attempt", att + 1);//increment the number of attempts
//         attempts.text = PlayerPrefs.GetInt("Attempt", 0).ToString();                  
        
//         // string ObjText = inputField.GetComponent<InputField>();
//         //theName = string.Empty;
//          inputfieldname.text = "";       
//     }

//     public void LevelEight()
//     {
//         level.text = "8";
//         theName =  inputfieldname.text;
//         string s = theName.ToLower();
//         int n = s.Length;
//         GetWords();
//         if (exist == true)
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 if ((s[0]=="a")||(s[0]=="e")||(s[0]=="i")||(s[0]=="o")||(s[0]=="u"))
//                 {

//                     textDisplay.GetComponent<Text>().text = "Correct answer!";
//                     h=GameObject.FindGameObjectWithTag("TagB").GetComponent<Opfirstlettervowel>();
//                     h.GiveWord();
                 

//                 if (correctAns < 2)
//                 {
//                     correctAns += 1;
//                     AddInUserTempRemoveFromUserWords();
//                     RemoveFromLevelFile("firstlettervowel");
//                 }
//                 else if (correctAns == 2)
//                 {
//                     textDisplay.GetComponent<Text>().text = "Level cleared!";
                    
//                     int points=PlayerPrefs.GetInt("FinalScore", 0); //gets previous levels score
//                     int tempf = PlayerPrefs.GetInt("Attempt", 0);
//                     int currentscore;
//                     if (tempf <= 5)
//                     {
//                         currentscore=30;
//                     }
//                     else if (tempf <= 10)
//                     {
//                         currentscore=20;
//                     }
//                     else
//                     {
//                         currentscore=10;
//                     }
//                     PlayerPrefs.SetInt("FinalScore",points+currentscore);//adds this level score to final score
//                     PlayerPrefs.Save();
//                     //for unlocking the next level
//                     int currentlevel= PlayerPrefs.GetInt("levelsunlocked",1);
//                     if(currentlevel<=9)
//                     {
//                         PlayerPrefs.SetInt("levelsunlocked",9);
//                     }
//                     else{
//                         PlayerPrefs.SetInt("levelsunlocked",currentlevel);
//                     }
//                     PlayerPrefs.Save();
//                     LevelCompleted_Panel.SetActive(true);

//                     AfterClearingLevel("firstlettervowel");
//                 }
//                 else
//                 {
//                     correctAns = 0;
//                 }
                
//                 break;
//                 }

//                 else if ((s[0]!="a")&&(s[0]!="e")&&(s[0]!="i")&&(s[0]!="o")&&(s[0]!="u"))
//                 {
//                     textDisplay.GetComponent<Text>().text = "Oops wrong logic!";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     h=GameObject.FindGameObjectWithTag("TagB").GetComponent<Opfirstlettervowel>();
//                     h.GiveWord();
//                     break;

//                 }
//                 else if (s == " ")
//                 {
//                     textDisplay.GetComponent<Text>().text = "Enter text";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     h=GameObject.FindGameObjectWithTag("TagB").GetComponent<Opfirstlettervowel>();
//                     h.GiveWord();
//                     break;

//                 }
//             }
//         }
//         else
//         {
//             textDisplay.GetComponent<Text>().text = "Word does not exist!";
//             //scoreSave(0);
//             correctAns = 0;
//             h=GameObject.FindGameObjectWithTag("TagB").GetComponent<Opfirstlettervowel>();
//             h.GiveWord();
//         }

//         att = PlayerPrefs.GetInt("Attempt", 0);
//         PlayerPrefs.SetInt("Attempt", att + 1);//increment the number of attempts
//         attempts.text = PlayerPrefs.GetInt("Attempt", 0).ToString();                  
        
//         // string ObjText = inputField.GetComponent<InputField>();
//         //theName = string.Empty;
//          inputfieldname.text = "";       
//     }

//     public void LevelNine()
//     {
//         level.text = "9";
//         theName =  inputfieldname.text;
//         string s = theName.ToLower();
//         int n = s.Length;
//         GetWords();
//         if (exist == true)
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 if (s[n-1]=="s")
//                 {

//                     textDisplay.GetComponent<Text>().text = "Correct answer!";
//                     j=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpendingwithS>();
//                     j.GiveWord();
                 

//                 if (correctAns < 2)
//                 {
//                     correctAns += 1;
//                     AddInUserTempRemoveFromUserWords();
//                     RemoveFromLevelFile("endingwithS");
//                 }
//                 else if (correctAns == 2)
//                 {
//                     textDisplay.GetComponent<Text>().text = "Level cleared!";
                    
//                     int points=PlayerPrefs.GetInt("FinalScore", 0); //gets previous levels score
//                     int tempf = PlayerPrefs.GetInt("Attempt", 0);
//                     int currentscore;
//                     if (tempf <= 5)
//                     {
//                         currentscore=30;
//                     }
//                     else if (tempf <= 10)
//                     {
//                         currentscore=20;
//                     }
//                     else
//                     {
//                         currentscore=10;
//                     }
//                     PlayerPrefs.SetInt("FinalScore",points+currentscore);//adds this level score to final score
//                     PlayerPrefs.Save();
//                     //for unlocking the next level
//                     int currentlevel= PlayerPrefs.GetInt("levelsunlocked",1);
//                     if(currentlevel<=10)
//                     {
//                         PlayerPrefs.SetInt("levelsunlocked",10);
//                     }
//                     else{
//                         PlayerPrefs.SetInt("levelsunlocked",currentlevel);
//                     }
//                     PlayerPrefs.Save();
//                     LevelCompleted_Panel.SetActive(true);

//                     AfterClearingLevel("endingwithS");
//                 }
//                 else
//                 {
//                     correctAns = 0;
//                 }
                
//                 break;
//                 }

//                 else if (s[n-1]!="s")
//                 {
//                     textDisplay.GetComponent<Text>().text = "Oops wrong logic!";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     j=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpendingwithS>();
//                     j.GiveWord();
//                     break;

//                 }
//                 else if (s == " ")
//                 {
//                     textDisplay.GetComponent<Text>().text = "Enter text";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     j=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpendingwithS>();
//                     j.GiveWord();
//                     break;

//                 }
//             }
//         }
//         else
//         {
//             textDisplay.GetComponent<Text>().text = "Word does not exist!";
//             //scoreSave(0);
//             correctAns = 0;
//             j=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpendingwithS>();
//                     j.GiveWord();
//         }

//         att = PlayerPrefs.GetInt("Attempt", 0);
//         PlayerPrefs.SetInt("Attempt", att + 1);//increment the number of attempts
//         attempts.text = PlayerPrefs.GetInt("Attempt", 0).ToString();                  
        
//         // string ObjText = inputField.GetComponent<InputField>();
//         //theName = string.Empty;
//          inputfieldname.text = "";       
//     }

//     public void LevelTen()
//     {
//         level.text = "5";
//         theName =  inputfieldname.text;
//         string s = theName.ToLower();
//         int n = s.Length;
//         GetWords();
//         if (exist == true)
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 if (s[0]=="m")
//                 {

//                     textDisplay.GetComponent<Text>().text = "Correct answer!";
//                     e=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpStartingwithM>();
//                     e.GiveWord();
                 

//                 if (correctAns < 2)
//                 {
//                     correctAns += 1;
//                     AddInUserTempRemoveFromUserWords();
//                     RemoveFromLevelFile("startingwithM");
//                 }
//                 else if (correctAns == 2)
//                 {
//                     textDisplay.GetComponent<Text>().text = "Level cleared!";
                    
//                     int points=PlayerPrefs.GetInt("FinalScore", 0); //gets previous levels score
//                     int tempf = PlayerPrefs.GetInt("Attempt", 0);
//                     int currentscore;
//                     if (tempf <= 5)
//                     {
//                         currentscore=30;
//                     }
//                     else if (tempf <= 10)
//                     {
//                         currentscore=20;
//                     }
//                     else
//                     {
//                         currentscore=10;
//                     }
//                     PlayerPrefs.SetInt("FinalScore",points+currentscore);//adds this level score to final score
//                     PlayerPrefs.Save();
//                     //for unlocking the next level
//                     int currentlevel= PlayerPrefs.GetInt("levelsunlocked",1);
//                     if(currentlevel<=11)
//                     {
//                         PlayerPrefs.SetInt("levelsunlocked",11);
//                     }
//                     else{
//                         PlayerPrefs.SetInt("levelsunlocked",currentlevel);
//                     }
//                     PlayerPrefs.Save();
//                     LevelCompleted_Panel.SetActive(true);

//                     AfterClearingLevel("startingwithM");
//                 }
//                 else
//                 {
//                     correctAns = 0;
//                 }
                
//                 break;
//                 }

//                 else if (s[0]!="m")
//                 {
//                     textDisplay.GetComponent<Text>().text = "Oops wrong logic!";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     e=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpStartingwithM>();
//                     e.GiveWord();
//                     break;

//                 }
//                 else if (s == " ")
//                 {
//                     textDisplay.GetComponent<Text>().text = "Enter text";
//                     //scoreSave(0);
//                     correctAns = 0;
//                     e=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpStartingwithM>();
//                     e.GiveWord();
//                     break;

//                 }
//             }
//         }
//         else
//         {
//             textDisplay.GetComponent<Text>().text = "Word does not exist!";
//             //scoreSave(0);
//             correctAns = 0;
//             e=GameObject.FindGameObjectWithTag("TagB").GetComponent<OpStartingwithM>();
//             e.GiveWord();
//         }

//         att = PlayerPrefs.GetInt("Attempt", 0);
//         PlayerPrefs.SetInt("Attempt", att + 1);//increment the number of attempts
//         attempts.text = PlayerPrefs.GetInt("Attempt", 0).ToString();                  
        
//         // string ObjText = inputField.GetComponent<InputField>();
//         //theName = string.Empty;
//          inputfieldname.text = "";       
//     }


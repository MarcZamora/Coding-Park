using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Main Menu
    //exit button
   public void Exitbutton()
   {
       Application.Quit();
       Debug.Log("Game closed");    
   }

   public void MM()
   {
       SceneManager.LoadScene("MainMenu");
   }
   
   
   //HTML LVLS
   public void HTML5lvl1()
   {
       SceneManager.LoadScene("lvl1ht");
       Time.timeScale = 1f;
   }
   //Java LVLS
   public void JAVAlvl1()
   {
       SceneManager.LoadScene("lvl1ja");
       Time.timeScale = 1f;
   }
   //Python LVLS
   public void PYTHONlvl1()
   {
       SceneManager.LoadScene("lvl1py");
       Time.timeScale = 1f;

   }
   //In game MENU/UI scene transfer
   public void ResetScene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Main Menu
   public void Exitbutton()
   {
       Application.Quit();
       Debug.Log("Game closed");    
   }

   // public void tutorial()
   // {
   //     SceneManager.LoadScene("tutorial");
   // }
   
   
   //HTML LVLS
   public void HTML5lvl1()
   {
       SceneManager.LoadScene("lvl1");
   }
   //In game MENU/UI scene transfer
   public void ResetScene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }


  
}

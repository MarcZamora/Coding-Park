using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlTran : MonoBehaviour
{
 public int ilvl2load;
 public string slvl2load;
 public bool useint2loadlvl = false;

 private void OnTriggerEnter2D(Collider2D col)
   {
       if (col.tag == "Player")
       {
            LoadScene();
        }
   }
   void LoadScene()
   {
       if (useint2loadlvl)
       {
           SceneManager.LoadScene(ilvl2load);
       }
       else
       {
       SceneManager.LoadScene(slvl2load);    
       }
   }
}

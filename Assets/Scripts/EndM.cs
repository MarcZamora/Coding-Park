using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndM : MonoBehaviour
{
   public GameObject endmenu;
   public GameObject left;
   public GameObject right;
   public GameObject jump;
   public GameObject pause;
   public GameObject reset;
    // Update is called once per frame
     private void OnTriggerEnter2D(Collider2D col)
   {
       if (col.tag == "Player")
       {
            EndMenu();
        }
   }
   void EndMenu()
   {
       Time.timeScale = 0f;
       endmenu.SetActive(true);
       left.SetActive(false);
       right.SetActive(false);
       jump.SetActive(false);
       pause.SetActive(false);
       reset.SetActive(false);
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverM : MonoBehaviour
{
   public GameObject gameovermenu;
   public GameObject left;
   public GameObject right;
   public GameObject jump;
   public GameObject pause;
   public GameObject reset;
   public GameObject hint;
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
       gameovermenu.SetActive(true);
       left.SetActive(false);
       right.SetActive(false);
       jump.SetActive(false);
       pause.SetActive(false);
       reset.SetActive(false);
       hint.SetActive(false);
   }
}

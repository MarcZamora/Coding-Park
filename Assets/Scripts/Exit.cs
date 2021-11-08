using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
   [SerializeField] private Transform prevRoom;
   [SerializeField] private Transform nxtRoom;
   [SerializeField] private CameraCon Cam;
   
   private void OnTriggerEnter2D(Collider2D col)
   {
       if (col.tag == "Player")
       {
           if (col.transform.position.x >= col.transform.position.x)
                Cam.MoveToNewRoom(nxtRoom);
           else
                Cam.MoveToNewRoom(prevRoom);
       }
   }
   
}

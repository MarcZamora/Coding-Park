using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    // Room cam
    [SerializeField] private float speed;

    private float currentPosX;
    private Vector3 velocity = Vector3.zero;
    //follow player
    // [SerializeField] private Transform player;
    // [SerializeField] private float aheadDistance;
    // [SerializeField] private float cameraSpeed;
    // private float lookahead;

    private void Update()
    {
        //Room camera
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z),
         ref velocity, speed);
        // follow player
        // transform.position = new Vector3(player.position.x + lookahead, transform.position.y, transform.position.z );
        // lookahead = Mathf.Lerp(lookahead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
    
    }

    
        
    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
    }
}
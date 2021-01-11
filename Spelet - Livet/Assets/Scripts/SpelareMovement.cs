using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyPlayerMovement : MonoBehaviour
{
    [SerializeField]
    float PlayerSpeed = 4f;
    [SerializeField] 
    float PlayerRotationSpeed = 20f;
    private Transform myPlayer;
    private CharacterController myControllerPlayer;
    public AudioSource source; 
    void Awake()
    {
        myPlayer = GetComponent<Transform>();
        myControllerPlayer = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        // rotera
        float moveHorizontal = Input.GetAxis("Horizontal");
        myPlayer.Rotate(
                        0f,
                        PlayerRotationSpeed * Time.deltaTime * moveHorizontal,
                        0f
                        );
        // flytta    
        float moveVertical = Input.GetAxis("Vertical");
        myControllerPlayer.SimpleMove(myPlayer.forward * PlayerSpeed * moveVertical);
    }
}

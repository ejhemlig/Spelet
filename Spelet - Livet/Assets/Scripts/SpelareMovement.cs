using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpelareMovement : MonoBehaviour
{
    public float PlayerSpeed = 4f;
    public float PlayerRotationSpeed = 20f;
    private Transform myPlayer;
    private CharacterController myControllerPlayer;

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
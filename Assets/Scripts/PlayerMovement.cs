using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
=======
using UnityEngine.UI;
>>>>>>> ebc637f... Testing on new computer, added highscore function

public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveVector;
    private CharacterController controller;
<<<<<<< HEAD

    public float speed = 5.0f;
    public float verticalVelocity = 0.0f;
    private float gravity = 10.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
=======
    public Text scoreText;
    
    public float speed = 15.0f;
    public float verticalVelocity = 0.0f;
    private float gravity = 10.0f;
    public static float score = 0.0f;
    public static float highscore = 0.0f;
    private int nextLevel = 10;
    private int speedUp = 1;
    private float scoreSpeed = 1.0f;

    void Start()
    {
        score = 0.0f;
        controller = GetComponent<CharacterController>();

>>>>>>> ebc637f... Testing on new computer, added highscore function
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
=======
        score = score + Time.deltaTime * scoreSpeed;
        scoreText.text = ((int)score).ToString();
>>>>>>> ebc637f... Testing on new computer, added highscore function

        if (controller.isGrounded)
        {
            verticalVelocity = 0.0f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        moveVector.y = verticalVelocity;
        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);
<<<<<<< HEAD
=======

        if (score > highscore)
        {
            highscore = score;
        }

        if (score >= nextLevel)
        {
            LevelUp();
        }
        
        void LevelUp()
        {
            nextLevel += 10;
            speedUp = speedUp + 2;
            scoreSpeed = scoreSpeed + 0.5f;

            SetSpeed(speedUp); 
        }
        
        void SetSpeed(float modifier)
        {
            speed = 15.0f + modifier;
        }
    
>>>>>>> ebc637f... Testing on new computer, added highscore function
    }
}

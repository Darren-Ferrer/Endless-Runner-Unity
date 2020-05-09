using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 move;
    private CharacterController controller;
    public Text scoreText;
    
    private int nextLevel = 10;
    private int speedUp = 1;
    public float speed = 15.0f;
    private float scoreSpeed = 1.0f;

    public static float score = 0.0f;
    public static float highscore = 0.0f;
    

    void Start()
    {
        score = 0.0f;
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        score = score + Time.deltaTime * scoreSpeed;
        scoreText.text = "Score: " + ((int)score).ToString();

        move = Vector3.zero;
        move.x = Input.GetAxisRaw("Horizontal") * speed;
        move.z = speed;
        controller.Move(move * Time.deltaTime);

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
            nextLevel = nextLevel + 10;
            speedUp = speedUp + 2;
            scoreSpeed = scoreSpeed + 0.5f;

            SetSpeed(speedUp); 
        }
        
        void SetSpeed(float plusSpeed)
        {
            speed = 15.0f + plusSpeed;
        }
    
    }
}

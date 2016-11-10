﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{

    public float addSpeed;
    public float maxSpeed;
    public float speed;

    void Update()
    {
        if (speed <= maxSpeed)
        {
            speed += addSpeed * Time.deltaTime;
        }
        else if(speed > maxSpeed)
            speed = maxSpeed;

        //Restarting Scene
        if (GameObject.FindWithTag("Player") == null)
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}

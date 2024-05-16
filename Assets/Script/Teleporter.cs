using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Teleporter : MonoBehaviour

{

    public GameObject gameOver;
    

    private void Awake()

    {


    }

    private void OnTriggerEnter2D(Collider2D collision)

    {

        if (collision.CompareTag("Player"))

        {
            gameOver.SetActive(true);

        }

    }

}

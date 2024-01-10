using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript Logic;
    public birdscripy Birdy;
    public bool IsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Birdy = GameObject.FindGameObjectWithTag("Bird").GetComponent<birdscripy>();
    }

    // Update is called once per frame
    void Update()
    {
        IsAlive = Birdy.birdAlive;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsAlive)
        {
            Logic.addScore();
        }
    }
}

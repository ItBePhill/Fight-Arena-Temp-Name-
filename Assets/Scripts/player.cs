using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class player : MonoBehaviour
{
    FightArena controls;
    public float speed = 5, jumpforce, attackspeed;
    Vector2 move;
    public Transform maincam;
    private void Awake()
    {
        //Get Input
        controls = new FightArena();
        controls.Player.Move.performed += ctx => OnMove(ctx.ReadValue<Vector2>());
    }
    void OnMove(Vector2 v)
    {
        print(v);
    }
    private void Update()
    {
        //Movement
        Vector3 Right = new Vector3(maincam.forward.x * move.x, 0, 0);
        print(Right);
    }
}

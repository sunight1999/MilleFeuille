using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainManager : SingletonMono<RainManager>
{
    public RainController controller;

    protected override void Awake()
    {
        base.Awake();
        controller.BeginRain();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            (controller as ISALeftMouseClick)?.OnMouseClickSignal();
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0)
        {
            (controller as ISAHorizontalMove)?.OnHorizontalMove(horizontal);
        }

        if (vertical != 0)
        {
            (controller as ISAVerticalMove)?.OnVerticalMove(vertical);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _horizontalSpeed = 30;
    [SerializeField] private float _verdicalSpeed = 70;

    private Rigidbody2D _rigidbody;
    private Utility.Option _lastHorizontalSide = Utility.Option.Defult;
    //private bool isJumpedOnce = false;
    //private bool isJumpedTwice = false;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }
    private void FixedUpdate()
    {
        HorizontalMovement();
    }

    private void HorizontalMovement()
    {
        Utility.Option site = Utility.ChooseLastUsedOption(InputCollector.Instance.GoLeft, 
            InputCollector.Instance.GoRight , ref _lastHorizontalSide);

        if (site == Utility.Option.Option1)
        {
            HorizontalMove(-_horizontalSpeed);
        }
        if (site == Utility.Option.Option2)
        {
            HorizontalMove(_horizontalSpeed);
        }
    }

    private void HorizontalMove(float speed)
    {
        _rigidbody.AddRelativeForce(new Vector2(speed, 0));
    }

    private void Jump()
    {
        if (InputCollector.Instance.Jump)
        {
            _rigidbody.AddRelativeForce(new Vector2(0, _verdicalSpeed));
        }
    }


}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.iOS;

public class playercontrole : MonoBehaviour
{
    private Controles _controle;
    private PlayerInput _playerInput;
    private Camera _camera;
    private Vector2 _moveInput;
    private Rigidbody _rigidbody;
    [SerializeField] private object moveMutipier;

    private void OnEnable()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
        _controle = new Controles();

        _playerInput = GetComponent<PlayerInput>();
        
        _camera = Camera.main;

        _playerInput.onActionTriggered += OnActionTriggered;
    }

    private void OnDisable()
    {
        _playerInput.onActionTriggered -= OnActionTriggered;
    }

    private void OnActionTriggered(InputAction.CallbackContext obj)
    {
        if (obj.action.name.CompareTo(_controle.gameplay.movimento.name) != 0) ;

        {
            _moveInput = obj.ReadValue<Vector2>();
        }
    }

    private void Move()
    {
        _rigidbody.AddForce((_camera.transform.forward * _moveInput.y + _camera.transform.right * _moveInput.x ) * (float) moveMutipier * Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        Move();
    }
}


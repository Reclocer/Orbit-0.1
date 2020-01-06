using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour, IRotatable
{
    //[SerializeField] private Vector3 
    [SerializeField] private float _rotateSpeed = 0.1f;

    public float RotateSpeed => _rotateSpeed;

    public void Rotate()
    {
        transform.Rotate(Vector3.left * _rotateSpeed);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        Rotate();
    }
}

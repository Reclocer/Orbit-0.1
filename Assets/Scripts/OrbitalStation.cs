using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalStation : MonoBehaviour, IRotatable
{
    [SerializeField] private float _rotateSpeed;
    public float RotateSpeed => _rotateSpeed;

    public void Rotate()
    {
        transform.Rotate(Vector3.left * _rotateSpeed);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
}

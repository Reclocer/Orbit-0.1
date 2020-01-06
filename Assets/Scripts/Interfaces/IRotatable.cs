using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRotatable 
{
    float RotateSpeed { get; }

    void Rotate();        
}

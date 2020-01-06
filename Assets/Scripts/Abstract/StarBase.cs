using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StarBase : MonoBehaviour
{
    [SerializeField] protected string _starName;
    protected float _heat;
    [SerializeField]protected Transform[] _planetAnchors;

    [Header("Light")]
    [SerializeField] protected Light _pointLight;    
    protected float _intensityLight;
    protected float _rangeLight;
           
    public virtual void Start()
    {
        InitializationVariables();
    }

    private void InitializationVariables()
    {
        _intensityLight = _pointLight.intensity;
        _rangeLight = _pointLight.range;
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolutionSegments : MonoBehaviour
{
    [SerializeField] private Material _dissolveMaterial;
    private Material _dissolveMaterial2;
    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _dissolveSpeed = 0;

    private void Start()
    {
        _dissolveMaterial2 = Instantiate(_dissolveMaterial);
    }


    private void FixedUpdate()
    {
        _dissolveMaterial2.SetFloat("_Activate", _dissolveSpeed += Time.deltaTime * Time.deltaTime); 
    }

    
}

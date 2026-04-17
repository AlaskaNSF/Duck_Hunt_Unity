using System.Numerics;
using UnityEngine;

public class PatoVuelo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D FisicaDelPato;
    public UnityEngine.Vector3 Velocidad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FisicaDelPato.AddForce(Velocidad);
    }
}

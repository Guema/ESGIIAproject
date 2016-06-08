using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Joint))]
public class Muscle : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    [Tooltip("The maximum strength of the muscle. affect power consuption")]
    float power;
    [SerializeField]
    [Tooltip("Allow power stoarge, but affect the mass.")]
    float storage;
    float consumption;

    void Reset()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start ()
    {
        
    }
    
    // Update is called once per frame
    void Update ()
    {
        
    }
}

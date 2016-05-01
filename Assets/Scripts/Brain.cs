using UnityEngine;
using System.Collections;

public class Brain : MonoBehaviour
{
    [SerializeField]
    Muscle muscle;
    void Reset()
    {
        muscle = GetComponent<Muscle>();
    }

    void Start()
    {

    }

    void Update()
    {
        muscle.Body.AddTorque(CalculateForceToApply());
    }

    Vector3 CalculateForceToApply()
    {
        return Vector3.forward;
    }
}

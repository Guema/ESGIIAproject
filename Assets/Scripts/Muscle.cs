using UnityEngine;
using System.Collections;

[SelectionBase]
[RequireComponent(typeof(Rigidbody))]
public class Muscle : BodyPart
{
    [SerializeField]
    Rigidbody body;
    [SerializeField]
    Collider col;

    public Rigidbody Body
    {
        get
        {
            return body;
        }
    }

    void Reset()
    {
        body = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
    }

    // Use this for initialization
    void Start()
    {
        if (transform.parent)
        {
            parent_ = transform.parent.GetComponent<BodyPart>();
            if (parent_)
            {
                Debug.Log(parent_);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

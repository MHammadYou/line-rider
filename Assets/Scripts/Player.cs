using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;

    private bool _bodyType;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            _bodyType = true;
        }

        if (_bodyType)
        {
            rb.AddForce(transform.right * 0.5f);
        }
    }
}

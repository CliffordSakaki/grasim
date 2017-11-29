using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrGravity : MonoBehaviour
{
    public bool DoNotInflunce = false;

    public float Mass = 0.0f;

    public const float G = (float)6.674e-11;

    Rigidbody _rigidbody = null;

    // Use this for initialization
    void Start()
    {
        _rigidbody = GetComponent <Rigidbody> ();
        if (_rigidbody != null) {
            Debug.Log ("I have rigidbody.");
            // 重力停止
            _rigidbody.useGravity = false;

        }
    }
	
    // Update is called once per frame
    void Update()
    {
		
    }
}

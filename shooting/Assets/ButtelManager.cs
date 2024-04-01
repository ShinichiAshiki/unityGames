using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtelManager : MonoBehaviour
{
    private Rigidbody rb;
    public float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, 20, ForceMode.Impulse); // 一瞬力を加える
        // rb.AddForce(0, 0, 20, ForceMode.Force); // 継続的にを加える

        Destroy(gameObject, lifetime);
    }
}

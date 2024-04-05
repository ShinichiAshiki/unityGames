using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtelManager : MonoBehaviour
{
    private Rigidbody rb;
    public float lifetime;
    [SerializeField] int forceX;
    [SerializeField] int forceY;
    [SerializeField] int forceZ;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(forceX, forceY, forceZ, ForceMode.Impulse); // 一瞬力を加える
        // rb.AddForce(0, 0, 20, ForceMode.Force); // 継続的にを加える

        Destroy(gameObject, lifetime);
    }
}

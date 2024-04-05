using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameManager myManager;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}

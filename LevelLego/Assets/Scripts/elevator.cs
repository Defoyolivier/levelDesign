using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    [SerializeField] private Transform elevat;
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < 10; i++)
        {
            elevat.Translate(0, 0.1f, 0);
        }
    }
}

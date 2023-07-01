using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] GameObject Platform;

    void Start()
    {
        Instantiate
            (
             Platform,
        transform.position,
        Quaternion.identity
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

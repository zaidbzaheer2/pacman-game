using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticGO : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

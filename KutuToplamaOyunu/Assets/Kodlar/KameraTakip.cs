using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public GameObject hedef;
    public Vector3 Mesafe;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   

    }
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, hedef.transform.position + Mesafe,Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void RespawnPlayer()
    {
        transform.position = startPos;

        Debug.Log(transform.position);
        //gameObject.transform = startPos;
    }



}

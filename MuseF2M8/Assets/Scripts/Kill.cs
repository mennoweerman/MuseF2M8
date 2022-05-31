using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    private PlayerMovement movement;
    private KillConditions kill;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        movement = player.GetComponent<PlayerMovement>();
        kill = player.GetComponent<KillConditions>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        //SceneManager.LoadScene(0);
        movement.controller.enabled = false;
        kill.Respawn();
        movement.controller.enabled = true;

    }
}

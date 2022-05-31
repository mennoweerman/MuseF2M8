using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillConditions : MonoBehaviour
{
    private PlayerMovement movement;
    private Respawn kill;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        movement = player.GetComponent<PlayerMovement>();
        kill = player.GetComponent<Respawn>();
    }
    public void Respawn()
    {
        //SceneManager.LoadScene(0);
        movement.controller.enabled = false;
        kill.RespawnPlayer();
        movement.controller.enabled = true;

    }
}

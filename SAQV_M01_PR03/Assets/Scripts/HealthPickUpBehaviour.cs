using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUpBehaviour : MonoBehaviour
{
    public GameBehaviour gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameBehaviour>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            UnityEngine.Debug.Log("Healing Time!");
            gameManager.HP += 1;
        }
    }
}

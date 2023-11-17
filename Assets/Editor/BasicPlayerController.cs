using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

public class BasicPlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator attack = null;
    int attack_value = 0;
    GameObject enemy = null;
    GameObject weapon = null;
    void Start()
    {
        TouchSimulation.Enable();
        attack = GetComponent<Animator>();
        this.attack_value = 1;
        this.enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || (Input.touchCount > 0))
        {
            //enemy.GetComponent<EnemyBehaviorScript>().health = enemy.GetComponent<EnemyBehaviorScript>().health - attack_value;
            attack.Play("Attack");
        }

    }
}

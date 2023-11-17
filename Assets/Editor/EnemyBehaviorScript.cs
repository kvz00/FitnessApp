using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim = null;
    public int health = 0;
    void Start()
    {
        this.health = 10;
        anim = GetComponent<Animator>();
        anim.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Transform player;
    private Animator animator;

    public float triggerDistance = 3;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) < triggerDistance)
        {
            animator.SetBool("IsDoorOpen", true);

        }
        else
        {
            animator.SetBool("IsDoorOpen", false);
        }
    }
}

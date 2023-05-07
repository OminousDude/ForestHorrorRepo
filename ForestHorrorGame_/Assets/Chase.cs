using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public Transform target;
    public Transform self;
    public float maxDistance = 10f;
    public Transform time;
    public Animator animator;
    public AnimatorController controller;
    NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (time.eulerAngles.x > 180)
        {
            nav.SetDestination(target.position);
            animator.SetBool("Crawl", true);
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Touch");
            animator.SetBool("Attack", true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{

    public GameObject Player;
    // public AudioSource ZOMBIE;
   

    public float health = 50f;
    public int points = 20;
    public void GetDamage(float damage)
    {
         
        //  ZOMBIE.Play();
        health -= damage;
        GameObject.Find("EnemyBar") .GetComponent<Image>().fillAmount = health / 50f;

        if (health <=0)
        {
            GameManagers.instance.UpdateScore(points) ;
            Destroy(this.gameObject) ;

        }

    }
    
    NavMeshAgent agent;
     public float detectionRadius = 10f;
    private void Start()
    {
       
        
        agent = GetComponent<NavMeshAgent>();
        

    }

    // Update is called once per frame
    void Update()
    {
       
       
        float distance = Vector3 .Distance(transform. position, Player .transform. position) ;
        if (distance <= detectionRadius)
        {
            agent .SetDestination(Player .transform. position) ; 
        }
       
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos .DrawWireSphere(transform.position, detectionRadius);
    }
}

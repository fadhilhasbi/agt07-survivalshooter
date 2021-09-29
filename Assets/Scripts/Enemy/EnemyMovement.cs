using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform player;               // Reference to the player's position.
    PlayerHealth playerHealth;      // Reference to the player's health.
    EnemyHealth enemyHealth;        // Reference to this enemy's health.
    UnityEngine.AI.NavMeshAgent nav;               // Reference to the nav mesh agent.


    void Awake()
    {
        // Cari gameobject dengan tag Player.
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Mengambil komponen yang dibutuhkan pada gameobject
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    void Update()
    {
        // Jika musuh dan player memiliki health diatas 0
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            // Musuh bergerak ke arah player.
            nav.SetDestination(player.position);
        }       
        else
        {
            // Jika tidak maka gerakan dihentikan.
            nav.enabled = false;
        }
    }
}

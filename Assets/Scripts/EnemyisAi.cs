using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyNavAI : MonoBehaviour
{
    //public variables for both ranged
    public float detectionRange = 50f;
    public float attackRange = 2f;

    //private variables for navmesh again and  player position
    private NavMeshAgent agent;
    private Transform player;

    

    void Awake()
    {
        //getting component for agent
        agent = GetComponent<NavMeshAgent>();
        //getting the player game object
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        //getting the transform of player if player exsists 
        if (playerObj != null)
            player = playerObj.transform;
    }

    void Update()
    {
        //if player doesnt exsist the script ends
        if (player == null) return;
        //getting the distance between player and enemy
        float distance = Vector3.Distance(transform.position, player.position);


        //starting movement if the player is in range
        if (distance <= detectionRange)
        {
            agent.SetDestination(player.position);

        }
        //checking if player is in attack range and going to death screen
        if (distance <= attackRange)
        {
            agent.ResetPath();
            SceneManager.LoadScene("DeathScreen");
            GameObject.Destroy(player.gameObject);



        }
        //adjusting the look direction to look at the player. 
        Vector3 lookDir = (player.position - transform.position).normalized;
        lookDir.y = 0f;
        transform.rotation = Quaternion.LookRotation(lookDir);

    }
}
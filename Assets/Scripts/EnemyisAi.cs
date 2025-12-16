using UnityEngine;
using UnityEngine.AI;

public class EnemyNavAI : MonoBehaviour
{
    public float detectionRange = 50f;
    public float attackRange = 2f;

    private NavMeshAgent agent;
    private Transform player;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
            player = playerObj.transform;
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= detectionRange)
        {
            agent.SetDestination(player.position);
        }

        if (distance <= attackRange)
        {
            agent.ResetPath(); // stop moving
            // Attack logic later
        }
        Vector3 lookDir = (player.position - transform.position).normalized;
        lookDir.y = 0f;
        transform.rotation = Quaternion.LookRotation(lookDir);

    }
}
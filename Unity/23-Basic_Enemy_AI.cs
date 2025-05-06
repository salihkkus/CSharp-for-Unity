using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float chaseRange = 5f;
    public float attackRange = 1f;
    public int maxHealth = 100;
    private int currentHealth;
    
    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= chaseRange)
        {
            agent.SetDestination(player.position);
            animator.SetBool("isMoving", true);

            if (distance <= attackRange)
            {
                agent.ResetPath(); // Saldırı sırasında dur
                animator.SetTrigger("Attack");
            }
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetTrigger("Die");
        Destroy(gameObject, 2f); // 2 saniye sonra yok et (animasyon süresi)
    }
}

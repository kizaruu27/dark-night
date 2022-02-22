using UnityEngine;
using UnityEngine.AI;

public class KillerAI : MonoBehaviour
{
    NavMeshAgent Killer;
    public GameObject Player;
    public float killerDistanceRun = 4f;
    public Transform[] wayPoint;
    int wayPointIndex;
    Vector3 target;

    void Start() {
        Killer = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    void Update() {
        ChasePlayer();
        KillerPatrol();
    }

    void ChasePlayer() {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < killerDistanceRun) {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;
            Killer.SetDestination(newPos);
        } else if (distance > killerDistanceRun){
            Killer.SetDestination(target);
        }
    }

    void KillerPatrol() {
        if (Vector3.Distance(transform.position, target) < 1) {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    void UpdateDestination() {
        target = wayPoint[wayPointIndex].position;
        Killer.SetDestination(target);
    }

    void IterateWaypointIndex() {
        wayPointIndex++;
        if (wayPointIndex == wayPoint.Length) {
            wayPointIndex = 0;
        }
    }
}

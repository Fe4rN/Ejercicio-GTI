using Dapasa.FSM;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : EstadoFSM
{
    NavMeshAgent agent;
    Transform player;
    EnemyController controller;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        controller = maquina as EnemyController;
        player = controller.Player;
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, controller.Player.position) > controller.AttackDistance){
            controller.SetEstado(controller.patrolState.Value);
            return;
        }

        if(agent.remainingDistance < .4f){
            Destroy(player.gameObject);
            controller.SetEstado(controller.patrolState.Value);
            return;
        }

        agent.SetDestination(player.position);
    }
}

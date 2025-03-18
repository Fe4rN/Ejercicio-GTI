using Dapasa.FSM;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : EstadoFSM
{
    [SerializeField]
    Transform[] path;

    int currentPoint = 0;

    NavMeshAgent agent;

    EnemyController controller;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(path[currentPoint].position);
        controller = maquina as EnemyController;
    }

    private void Update()
    {

        if(controller.Player && Vector3.Distance(transform.position, controller.Player.position) < controller.AttackDistance) {
            controller.SetEstado(controller.attackState.Value);
        }

        if(agent.remainingDistance <= 0.1f){
            currentPoint++;
            agent.SetDestination(path[currentPoint % path.Length].position);
        }
    }
}

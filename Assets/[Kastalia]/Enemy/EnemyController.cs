using Dapasa.FSM;
using UnityEngine;

public class EnemyController : MaquinaFSM
{

    public StringValue patrolState;
    public StringValue attackState;
    
    [SerializeField]
    float attackDistance = 5f;

    public float AttackDistance { get { return attackDistance;}}
    Transform player;

    public Transform Player { get { return player; } }

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

}

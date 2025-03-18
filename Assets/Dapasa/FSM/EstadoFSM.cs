using UnityEngine;

namespace Dapasa.FSM
{
    /// <summary>
    /// Clase base para los estados de una m�quina de estados finitos.
    /// </summary>
    public abstract class EstadoFSM : MonoBehaviour
    {
        [SerializeField]
        StringValue nombre;

        [SerializeField]
        bool inicial = false;

        protected MaquinaFSM maquina;

        public string Nombre { get {
            if(!nombre) return "";
            return nombre.Value;} }
        public bool Inicial { get => inicial; set => inicial = value; }

        void Awake()
        {
            maquina = GetComponent<MaquinaFSM>();
            OnAwake();
        }

        protected virtual void OnAwake() { }
    }
}
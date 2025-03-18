using UnityEngine;
using UnityEngine.Events;

namespace Dapasa.FSM
{

    [DefaultExecutionOrder(-100)]
    public abstract class MaquinaFSM : MonoBehaviour
    {

        public UnityEvent<string> OnStateChanged;

        EstadoFSM[] estados;

        EstadoFSM _estado;

        public EstadoFSM Estado
        {
            get => _estado;
            set
            {
                if (_estado == value) return;
                _estado = value;
                foreach (EstadoFSM estado in estados)
                {
                    estado.enabled = (estado == _estado);
                }
                OnStateChanged.Invoke(_estado.Nombre);
            }
        }

        void Awake()
        {
            estados = GetComponents<EstadoFSM>();
            foreach (EstadoFSM estado in estados)
            {
                if (estado.Inicial) Estado = estado;
            }
            if (Estado == null) Estado = estados[0];
            OnAwake();
        }

        protected virtual void OnAwake() { }

        public void SetEstado(string nombre)
        {
            foreach (EstadoFSM estado in estados)
            {
                if (estado.Nombre == nombre)
                {
                    Estado = estado;
                    return;
                }
            }
            Debug.LogError($"No hay un estado {nombre}");
        }
    }
}
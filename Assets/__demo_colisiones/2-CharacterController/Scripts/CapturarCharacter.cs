using UnityEngine;

namespace Demo.Colisiones
{

    public class CapturarCharacter : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out CharacterController chr))
            {
                chr.transform.parent = transform;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out CharacterController chr))
            {
                chr.transform.parent = null;
            }
        }
    }

}
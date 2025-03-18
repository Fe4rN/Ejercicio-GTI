using UnityEngine;

namespace Demo.Colisiones
{

    public class CharacterHit : MonoBehaviour
    {
        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            ObstaculoColisiones obstaculo = hit.gameObject.GetComponent<ObstaculoColisiones>();
            if (obstaculo != null)
            {
                Debug.Log("Colisión del Character");
                obstaculo.CambiarColorColision();
            }
        }
    }

}
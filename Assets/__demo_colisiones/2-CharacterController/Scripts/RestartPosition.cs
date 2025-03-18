using UnityEngine;

namespace Demo.Colisiones
{

    /// <summary>
    /// Devuelve un objeto a su posición original si cae por debajo de un límite.
    /// </summary>
    public class RestartPosition : MonoBehaviour
    {
        public float limitY = -3f;

        private Vector3 startPos;

        void Start()
        {
            SetStartPos();
        }

        void LateUpdate()
        {
            if (transform.position.y < limitY) transform.position = startPos;
        }

        public void SetStartPos()
        {
            startPos = transform.position;
        }
    }
}

using UnityEngine;

namespace Demo.Colisiones
{

    public class Plataforma : MonoBehaviour
    {

        public Vector3 velocidad;

        public float distancia = 1;

        public bool empezarCentro = true;

        int sentido = 1;

        float recorrido = 0;

        private void Start()
        {
            if (empezarCentro)
            {
                recorrido = distancia / 2;
            }
        }

        void FixedUpdate()
        {
            Vector3 v = Vector3.ClampMagnitude(velocidad * (Time.deltaTime * sentido), distancia - recorrido);
            recorrido += v.magnitude;
            if (recorrido >= distancia)
            {
                recorrido = 0;
                sentido = -sentido;
            }
            transform.Translate(v);
        }
    }

}
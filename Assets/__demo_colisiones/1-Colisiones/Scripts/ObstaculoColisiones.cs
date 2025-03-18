using UnityEngine;

namespace Demo.Colisiones
{

    public class ObstaculoColisiones : MonoBehaviour
    {

        public Color colorCollision;

        public Color colorTrigger;

        Material mat;

        Color color;

        void Start()
        {
            mat = GetComponent<Renderer>().material;
            color = mat.color;
        }

        private void OnCollisionEnter(Collision collision)
        {
            CambiarColorColision();
        }

        private void OnCollisionExit(Collision collision)
        {
            RestaurarColor();
        }

        private void OnTriggerEnter(Collider other)
        {
            CambiarColorTrigger();
        }

        private void OnTriggerExit(Collider other)
        {
            RestaurarColor();
        }

        public void RestaurarColor()
        {
            mat.color = color;
        }

        public void CambiarColorColision()
        {
            mat.color = colorCollision;
        }

        public void CambiarColorTrigger()
        {
            mat.color = colorTrigger;
        }
    }

}
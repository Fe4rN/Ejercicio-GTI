using UnityEngine;

namespace Demo.Colisiones
{

    public class PersonajeColisiones : MonoBehaviour
    {

        public float velocidad = 1f;

        Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }

        void FixedUpdate()
        {
            if (rb.isKinematic)
            {
                transform.Translate(Vector3.right * (Input.GetAxis("Horizontal") / 10));
            }
            else
            {
                Vector3 v = rb.linearVelocity;
                v.x = velocidad * Input.GetAxis("Horizontal");
                rb.linearVelocity = v;
            }
        }
    }

}
using System;
using UnityEngine;

public class CargarArma : MonoBehaviour
{

    [SerializeField] Arma[] armas;
    [SerializeField] Transform mano;

    int index = 0;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            CambiarDeArma();
        }
    }

    private void CambiarDeArma()
    {
        if(mano.childCount != 0)
        {
            Destroy(mano.GetChild(0).gameObject);
        }
        Instantiate(armas[index % armas.Length], mano);
        index++;
    }
}

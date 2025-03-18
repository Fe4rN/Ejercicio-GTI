using System.Collections;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{

    [SerializeField] private Color colorCambio;
    Color colorOriginal;
    Renderer rend;

    bool cooldown = false;
    void Start()
    {
        rend = GetComponent<Renderer>();
        colorOriginal = rend.material.color;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if(!cooldown) StartCoroutine(CambiarAColorNuevo());
        }
    }

    IEnumerator CambiarAColorNuevo(){
        cooldown = true;
        rend.material.color = colorCambio;
        yield return new WaitForSeconds(1f);
        rend.material.color = colorOriginal;
        yield return new WaitForSeconds(2f);
        cooldown = false;   
    }
}

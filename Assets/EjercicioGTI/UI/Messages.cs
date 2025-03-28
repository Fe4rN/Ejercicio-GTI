using TMPro;
using UnityEngine;

public class Messages : MonoBehaviour
{
    TextMeshProUGUI m_TextMeshProUGUI;

    static Messages s_Instance;
    public static Messages Instance
    {
        get
        {
            return s_Instance;
        }
    }
    private void Start()
    {
        if(s_Instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        s_Instance = this;


        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        m_TextMeshProUGUI.text = "";
    }
    public void SetText(string text)
    {
        m_TextMeshProUGUI.text = text;
    }
}

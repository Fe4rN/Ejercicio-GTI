using UnityEngine;

[CreateAssetMenu(fileName = "StringValue", menuName = "Values/String")]
public class StringValue : ScriptableObject
{
    [SerializeField]
    private string m_Value;

    public string Value { get { return m_Value; } }
}

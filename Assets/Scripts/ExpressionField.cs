using UnityEngine;
using UnityEngine.UI;

// Minimal placeholder component for the expression input area.
// Expand this with real UI handling when ready.
public class ExpressionField : MonoBehaviour
{
    public InputField inputField;

    void Awake()
    {
        if (inputField == null)
            inputField = GetComponent<InputField>();
    }

    public string GetExpression()
    {
        return inputField != null ? inputField.text : string.Empty;
    }

    public void SetExpression(string expr)
    {
        if (inputField != null)
            inputField.text = expr;
    }
}

using UnityEngine;
using TMPro;

public class MainUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;

    public Fox fox;

    public void SaveFoxName()
    {
        fox.fox_name = inputField.text;

        if (!string.IsNullOrWhiteSpace(fox.fox_name))
        {
            Debug.Log("Player Name Saved: " + fox.fox_name);
        }
        else
        {
            Debug.LogWarning("Input field is empty! Name not saved.");
        }
    }
}

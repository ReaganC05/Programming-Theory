using TMPro;
using UnityEngine;

// INHERITANCE (The Fox is inhertiing from the Animal class)
public class Fox : Animal
{
    private int fox_speed = 10;
    private string m_fox_name = "Fox";
    
    // ENCAPSULATION (The Fox's name cannot exceed 10 characters)
    public string fox_name
    {
        get { return m_fox_name; }
        set
        {
            if(m_fox_name.Length > 10)
            {
                Debug.LogError("Fox name length cannot exceed 10 characters");
            }
            else
            {
                m_fox_name = value;
            }
        }
    }

    // POLYMORPHISM (Overriding the Move() function)
    public override void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * fox_speed);
    }

    private void Update()
    {
        Move();
    }

    public TMP_InputField inputField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            inputField.text = PlayerPrefs.GetString("PlayerName");
        }
    }
}

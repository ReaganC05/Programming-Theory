using UnityEngine;

// INHERITANCE (The Stag is inhertiing from the Animal class)
public class Stag : Animal
{
    private int stag_speed = 30;
    private string m_stag_name = "Stag";

    // ENCAPSULATION (The Stag's name cannot exceed 10 characters)
    public string stag_name
    {
        get { return m_stag_name; }
        set
        {
            if (m_stag_name.Length > 10)
            {
                Debug.LogError("Stag name length cannot exceed 10 characters");
            }
            else
            {
                m_stag_name = value;
            }
        }
    }

    // POLYMORPHISM (Overriding the Move() function)
    public override void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * stag_speed);
    }

    private void Update()
    {
        Move();
    }
}

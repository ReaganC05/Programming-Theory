using UnityEngine;

// INHERITANCE (The Dog is inhertiing from the Animal class)
public class Dog : Animal
{
    private int dog_speed = 20;
    private string m_dog_name = "Fox";

    // ENCAPSULATION (The Dog's name cannot exceed 10 characters)
    public string dog_name
    {
        get { return m_dog_name; }
        set
        {
            if (m_dog_name.Length > 10)
            {
                Debug.LogError("Fox name length cannot exceed 10 characters");
            }
            else
            {
                m_dog_name = value;
            }
        }
    }

    // POLYMORPHISM (Overriding the Move() function)
    public override void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * dog_speed);
    }

    private void Update()
    {
        Move();
    }
}

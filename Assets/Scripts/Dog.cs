using UnityEngine;

// INHERITANCE (The Dog is inhertiing from the Animal class)
public class Dog : Animal
{
    private int dog_speed = 20;

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

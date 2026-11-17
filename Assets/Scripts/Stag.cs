using UnityEngine;

// INHERITANCE (The Stag is inhertiing from the Animal class)
public class Stag : Animal
{
    private int stag_speed = 30;

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

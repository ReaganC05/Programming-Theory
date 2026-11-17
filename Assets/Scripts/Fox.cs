using UnityEngine;

// INHERITANCE (The Fox is inhertiing from the Animal class)
public class Fox : Animal
{
    private int fox_speed = 10;

    // POLYMORPHISM (Overriding the Move() function)
    public override void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * fox_speed);
    }

    private void Update()
    {
        Move();
    }
}

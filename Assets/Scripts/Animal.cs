using UnityEngine;

public class Animal : MonoBehaviour
{
    private int speed = 0;
    public virtual void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void Update()
    {
        Move();
    }
}

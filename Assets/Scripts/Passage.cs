using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Passage : MonoBehaviour
{
    public Transform connection;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = connection.position;
    }

}

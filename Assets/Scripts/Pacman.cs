using System;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Pacman : MonoBehaviour
{
    
    public Movement movement { get; private set; }

    void Awake()
    {
        movement = GetComponent<Movement>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            movement.SetDirection(Vector2.up);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            movement.SetDirection(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            movement.SetDirection(Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            movement.SetDirection(Vector2.left);
        }

        RotatePacman(movement.direction);
    }
    private void RotatePacman(Vector2 direction)
    {
        float angle = Mathf.Atan2(direction.y, direction.x);
        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
    }

    public void ResetState()
    {
        enabled = true;
        movement.ResetState();
        gameObject.SetActive(true);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbdy;
    public SpriteRenderer sprite;
    
    private void start()
    {
        rbdy = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerMovement(rbdy);
    }

    private void PlayerMovement(Rigidbody rigidbody)
    {
        if (Input.GetKey("d"))
        {
            sprite.flipX = false;
            rigidbody.velocity = new Vector2(5, rigidbody.velocity.y);
        }

        if (Input.GetKey("a"))
        {
            rigidbody.velocity = new Vector2(-5, rigidbody.velocity.y);
        }

        if (Input.GetKey("space"))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 10);
        }
        else
        {
            return;
        }
    }
}
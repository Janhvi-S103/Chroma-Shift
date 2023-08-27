using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpforce = 10f;
    public Rigidbody2D rb;
        void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpforce;
        }
    }
}

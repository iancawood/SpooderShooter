using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField]
    private Rigidbody2D rb;
    // position
    private float x, y = 0;
    public bool isGrounded = false;
    // force
    private float gravity = 0.1f;
    private float speed = 5f;
    private float quadStrength = 15f;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {

        // walk
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x -= speed * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.RightArrow))
        {
            x += speed * Time.deltaTime;
        }
        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                y += quadStrength * Time.deltaTime;
                isGrounded = false;
            }
        }
        else
        {
            y -= speed * Time.deltaTime;
        }
        

        rb.MovePosition(new Vector2(x, y));
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            isGrounded = true;
        }
    }
}

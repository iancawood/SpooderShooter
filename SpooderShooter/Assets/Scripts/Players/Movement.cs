using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField]
    private float speed = 1;
    private CharacterController controller; 

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update () {
        Vector2 moveDirection = new Vector2(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
            ); 
        controller.Move(moveDirection * speed * Time.deltaTime);
    }
}

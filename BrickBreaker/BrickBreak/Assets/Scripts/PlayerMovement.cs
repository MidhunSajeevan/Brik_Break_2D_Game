using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    float HorizontalMovement;
    public float Maxx;

    void Update()
    {
        HorizontalMovement = Input.GetAxis("Horizontal");
        if ((HorizontalMovement > 0 && transform.position.x < Maxx) || (HorizontalMovement < 0 && transform.position.x > -Maxx))
        {
            transform.position += Vector3.right * HorizontalMovement * speed * Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMove : MonoBehaviour {

    private Rigidbody2D rigidbody2D;
    private float startGravity;
    [SerializeField]
    private float m_MaxGravity = 4;
    [SerializeField]
    private float m_Step = 10;
    [SerializeField]
    private float m_Speed = 2;

    private float startFriction;

    private Vector2 prevPos;
    private int frameCounter = 30;
    private bool isCollided = false;

    [SerializeField]
    private GameObject m_Swoosh;


    void Start () {

        rigidbody2D = this.GetComponent<Rigidbody2D>();
        startGravity = rigidbody2D.gravityScale;
        startFriction = rigidbody2D.sharedMaterial.friction;
	}

	void Update () {

        float deltaTime = Time.deltaTime;

        if (frameCounter > 0)
        {
            frameCounter--;
        }
        else if (frameCounter == 0)
        {
            frameCounter = 10;

            Vector3 diff = gameObject.transform.position - (Vector3)prevPos;
            if (diff.magnitude < 1f)
            {
                rigidbody2D.AddForce(Vector2.right * deltaTime * m_Speed, ForceMode2D.Impulse);
            }
            else if (diff.magnitude > 2.5f && diff.y < 0f && isCollided)
            {
                GameObject gameObject = Instantiate(m_Swoosh);
                gameObject.SetActive(true);
                gameObject.transform.SetParent(m_Swoosh.transform.parent);
                gameObject.transform.position = m_Swoosh.transform.position;
                gameObject.transform.localScale = m_Swoosh.transform.localScale;
                Destroy(gameObject, 1f);
                rigidbody2D.AddForce(Vector2.right * 2.4f, ForceMode2D.Impulse);
            }
            prevPos = gameObject.transform.position;
            isCollided = false;
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {

            if (rigidbody2D.gravityScale <= m_MaxGravity)
            {
                rigidbody2D.gravityScale += rigidbody2D.gravityScale / m_Step;
            }
        }
        else if (rigidbody2D.gravityScale > startGravity)
        {

            rigidbody2D.gravityScale -= rigidbody2D.gravityScale / m_Step;
        }
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Foreground")
        {
            isCollided = true;
        }
    }

}

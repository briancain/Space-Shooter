using UnityEngine;
using System.Collections;

public abstract class Actor : MonoBehaviour {

  private Rigidbody2D rb;

  // Use this for initialization
  protected virtual void Start() {
    rb = gameObject.GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update() {
  }

  // Collision detection
  void OnTriggerEnter2D(Collider2D coll) {
    rb.velocity = Vector2.zero;
  }

  // Collision detection
  void OnTriggerStay2D(Collider2D coll) {
    rb.velocity = Vector2.zero;
  }

  void RepositionActor() {
    Vector2 newPosition = rb.position;

    if (rb.position.x > 10.5f) {
      newPosition.x = -10.5f;
    } else if (rb.position.x < -10.5f) {
      newPosition.x = 10.5f;
    } else if (rb.position.y > 5f) {
      newPosition.y = -5f;
    } else if (rb.position.y < -5f) {
      newPosition.y = 5f;
    }

    rb.position = newPosition;
  }

  protected virtual void Move(float velocityX, float velocityY) {
    rb.velocity = new Vector2 (velocityX, velocityY);

    RepositionActor();
  }

  protected virtual void Attack() {
  }
}

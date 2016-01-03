using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

  private BoxCollider2D boxCollider;
  private Rigidbody2D rb2D;

  private Transform player;

  void Start() {
    boxCollider = GetComponent<BoxCollider2D>();
    rb2D = GetComponent<Rigidbody2D>();
  }

  void Update() {
    Move();
  }

  void Move() {
    float playerX = player.position.x;
    if (rb2D.position.y <= 5f) {
      rb2D.velocity = new Vector2(playerX, 2f);
    } else {
      Destroy(gameObject);
    }
  }
}

using UnityEngine;
using System.Collections;

public class Player : Actor {

  public float playerSpeed;
  public Transform projectile;

  private int fireDelay;

  protected override void Start() {
    base.Start();
  }

  void Update() {
    if (Input.GetButtonDown("Fire1")) {
      Attack();
    }

    Move();
  }

  private void Move() {
    float velocityX = Input.GetAxisRaw("Horizontal") * playerSpeed;
    float velocityY = Input.GetAxisRaw("Vertical") * playerSpeed;

    base.Move(velocityX, velocityY);
  }

  protected override void Attack() {
    Vector3 playerPosition = transform.position;
    playerPosition.y += 0.5f;
    Instantiate(projectile, playerPosition, Quaternion.identity);
  }
}

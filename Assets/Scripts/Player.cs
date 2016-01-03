using UnityEngine;
using System.Collections;

public class Player : Actor {

  public float playerSpeed;

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
    float velocityX = Input.GetAxisRaw ("Horizontal") * playerSpeed;
    float velocityY = Input.GetAxisRaw ("Vertical") * playerSpeed;

    base.Move(velocityX, velocityY);
  }

  protected override void Attack() {
    Debug.Log("Pew pew");
    //Projectile projectile = new Projectile();
  }
}

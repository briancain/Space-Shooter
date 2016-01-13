using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : Actor {

  private float velocityX;
  private float velocityY;

  protected override void Start() {
    velocityX = 0f;
    velocityY = Random.Range(-5, 0);

    base.Start();
  }

  void Update() {
    base.Move(velocityX, velocityY);
  }

  void OnTriggerEnter2D(Collider2D coll) {
    if (coll.gameObject.tag == "Projectile") {
      Debug.Log("Boom!");
      Destroy(gameObject);
      Destroy(coll.gameObject);
    }
  }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Meteor : Actor {
  private float velocityX;
  private float velocityY;

  protected override void Start() {
    velocityX = Random.Range(-1, 2);
    velocityY = Random.Range(-1, 2);
    Debug.Log(velocityX + " " + velocityY);
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

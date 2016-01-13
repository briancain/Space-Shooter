using UnityEngine;
using System.Collections;

public class Enemy : Actor {

  void Update() {
    Move();
  }

  void Move() {

  }

  void OnTriggerEnter2D(Collider2D coll) {
    if (coll.gameObject.tag == "Projectile") {
      Debug.Log("Boom!");
      Destroy(gameObject);
      Destroy(coll.gameObject);
    }
  }
}

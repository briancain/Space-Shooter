using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

  public GameObject player;
  public GameObject enemy;
  public GameObject meteor;

  private int score;
  private List<Enemy> enemies;


  void InitGame() {
    Instantiate(player, new Vector3(0f, -3.5f, 0f), Quaternion.identity);
    Instantiate(enemy, new Vector3(3.0f, 2.0f, 0f), Quaternion.identity);
  }

  void Awake() {
    InitGame();
  }
}

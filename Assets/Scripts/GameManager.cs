using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

  public GameObject player;
  public GameObject enemy;
  public GameObject[] enemyArr;
  public GameObject meteor;

  private int score;
  private int enemyTotal;

  void InitGame() {
    Instantiate(player, new Vector3(0f, -3.5f, 0f), Quaternion.identity);

    enemyTotal = 3;
    GenerateEnemyList(enemyTotal);
  }

  void GenerateEnemyList(int size) {
    enemyArr = new GameObject[size];

    for (int i = 0; i < size; i++) {
      Vector3 randomPos = new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), 0f);
      enemyArr[i] = (GameObject)Instantiate(enemy, randomPos, Quaternion.identity);
    }
  }

  void Awake() {
    InitGame();
  }
}

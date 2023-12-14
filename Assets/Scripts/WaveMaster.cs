using System.Collections;
using UnityEngine;
using TMPro;
using System;

public class WaveMaster : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timeBetweenWaves = 5f;
    private float countDown = 2f;
    private int waveIndex = 0;
    public Transform spawnPoint;
    public TextMeshProUGUI waveCountDowntText;

    void Update() {
        if(countDown <= 0f) {
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        }
        countDown -= Time.deltaTime;
        waveCountDowntText.text = MathF.Round(countDown).ToString();
    }

    IEnumerator SpawnWave() {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++) {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy() {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}

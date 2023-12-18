using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;
    public int health = 100;
    public int value = 50;
    void Start() {
        target = WayPoint.points[0];
    }

    public void TakeDamage(int amount) {
        health -= amount;
        if (health <= 0) {
            Die();
        }   
    }

    void Die() {
        PlayerStats.Money += value;
        Destroy(gameObject);
    }

    void Update() {
        Vector3 dir = target.position - transform.position;     
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) <= 0.2f) {
            GetNextWayPoint();
        }
    }

    private void GetNextWayPoint() {
        if(wavepointIndex >= WayPoint.points.Length - 1) {
            Destroy(gameObject);
            EndPath(); 
            return;
        }
        wavepointIndex++;
        target = WayPoint.points[wavepointIndex];   
    }
    void EndPath() {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}

using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public float spawnTime = 3f;
    //public Transform[] spawnPoints; -> Disable karena diganti menggunakan Factory Pattern

    [SerializeField]
    EnemyFactory factory;
    IFactory Factory { get { return factory as IFactory; } }

    void Start ()
    {
        //Mulai eksekusi fungsi spawn untuk beberapa detik sesuai nilai SpawnTime
        InvokeRepeating(nameof(Spawn), spawnTime, spawnTime);
    }


    void Spawn ()
    {
        // Jika player mati tidak akan spawn enemy baru
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        //Mendapatkan nilai random
        //int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int spawnEnemy = Random.Range(0, 3);

        //Menduplikasi enemy
        Factory.FactoryMethod(spawnEnemy);
    }
}

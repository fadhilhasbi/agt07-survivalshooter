using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    public GameObject[] enemyPrefab;

    public GameObject FactoryMethod(int tag)
    {
        GameObject enemy = Instantiate(enemyPrefab[tag]);
        return enemy;
    }
}

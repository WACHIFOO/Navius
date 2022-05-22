using UnityEngine;

namespace Enemy
{
    public class EnemyInstance : MonoBehaviour
    {
        public GameObject enemyPrefab;
        private bool _anyEnemy;

        // Start is called before the first frame update
        private void Start()
        {
            Invoke("SpawnEnemy", 1f);
            Invoke("SpawnEnemy", 2f);
            Invoke("SpawnEnemy", 3f);
        }


        // Spawneamos el enemigo tiempo y posicion aleatoria
        private void SpawnEnemy()
        {
            if (null == enemyPrefab) return;
            Debug.Log("Spawn Enemy");
            var randomPosition = new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-0.7f, 0.7f), 0);
            var enemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);

            var enemyComponent = enemy.GetComponent<Enemy>();
            enemyComponent.livingTime = Random.Range(1f, 5f);
        }
    }
}
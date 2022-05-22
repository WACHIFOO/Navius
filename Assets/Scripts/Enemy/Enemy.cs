using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        private GameObject _player;
        public GameObject bulletPrefab;
        public float livingTime;

        // Apuntamos al jugador
        private void Awake()
        {
            _player = GameObject.FindWithTag("Player");
        }

        // Start is called before the first frame update
        private void Start()
        {
            Invoke("Shoot", 1f);
            Invoke("Shoot", 1.5f);
            Invoke("Shoot", 2f);
            Destroy(this.gameObject, livingTime);
        }

        // Instanciamos la bala (Apuntamos y disparamos)
        private void Shoot()
        {
            var actualPosition = transform.position;

            var bullet = Instantiate(bulletPrefab, actualPosition, Quaternion.identity);
            var bulletComponent = bullet.GetComponent<Bullet.SimpleBullet>();

            var aimToPlayer = _player.transform.position - actualPosition;
            Debug.Log("Calculo punteria: \n Posicion Jugador: "+_player.transform.position+"\n Posicion Actual: "+actualPosition+" RESTA: "+aimToPlayer);
            bulletComponent.direction = aimToPlayer;
        }
    }
}
using UnityEngine;

namespace Bullet
{
    public class SimpleBullet : MonoBehaviour
    {
        public float speed = 2f;
        public float livingTime = 4f;
        public Vector2 direction;

        // Start is called before the first frame update
        private void Start()
        {
            Destroy(gameObject, livingTime);
        }

        private void Update()
        {
            Shoot();
        }

        //Movemos la bala por el escenario
        private void Shoot()
        {
            var movement = direction.normalized * (speed * Time.deltaTime);
            transform.Translate(movement);
        }
    }
}
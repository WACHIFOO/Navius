using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        public float livingTime = 1f;
        
        // Start is called before the first frame update
        private void Start()
        {
            Destroy(this.gameObject, livingTime);
        }

        void Update()
        {
        }
    }
}
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        public float speed;

        // Start is called before the first frame update
        // void Start()
        // {
        // }

        // Update is called once per frame
        private void Update()
        {
            // Movement
            var keyboardInput = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.Translate(keyboardInput * (speed * Time.deltaTime));
        }
    }
}
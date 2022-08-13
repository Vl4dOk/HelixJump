using UnityEngine;

namespace Menu.Menu_DefeatScreen
{
    public class Particles : MonoBehaviour
    {
        [SerializeField] string _path;
        private Transform _camera;

        private void Awake()
        {
            GlobalEventManager.Event_PlayerDied += ActivateParticles;

        }


        private void ActivateParticles()
        {
            _camera = FindObjectOfType<Camera>().transform;
            GameObject Particles = Instantiate(Resources.Load<GameObject>(_path), _camera); Particles.transform.localPosition = new Vector3(0, 0, 5);
        }
    }
}
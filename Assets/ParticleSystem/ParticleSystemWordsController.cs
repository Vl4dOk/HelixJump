using UnityEngine;

public class ParticleSystemWordsController : MonoBehaviour
{
    [SerializeField] private GameObject[] _letters;
    [SerializeField] private byte _destroyTime = 5;

    private void Start()
    {
        for (int i = 0; i < _letters.Length; i++)
        { _letters[i].GetComponent<ParticleSystem>().Play(); }
        Destroy(gameObject, _destroyTime);
    }

}

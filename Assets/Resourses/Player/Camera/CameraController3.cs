using UnityEngine;

public class CameraController3 : MonoBehaviour
{
    //Данный скрипт основан и работает как второй но задержки нет (мне удалось сделать то что хотел) 

    [SerializeField] private GameObject character;
    [SerializeField] private float heightDifference = 2;
    private float speed;

    private void FixedUpdate()
    {
        if (character.transform.position.y + heightDifference < gameObject.transform.position.y)
        {
            speed = (character.transform.position.y + heightDifference) - gameObject.transform.position.y;
        }

        if (character.transform.position.y + heightDifference < gameObject.transform.position.y)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + speed, gameObject.transform.position.z);
            speed += Time.deltaTime;
}   }   }
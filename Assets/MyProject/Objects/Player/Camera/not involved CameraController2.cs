using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    //Почти аналогичная ситуация, хоть и лучше чем с первым вариантом
    //1.Камера запоминает самую никую точку на которой был персонаж
    //2.Камера начинает резкое снижение и постепенно скорость снижения уменьшается, но чтото я делаю явно не так, из-за чего не выходит сделать камеру как в игре (самостоятельно по крайней мере)
    //3.У камеры присутствует не понятная мне задержка, т.е. камера не снижается до того как игрок не коснётся яруса, и если он пролетит один ярус то не увидит следующий...

    [SerializeField] private GameObject character;
    private float endPosition = 100;
    private float speed;

    private void FixedUpdate()
    {
        if (character.transform.position.y < endPosition)
        { endPosition = character.transform.position.y;
            speed = character.transform.position.y - endPosition;           
        }

        if (gameObject.transform.position.y > endPosition)
        {
            gameObject.transform.position = new Vector3 (gameObject.transform.position.x , gameObject.transform.position.y +  speed  , gameObject.transform.position.z);
            speed -= Time.deltaTime;
        }
    }

}

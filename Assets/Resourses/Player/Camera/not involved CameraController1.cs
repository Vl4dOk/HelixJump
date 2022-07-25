using UnityEngine;

/*ѕридуманный мной вариант рабочий но он €вно не подходит дл€ данной игры так как камера опускаетс€, или слишком сильно, или слишком медленно  (сделано на гравитации и Drag)*/ 
//1. амера запоминает самую никую точку на которой был персонаж
//2.” камеры включаетс€ гравитаци€ пока камера не опуститс€ до данной точки
//3.√равитаци€ выключаетс€ и камера плавно останавливаетс€ за счЄт Drag

public class CameraController1 : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] private Rigidbody _cameraTransform;

    private float transformPositionY = 10;

    
    private void FixedUpdate()
    {
        if (character.position.y < _cameraTransform.position.y && character.position.y < transformPositionY)
        {
            transformPositionY = character.position.y - 1;
        }

        if (transformPositionY + 8 < _cameraTransform.position.y)
        {
            _cameraTransform.useGravity = true;
        }
        else
        { _cameraTransform.useGravity = false; }

    }
}

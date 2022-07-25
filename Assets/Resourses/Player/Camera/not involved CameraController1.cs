using UnityEngine;

/*����������� ���� ������� ������� �� �� ���� �� �������� ��� ������ ���� ��� ��� ������ ����������, ��� ������� ������, ��� ������� ��������  (������� �� ���������� � Drag)*/ 
//1.������ ���������� ����� ����� ����� �� ������� ��� ��������
//2.� ������ ���������� ���������� ���� ������ �� ��������� �� ������ �����
//3.���������� ����������� � ������ ������ ��������������� �� ���� Drag

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

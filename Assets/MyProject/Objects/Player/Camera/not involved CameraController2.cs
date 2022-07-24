using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    //����� ����������� ��������, ���� � ����� ��� � ������ ���������
    //1.������ ���������� ����� ����� ����� �� ������� ��� ��������
    //2.������ �������� ������ �������� � ���������� �������� �������� �����������, �� ����� � ����� ���� �� ���, ��-�� ���� �� ������� ������� ������ ��� � ���� (�������������� �� ������� ����)
    //3.� ������ ������������ �� �������� ��� ��������, �.�. ������ �� ��������� �� ���� ��� ����� �� ������� �����, � ���� �� �������� ���� ���� �� �� ������ ���������...

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

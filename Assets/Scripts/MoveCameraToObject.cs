using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraToObject : MonoBehaviour
{
    public float smoothSpeed = 0.5f;

    private int i = 0;
    public Vector3[] targetPosition;

    private int j = 0;
    [SerializeField] public Quaternion[] targetRotation;

    [SerializeField] public Canvas canvasMainMenu;
    [SerializeField] public Canvas canvasCloseMenu;

    private Coroutine currentCoroutine;

    // МОИ ПЕРЕМЕННЫЕ 
    public float switchDuration;
    public float switchTime;
    public bool isSwitching = false;
    public Transform cameraTransform;
    private Vector3 savedCameraPosition;
    //

    public void StartTheActiom()
    {
        MoveToPosition(targetPosition[i]);
    }

    public void MoveToPosition(Vector3 newPosition)
    {
        cameraTransform = Camera.main.transform;
        savedCameraPosition = cameraTransform.position;

        if (currentCoroutine != null)
        {
            StopCoroutine(currentCoroutine);
        }
        currentCoroutine = StartCoroutine(SmoothMove(newPosition));
    }

    private IEnumerator SmoothMove(Vector3 endPos)
    {
        float distance = Vector3.Distance(transform.position, endPos);

        //МОИ ФУНкции
        switchTime = Time.time;
        // Устанавливаем флаг смены в true
        isSwitching = true;
        // Вызываем метод для возврата к первой камере через switchDuration секунд
        Invoke("ReturnToFirstCamera", switchDuration);
        //
        canvasMainMenu.enabled = false;
        canvasCloseMenu.enabled = false;

        while (distance > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, endPos, smoothSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation[j], smoothSpeed * Time.deltaTime);
            distance = Vector3.Distance(transform.position, endPos);
            yield return null;
        }
        i += 1;
        j += 1;

        // Окончательная позиция может быть несколько отличающейся от заданной точки,
        // так что мы корректируем позицию, чтобы точно совпадать с конечной точкой.
        transform.position = endPos;
    }
    private void ReturnToFirstCamera()
    {
        // Сбрасываем флаг смены камер
        isSwitching = false;
        cameraTransform.position = savedCameraPosition;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        canvasMainMenu.enabled = true;
        canvasCloseMenu.enabled = true;

    }
}

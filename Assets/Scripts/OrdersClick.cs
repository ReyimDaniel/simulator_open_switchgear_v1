using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Threading.Tasks;
using TMPro;
using UnityEngine.SceneManagement;

public class OrdersClick : MonoBehaviour
{
    public List<Button> sequence = new List<Button>();
    private int currentIndex = 0;
    public event Action OnCorrectSequence;
    public event Action OnIncorrectSequence;
    public List<ParticleSystem> particleSystems = new List<ParticleSystem>();
    [SerializeField] public AudioSource Expl;
    [SerializeField] public Canvas canvInError;
    [SerializeField] public Canvas canvInWork;
    [SerializeField] public Camera cameraMain;
    [SerializeField] public Camera cameraAddit;
    [SerializeField] public TextMeshProUGUI textSucces;


    public void CheckSequence(Button buttonPressed)
    {
        if (buttonPressed == sequence[currentIndex])
        {
            currentIndex++;
            if (currentIndex == sequence.Count)
            {
                OnCorrectSequence?.Invoke();
                currentIndex = 0;
                Debug.Log("Правильная последовательность нажатий!");
                textSucces.enabled = true;
            }
        }
        else
        {
            OnIncorrectSequence?.Invoke();
            Debug.Log("Ошибка в последовательности!");
            currentIndex = 0;
            canvInWork.enabled = false;
            cameraMain.enabled = false;
            canvInError.enabled = true;
            cameraAddit.enabled = true;

            foreach (ParticleSystem ps in particleSystems)
            {
                ps.Play();
            }
            Expl.Play();
        }
    }
    public void ReloadScene1()
    {
        // Получаем название активной сцены
        string currentSceneName = SceneManager.GetActiveScene().name;
        // Перезапускаем сцену
        SceneManager.LoadScene(currentSceneName);
    }
}
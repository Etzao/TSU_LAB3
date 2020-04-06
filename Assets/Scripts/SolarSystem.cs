using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BodyType { Sun, Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto}

public class SolarSystem : MonoBehaviour
{
    public const float DayInSec = 0.2f;//Время в секундах означающее 1 земные сутки
    private static float timer = 0;//Обнуляемый таймер

    private static List<IHeavenBody> heavenBodies = new List<IHeavenBody>();//Список зарегистрированных планет

    /// <summary>
    /// Метод регистрирует небесный объект. С уникальным значением BodyType.
    /// </summary>
    /// <param name="body">Скрипт привязанный к небесному телу</param>
    public static void RegisterBody(IHeavenBody body) {
        for (int i = 0; i < heavenBodies.Count; i++)
        {
            if (heavenBodies[i].BodyType == body.BodyType) {
                //throw new System.Exception("Данное небесное тело уже зарегистрированно.");
                return;
            }
        }
        heavenBodies.Add(body);
    }


    /// <summary>
    /// Метод вызываемый каждый кадр
    /// </summary>
    void Update()
    {
        if (timer > DayInSec)
        {
            timer = 0;
            PingAllBody();
        }
        timer += Time.deltaTime;
    }


    /// <summary>
    /// Метод вращает все зарегистрированные объекты.
    /// </summary>
    private static void PingAllBody() {
        foreach (var body in heavenBodies)
        {
            body.RotateOneDay();
        }
    }
}

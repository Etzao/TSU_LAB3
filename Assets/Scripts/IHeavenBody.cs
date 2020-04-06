using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHeavenBody
{
    /// <summary>
    /// Тип небесного тела.
    /// </summary>
    BodyType BodyType { get; }
    /// <summary>
    /// Передвинуть объект по оси вращения на длину пути проходимого за одни земные сутки.
    /// </summary>
    void RotateOneDay();
}

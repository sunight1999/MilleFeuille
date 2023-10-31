using UnityEngine;

public abstract class RainController : MonoBehaviour
{
    /// <summary>
    /// �� ������.
    /// </summary>
    public abstract void BeginRain();

    /// <summary>
    /// �� �����.
    /// </summary>
    public abstract void EndRain();
}
using UnityEngine;

public class test : MonoBehaviour, IMyInterface
{
    [SerializeReference, SerializeInterface] public IMyInterface a;
    // [SerializeField, SerializeInterface] private Object b;
    public int c => 1;
}

public interface IMyInterface
{
    public int c { get; }
}

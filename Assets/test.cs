using UnityEngine;

public class test : MonoBehaviour, IMyInterface
{
    [SerializeReference, SerializeInterface] private IMyInterface a;
    // [SerializeField, SerializeInterface] private Object b;
}

public interface IMyInterface
{
    
}

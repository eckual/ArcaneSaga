using UnityEngine;

namespace Core
{
    public abstract class BaseMonoBehaviour : MonoBehaviour
    {
        protected abstract void ReleaseReferences();
        private void OnDestroy() => ReleaseReferences();
        
    }
}
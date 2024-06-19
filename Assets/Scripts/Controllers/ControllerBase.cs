using Core;

namespace Controllers
{
    public abstract class ControllerBase : BaseMonoBehaviour
    {
        protected override void ReleaseReferences()
        {
        }

        public abstract void Initialize();

    }
}


using System;

namespace SOLID.LiskovSubstitution.BadCode
{
    class Program
    {
        void Start()
        {
            ParentClass pc = new NaughtyChildClass();

            int result = pc.GetResult(10);
        }
    }

    class ParentClass
    {
        public virtual int GetResult(int data)
        {
            return data + 1;
        }
    }

    class NaughtyChildClass : ParentClass
    {
        private int specialValue;
        private bool isInitialized = false;
        public void RequiredInitialSetup(int x)
        {
            specialValue = x;
            isInitialized = true;
        }

        public override int GetResult(int data)
        {
            if (isInitialized == false)
                throw new InvalidOperationException("You should have initialized");

            return base.GetResult(data) + specialValue;
        }
    }
}

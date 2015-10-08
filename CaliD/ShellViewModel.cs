namespace CaliD {
    public class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell {

         
        private int _count = 50;

        public int Count
        {
            get { return _count; }
            set
            {

                _count = value;
                NotifyOfPropertyChange(() => Count);
                NotifyOfPropertyChange(() => CanIncrementCount);

            }
        }

        public void IncrementCount()
        {
            Count++;
        }

        public bool CanIncrementCount
        {
            get { return Count < 100; }
        }



    }
}
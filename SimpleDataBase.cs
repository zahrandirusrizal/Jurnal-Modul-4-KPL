using System;

namespace mod4
{
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T dataBaru)
        {
            this.storedData.Add(dataBaru);
            this.inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            foreach (T data_generic in this.storedData)
            {
                foreach(DateTime waktu in this.inputDates)
                {
                    Console.WriteLine("Data Yang Berisi : " + data_generic + " disimpan pada waktu : " + waktu);
                }
            }
            
        }
            

    }
}

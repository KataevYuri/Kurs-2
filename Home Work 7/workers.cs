using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_7
{
    struct Worker
    {
        public int Id { get; set; }
        public string FIO { get; set; }
    }

    internal class Repository
    {

        //private Worker[] workers = new Worker[0];
        private const string FileName = "rep.txt";

        public Worker[] GetAllWorkers()
            {
                return null;
            }

            public Worker GetWorkerById(int id)
            {
                // происходит чтение из файла, возвращается Worker
                // с запрашиваемым ID
            }

            public void DeleteWorker(int id)
            {
                // считывается файл, находится нужный Worker
                // происходит запись в файл всех Worker,
                // кроме удаляемого
            }

            public void AddWorker(Worker worker)
            {
                // присваиваем worker уникальный ID,
                // дописываем нового worker в файл
            }

            public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
            {
                // здесь происходит чтение из файла
                // фильтрация нужных записей
                // и возврат массива считанных экземпляров
            }
        
    }
   
}

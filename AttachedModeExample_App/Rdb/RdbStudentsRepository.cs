using AttachedModeExample_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttachedModeExample_App.Rdb
{
    // RdbStudentsRepository - класс, реализующий операции со студентами в СУБД MS SQL Server
    // в присоединном режиме
    // соединение с БД открывается в момент создания экземпляра
    // закрывается в методе Dispose
    internal class RdbStudentsRepository : IStudentsRepository
    {
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

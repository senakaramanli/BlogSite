using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        Writer GetById(int id);
        void WriterAdd(Writer writer);
        void WriterUpdate(Writer writer);
        void WriterRemove(Writer writer);

    }
}

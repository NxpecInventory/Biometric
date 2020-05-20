using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_application
{
    class MarkAttendence
    {
        public string Studentid { get; set; }
        public string Name { get; set; }
        public byte[] PrintBinary { get; set; }

        
        public int Id { get; set; }
 
        public int ClassId { get; set; }
        public string Classname { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dataofattendance { get; set; }


      
        public int StatusId { get; set; }
      

        public string Remarks { get; set; }

    }
}

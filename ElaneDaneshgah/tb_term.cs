//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElaneDaneshgah
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_term
    {
        public tb_term()
        {
            this.tb_exception = new HashSet<tb_exception>();
        }
    
        public int id { get; set; }
        public string teacherID { get; set; }
        public int courseID { get; set; }
        public int classroomID { get; set; }
        public string Day { get; set; }
        public string Start_time { get; set; }
        public string end_time { get; set; }
        public string Description { get; set; }
    
        public virtual tb_classroom tb_classroom { get; set; }
        public virtual ICollection<tb_exception> tb_exception { get; set; }
        public virtual tb_teacher tb_teacher { get; set; }
        public virtual tbl_course tbl_course { get; set; }
    }
}

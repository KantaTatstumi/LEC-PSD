//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LEC_PSD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public int Answer_Id { get; set; }
        public int Question_Id { get; set; }
        public string Answer1 { get; set; }
        public string Option_1 { get; set; }
        public string Option_2 { get; set; }
        public string Option_3 { get; set; }
        public string Student_Answer { get; set; }
    
        public virtual Question Question { get; set; }
    }
}

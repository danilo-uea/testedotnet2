//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleTeste
{
    using System;
    using System.Collections.Generic;
    
    public partial class Desenvolvedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Desenvolvedor()
        {
            this.LancamentoHoras = new HashSet<LancamentoHoras>();
            this.Projeto = new HashSet<Projeto>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LancamentoHoras> LancamentoHoras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projeto> Projeto { get; set; }
    }
}
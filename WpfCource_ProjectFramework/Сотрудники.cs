//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfCource_ProjectFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Сотрудники
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудники()
        {
            this.Выдача_книг = new HashSet<Выдача_книг>();
        }
    
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string Отчество { get; set; }
        public int Номер_сотрудника { get; set; }
        public string Должность { get; set; }
        public string Логин { get; set; }
        public Nullable<int> Пароль { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Выдача_книг> Выдача_книг { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.ProductMaterial = new HashSet<ProductMaterial>();
            this.ProductSale = new HashSet<ProductSale>();
        }
    
        public int ID { get; set; }
        public string НаименованиеПродукции { get; set; }
        public long Артикул { get; set; }
        public decimal МинимальнаяСтоимостьДляАгента { get; set; }
        public string Изображение { get; set; }
        public int IDТипПродукции { get; set; }
        public int КоличествоЧеловекДляПроизводства { get; set; }
        public int НомерЦехаДляПроизводства { get; set; }
        public string Описание { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaterial> ProductMaterial { get; set; }
        public virtual TypesProducts TypesProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSale { get; set; }
    }
}
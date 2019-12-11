//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Comments = new HashSet<Comments>();
            this.DetailProduct = new HashSet<DetailProduct>();
            this.ImagesProduct = new HashSet<ImagesProduct>();
            this.SimilarProduct = new HashSet<SimilarProduct>();
            this.SizeForProduct = new HashSet<SizeForProduct>();
            this.Qualification = new HashSet<Qualification>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdType { get; set; }
        public Nullable<int> IdColor { get; set; }
        public Nullable<int> IdBrand { get; set; }
        public Nullable<int> IdProvider { get; set; }
        public int IdCatalog { get; set; }
        public string Title { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public Nullable<decimal> PriceDistributor { get; set; }
        public decimal PriceClient { get; set; }
        public decimal PriceMember { get; set; }
        public bool IsEnabled { get; set; }
        public string Keywords { get; set; }
        public System.DateTime DateUpdate { get; set; }
    
        public virtual CatBrands CatBrands { get; set; }
        public virtual CatCatalogs CatCatalogs { get; set; }
        public virtual CatColors CatColors { get; set; }
        public virtual CatProviders CatProviders { get; set; }
        public virtual CatTypeProduct CatTypeProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailProduct> DetailProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagesProduct> ImagesProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SimilarProduct> SimilarProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SizeForProduct> SizeForProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Qualification> Qualification { get; set; }
    }
}

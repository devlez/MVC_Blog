using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete
{
    public class Article : IEntity
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleBody { get; set; }
        public string ImagePath { get; set; }
        public DateTime AddedDate { get; set; }
        public bool  IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsSlider { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Categories { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

        public DateTime CreatedDate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime? UpdatedDate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime? DeletedDate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}

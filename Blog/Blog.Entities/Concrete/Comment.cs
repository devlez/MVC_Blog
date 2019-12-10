using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete
{
    public class Comment : IEntity
    {
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Article Article { get; set; }

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

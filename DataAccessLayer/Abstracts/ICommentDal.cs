﻿using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        public List<Comment> GetListCommentWithDestination();
        public List<Comment> TGetListCommentWithDestinationAndUser(int id);
    }
}

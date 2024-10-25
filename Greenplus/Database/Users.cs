using Microsoft.EntityFrameworkCore;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenplus.Database
{
    public class User
    {
        [Key]
        public int userId;

        public bool tipo;

        public string nome;

        public string email;

        public string cargo;

        public string grupos;

        public string username;

        public string senha;
    }
}

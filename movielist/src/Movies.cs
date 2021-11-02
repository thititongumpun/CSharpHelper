using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace imdbx
{
    public class Movies
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public MovieType MovieType { get; set; }
    }

    public enum MovieType
    {
        Action = 1,
        Drama = 2,
        Comedy = 3
    }
}

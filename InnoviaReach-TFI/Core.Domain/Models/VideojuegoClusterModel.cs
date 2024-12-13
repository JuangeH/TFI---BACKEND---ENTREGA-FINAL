﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Models
{
    public class VideojuegoClusterModel
    {
        public int Videojuego_ID { get; set; }
        public int AppRawgId { get; set; }
        public string Nombre { get; set; }
        public string Caracteristicas { get; set; }

        [NotMapped]
        public float Similitud { get; set; }

        [NotMapped]
        public int ClusterID { get; set; }

        [NotMapped]
        public float[] CaracteristicasVector { get; set; }
    }
}

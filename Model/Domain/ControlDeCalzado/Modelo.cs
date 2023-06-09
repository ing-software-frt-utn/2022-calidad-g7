﻿using System.ComponentModel.DataAnnotations;

namespace Model.Domain.ControlDeCalzado
{
    public class Modelo
    {
        [Key]
        public string Sku { get; set; }
        public string Denominacion { get; set; }
        [Display(Name = "Limite Inferior de Observado: ")]
        public int LimiteInferiorDeObservado { get; set; }
        [Display(Name = "Limite Inferior de Reproceso: ")]
        public int LimiteInferiorDeReproceso { get; set; }
        [Display(Name = "Limite Superior de Observado: ")]
        public int LimiteSuperiorDeObservado { get; set; }
        [Display(Name = "Limite Superior de Reproceso: ")]
        public int LimiteSuperiorDeReproceso { get; set; }
    }
}

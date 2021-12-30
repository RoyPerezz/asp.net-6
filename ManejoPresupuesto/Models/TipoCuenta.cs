﻿using ManejoPresupuesto.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El {0} es requerido")]

        [Display(Name ="Nombre del tipo de Cuenta")]

        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Nombre !=null && Nombre.Length>0)
        //    {
        //        var primeraLetra = Nombre[0].ToString();

        //        if (primeraLetra !=primeraLetra.ToUpper())
        //        {
        //            yield return new ValidationResult("La primera letra debe ser mayuscula",new[] {nameof(Nombre) });
        //        }
        //    }
        //}
    }
}

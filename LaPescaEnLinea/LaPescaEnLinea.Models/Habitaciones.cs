using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LaPescaEnLinea.Models
{
   public class Habitaciones
    {

		[Key]
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string PalabrasClave { get; set; }
		public string Descripcion { get; set; }
		public decimal Costo { get; set; }
		public int Adultos { get; set; }
		public int Ninos { get; set; }
		public int Infantes { get; set; }
		public int MaximoAdultos { get; set; }
		public int MaximoNinos { get; set; }
		public int MaximoInfantes { get; set; }
		public int CostoAdicionalAdulto { get; set; }
		public int CostoAdicionalNino { get; set; }
		public int CostoAdicionalInfante { get; set; }
		public int TotalHabitaciones { get; set; }
		public decimal Calificacion { get; set; }
		public bool Activo { get; set; }
		[ForeignKey("Hoteles")]
		public int HotelId { get; set; }
		public int CamaIndividual { get; set; }
		public int CamaDoble { get; set; }
		public int CamaQueenSize { get; set; }
		public int CamaKingSize { get; set; }
		public virtual Hoteles Hoteles { get; set; }

	}
}

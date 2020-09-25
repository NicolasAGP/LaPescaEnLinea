using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LaPescaEnLinea.Models
{
	public class ReservaDetalle
	{
		[Key]
		public int Id { get; set; }
		public int TotalDias { get; set; }
		public int Adultos { get; set; }
		public int Ninos { get; set; }
		public int Infantes { get; set; }
		public decimal CostoHabitacion { get; set; }
		[ForeignKey("Reserva")]
		public int ReservaId { get; set; }
		[ForeignKey("Habitaciones")]
		public int HabitacionId { get; set; }
		
		public virtual Habitaciones Habitaciones { get; set; }
		public virtual Reservas Reservas { get; set; }

	}
	}

using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;

namespace Grintsys.SROverview.Clients
{
    public class Client: Entity, IHasCreationTime, IHasModificationTime, IMustHaveTenant
    {
        [StringLength(100)]
        public string Name { get; set; }
        public string Code { get; set; }
        public string IdNumber { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitud { get; set; }
        [StringLength(10)]
        public string Phone { get; set; }
        [StringLength(10)]
        public string Celphone { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime BithDate { get; set; }
        public ClientStatus Status { get; set; } = ClientStatus.Inactivo;
        public int TenantId { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public DateTime? LastModificationTime { get; set; }
    }

    public enum Sexo
    {
        Femenino = 1,
        Masculino = 2,
        Otro = 3
    }

    public enum ClientStatus
    {
        Activo = 1,
        Inactivo = 2
    }
}

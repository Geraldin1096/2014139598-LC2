﻿using _2014139598_ENT.Entities;
using _2014139598_PER_Persistence.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_PER_Persistence
{
    public class LineaNuevaDbContext : DbContext

    {

    public DbSet<AdministradorEquipo> AdministradorEquipos { get; set; }
    public DbSet<AdministrarLinea> AdministrarLineas { get; set; }
    public DbSet<CentroAtencion> CentroAtencions { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Contrato> Contratos { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Direccion> Direccions { get; set; }
    public DbSet<Distrito> Distritos { get; set; }
    public DbSet<EquipoCelular> EquipoCelulars { get; set; }
  
    public DbSet<Evaluacion> Evaluacions { get; set; }
    public DbSet<LineaTelefonica> LineaTelefonicas { get; set; }
    public DbSet<Plan> Plans { get; set; }
    public DbSet<Provincia> Provincias { get; set; }
    
    public DbSet<Trabajador> Trabajadors { get; set; }
    public DbSet<Ubigeo> Ubigeos { get; set; }
    public DbSet<Venta> Ventas { get; set; }
    

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Configurations.Add(new AdministradorEquipoConfiguration());
        modelBuilder.Configurations.Add(new AdministrarLineaConfiguration());
        modelBuilder.Configurations.Add(new CentroAtencionConfiguration());
        modelBuilder.Configurations.Add(new ClienteConfiguration());
        modelBuilder.Configurations.Add(new ContratoConfiguration());
        modelBuilder.Configurations.Add(new DepartamentoConfiguration());
        modelBuilder.Configurations.Add(new DireccionConfiguration());
        modelBuilder.Configurations.Add(new DistritoConfiguration());
        modelBuilder.Configurations.Add(new EquipoCelularConfiguration());
        
        modelBuilder.Configurations.Add(new EvaluacionConfiguration());
        modelBuilder.Configurations.Add(new LineaTelefonicaConfiguration());
        modelBuilder.Configurations.Add(new PlanConfiguration());
        modelBuilder.Configurations.Add(new ProvinciaConfiguration());
       
        modelBuilder.Configurations.Add(new TrabajadorConfiguration());
        modelBuilder.Configurations.Add(new UbigeoConfiguration());
        modelBuilder.Configurations.Add(new VentaConfiguration());
      


        base.OnModelCreating(modelBuilder);

    }
}


}



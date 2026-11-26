using System;
using System.Collections.Generic;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class AutoServiceContext : DbContext
{
    public AutoServiceContext()
    {
    }

    public AutoServiceContext(DbContextOptions<AutoServiceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClienteModel> Cliente { get; set; }

    public virtual DbSet<UsuarioModel> Usuario { get; set; }

    public virtual DbSet<VehiculoModel> Vehiculo { get; set; }

    public virtual DbSet<OrdenServicioModel> OrdenServicio { get; set; }

    public virtual DbSet<RepuestoModel> Repuesto { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(ConeccionString.getConectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClienteModel>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasIndex(e => e.Dni).IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Dni)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<UsuarioModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC27631026A8");

            entity.HasIndex(e => e.Usuario, "UQ__Usuario__E251F4843079F6ED").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<VehiculoModel>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasIndex(e => e.IdCliente, "IX_Vehiculo_Cliente");

            entity.HasIndex(e => e.Patente).IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.Color)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Patente)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PATENTE");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Vehiculos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OrdenServicioModel>(entity =>
        {
            entity.HasKey(e => e.IdOrden);
            entity.ToTable("ORDEN_SERVICIO");

            entity.Property(e => e.IdOrden).HasColumnName("ID_ORDEN");
            entity.Property(e => e.IdVehiculo).HasColumnName("ID_VEHICULO");
            entity.Property(e => e.IdTecnico).HasColumnName("ID_TECNICO");
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.FechaCierre)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CIERRE");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.ManoObra)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MANO_OBRA");
            entity.Property(e => e.TotalRepuestos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TOTAL_REPUESTOS");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<RepuestoModel>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("REPUESTO");

            entity.HasIndex(e => e.Codigo).IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.StockFisico).HasColumnName("STOCK_FISICO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
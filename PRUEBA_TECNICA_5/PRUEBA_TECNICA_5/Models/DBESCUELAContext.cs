using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRUEBA_TECNICA_5.Models
{
    public partial class DBESCUELAContext : DbContext
    {
        public DBESCUELAContext()
        {
        }

        public DBESCUELAContext(DbContextOptions<DBESCUELAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudiante> Estudiantes { get; set; } = null!;
        public virtual DbSet<Materia> Materias { get; set; } = null!;
        public virtual DbSet<Nota> Notas { get; set; } = null!;
        public virtual DbSet<Periodo> Periodos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.EsIdentificacion)
                    .HasName("PK__ESTUDIAN__D4298D192859694A");

                entity.ToTable("ESTUDIANTES");

                entity.Property(e => e.EsIdentificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ES_IDENTIFICACION");

                entity.Property(e => e.EsEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ES_EMAIL");

                entity.Property(e => e.EsPrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ES_PRIMER_APELLIDO");

                entity.Property(e => e.EsPrimerNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ES_PRIMER_NOMBRE");

                entity.Property(e => e.EsSegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ES_SEGUNDO_APELLIDO");

                entity.Property(e => e.EsSegundoNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ES_SEGUNDO_NOMBRE");

                entity.Property(e => e.EsTelefono)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ES_TELEFONO");
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(e => e.MaCodigo)
                    .HasName("PK__MATERIAS__5EE0A50F82584EFE");

                entity.ToTable("MATERIAS");

                entity.Property(e => e.MaCodigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MA_CODIGO");

                entity.Property(e => e.MaDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MA_DESCRIPCION");
            });

            modelBuilder.Entity<Nota>(entity =>
            {
                entity.HasKey(e => e.NoId)
                    .HasName("PK__NOTAS__0CE533A7A07625D3");

                entity.ToTable("NOTAS");

                entity.Property(e => e.NoId).HasColumnName("NO_ID");

                entity.Property(e => e.NoEstudiante)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NO_ESTUDIANTE");

                entity.Property(e => e.NoFecha)
                    .HasColumnType("date")
                    .HasColumnName("NO_FECHA");

                entity.Property(e => e.NoMateria)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NO_MATERIA");

                entity.Property(e => e.NoNota)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("NO_NOTA");

                entity.Property(e => e.NoPeriodo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NO_PERIODO");

                entity.HasOne(d => d.oEstudiante)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.NoEstudiante)
                    .HasConstraintName("FK_ESTUDIANTE");

                entity.HasOne(d => d.oMateria)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.NoMateria)
                    .HasConstraintName("FK_MATERIA");

                entity.HasOne(d => d.oPeriodo)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.NoPeriodo)
                    .HasConstraintName("FK_PERIODO");
            });

            modelBuilder.Entity<Periodo>(entity =>
            {
                entity.HasKey(e => e.PeCodigo)
                    .HasName("PK__PERIODOS__FA9A4C27BC11CEAC");

                entity.ToTable("PERIODOS");

                entity.Property(e => e.PeCodigo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PE_CODIGO");

                entity.Property(e => e.PeFechaFinal)
                    .HasColumnType("date")
                    .HasColumnName("PE_FECHA_FINAL");

                entity.Property(e => e.PeFechaInicial)
                    .HasColumnType("date")
                    .HasColumnName("PE_FECHA_INICIAL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

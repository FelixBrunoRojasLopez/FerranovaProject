using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BDFerranova;

public partial class _dbFerranovaContext : DbContext
{
    public _dbFerranovaContext()
    {
    }

    public _dbFerranovaContext(DbContextOptions<_dbFerranovaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetallePedido> DetallePedidos { get; set; }

    public virtual DbSet<DetalleProducto> DetalleProductos { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<MenuAcceso> MenuAccesos { get; set; }

    public virtual DbSet<MenuRol> MenuRols { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<NumeroDoc> NumeroDocs { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<ProveedorProducto> ProveedorProductos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<SesionUsuario> SesionUsuarios { get; set; }

    public virtual DbSet<TipoComprobante> TipoComprobantes { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoPersona> TipoPersonas { get; set; }

    public virtual DbSet<UsuarioAcceso> UsuarioAccesos { get; set; }

    public virtual DbSet<Vcliente> Vclientes { get; set; }

    public virtual DbSet<Vempleado> Vempleados { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    public virtual DbSet<Vpersona> Vpersonas { get; set; }

    public virtual DbSet<Vproducto> Vproductos { get; set; }

    public virtual DbSet<Vusuario> Vusuarios { get; set; }

    public virtual DbSet<Vventum> Vventa { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS; Initial Catalog=ferranovabd; Integrated Security=True; Trusted_Connection=true; Trust Server Certificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("XPKcargo");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Cargos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_1");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("XPKclientes");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Clientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_2");

            entity.HasOne(d => d.IdTipoPersonaNavigation).WithMany(p => p.Clientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_3");
        });

        modelBuilder.Entity<DetallePedido>(entity =>
        {
            entity.HasKey(e => e.IdDetallePedido).HasName("XPKdetallePedido");

            entity.Property(e => e.IdDetallePedido).ValueGeneratedNever();

            entity.HasOne(d => d.IdPedidosNavigation).WithMany(p => p.DetallePedidos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_5");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetallePedidos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_4");
        });

        modelBuilder.Entity<DetalleProducto>(entity =>
        {
            entity.HasKey(e => e.IdDetalleProducto).HasName("XPKdetalleProducto");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.IdDetalleVenta).HasName("XPKdetalleVenta");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_6");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.DetalleVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_7");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("XPKempleado");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Empleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_8");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Empleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_9");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Empleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_10");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.IdError).HasName("XPKerror");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Errors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_11");

            entity.HasOne(d => d.IdUsuarioAccesoNavigation).WithMany(p => p.Errors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_12");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("XPKestado");
        });

        modelBuilder.Entity<MenuAcceso>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PK__menu__C26AF483976834A5");

            entity.Property(e => e.IdMenu).ValueGeneratedNever();

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.MenuAccesos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menu__idEstado__41EDCAC5");
        });

        modelBuilder.Entity<MenuRol>(entity =>
        {
            entity.HasKey(e => e.IdMenuRol).HasName("PK__menuRol__9D6D61A4CAD562D3");

            entity.Property(e => e.IdMenuRol).ValueGeneratedNever();

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.MenuRols)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menuRol__idEstad__45BE5BA9");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.MenuRols)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menuRol__idMenu__46B27FE2");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.MenuRols)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menuRol__idRol__44CA3770");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodopago).HasName("XPKmetodoPago");
        });

        modelBuilder.Entity<NumeroDoc>(entity =>
        {
            entity.HasKey(e => e.IdNumDoc).HasName("PK__NumeroDo__885994790D8F3D61");

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedidos).HasName("XPKpedidos");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_13");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("XPKpersona");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Personas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_14");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("XPKproducto");

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdDetalleProductoNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_15");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Productos).HasConstraintName("FK__producto__idEsta__4E53A1AA");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("XPKproveedor");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Proveedors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_16");
        });

        modelBuilder.Entity<ProveedorProducto>(entity =>
        {
            entity.HasKey(e => e.IdProveedorProducto).HasName("XPKproveedorProducto");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProveedorProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_18");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ProveedorProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_17");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("XPKrol");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Rols)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_19");
        });

        modelBuilder.Entity<SesionUsuario>(entity =>
        {
            entity.HasKey(e => e.IdSesionUser).HasName("XPKsesionUsuario");

            entity.HasOne(d => d.IdUsuarioAccesoNavigation).WithMany(p => p.SesionUsuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_20");
        });

        modelBuilder.Entity<TipoComprobante>(entity =>
        {
            entity.HasKey(e => e.IdTipoComprobante).HasName("XPKtipoComprobante");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento).HasName("XPKtipoDocumento");
        });

        modelBuilder.Entity<TipoPersona>(entity =>
        {
            entity.HasKey(e => e.IdTipoPersona).HasName("XPKtipoPersona");
        });

        modelBuilder.Entity<UsuarioAcceso>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioAcceso).HasName("XPKusuarioAcceso");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.UsuarioAccesos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_21");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.UsuarioAccesos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_22");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.UsuarioAccesos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_23");
        });

        modelBuilder.Entity<Vcliente>(entity =>
        {
            entity.ToView("VCliente");
        });

        modelBuilder.Entity<Vempleado>(entity =>
        {
            entity.ToView("VEmpleado");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("XPKventa");

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Venta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_26");

            entity.HasOne(d => d.IdMetodopagoNavigation).WithMany(p => p.Venta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_28");

            entity.HasOne(d => d.IdTipoComprobanteNavigation).WithMany(p => p.Venta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_27");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Venta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_25");
        });

        modelBuilder.Entity<Vpersona>(entity =>
        {
            entity.ToView("VPersona");
        });

        modelBuilder.Entity<Vproducto>(entity =>
        {
            entity.ToView("VProducto");
        });

        modelBuilder.Entity<Vusuario>(entity =>
        {
            entity.ToView("VUsuario");
        });

        modelBuilder.Entity<Vventum>(entity =>
        {
            entity.ToView("VVenta");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

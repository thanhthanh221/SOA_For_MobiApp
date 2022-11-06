﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Order.Infra.Data.Data;

#nullable disable

namespace Order.Infra.Data.Migrations
{
    [DbContext(typeof(OrderServiceContext))]
    [Migration("20221105150630_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Order.Domain.Model.OrderAggregate", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Thời gian tạo");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Mã người tạo");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Thời gian sửa");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Mã chỉnh sửa");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Mô tả đơn hàng");

                    b.Property<bool>("isDraft")
                        .HasColumnType("bit")
                        .HasColumnName("Đã lưu");

                    b.Property<string>("orderStatusId")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Mã trạng thái");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Mã người mua");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Tên người mua");

                    b.HasKey("Id");

                    b.HasIndex("orderStatusId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Order.Domain.Model.OrderItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Thời gian tạo");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Mã người tạo");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("Thời gian sửa");

                    b.Property<string>("UpdateBy")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Mã chỉnh sửa");

                    b.Property<int>("count")
                        .HasColumnType("int")
                        .HasColumnName("Số lượng");

                    b.Property<decimal>("discount")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("Giảm giá");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Ảnh");

                    b.Property<string>("orderId")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Mã đơn hàng");

                    b.Property<decimal>("price")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("Giá");

                    b.Property<string>("productId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Mã sản phẩm");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Tên sản phẩm");

                    b.HasKey("Id");

                    b.HasIndex("orderId");

                    b.ToTable("orderItems");
                });

            modelBuilder.Entity("Order.Domain.Model.OrderStatus", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Trạng thái Đơn hàng");

                    b.HasKey("Id");

                    b.ToTable("orderStatuses");
                });

            modelBuilder.Entity("Order.Domain.Model.OrderAggregate", b =>
                {
                    b.HasOne("Order.Domain.Model.OrderStatus", "orderStatus")
                        .WithMany()
                        .HasForeignKey("orderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Order.Domain.Model.Address", "address", b1 =>
                        {
                            b1.Property<string>("OrderAggregateId")
                                .HasColumnType("varchar(20)");

                            b1.Property<string>("city")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Thành phố/Tỉnh");

                            b1.Property<string>("commune")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Xã/Phường");

                            b1.Property<string>("district")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Quận/Huyện");

                            b1.Property<string>("infomation")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Địa chỉ");

                            b1.Property<string>("street")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Tuyến đường");

                            b1.HasKey("OrderAggregateId");

                            b1.ToTable("orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderAggregateId");
                        });

                    b.Navigation("address");

                    b.Navigation("orderStatus");
                });

            modelBuilder.Entity("Order.Domain.Model.OrderItem", b =>
                {
                    b.HasOne("Order.Domain.Model.OrderAggregate", "order")
                        .WithMany("orderItems")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");
                });

            modelBuilder.Entity("Order.Domain.Model.OrderAggregate", b =>
                {
                    b.Navigation("orderItems");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YJCA.Blog.EntityFrameWorkCore.EntityFrameworkCore;

#nullable disable

namespace YJCA.Blog.EntityFrameWorkCore.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    partial class BlogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("YJCA.Blog.Domain.Entity.Role", b =>
                {
                    b.Property<int>("AuthorityScope")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreateId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dids")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModifyBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("ModifyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderSort")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("T_Role", (string)null);
                });

            modelBuilder.Entity("YJCA.Blog.Domain.Entity.UserInfo", b =>
                {
                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriticalModifyTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ErrorCount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastErrorTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginPWD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RealName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Sex")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.ToTable("T_UserInfo", (string)null);
                });

            modelBuilder.Entity("YJCA.Blog.Domain.Entity.UserRole", b =>
                {
                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreateId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModifyBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ModifyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.ToTable("T_UserRole", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using album_collection.Models;

namespace album_collection.Migrations
{
    [DbContext(typeof(AlbumCollectionContext))]
    [Migration("20200318154503_AddTitleToAlbum")]
    partial class AddTitleToAlbum
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumId = 1,
                            ArtistId = 1,
                            Image = "sighnomore.jpg",
                            RecordLabel = "Island Records",
                            Title = "Sigh No More"
                        },
                        new
                        {
                            AlbumId = 2,
                            ArtistId = 1,
                            Image = "babel.jpg",
                            RecordLabel = "Island Records",
                            Title = "Babel"
                        },
                        new
                        {
                            AlbumId = 3,
                            ArtistId = 2,
                            Image = "unleashedmemories.jpg",
                            RecordLabel = "Century Media",
                            Title = "Unleashed Memories"
                        },
                        new
                        {
                            AlbumId = 4,
                            ArtistId = 2,
                            Image = "comalies.jpg",
                            RecordLabel = "Century Media",
                            Title = "Comalies"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hometown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            Hometown = "London, UK",
                            Image = "mumfordsons.jpg",
                            Name = "Mumford & Sons"
                        },
                        new
                        {
                            ArtistId = 2,
                            Hometown = "Milan, Italy",
                            Image = "lacunacoil.jpg",
                            Name = "Lacuna Coil"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Links")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.HasOne("album_collection.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using DarlingDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DarlingDb.Migrations
{
    [DbContext(typeof(db))]
    [Migration("20210918153815_GiveawayAddEnd")]
    partial class GiveawayAddEnd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-preview.5.21301.9");

            modelBuilder.Entity("DarlingDb.Models.Channels", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BadWordString")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DelCaps")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DelUrl")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DelUrlImage")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("GiveXP")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("GuildsId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("InviteMessage")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SendBadWord")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Spaming")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UseAdminCommand")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UseCommand")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UseRPcommand")
                        .HasColumnType("INTEGER");

                    b.Property<string>("csUrlWhiteListString")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GuildsId");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("DarlingDb.Models.DarlingBoost", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Ends")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("Streak")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsersId")
                        .IsUnique();

                    b.ToTable("DarlingBoost");
                });

            modelBuilder.Entity("DarlingDb.Models.EmoteClick", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("ChannelsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Emote")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Get")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("MessageId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChannelsId");

                    b.ToTable("EmoteClick");
                });

            modelBuilder.Entity("DarlingDb.Models.GiveAways", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AdminEnd")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("MessageId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Times")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.ToTable("GiveAways");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("ChatMuteRole")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommandInviseString")
                        .HasColumnType("TEXT");

                    b.Property<bool>("GiveXPnextChannel")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Leaved")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Prefix")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("PrivateId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VS")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("VoiceMuteRole")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Logs", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("ChannelsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChannelsId");

                    b.ToTable("Guilds_Logs");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Meeting_Leave", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("GuildsId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("LeaveChannelsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LeaveMessage")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GuildsId")
                        .IsUnique();

                    b.HasIndex("LeaveChannelsId")
                        .IsUnique();

                    b.ToTable("Guilds_Meeting_Leave");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Meeting_Welcome", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("GuildsId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("WelcomeChannelsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WelcomeDMmessage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("WelcomeDMuser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WelcomeMessage")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("WelcomeRole")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GuildsId")
                        .IsUnique();

                    b.HasIndex("WelcomeChannelsId")
                        .IsUnique();

                    b.ToTable("Guilds_Meeting_Welcome");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Raid", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("GuildsId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RaidMuted")
                        .HasColumnType("TEXT");

                    b.Property<bool>("RaidStop")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("RaidTime")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("RaidUserCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GuildsId")
                        .IsUnique();

                    b.ToTable("Guilds_Raid");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Warns", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("CountWarn")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("GuildsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReportTypes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GuildsId");

                    b.ToTable("Guilds_Warns");
                });

            modelBuilder.Entity("DarlingDb.Models.Invites", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("UsersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsesCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Invites");
                });

            modelBuilder.Entity("DarlingDb.Models.PrivateChannels", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UsersId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("VoiceChannelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsersId")
                        .IsUnique();

                    b.ToTable("PrivateChannels");
                });

            modelBuilder.Entity("DarlingDb.Models.QiwiTransactions", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("discord_id")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("invoice_ammount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("invoice_date_add")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("QiwiTransactions");
                });

            modelBuilder.Entity("DarlingDb.Models.Roles", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("GuildsId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GuildsId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DarlingDb.Models.Tasks", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("ChannelsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Repeat")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Times")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChannelsId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("DarlingDb.Models.TempUser", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("ChannelsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Reason")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ToTime")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChannelsId");

                    b.HasIndex("UsersId");

                    b.ToTable("TempUser");
                });

            modelBuilder.Entity("DarlingDb.Models.Users", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("CountWarns")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Daily")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("GuildsId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Leaved")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("RealCoin")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("Streak")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("UsersMId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("XP")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("ZeroCoin")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GuildsId");

                    b.HasIndex("UsersMId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DarlingDb.Models.Channels", b =>
                {
                    b.HasOne("DarlingDb.Models.Guilds", "Guilds")
                        .WithMany("Channels")
                        .HasForeignKey("GuildsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guilds");
                });

            modelBuilder.Entity("DarlingDb.Models.DarlingBoost", b =>
                {
                    b.HasOne("DarlingDb.Models.Users", "Users")
                        .WithOne("Boost")
                        .HasForeignKey("DarlingDb.Models.DarlingBoost", "UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DarlingDb.Models.EmoteClick", b =>
                {
                    b.HasOne("DarlingDb.Models.Channels", "Channels")
                        .WithMany("EmoteClick")
                        .HasForeignKey("ChannelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channels");
                });

            modelBuilder.Entity("DarlingDb.Models.GiveAways", b =>
                {
                    b.HasOne("DarlingDb.Models.Guilds", "Guild")
                        .WithMany("GiveAways")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Logs", b =>
                {
                    b.HasOne("DarlingDb.Models.Channels", "Channels")
                        .WithMany("Guilds_Logs")
                        .HasForeignKey("ChannelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channels");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Meeting_Leave", b =>
                {
                    b.HasOne("DarlingDb.Models.Guilds", "Guilds")
                        .WithOne("Guilds_Meeting_Leave")
                        .HasForeignKey("DarlingDb.Models.Guilds_Meeting_Leave", "GuildsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DarlingDb.Models.Channels", "LeaveChannels")
                        .WithOne("Guilds_Meeting_Leave")
                        .HasForeignKey("DarlingDb.Models.Guilds_Meeting_Leave", "LeaveChannelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guilds");

                    b.Navigation("LeaveChannels");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Meeting_Welcome", b =>
                {
                    b.HasOne("DarlingDb.Models.Guilds", "Guilds")
                        .WithOne("Guilds_Meeting_Welcome")
                        .HasForeignKey("DarlingDb.Models.Guilds_Meeting_Welcome", "GuildsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DarlingDb.Models.Channels", "WelcomeChannels")
                        .WithOne("Guilds_Meeting_Welcome")
                        .HasForeignKey("DarlingDb.Models.Guilds_Meeting_Welcome", "WelcomeChannelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guilds");

                    b.Navigation("WelcomeChannels");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Raid", b =>
                {
                    b.HasOne("DarlingDb.Models.Guilds", "Guilds")
                        .WithOne("Guilds_Raid")
                        .HasForeignKey("DarlingDb.Models.Guilds_Raid", "GuildsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guilds");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds_Warns", b =>
                {
                    b.HasOne("DarlingDb.Models.Guilds", "Guilds")
                        .WithMany("Guilds_Warns")
                        .HasForeignKey("GuildsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guilds");
                });

            modelBuilder.Entity("DarlingDb.Models.Invites", b =>
                {
                    b.HasOne("DarlingDb.Models.Users", "Users")
                        .WithMany("Invites")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DarlingDb.Models.PrivateChannels", b =>
                {
                    b.HasOne("DarlingDb.Models.Users", "Users")
                        .WithOne("PrivateChannels")
                        .HasForeignKey("DarlingDb.Models.PrivateChannels", "UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DarlingDb.Models.Roles", b =>
                {
                    b.HasOne("DarlingDb.Models.Guilds", "Guilds")
                        .WithMany("Roles")
                        .HasForeignKey("GuildsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guilds");
                });

            modelBuilder.Entity("DarlingDb.Models.Tasks", b =>
                {
                    b.HasOne("DarlingDb.Models.Channels", "Channels")
                        .WithMany("Tasks")
                        .HasForeignKey("ChannelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channels");
                });

            modelBuilder.Entity("DarlingDb.Models.TempUser", b =>
                {
                    b.HasOne("DarlingDb.Models.Channels", "Channels")
                        .WithMany("TempUser")
                        .HasForeignKey("ChannelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DarlingDb.Models.Users", "Users")
                        .WithMany("TempUser")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channels");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DarlingDb.Models.Users", b =>
                {
                    b.HasOne("DarlingDb.Models.Guilds", "Guilds")
                        .WithMany("Users")
                        .HasForeignKey("GuildsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DarlingDb.Models.Users", "UsersM")
                        .WithMany()
                        .HasForeignKey("UsersMId");

                    b.Navigation("Guilds");

                    b.Navigation("UsersM");
                });

            modelBuilder.Entity("DarlingDb.Models.Channels", b =>
                {
                    b.Navigation("EmoteClick");

                    b.Navigation("Guilds_Logs");

                    b.Navigation("Guilds_Meeting_Leave");

                    b.Navigation("Guilds_Meeting_Welcome");

                    b.Navigation("Tasks");

                    b.Navigation("TempUser");
                });

            modelBuilder.Entity("DarlingDb.Models.Guilds", b =>
                {
                    b.Navigation("Channels");

                    b.Navigation("GiveAways");

                    b.Navigation("Guilds_Meeting_Leave");

                    b.Navigation("Guilds_Meeting_Welcome");

                    b.Navigation("Guilds_Raid");

                    b.Navigation("Guilds_Warns");

                    b.Navigation("Roles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DarlingDb.Models.Users", b =>
                {
                    b.Navigation("Boost");

                    b.Navigation("Invites");

                    b.Navigation("PrivateChannels");

                    b.Navigation("TempUser");
                });
#pragma warning restore 612, 618
        }
    }
}

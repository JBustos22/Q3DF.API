using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

#nullable disable

namespace Q3DF.API.Models
{
    public partial class DefragContext : DbContext
    {
        public DefragContext()
        {
        }

        public DefragContext(DbContextOptions<DefragContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public virtual DbSet<Q3Access> Q3Accesses { get; set; }
        public virtual DbSet<Q3DefragDemo> Q3DefragDemos { get; set; }
        public virtual DbSet<Q3DefragForbiddenMap> Q3DefragForbiddenMaps { get; set; }
        public virtual DbSet<Q3DefragRecord> Q3DefragRecords { get; set; }
        public virtual DbSet<Q3DefragRecordsHistory> Q3DefragRecordsHistories { get; set; }
        public virtual DbSet<Q3DefragRecordsTmp> Q3DefragRecordsTmps { get; set; }
        public virtual DbSet<Q3IpToCountry> Q3IpToCountries { get; set; }
        public virtual DbSet<Q3MinnieRecord> Q3MinnieRecords { get; set; }
        public virtual DbSet<Q3News> Q3News { get; set; }
        public virtual DbSet<Q3NewsComment> Q3NewsComments { get; set; }
        public virtual DbSet<Q3Pinboard> Q3Pinboards { get; set; }
        public virtual DbSet<Q3Server> Q3Servers { get; set; }
        public virtual DbSet<Q3ServersAccess> Q3ServersAccesses { get; set; }
        public virtual DbSet<Q3ServersAccessLog> Q3ServersAccessLogs { get; set; }
        public virtual DbSet<Q3ServersBannedMap> Q3ServersBannedMaps { get; set; }
        public virtual DbSet<Q3ServersStatus> Q3ServersStatuses { get; set; }
        public virtual DbSet<Q3ServersStatusPlayer> Q3ServersStatusPlayers { get; set; }
        public virtual DbSet<Q3TypeCountry> Q3TypeCountrys { get; set; }
        public virtual DbSet<Q3User> Q3Users { get; set; }
        public virtual DbSet<Q3UsersCopy> Q3UsersCopies { get; set; }
        public virtual DbSet<Q3UsersOnline> Q3UsersOnlines { get; set; }
        public virtual DbSet<Q3UsersRight> Q3UsersRights { get; set; }
        public virtual DbSet<Q3UsersVote> Q3UsersVotes { get; set; }
        public virtual DbSet<Q3Vote> Q3Votes { get; set; }
        public virtual DbSet<Q3VotesAnswer> Q3VotesAnswers { get; set; }
        public virtual DbSet<Q3WikiPage> Q3WikiPages { get; set; }
        public virtual DbSet<Tmp> Tmps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(Configuration.GetConnectionString("Defrag"), new MySqlServerVersion(new Version(8, 0, 22)));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Q3Access>(entity =>
            {
                entity.ToTable("q3_access");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cmd)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("cmd")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("description")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3DefragDemo>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PRIMARY");

                entity.ToTable("q3_defrag_demos");

                entity.Property(e => e.RecId).HasColumnName("rec_id");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Datetime)
                    .HasColumnType("timestamp")
                    .HasColumnName("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("filename")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
                // .HasCharSet("utf8")

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<Q3DefragForbiddenMap>(entity =>
            {
                entity.ToTable("q3_defrag_forbidden_maps");

                entity.HasComment("Players cannot vote these maps");

                entity.HasIndex(e => e.Mapname, "mapname")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mapname)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("mapname")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timeout).HasColumnName("timeout");
            });

            modelBuilder.Entity<Q3DefragRecord>(entity =>
            {
                entity.ToTable("q3_defrag_records");

                entity.HasIndex(e => new { e.ServerId, e.UserId, e.Map, e.Mstime, e.Physic, e.Mode, e.Timestamp, e.Status }, "idx");

                entity.HasIndex(e => e.Map, "map");

                entity.HasIndex(e => new { e.Map, e.Physic, e.Mode }, "map_2");

                entity.HasIndex(e => e.Mstime, "mstime");

                entity.HasIndex(e => new { e.Map, e.Physic, e.Mode, e.Mstime }, "places");

                entity.HasIndex(e => e.Timestamp, "timestamp");

                entity.HasIndex(e => new { e.UserId, e.Map, e.Physic, e.Mode }, "user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DefragVersion)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("defrag_version")
                    .HasDefaultValueSql("'19108'")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Map)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("map")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Mstime).HasColumnName("mstime");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("nickname")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3jVersion)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("o3j_version")
                    .HasDefaultValueSql("'1016'")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Physic).HasColumnName("physic");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Userinfostring)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("userinfostring")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3DefragRecordsHistory>(entity =>
            {
                entity.ToTable("q3_defrag_records_history");

                entity.HasIndex(e => new { e.Map, e.Physic, e.Mode }, "auth");

                entity.HasIndex(e => e.Mstime, "mstime");

                entity.HasIndex(e => e.ServerId, "server_id");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.HasIndex(e => new { e.UserId, e.Physic, e.Mode, e.Map }, "user_id_2");

                entity.HasIndex(e => new { e.UserId, e.Map, e.Mstime, e.Physic, e.Mode }, "user_id_3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DefragVersion)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("defrag_version")
                    .HasDefaultValueSql("'19108'")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Map)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("map")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Mstime).HasColumnName("mstime");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("nickname")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3jVersion)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("o3j_version")
                    .HasDefaultValueSql("'1016'")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Physic).HasColumnName("physic");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Userinfostring)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("userinfostring")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3DefragRecordsTmp>(entity =>
            {
                entity.ToTable("q3_defrag_records_tmp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DefragVersion)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("defrag_version")
                    .HasDefaultValueSql("'19108'")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Map)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("map")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Mstime).HasColumnName("mstime");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("nickname")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O3jVersion)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("o3j_version")
                    .HasDefaultValueSql("'1016'")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Physic).HasColumnName("physic");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Userinfostring)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("userinfostring")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3IpToCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("q3_ip_to_country");

                entity.Property(e => e.Drei)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasColumnName("drei")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IpFrom).HasColumnName("IP_from");

                entity.Property(e => e.IpTo).HasColumnName("IP_to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("name")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zwei)
                    .IsRequired()
                    .HasColumnType("char(2)")
                    .HasColumnName("zwei")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3MinnieRecord>(entity =>
            {
                entity.ToTable("q3_minnie_records");

                entity.HasIndex(e => e.Mapname, "mapname");

                entity.HasIndex(e => new { e.Mapname, e.Physic }, "mapname_2");

                entity.HasIndex(e => e.Physic, "physic");

                entity.HasIndex(e => e.Playername, "playername");

                entity.HasIndex(e => e.Rank, "rank");

                entity.HasIndex(e => e.Rectime, "rectime");

                entity.HasIndex(e => e.Ts, "ts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mapname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mapname")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Physic).HasColumnName("physic");

                entity.Property(e => e.Playername)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("playername")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.Rectime).HasColumnName("rectime");

                entity.Property(e => e.Ts)
                    .HasColumnType("datetime")
                    .HasColumnName("ts");

                entity.Property(e => e.Visname)
                    .IsRequired()
                    .HasColumnType("varchar(96)")
                    .HasColumnName("visname")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3News>(entity =>
            {
                entity.ToTable("q3_news");

                entity.HasIndex(e => new { e.UserId, e.Datetime }, "user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("content")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.Headline)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("headline")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Q3NewsComment>(entity =>
            {
                entity.ToTable("q3_news_comments");

                entity.HasIndex(e => new { e.NewsId, e.UserId, e.Datetime }, "news_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("comment")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.Delete).HasColumnName("delete");

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Q3Pinboard>(entity =>
            {
                entity.ToTable("q3_pinboard");

                entity.HasIndex(e => e.Timestamp, "timestamp");

                entity.HasIndex(e => e.Uid, "uid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Del).HasColumnName("del");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("message")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<Q3Server>(entity =>
            {
                entity.ToTable("q3_servers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("comment")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Del).HasColumnName("del");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasColumnType("varchar(6)")
                    .HasColumnName("flag")
                    .HasDefaultValueSql("'noflag'")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("ip")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.Rcon)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("rcon")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3ServersAccess>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ServerId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("q3_servers_access");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.AccessBits).HasColumnName("access_bits");
            });

            modelBuilder.Entity<Q3ServersAccessLog>(entity =>
            {
                entity.ToTable("q3_servers_access_log");

                entity.HasIndex(e => e.AccessId, "access_id");

                entity.HasIndex(e => e.ServerId, "server_id");

                entity.HasIndex(e => e.Timestamp, "timestamp");

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessId).HasColumnName("access_id");

                entity.Property(e => e.Parameter)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("parameter")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Q3ServersBannedMap>(entity =>
            {
                entity.HasKey(e => e.Mapname)
                    .HasName("PRIMARY");

                entity.ToTable("q3_servers_banned_maps");

                entity.Property(e => e.Mapname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mapname")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3ServersStatus>(entity =>
            {
                entity.HasKey(e => e.ServerId)
                    .HasName("PRIMARY");

                entity.ToTable("q3_servers_status");

                entity.Property(e => e.ServerId)
                    .ValueGeneratedNever()
                    .HasColumnName("server_id");

                entity.Property(e => e.CurPlayers).HasColumnName("cur_players");

                entity.Property(e => e.Map)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("map")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaxPlayers).HasColumnName("max_players");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.NameColors)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("name_colors")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Physic).HasColumnName("physic");

                entity.Property(e => e.Speedaward).HasColumnName("speedaward");

                entity.Property(e => e.SpeedawardName)
                    .IsRequired()
                    .HasColumnType("varchar(34)")
                    .HasColumnName("speedaward_name")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3ServersStatusPlayer>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.ServerId, e.UserId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("q3_servers_status_players");

                entity.Property(e => e.PlayerId).HasColumnName("player_id");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("varchar(3)")
                    .HasColumnName("country")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HasSpeedaward).HasColumnName("has_speedaward");

                entity.Property(e => e.IsSpectated).HasColumnName("is_spectated");

                entity.Property(e => e.Mstime).HasColumnName("mstime");

                entity.Property(e => e.NameColors)
                    .IsRequired()
                    .HasColumnType("varchar(35)")
                    .HasColumnName("name_colors")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ping).HasColumnName("ping");

                entity.Property(e => e.SpectatorName)
                    .IsRequired()
                    .HasColumnType("varchar(34)")
                    .HasColumnName("spectator_name")
                    .HasDefaultValueSql("'-1'")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3TypeCountry>(entity =>
            {
                entity.HasKey(e => e.Two)
                    .HasName("PRIMARY");

                entity.ToTable("q3_type_countrys");

                entity.Property(e => e.Two)
                    .HasColumnType("varchar(3)")
                    .HasColumnName("two")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Three)
                    .IsRequired()
                    .HasColumnType("varchar(4)")
                    .HasColumnName("three")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3User>(entity =>
            {
                entity.ToTable("q3_users");

                entity.HasIndex(e => e.StripVisname, "strip_visname")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "username");

                entity.HasIndex(e => e.Visname, "visname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("avatar")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BackendUser).HasColumnName("backend_user");

                entity.Property(e => e.Boardid).HasColumnName("boardid");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("comment")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("varchar(3)")
                    .HasColumnName("country")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dateformat)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("dateformat")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Del).HasColumnName("del");

                entity.Property(e => e.EloStartWert).HasColumnName("elo_start_wert");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hardware)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("hardware")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastActive).HasColumnName("last_active");

                entity.Property(e => e.LastChange)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change");

                entity.Property(e => e.LastLogin).HasColumnName("last_login");

                entity.Property(e => e.Newpw)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("newpw")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Newpwkey)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("newpwkey")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OldUsername)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("old_username")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("password")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serverid).HasColumnName("serverid");

                entity.Property(e => e.Sessionid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sessionid")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StripVisname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("strip_visname")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timezone).HasColumnName("timezone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("username")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Visname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("visname")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WikiAdmin).HasColumnName("wiki_admin");
            });

            modelBuilder.Entity<Q3UsersCopy>(entity =>
            {
                entity.ToTable("q3_users_copy");

                entity.HasIndex(e => e.StripVisname, "strip_visname")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "username");

                entity.HasIndex(e => e.Visname, "visname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("avatar")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BackendUser).HasColumnName("backend_user");

                entity.Property(e => e.Boardid).HasColumnName("boardid");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("comment")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("varchar(3)")
                    .HasColumnName("country")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dateformat)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("dateformat")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Del).HasColumnName("del");

                entity.Property(e => e.EloStartWert).HasColumnName("elo_start_wert");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hardware)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("hardware")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastActive).HasColumnName("last_active");

                entity.Property(e => e.LastLogin).HasColumnName("last_login");

                entity.Property(e => e.OldUsername)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("old_username")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("password")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serverid).HasColumnName("serverid");

                entity.Property(e => e.Sessionid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sessionid")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StripVisname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("strip_visname")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timezone).HasColumnName("timezone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("username")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Visname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("visname")
                    .HasDefaultValueSql("''")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WikiAdmin).HasColumnName("wiki_admin");
            });

            modelBuilder.Entity<Q3UsersOnline>(entity =>
            {
                entity.HasKey(e => new { e.Uid, e.Sessionid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("q3_users_online");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Sessionid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sessionid")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RequestUri)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("request_uri")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("user_agent")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3UsersRight>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PRIMARY");

                entity.ToTable("q3_users_rights");

                entity.Property(e => e.Uid)
                    .ValueGeneratedNever()
                    .HasColumnName("uid");

                entity.Property(e => e.CanAddMddrecords).HasColumnName("can_add_mddrecords");

                entity.Property(e => e.CanNewsAdd).HasColumnName("can_news_add");

                entity.Property(e => e.CanNewsCommentDel).HasColumnName("can_news_comment_del");

                entity.Property(e => e.CanNewsDel).HasColumnName("can_news_del");

                entity.Property(e => e.CanNewsEdit).HasColumnName("can_news_edit");

                entity.Property(e => e.CanRecsDel).HasColumnName("can_recs_del");

                entity.Property(e => e.CanRights).HasColumnName("can_rights");

                entity.Property(e => e.CanUserAdd).HasColumnName("can_user_add");

                entity.Property(e => e.CanUserDel).HasColumnName("can_user_del");

                entity.Property(e => e.CanUserEdit).HasColumnName("can_user_edit");
            });

            modelBuilder.Entity<Q3UsersVote>(entity =>
            {
                entity.HasKey(e => new { e.VoteId, e.AnswerId, e.UserId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("q3_users_votes");

                entity.Property(e => e.VoteId).HasColumnName("vote_id");

                entity.Property(e => e.AnswerId).HasColumnName("answer_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<Q3Vote>(entity =>
            {
                entity.ToTable("q3_votes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateFrom).HasColumnName("date_from");

                entity.Property(e => e.DateTo).HasColumnName("date_to");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Q3VotesAnswer>(entity =>
            {
                entity.ToTable("q3_votes_answer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("answer")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VoteId).HasColumnName("vote_id");
            });

            modelBuilder.Entity<Q3WikiPage>(entity =>
            {
                entity.ToTable("q3_wiki_pages");

                entity.HasIndex(e => e.ParentId, "IDX_8C939A1A727ACA70");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("content")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lft).HasColumnName("lft");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("name")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Rgt).HasColumnName("rgt");

                entity.Property(e => e.Root).HasColumnName("root");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_8C939A1A727ACA70");
            });

            modelBuilder.Entity<Tmp>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("tmp");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.Boardid).HasColumnName("boardid");

                entity.Property(e => e.CountComments).HasColumnName("count_comments");

                entity.Property(e => e.CountPosts).HasColumnName("count_posts");

                entity.Property(e => e.CountRecords).HasColumnName("count_records");

                entity.Property(e => e.CountRecordsHistory).HasColumnName("count_records_history");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_bin");

                entity.Property(e => e.Username)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("username")
                    .HasCharSet(CharSet.Utf8)
                    .HasCollation("utf8_bin");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

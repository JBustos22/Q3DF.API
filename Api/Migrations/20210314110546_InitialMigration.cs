using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "q3_access",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    cmd = table.Column<string>(type: "varchar(50)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_access", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_defrag_demos",
                columns: table => new
                {
                    rec_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    filename = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    size = table.Column<int>(type: "int", nullable: false),
                    datetime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.rec_id);
                });

            migrationBuilder.CreateTable(
                name: "q3_defrag_forbidden_maps",
                columns: table => new
                {
                    id = table.Column<sbyte>(type: "tinyint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mapname = table.Column<string>(type: "varchar(100)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timeout = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_defrag_forbidden_maps", x => x.id);
                },
                comment: "Players cannot vote these maps");

            migrationBuilder.CreateTable(
                name: "q3_defrag_records",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    server_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    nickname = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    map = table.Column<string>(type: "varchar(100)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mstime = table.Column<int>(type: "int", nullable: false),
                    physic = table.Column<int>(type: "int", nullable: false),
                    mode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    userinfostring = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timestamp = table.Column<int>(type: "int", nullable: false),
                    o3j_version = table.Column<string>(type: "varchar(100)", nullable: false, defaultValueSql: "'1016'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    defrag_version = table.Column<string>(type: "varchar(100)", nullable: false, defaultValueSql: "'19108'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_defrag_records", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_defrag_records_history",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    server_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    nickname = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    map = table.Column<string>(type: "varchar(100)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mstime = table.Column<int>(type: "int", nullable: false),
                    physic = table.Column<int>(type: "int", nullable: false),
                    mode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    userinfostring = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timestamp = table.Column<int>(type: "int", nullable: false),
                    o3j_version = table.Column<string>(type: "varchar(100)", nullable: false, defaultValueSql: "'1016'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    defrag_version = table.Column<string>(type: "varchar(100)", nullable: false, defaultValueSql: "'19108'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_defrag_records_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_defrag_records_tmp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    server_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    nickname = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    map = table.Column<string>(type: "varchar(100)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mstime = table.Column<int>(type: "int", nullable: false),
                    physic = table.Column<int>(type: "int", nullable: false),
                    mode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    userinfostring = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timestamp = table.Column<int>(type: "int", nullable: false),
                    o3j_version = table.Column<string>(type: "varchar(100)", nullable: false, defaultValueSql: "'1016'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    defrag_version = table.Column<string>(type: "varchar(100)", nullable: false, defaultValueSql: "'19108'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_defrag_records_tmp", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_ip_to_country",
                columns: table => new
                {
                    IP_from = table.Column<double>(type: "double", nullable: false),
                    IP_to = table.Column<double>(type: "double", nullable: false),
                    zwei = table.Column<string>(type: "char(2)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    drei = table.Column<string>(type: "char(3)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    name = table.Column<string>(type: "varchar(50)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "q3_minnie_records",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mapname = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    playername = table.Column<string>(type: "varchar(32)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    visname = table.Column<string>(type: "varchar(96)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    rectime = table.Column<uint>(type: "int unsigned", nullable: false),
                    physic = table.Column<ushort>(type: "smallint unsigned", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false),
                    ts = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_minnie_records", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_news",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    headline = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    content = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    datetime = table.Column<DateTime>(type: "datetime", nullable: false),
                    locked = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_news", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_news_comments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    news_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    comment = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    datetime = table.Column<DateTime>(type: "datetime", nullable: false),
                    delete = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_news_comments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_pinboard",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<int>(type: "int", nullable: false),
                    message = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timestamp = table.Column<int>(type: "int", nullable: false),
                    del = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_pinboard", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_servers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ip = table.Column<string>(type: "varchar(15)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    port = table.Column<int>(type: "int", nullable: false),
                    rcon = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    name = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    flag = table.Column<string>(type: "varchar(6)", nullable: false, defaultValueSql: "'noflag'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    del = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_servers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_servers_access",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    server_id = table.Column<int>(type: "int", nullable: false),
                    access_bits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.user_id, x.server_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                });

            migrationBuilder.CreateTable(
                name: "q3_servers_access_log",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    server_id = table.Column<int>(type: "int", nullable: false),
                    access_id = table.Column<int>(type: "int", nullable: false),
                    parameter = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timestamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_servers_access_log", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_servers_banned_maps",
                columns: table => new
                {
                    mapname = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    comment = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.mapname);
                });

            migrationBuilder.CreateTable(
                name: "q3_servers_status",
                columns: table => new
                {
                    server_id = table.Column<int>(type: "int", nullable: false),
                    name_colors = table.Column<string>(type: "varchar(100)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    map = table.Column<string>(type: "varchar(50)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    cur_players = table.Column<int>(type: "int", nullable: false),
                    max_players = table.Column<int>(type: "int", nullable: false),
                    speedaward = table.Column<int>(type: "int", nullable: false),
                    speedaward_name = table.Column<string>(type: "varchar(34)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    physic = table.Column<int>(type: "int", nullable: false),
                    mode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.server_id);
                });

            migrationBuilder.CreateTable(
                name: "q3_servers_status_players",
                columns: table => new
                {
                    player_id = table.Column<int>(type: "int", nullable: false),
                    server_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    name_colors = table.Column<string>(type: "varchar(35)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ping = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "varchar(3)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    spectator_name = table.Column<string>(type: "varchar(34)", nullable: false, defaultValueSql: "'-1'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    mstime = table.Column<int>(type: "int", nullable: false),
                    is_spectated = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    has_speedaward = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.player_id, x.server_id, x.user_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                });

            migrationBuilder.CreateTable(
                name: "q3_type_countrys",
                columns: table => new
                {
                    two = table.Column<string>(type: "varchar(3)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    name = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    three = table.Column<string>(type: "varchar(4)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.two);
                });

            migrationBuilder.CreateTable(
                name: "q3_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    password = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    visname = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    strip_visname = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    serverid = table.Column<int>(type: "int", nullable: false),
                    last_active = table.Column<int>(type: "int", nullable: false),
                    last_login = table.Column<int>(type: "int", nullable: false),
                    elo_start_wert = table.Column<int>(type: "int", nullable: false),
                    sessionid = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    avatar = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    hardware = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country = table.Column<string>(type: "varchar(3)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    dateformat = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timezone = table.Column<int>(type: "int", nullable: false),
                    del = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    old_username = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    boardid = table.Column<int>(type: "int", nullable: false),
                    backend_user = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    wiki_admin = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    newpw = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    newpwkey = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    last_change = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_users_copy",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    password = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    visname = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    strip_visname = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    serverid = table.Column<int>(type: "int", nullable: false),
                    last_active = table.Column<int>(type: "int", nullable: false),
                    last_login = table.Column<int>(type: "int", nullable: false),
                    elo_start_wert = table.Column<int>(type: "int", nullable: false),
                    sessionid = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    avatar = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    hardware = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    country = table.Column<string>(type: "varchar(3)", nullable: false, defaultValueSql: "''", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    dateformat = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timezone = table.Column<int>(type: "int", nullable: false),
                    del = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    old_username = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    boardid = table.Column<int>(type: "int", nullable: false),
                    backend_user = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    wiki_admin = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_users_copy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_users_online",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: false),
                    sessionid = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    user_agent = table.Column<string>(type: "mediumtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    request_uri = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    timestamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.uid, x.sessionid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                });

            migrationBuilder.CreateTable(
                name: "q3_users_rights",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: false),
                    can_news_add = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_news_edit = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_news_del = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_news_comment_del = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_user_add = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_user_edit = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_user_del = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_add_mddrecords = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_recs_del = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    can_rights = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "q3_users_votes",
                columns: table => new
                {
                    vote_id = table.Column<int>(type: "int", nullable: false),
                    answer_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    timestamp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.vote_id, x.answer_id, x.user_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                });

            migrationBuilder.CreateTable(
                name: "q3_votes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date_from = table.Column<int>(type: "int", nullable: false),
                    date_to = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_votes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_votes_answer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    vote_id = table.Column<int>(type: "int", nullable: false),
                    answer = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_votes_answer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "q3_wiki_pages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    parent_id = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "varchar(64)", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    content = table.Column<string>(type: "longtext", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    lft = table.Column<int>(type: "int", nullable: false),
                    lvl = table.Column<int>(type: "int", nullable: false),
                    rgt = table.Column<int>(type: "int", nullable: false),
                    root = table.Column<int>(type: "int", nullable: true),
                    active = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_q3_wiki_pages", x => x.id);
                    table.ForeignKey(
                        name: "FK_8C939A1A727ACA70",
                        column: x => x.parent_id,
                        principalTable: "q3_wiki_pages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "tmp",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "varchar(255)", nullable: true, collation: "utf8_bin")
                        .Annotation("MySql:CharSet", "utf8"),
                    boardid = table.Column<int>(type: "int", nullable: true),
                    username = table.Column<string>(type: "varchar(255)", nullable: true, collation: "utf8_bin")
                        .Annotation("MySql:CharSet", "utf8"),
                    count_records = table.Column<int>(type: "int", nullable: true),
                    count_records_history = table.Column<int>(type: "int", nullable: true),
                    count_comments = table.Column<int>(type: "int", nullable: true),
                    count_posts = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.user_id);
                });

            migrationBuilder.CreateIndex(
                name: "mapname",
                table: "q3_defrag_forbidden_maps",
                column: "mapname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx",
                table: "q3_defrag_records",
                columns: new[] { "server_id", "user_id", "map", "mstime", "physic", "mode", "timestamp", "status" });

            migrationBuilder.CreateIndex(
                name: "map",
                table: "q3_defrag_records",
                column: "map");

            migrationBuilder.CreateIndex(
                name: "map_2",
                table: "q3_defrag_records",
                columns: new[] { "map", "physic", "mode" });

            migrationBuilder.CreateIndex(
                name: "mstime",
                table: "q3_defrag_records",
                column: "mstime");

            migrationBuilder.CreateIndex(
                name: "places",
                table: "q3_defrag_records",
                columns: new[] { "map", "physic", "mode", "mstime" });

            migrationBuilder.CreateIndex(
                name: "timestamp",
                table: "q3_defrag_records",
                column: "timestamp");

            migrationBuilder.CreateIndex(
                name: "user_id",
                table: "q3_defrag_records",
                columns: new[] { "user_id", "map", "physic", "mode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "auth",
                table: "q3_defrag_records_history",
                columns: new[] { "map", "physic", "mode" });

            migrationBuilder.CreateIndex(
                name: "mstime1",
                table: "q3_defrag_records_history",
                column: "mstime");

            migrationBuilder.CreateIndex(
                name: "server_id",
                table: "q3_defrag_records_history",
                column: "server_id");

            migrationBuilder.CreateIndex(
                name: "user_id_2",
                table: "q3_defrag_records_history",
                columns: new[] { "user_id", "physic", "mode", "map" });

            migrationBuilder.CreateIndex(
                name: "user_id_3",
                table: "q3_defrag_records_history",
                columns: new[] { "user_id", "map", "mstime", "physic", "mode" });

            migrationBuilder.CreateIndex(
                name: "user_id1",
                table: "q3_defrag_records_history",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "mapname_2",
                table: "q3_minnie_records",
                columns: new[] { "mapname", "physic" });

            migrationBuilder.CreateIndex(
                name: "mapname1",
                table: "q3_minnie_records",
                column: "mapname");

            migrationBuilder.CreateIndex(
                name: "physic",
                table: "q3_minnie_records",
                column: "physic");

            migrationBuilder.CreateIndex(
                name: "playername",
                table: "q3_minnie_records",
                column: "playername");

            migrationBuilder.CreateIndex(
                name: "rank",
                table: "q3_minnie_records",
                column: "rank");

            migrationBuilder.CreateIndex(
                name: "rectime",
                table: "q3_minnie_records",
                column: "rectime");

            migrationBuilder.CreateIndex(
                name: "ts",
                table: "q3_minnie_records",
                column: "ts");

            migrationBuilder.CreateIndex(
                name: "user_id2",
                table: "q3_news",
                columns: new[] { "user_id", "datetime" });

            migrationBuilder.CreateIndex(
                name: "news_id",
                table: "q3_news_comments",
                columns: new[] { "news_id", "user_id", "datetime" });

            migrationBuilder.CreateIndex(
                name: "timestamp1",
                table: "q3_pinboard",
                column: "timestamp");

            migrationBuilder.CreateIndex(
                name: "uid",
                table: "q3_pinboard",
                column: "uid");

            migrationBuilder.CreateIndex(
                name: "access_id",
                table: "q3_servers_access_log",
                column: "access_id");

            migrationBuilder.CreateIndex(
                name: "server_id1",
                table: "q3_servers_access_log",
                column: "server_id");

            migrationBuilder.CreateIndex(
                name: "timestamp2",
                table: "q3_servers_access_log",
                column: "timestamp");

            migrationBuilder.CreateIndex(
                name: "user_id3",
                table: "q3_servers_access_log",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "strip_visname",
                table: "q3_users",
                column: "strip_visname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "username",
                table: "q3_users",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "visname",
                table: "q3_users",
                column: "visname");

            migrationBuilder.CreateIndex(
                name: "strip_visname1",
                table: "q3_users_copy",
                column: "strip_visname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "username1",
                table: "q3_users_copy",
                column: "username");

            migrationBuilder.CreateIndex(
                name: "visname1",
                table: "q3_users_copy",
                column: "visname");

            migrationBuilder.CreateIndex(
                name: "IDX_8C939A1A727ACA70",
                table: "q3_wiki_pages",
                column: "parent_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "q3_access");

            migrationBuilder.DropTable(
                name: "q3_defrag_demos");

            migrationBuilder.DropTable(
                name: "q3_defrag_forbidden_maps");

            migrationBuilder.DropTable(
                name: "q3_defrag_records");

            migrationBuilder.DropTable(
                name: "q3_defrag_records_history");

            migrationBuilder.DropTable(
                name: "q3_defrag_records_tmp");

            migrationBuilder.DropTable(
                name: "q3_ip_to_country");

            migrationBuilder.DropTable(
                name: "q3_minnie_records");

            migrationBuilder.DropTable(
                name: "q3_news");

            migrationBuilder.DropTable(
                name: "q3_news_comments");

            migrationBuilder.DropTable(
                name: "q3_pinboard");

            migrationBuilder.DropTable(
                name: "q3_servers");

            migrationBuilder.DropTable(
                name: "q3_servers_access");

            migrationBuilder.DropTable(
                name: "q3_servers_access_log");

            migrationBuilder.DropTable(
                name: "q3_servers_banned_maps");

            migrationBuilder.DropTable(
                name: "q3_servers_status");

            migrationBuilder.DropTable(
                name: "q3_servers_status_players");

            migrationBuilder.DropTable(
                name: "q3_type_countrys");

            migrationBuilder.DropTable(
                name: "q3_users");

            migrationBuilder.DropTable(
                name: "q3_users_copy");

            migrationBuilder.DropTable(
                name: "q3_users_online");

            migrationBuilder.DropTable(
                name: "q3_users_rights");

            migrationBuilder.DropTable(
                name: "q3_users_votes");

            migrationBuilder.DropTable(
                name: "q3_votes");

            migrationBuilder.DropTable(
                name: "q3_votes_answer");

            migrationBuilder.DropTable(
                name: "q3_wiki_pages");

            migrationBuilder.DropTable(
                name: "tmp");
        }
    }
}

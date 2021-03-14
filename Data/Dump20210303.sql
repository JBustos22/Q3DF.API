-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: defrag
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `q3_access`
--

DROP TABLE IF EXISTS `q3_access`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_access` (
  `id` int NOT NULL AUTO_INCREMENT,
  `description` varchar(255) NOT NULL,
  `cmd` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_access`
--

LOCK TABLES `q3_access` WRITE;
/*!40000 ALTER TABLE `q3_access` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_access` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_defrag_demos`
--

DROP TABLE IF EXISTS `q3_defrag_demos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_defrag_demos` (
  `rec_id` int NOT NULL AUTO_INCREMENT,
  `filename` varchar(255) NOT NULL DEFAULT '',
  `size` int NOT NULL DEFAULT '0',
  `datetime` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `counter` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`rec_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_defrag_demos`
--

LOCK TABLES `q3_defrag_demos` WRITE;
/*!40000 ALTER TABLE `q3_defrag_demos` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_defrag_demos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_defrag_forbidden_maps`
--

DROP TABLE IF EXISTS `q3_defrag_forbidden_maps`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_defrag_forbidden_maps` (
  `id` tinyint NOT NULL AUTO_INCREMENT,
  `mapname` varchar(100) NOT NULL,
  `timeout` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `mapname` (`mapname`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Players cannot vote these maps';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_defrag_forbidden_maps`
--

LOCK TABLES `q3_defrag_forbidden_maps` WRITE;
/*!40000 ALTER TABLE `q3_defrag_forbidden_maps` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_defrag_forbidden_maps` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_defrag_records`
--

DROP TABLE IF EXISTS `q3_defrag_records`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_defrag_records` (
  `id` int NOT NULL AUTO_INCREMENT,
  `server_id` int NOT NULL,
  `user_id` int NOT NULL,
  `nickname` text NOT NULL,
  `map` varchar(100) NOT NULL,
  `mstime` int NOT NULL,
  `physic` int NOT NULL,
  `mode` tinyint(1) NOT NULL,
  `userinfostring` mediumtext NOT NULL,
  `timestamp` int NOT NULL,
  `o3j_version` varchar(100) NOT NULL DEFAULT '1016',
  `defrag_version` varchar(100) NOT NULL DEFAULT '19108',
  `status` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `user_id` (`user_id`,`map`,`physic`,`mode`),
  KEY `map` (`map`),
  KEY `places` (`map`,`physic`,`mode`,`mstime`),
  KEY `mstime` (`mstime`),
  KEY `map_2` (`map`,`physic`,`mode`),
  KEY `idx` (`server_id`,`user_id`,`map`,`mstime`,`physic`,`mode`,`timestamp`,`status`),
  KEY `timestamp` (`timestamp`)
) ENGINE=InnoDB AUTO_INCREMENT=513533 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_defrag_records`
--

LOCK TABLES `q3_defrag_records` WRITE;
/*!40000 ALTER TABLE `q3_defrag_records` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_defrag_records` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_defrag_records_history`
--

DROP TABLE IF EXISTS `q3_defrag_records_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_defrag_records_history` (
  `id` int NOT NULL AUTO_INCREMENT,
  `server_id` int NOT NULL,
  `user_id` int NOT NULL,
  `nickname` text NOT NULL,
  `map` varchar(100) NOT NULL,
  `mstime` int NOT NULL,
  `physic` int NOT NULL,
  `mode` tinyint(1) NOT NULL,
  `userinfostring` mediumtext NOT NULL,
  `timestamp` int NOT NULL,
  `o3j_version` varchar(100) NOT NULL DEFAULT '1016',
  `defrag_version` varchar(100) NOT NULL DEFAULT '19108',
  PRIMARY KEY (`id`),
  KEY `server_id` (`server_id`),
  KEY `auth` (`map`,`physic`,`mode`),
  KEY `user_id` (`user_id`),
  KEY `mstime` (`mstime`),
  KEY `user_id_2` (`user_id`,`physic`,`mode`,`map`),
  KEY `user_id_3` (`user_id`,`map`,`mstime`,`physic`,`mode`)
) ENGINE=InnoDB AUTO_INCREMENT=2203529 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_defrag_records_history`
--

LOCK TABLES `q3_defrag_records_history` WRITE;
/*!40000 ALTER TABLE `q3_defrag_records_history` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_defrag_records_history` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_defrag_records_tmp`
--

DROP TABLE IF EXISTS `q3_defrag_records_tmp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_defrag_records_tmp` (
  `id` int NOT NULL AUTO_INCREMENT,
  `server_id` int NOT NULL,
  `user_id` int NOT NULL,
  `nickname` text NOT NULL,
  `map` varchar(100) NOT NULL,
  `mstime` int NOT NULL,
  `physic` int NOT NULL,
  `mode` tinyint(1) NOT NULL,
  `userinfostring` mediumtext NOT NULL,
  `timestamp` int NOT NULL,
  `o3j_version` varchar(100) NOT NULL DEFAULT '1016',
  `defrag_version` varchar(100) NOT NULL DEFAULT '19108',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=117442 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_defrag_records_tmp`
--

LOCK TABLES `q3_defrag_records_tmp` WRITE;
/*!40000 ALTER TABLE `q3_defrag_records_tmp` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_defrag_records_tmp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_ip_to_country`
--

DROP TABLE IF EXISTS `q3_ip_to_country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_ip_to_country` (
  `IP_from` double NOT NULL,
  `IP_to` double NOT NULL,
  `zwei` char(2) NOT NULL,
  `drei` char(3) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_ip_to_country`
--

LOCK TABLES `q3_ip_to_country` WRITE;
/*!40000 ALTER TABLE `q3_ip_to_country` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_ip_to_country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_minnie_records`
--

DROP TABLE IF EXISTS `q3_minnie_records`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_minnie_records` (
  `id` int NOT NULL AUTO_INCREMENT,
  `mapname` varchar(255) NOT NULL DEFAULT '',
  `playername` varchar(32) NOT NULL DEFAULT '',
  `visname` varchar(96) NOT NULL DEFAULT '',
  `rectime` int unsigned NOT NULL DEFAULT '0',
  `physic` smallint unsigned NOT NULL DEFAULT '0',
  `rank` int NOT NULL DEFAULT '0',
  `ts` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `mapname` (`mapname`),
  KEY `rectime` (`rectime`),
  KEY `physic` (`physic`),
  KEY `playername` (`playername`),
  KEY `ts` (`ts`),
  KEY `rank` (`rank`),
  KEY `mapname_2` (`mapname`,`physic`)
) ENGINE=InnoDB AUTO_INCREMENT=258300 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_minnie_records`
--

LOCK TABLES `q3_minnie_records` WRITE;
/*!40000 ALTER TABLE `q3_minnie_records` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_minnie_records` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_news`
--

DROP TABLE IF EXISTS `q3_news`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_news` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL DEFAULT '0',
  `headline` varchar(255) NOT NULL DEFAULT '',
  `content` mediumtext NOT NULL,
  `datetime` datetime NOT NULL,
  `locked` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`,`datetime`)
) ENGINE=InnoDB AUTO_INCREMENT=89 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_news`
--

LOCK TABLES `q3_news` WRITE;
/*!40000 ALTER TABLE `q3_news` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_news` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_news_comments`
--

DROP TABLE IF EXISTS `q3_news_comments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_news_comments` (
  `id` int NOT NULL AUTO_INCREMENT,
  `news_id` int NOT NULL DEFAULT '0',
  `user_id` int NOT NULL DEFAULT '0',
  `comment` mediumtext NOT NULL,
  `datetime` datetime NOT NULL,
  `delete` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `news_id` (`news_id`,`user_id`,`datetime`)
) ENGINE=InnoDB AUTO_INCREMENT=2244 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_news_comments`
--

LOCK TABLES `q3_news_comments` WRITE;
/*!40000 ALTER TABLE `q3_news_comments` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_news_comments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_pinboard`
--

DROP TABLE IF EXISTS `q3_pinboard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_pinboard` (
  `id` int NOT NULL AUTO_INCREMENT,
  `uid` int NOT NULL,
  `message` mediumtext NOT NULL,
  `timestamp` int NOT NULL DEFAULT '0',
  `del` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `uid` (`uid`),
  KEY `timestamp` (`timestamp`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=18131 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_pinboard`
--

LOCK TABLES `q3_pinboard` WRITE;
/*!40000 ALTER TABLE `q3_pinboard` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_pinboard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_servers`
--

DROP TABLE IF EXISTS `q3_servers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_servers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ip` varchar(15) NOT NULL DEFAULT '',
  `port` int NOT NULL DEFAULT '0',
  `rcon` varchar(255) NOT NULL DEFAULT '',
  `name` varchar(255) NOT NULL,
  `flag` varchar(6) NOT NULL DEFAULT 'noflag',
  `del` tinyint unsigned NOT NULL DEFAULT '0',
  `comment` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=401 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_servers`
--

LOCK TABLES `q3_servers` WRITE;
/*!40000 ALTER TABLE `q3_servers` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_servers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_servers_access`
--

DROP TABLE IF EXISTS `q3_servers_access`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_servers_access` (
  `user_id` int NOT NULL DEFAULT '0',
  `server_id` int NOT NULL DEFAULT '0',
  `access_bits` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`user_id`,`server_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_servers_access`
--

LOCK TABLES `q3_servers_access` WRITE;
/*!40000 ALTER TABLE `q3_servers_access` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_servers_access` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_servers_access_log`
--

DROP TABLE IF EXISTS `q3_servers_access_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_servers_access_log` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL DEFAULT '0',
  `server_id` int NOT NULL DEFAULT '0',
  `access_id` int NOT NULL DEFAULT '0',
  `parameter` text NOT NULL,
  `timestamp` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`),
  KEY `server_id` (`server_id`),
  KEY `access_id` (`access_id`),
  KEY `timestamp` (`timestamp`)
) ENGINE=InnoDB AUTO_INCREMENT=1169 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_servers_access_log`
--

LOCK TABLES `q3_servers_access_log` WRITE;
/*!40000 ALTER TABLE `q3_servers_access_log` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_servers_access_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_servers_banned_maps`
--

DROP TABLE IF EXISTS `q3_servers_banned_maps`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_servers_banned_maps` (
  `mapname` varchar(255) NOT NULL,
  `comment` text,
  PRIMARY KEY (`mapname`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_servers_banned_maps`
--

LOCK TABLES `q3_servers_banned_maps` WRITE;
/*!40000 ALTER TABLE `q3_servers_banned_maps` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_servers_banned_maps` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_servers_status`
--

DROP TABLE IF EXISTS `q3_servers_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_servers_status` (
  `server_id` int NOT NULL,
  `name_colors` varchar(100) NOT NULL,
  `map` varchar(50) NOT NULL,
  `cur_players` int NOT NULL,
  `max_players` int NOT NULL,
  `speedaward` int NOT NULL,
  `speedaward_name` varchar(34) NOT NULL,
  `physic` int NOT NULL,
  `mode` int NOT NULL,
  PRIMARY KEY (`server_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_servers_status`
--

LOCK TABLES `q3_servers_status` WRITE;
/*!40000 ALTER TABLE `q3_servers_status` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_servers_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_servers_status_players`
--

DROP TABLE IF EXISTS `q3_servers_status_players`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_servers_status_players` (
  `player_id` int NOT NULL,
  `server_id` int NOT NULL,
  `name_colors` varchar(35) NOT NULL,
  `ping` int NOT NULL,
  `country` varchar(3) NOT NULL,
  `user_id` int NOT NULL,
  `spectator_name` varchar(34) NOT NULL DEFAULT '-1',
  `mstime` int NOT NULL,
  `is_spectated` tinyint(1) NOT NULL,
  `has_speedaward` tinyint(1) NOT NULL,
  PRIMARY KEY (`player_id`,`server_id`,`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_servers_status_players`
--

LOCK TABLES `q3_servers_status_players` WRITE;
/*!40000 ALTER TABLE `q3_servers_status_players` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_servers_status_players` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_type_countrys`
--

DROP TABLE IF EXISTS `q3_type_countrys`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_type_countrys` (
  `name` varchar(255) NOT NULL DEFAULT '',
  `two` varchar(3) NOT NULL DEFAULT '',
  `three` varchar(4) NOT NULL DEFAULT '',
  PRIMARY KEY (`two`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_type_countrys`
--

LOCK TABLES `q3_type_countrys` WRITE;
/*!40000 ALTER TABLE `q3_type_countrys` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_type_countrys` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_users`
--

DROP TABLE IF EXISTS `q3_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL DEFAULT '',
  `password` varchar(255) NOT NULL DEFAULT '',
  `email` varchar(255) NOT NULL,
  `visname` varchar(255) NOT NULL DEFAULT '',
  `strip_visname` varchar(255) NOT NULL,
  `serverid` int NOT NULL,
  `last_active` int NOT NULL DEFAULT '0',
  `last_login` int NOT NULL DEFAULT '0',
  `elo_start_wert` int NOT NULL,
  `sessionid` varchar(255) NOT NULL,
  `avatar` varchar(255) NOT NULL,
  `hardware` mediumtext NOT NULL,
  `country` varchar(3) NOT NULL DEFAULT '',
  `dateformat` varchar(255) NOT NULL,
  `timezone` int NOT NULL,
  `del` tinyint(1) NOT NULL DEFAULT '0',
  `old_username` varchar(255) NOT NULL,
  `boardid` int NOT NULL,
  `backend_user` tinyint(1) NOT NULL DEFAULT '0',
  `wiki_admin` tinyint unsigned NOT NULL DEFAULT '0',
  `comment` text NOT NULL,
  `newpw` varchar(255) NOT NULL,
  `newpwkey` varchar(255) NOT NULL,
  `last_change` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `strip_visname_2` (`strip_visname`),
  KEY `visname` (`visname`),
  KEY `username` (`username`),
  KEY `strip_visname` (`strip_visname`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=12007 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_users`
--

LOCK TABLES `q3_users` WRITE;
/*!40000 ALTER TABLE `q3_users` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_users_copy`
--

DROP TABLE IF EXISTS `q3_users_copy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_users_copy` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL DEFAULT '',
  `password` varchar(255) NOT NULL DEFAULT '',
  `email` varchar(255) NOT NULL,
  `visname` varchar(255) NOT NULL DEFAULT '',
  `strip_visname` varchar(255) NOT NULL,
  `serverid` int NOT NULL,
  `last_active` int NOT NULL DEFAULT '0',
  `last_login` int NOT NULL DEFAULT '0',
  `elo_start_wert` int NOT NULL,
  `sessionid` varchar(255) NOT NULL,
  `avatar` varchar(255) NOT NULL,
  `hardware` mediumtext NOT NULL,
  `country` varchar(3) NOT NULL DEFAULT '',
  `dateformat` varchar(255) NOT NULL,
  `timezone` int NOT NULL,
  `del` tinyint(1) NOT NULL DEFAULT '0',
  `old_username` varchar(255) NOT NULL,
  `boardid` int NOT NULL,
  `backend_user` tinyint(1) NOT NULL DEFAULT '0',
  `wiki_admin` tinyint unsigned NOT NULL DEFAULT '0',
  `comment` text NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `strip_visname_2` (`strip_visname`),
  KEY `visname` (`visname`),
  KEY `username` (`username`),
  KEY `strip_visname` (`strip_visname`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=9779 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_users_copy`
--

LOCK TABLES `q3_users_copy` WRITE;
/*!40000 ALTER TABLE `q3_users_copy` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_users_copy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_users_online`
--

DROP TABLE IF EXISTS `q3_users_online`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_users_online` (
  `uid` int NOT NULL,
  `sessionid` varchar(255) NOT NULL,
  `user_agent` mediumtext NOT NULL,
  `request_uri` text NOT NULL,
  `timestamp` int NOT NULL,
  PRIMARY KEY (`uid`,`sessionid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_users_online`
--

LOCK TABLES `q3_users_online` WRITE;
/*!40000 ALTER TABLE `q3_users_online` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_users_online` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_users_rights`
--

DROP TABLE IF EXISTS `q3_users_rights`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_users_rights` (
  `uid` int NOT NULL DEFAULT '0',
  `can_news_add` tinyint(1) NOT NULL DEFAULT '0',
  `can_news_edit` tinyint(1) NOT NULL DEFAULT '0',
  `can_news_del` tinyint(1) NOT NULL DEFAULT '0',
  `can_news_comment_del` tinyint(1) NOT NULL DEFAULT '0',
  `can_user_add` tinyint(1) NOT NULL DEFAULT '0',
  `can_user_edit` tinyint(1) NOT NULL DEFAULT '0',
  `can_user_del` tinyint(1) NOT NULL DEFAULT '0',
  `can_add_mddrecords` tinyint(1) NOT NULL DEFAULT '0',
  `can_recs_del` tinyint(1) NOT NULL DEFAULT '0',
  `can_rights` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_users_rights`
--

LOCK TABLES `q3_users_rights` WRITE;
/*!40000 ALTER TABLE `q3_users_rights` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_users_rights` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_users_votes`
--

DROP TABLE IF EXISTS `q3_users_votes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_users_votes` (
  `vote_id` int NOT NULL,
  `answer_id` int NOT NULL,
  `user_id` int NOT NULL,
  `timestamp` int NOT NULL,
  PRIMARY KEY (`vote_id`,`answer_id`,`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_users_votes`
--

LOCK TABLES `q3_users_votes` WRITE;
/*!40000 ALTER TABLE `q3_users_votes` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_users_votes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_votes`
--

DROP TABLE IF EXISTS `q3_votes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_votes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `date_from` int NOT NULL,
  `date_to` int NOT NULL,
  `title` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_votes`
--

LOCK TABLES `q3_votes` WRITE;
/*!40000 ALTER TABLE `q3_votes` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_votes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_votes_answer`
--

DROP TABLE IF EXISTS `q3_votes_answer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_votes_answer` (
  `id` int NOT NULL AUTO_INCREMENT,
  `vote_id` int NOT NULL,
  `answer` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_votes_answer`
--

LOCK TABLES `q3_votes_answer` WRITE;
/*!40000 ALTER TABLE `q3_votes_answer` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_votes_answer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `q3_wiki_pages`
--

DROP TABLE IF EXISTS `q3_wiki_pages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `q3_wiki_pages` (
  `id` int NOT NULL AUTO_INCREMENT,
  `parent_id` int DEFAULT NULL,
  `name` varchar(64) NOT NULL,
  `content` longtext NOT NULL,
  `lft` int NOT NULL,
  `lvl` int NOT NULL,
  `rgt` int NOT NULL,
  `root` int DEFAULT NULL,
  `active` tinyint unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `IDX_8C939A1A727ACA70` (`parent_id`),
  CONSTRAINT `FK_8C939A1A727ACA70` FOREIGN KEY (`parent_id`) REFERENCES `q3_wiki_pages` (`id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=197 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `q3_wiki_pages`
--

LOCK TABLES `q3_wiki_pages` WRITE;
/*!40000 ALTER TABLE `q3_wiki_pages` DISABLE KEYS */;
/*!40000 ALTER TABLE `q3_wiki_pages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tmp`
--

DROP TABLE IF EXISTS `tmp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tmp` (
  `user_id` int NOT NULL DEFAULT '0',
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `boardid` int DEFAULT NULL,
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `count_records` int DEFAULT NULL,
  `count_records_history` int DEFAULT NULL,
  `count_comments` int DEFAULT NULL,
  `count_posts` int DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tmp`
--

LOCK TABLES `tmp` WRITE;
/*!40000 ALTER TABLE `tmp` DISABLE KEYS */;
/*!40000 ALTER TABLE `tmp` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-03 17:55:52

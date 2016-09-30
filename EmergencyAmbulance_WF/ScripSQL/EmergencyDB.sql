CREATE DATABASE  IF NOT EXISTS `emergency` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `emergency`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: emergency
-- ------------------------------------------------------
-- Server version	5.7.15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ambulanciasdisponibles`
--

DROP TABLE IF EXISTS `ambulanciasdisponibles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ambulanciasdisponibles` (
  `idAmbulancia` int(11) NOT NULL AUTO_INCREMENT,
  `nombreAmbulancia` varchar(150) DEFAULT NULL,
  `combustibleAmbulancia` double DEFAULT NULL,
  `disponibleAmbulancia` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idAmbulancia`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ambulanciasdisponibles`
--

LOCK TABLES `ambulanciasdisponibles` WRITE;
/*!40000 ALTER TABLE `ambulanciasdisponibles` DISABLE KEYS */;
INSERT INTO `ambulanciasdisponibles` VALUES (1,'Ambulancia XFC-456',100,'No Disponible'),(2,'Ambulancia XFC-457',94.6,'No Disponible'),(3,'Ambulancia XFC-458',100,'Disponible'),(4,'Ambulancia XFC-459',90,'Disponible'),(5,'Ambulancia XFC-460',100,'Disponible'),(6,'Ambulancia XFC-461',100,'Disponible'),(7,'Ambulancia XFC-452',100,'Disponible'),(8,'Ambulancia XFC-463',87.5,'Disponible'),(9,'Ambulancia XFC-464',50,'No Disponible'),(10,'Ambulancia XFC-465',50,'No Disponible');
/*!40000 ALTER TABLE `ambulanciasdisponibles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ambulanciasemergencias`
--

DROP TABLE IF EXISTS `ambulanciasemergencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ambulanciasemergencias` (
  `idEmergencia` int(11) NOT NULL AUTO_INCREMENT,
  `idAmbulancia` int(11) DEFAULT NULL,
  `ubicacionEmergencia` varchar(300) DEFAULT NULL,
  `horaSalidaEmergencia` text,
  PRIMARY KEY (`idEmergencia`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ambulanciasemergencias`
--

LOCK TABLES `ambulanciasemergencias` WRITE;
/*!40000 ALTER TABLE `ambulanciasemergencias` DISABLE KEYS */;
INSERT INTO `ambulanciasemergencias` VALUES (1,1,'25.5093054585857,-103.4181982969','30/09/2016 02:59:28 p. m.'),(2,1,'25.7797121597123,-103.576034851621','30/09/2016 03:00:41 p. m.'),(3,1,'25.4440118474533,-103.65089841177','30/09/2016 03:00:57 p. m.'),(4,1,'25.3502174246996,-103.352909229938','30/09/2016 03:01:04 p. m.'),(5,1,'25.5655320175041,-103.255005976888','30/09/2016 03:04:57 p. m.'),(6,2,'25.3998018234946,-103.2131199199','30/09/2016 03:05:07 p. m.');
/*!40000 ALTER TABLE `ambulanciasemergencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ambulanciashistorial`
--

DROP TABLE IF EXISTS `ambulanciashistorial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ambulanciashistorial` (
  `idEmergencia` int(11) NOT NULL,
  `idAmbulancia` int(11) DEFAULT NULL,
  `ubicacionEmergencia` text,
  `horaSalidaEmergencia` text,
  `horaEntradaEmergencia` text,
  PRIMARY KEY (`idEmergencia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ambulanciashistorial`
--

LOCK TABLES `ambulanciashistorial` WRITE;
/*!40000 ALTER TABLE `ambulanciashistorial` DISABLE KEYS */;
/*!40000 ALTER TABLE `ambulanciashistorial` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-09-30 15:08:36

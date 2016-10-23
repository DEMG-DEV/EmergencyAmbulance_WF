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
  `disponibleAmbulancia` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idAmbulancia`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ambulanciasdisponibles`
--

LOCK TABLES `ambulanciasdisponibles` WRITE;
/*!40000 ALTER TABLE `ambulanciasdisponibles` DISABLE KEYS */;
INSERT INTO `ambulanciasdisponibles` VALUES (1,'Ambulancia XFC-456','Disponible'),(2,'Ambulancia XFC-457','Disponible'),(3,'Ambulancia XFC-458','Disponible'),(4,'Ambulancia XFC-459','Disponible'),(5,'Ambulancia XFC-460','Disponible'),(6,'Ambulancia XFC-461','Disponible'),(7,'Ambulancia XFC-452','Disponible'),(8,'Ambulancia XFC-463','Disponible'),(9,'Ambulancia XFC-464','Disponible'),(10,'Ambulancia XFC-465','Disponible');
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ambulanciasemergencias`
--

LOCK TABLES `ambulanciasemergencias` WRITE;
/*!40000 ALTER TABLE `ambulanciasemergencias` DISABLE KEYS */;
/*!40000 ALTER TABLE `ambulanciasemergencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ambulanciashistorial`
--

DROP TABLE IF EXISTS `ambulanciashistorial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ambulanciashistorial` (
  `idEmergencia` int(11) NOT NULL AUTO_INCREMENT,
  `idAmbulancia` int(11) DEFAULT NULL,
  `ubicacionEmergencia` text,
  `horaSalidaEmergencia` text,
  `horaEntradaEmergencia` text,
  PRIMARY KEY (`idEmergencia`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ambulanciashistorial`
--

LOCK TABLES `ambulanciashistorial` WRITE;
/*!40000 ALTER TABLE `ambulanciashistorial` DISABLE KEYS */;
INSERT INTO `ambulanciashistorial` VALUES (1,1,'25.5193536903939,-103.393792359061','17/10/2016 06:36:35 p. m.','17/10/2016 06:36:47 p. m.'),(2,1,'25.5303167457943,-103.437389883824','19/10/2016 02:52:40 p. m.','19/10/2016 02:52:54 p. m.'),(3,2,'25.5745593929059,-103.404281807824','19/10/2016 02:52:47 p. m.','19/10/2016 02:52:52 p. m.'),(13,1,'25.5263687796685,-103.396504509517','15/10/2016 05:24:53 p. m.','16/10/2016 02:40:20 p. m.'),(14,2,'25.5662743371073,-103.396175696688','15/10/2016 05:25:08 p. m.','16/10/2016 02:51:54 p. m.'),(15,3,'25.5754354719547,-103.418991651335','15/10/2016 05:31:16 p. m.','16/10/2016 02:54:22 p. m.'),(16,4,'25.5254801366791,-103.369675112967','15/10/2016 05:31:27 p. m.','16/10/2016 02:54:24 p. m.'),(17,5,'25.540815004451,-103.442677571418','15/10/2016 05:35:46 p. m.','16/10/2016 02:54:26 p. m.'),(18,6,'25.5526789001876,-103.36034298454','15/10/2016 05:35:59 p. m.','16/10/2016 02:54:28 p. m.'),(19,1,'25.5654417195157,-103.440292824218','16/10/2016 02:54:04 p. m.','16/10/2016 02:54:15 p. m.'),(20,1,'25.5522488745257,-103.442545226114','16/10/2016 06:10:29 p. m.','16/10/2016 06:10:42 p. m.'),(21,3,'25.5461266440938,-103.404571196552','23/10/2016 01:32:20 p. m.','23/10/2016 01:39:28 p. m.'),(22,4,'25.5046141034297,-103.389400693325','23/10/2016 01:35:50 p. m.','23/10/2016 01:39:49 p. m.');
/*!40000 ALTER TABLE `ambulanciashistorial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte_medico`
--

DROP TABLE IF EXISTS `reporte_medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reporte_medico` (
  `idReporte` int(11) NOT NULL AUTO_INCREMENT,
  `idAmbulancia` int(11) DEFAULT NULL,
  `fechaReporte` varchar(50) DEFAULT NULL,
  `nombrePaciente` varchar(250) DEFAULT NULL,
  `apellidoPaciente` varchar(250) DEFAULT NULL,
  `sexoPaciente` varchar(50) DEFAULT NULL,
  `edadPaciente` int(11) DEFAULT NULL,
  `presionPaciente` varchar(250) DEFAULT NULL,
  `pulsoPaciente` varchar(250) DEFAULT NULL,
  `sangrePaciente` varchar(50) DEFAULT NULL,
  `diagnosticoPaciente` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`idReporte`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_medico`
--

LOCK TABLES `reporte_medico` WRITE;
/*!40000 ALTER TABLE `reporte_medico` DISABLE KEYS */;
INSERT INTO `reporte_medico` VALUES (1,1,'15/10/2016 0:00:00','David','Mendez Guardado','Hombre',22,'100/90','100/60','A +','no\ntiene\nnada\nel\npaciente'),(2,1,'15/10/2016 16:44:36','David','Mendez Guardado','Hombre',22,'100/60','90/50','A +','no\ntiene\nnada\nel\npaciente'),(3,4,'15/10/2016 16:45:26','David','Mendez Guardado','Mujer',22,'100/60','90/50','O +','no\ntiene\nnada\nel\npaciente'),(4,4,'15/10/2016 16:45:40','David','Mendez Guardado','Hombre',22,'100/60','90/50','AB -','no\ntiene\nnada\nel\npaciente'),(5,10,'15/10/2016 16:45:50','David','Mendez Guardado','Hombre',22,'100/60','90/50','AB -','no\ntiene\nnada\nel\npaciente'),(6,1,'16/10/2016 16:1:34','Daniel','Lope','Hombre',35,'100/90','80/60','B -','no tiene ningún síntoma raro el paciente ni tampoco este texto d varias líneas\nverdad'),(7,8,'16/10/2016 16:5:5','Jose','Pavon','Mujer',85,'70/90','40/60','A -','solo nada presión alta'),(8,1,'19/10/2016 18:39:8','Test','test','Hombre',22,'test','test','A +','test');
/*!40000 ALTER TABLE `reporte_medico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'emergency'
--

--
-- Dumping routines for database 'emergency'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-10-23 13:41:46

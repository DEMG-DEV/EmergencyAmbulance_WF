CREATE DATABASE  IF NOT EXISTS `emergency` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `emergency`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: emergency
-- ------------------------------------------------------
-- Server version	5.7.16-log

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
  `idEmergencia` int(11) NOT NULL,
  `idAmbulancia` int(11) DEFAULT NULL,
  `ubicacionEmergencia` varchar(300) DEFAULT NULL,
  `horaSalidaEmergencia` text,
  PRIMARY KEY (`idEmergencia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
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
INSERT INTO `ambulanciashistorial` VALUES (1,1,'25.5547648,-103.3300987','27/11/2016 06:08:20 p. m.','27/11/2016 06:08:39 p. m.'),(2,1,'25.5320047,-103.4755958','27/11/2016 06:09:00 p. m.','27/11/2016 06:10:29 p. m.'),(3,2,'25.5318613,-103.4756955','27/11/2016 06:09:56 p. m.','27/11/2016 06:10:02 p. m.'),(4,1,'25.5547442,-103.3297904','27/11/2016 06:10:30 p. m.','27/11/2016 06:10:33 p. m.'),(5,1,'25.5547264,-103.3303277','27/11/2016 06:24:41 p. m.','27/11/2016 06:24:44 p. m.'),(6,1,'25.5547421,-103.3298749','27/11/2016 06:28:26 p. m.','27/11/2016 06:28:29 p. m.');
/*!40000 ALTER TABLE `ambulanciashistorial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emergencias`
--

DROP TABLE IF EXISTS `emergencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `emergencias` (
  `idEmergencia` int(11) NOT NULL AUTO_INCREMENT,
  `calleEmergencia` varchar(200) DEFAULT NULL,
  `coloniaEmergencia` varchar(200) DEFAULT NULL,
  `numeroEmergencia` int(11) DEFAULT NULL,
  `cpEmergencia` int(11) DEFAULT NULL,
  `ciudadEmergencia` varchar(200) DEFAULT NULL,
  `estadoEmergencia` varchar(200) DEFAULT NULL,
  `entreCallesEmergencia` varchar(500) DEFAULT NULL,
  `otrasReferenciasEmergencia` varchar(500) DEFAULT NULL,
  `ubicacionEmergencia` varchar(300) DEFAULT NULL,
  `statusEmergencia` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idEmergencia`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emergencias`
--

LOCK TABLES `emergencias` WRITE;
/*!40000 ALTER TABLE `emergencias` DISABLE KEYS */;
INSERT INTO `emergencias` VALUES (1,'HUERTO LA JOYA','REAL DEL SOL',8813,27087,'TORREON','COAHUILA','','','25.5547648,-103.3300987','No Activo'),(2,'NAZARIO ORTIZ GARZA','SAN CARLOS',668,27087,'TORREON','COAHUILA','','','25.5320047,-103.4755958','No Activo'),(3,'NAZARIO ORTIZ GARZA','SAN CARLOS',253,27310,'TORREON','COAHUILA','','','25.5318613,-103.4756955','No Activo'),(4,'HUERTO LA JOYA','REAL DEL SOL',8827,27087,'TORREON','COAHUILA','','','25.5547442,-103.3297904','No Activo'),(5,'HUERTO LA JOYA','REAL DEL SOL 1',8807,27087,'TORREON','COAHUILA','FOSFORITA Y REAL DE DUNAS','CASA CON MALLA GALLINERA','25.5547264,-103.3303277','No Activo'),(6,'HUERTO LA JOYA','REAL DEL SOL 1',8821,27087,'TORREON','COAHUILA','FOSFORITA Y REAL DE DUNAS','CASA ROSA','25.5547421,-103.3298749','No Activo');
/*!40000 ALTER TABLE `emergencias` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte_medico`
--

LOCK TABLES `reporte_medico` WRITE;
/*!40000 ALTER TABLE `reporte_medico` DISABLE KEYS */;
INSERT INTO `reporte_medico` VALUES (1,1,'15/10/2016 0:00:00','David','Mendez Guardado','Hombre',22,'100/90','100/60','A +','no\ntiene\nnada\nel\npaciente'),(2,1,'15/10/2016 16:44:36','David','Mendez Guardado','Hombre',22,'100/60','90/50','A +','no\ntiene\nnada\nel\npaciente'),(3,4,'15/10/2016 16:45:26','David','Mendez Guardado','Mujer',22,'100/60','90/50','O +','no\ntiene\nnada\nel\npaciente'),(4,4,'15/10/2016 16:45:40','David','Mendez Guardado','Hombre',22,'100/60','90/50','AB -','no\ntiene\nnada\nel\npaciente'),(5,10,'15/10/2016 16:45:50','David','Mendez Guardado','Hombre',22,'100/60','90/50','AB -','no\ntiene\nnada\nel\npaciente'),(6,1,'16/10/2016 16:1:34','Daniel','Lope','Hombre',35,'100/90','80/60','B -','no tiene ningún síntoma raro el paciente ni tampoco este texto d varias líneas\nverdad'),(7,8,'16/10/2016 16:5:5','Jose','Pavon','Mujer',85,'70/90','40/60','A -','solo nada presión alta'),(8,1,'19/10/2016 18:39:8','Test','test','Hombre',22,'test','test','A +','test'),(9,8,'9/11/2016 17:12:7','test','test','Mujer',96,'test','test','O -','test'),(10,1,'14/11/2016 18:29:37','Jerrry Lengua','Taladro','Hombre',25,'120-90','78','O +','El\nf\ng\n\ngg\n\ngg'),(11,1,'14/11/2016 18:29:54','Jerrry Lengua','Taladro','Hombre',25,'120-90','78','O +','El\nf\ng\n\ngg\n\ngg'),(12,1,'14/11/2016 18:49:29','Luis ','Herrera','Hombre',28,'120/110','40 a 60\n40 a 60','O +','Alumno contreras con delirio de que siempre tiene hueva y busca pokemones al por mayor '),(13,1,'18/11/2016 23:3:29','daniel','lopez molins','Hombre',56,'120/39','123-36','O -','тιene preѕιón мυy baja'),(14,1,'18/11/2016 23:3:46','daniel','lopez molins','Hombre',56,'X/X','X-X','O -','тιene preѕιón мυy baja'),(15,1,'18/11/2016 23:10:43','jose','morelos','Hombre',23,'X/X','X-X','O -','no тenιa pulso'),(16,1,'18/11/2016 23:11:16','jose','morelos','Hombre',23,'56/23','15-85','O -','no тenιa pulso'),(17,1,'18/11/2016 23:40:47','test','test','Hombre',13,'X/X','X-X','A +','de varias \nlineas'),(18,1,'18/11/2016 23:57:4','test','test','Hombre',99,'100/80','100-80','B -','diagnostico de\nvarias\nlíneas'),(19,1,'18/11/2016 23:57:30','test','test','Hombre',99,'100/80','100-80','B -','diagnostico de\nvarias\nlíneas'),(20,1,'25/11/2016 17:2:1','Emmanuel ','Rosales','Hombre',28,'110/90','60-12','O +','Loquera aguda'),(21,1,'25/11/2016 17:4:30','Raul','Salazar','Mujer',21,'80/60','100-60','AB -','Fractura de miembros superior derecho'),(22,1,'25/11/2016 17:5:39','Erick','Hernandez','Hombre',22,'120/100','80-40','B -','Contusión craneal '),(23,4,'25/11/2016 18:5:14','David','Mendez','Hombre',22,'X/X','X-X','A +','no se'),(24,1,'25/11/2016 19:57:0','Nayelli','Aguilar','Mujer',15,'120/60','X-X','O +','Rotura de clavícula ');
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

-- Dump completed on 2016-11-27 18:40:04

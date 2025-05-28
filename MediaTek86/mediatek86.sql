-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 28 mai 2025 à 11:07
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : mediatek86
--
CREATE DATABASE IF NOT EXISTS mediatek86 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
CREATE USER 'mediatek86'@'%' IDENTIFIED BY 'motdepasseuser';
GRANT USAGE ON *.* TO 'mediatek86'@'%';
GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'mediatek86'@'%';
USE mediatek86;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  idpersonnel int NOT NULL,
  datedebut datetime NOT NULL,
  datefin datetime DEFAULT NULL,
  idmotif int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES
(12, '2024-03-02 09:00:00', '2024-03-05 17:00:00', 0),
(7, '2024-05-04 08:00:00', '2024-05-19 18:00:00', 1),
(22, '2024-07-20 09:00:00', '2024-07-25 17:00:00', 3),
(5, '2024-02-10 09:00:00', '2024-02-12 17:00:00', 4),
(33, '2024-01-15 08:30:00', '2024-01-18 18:00:00', 1),
(18, '2024-11-01 08:00:00', '2024-11-03 18:00:00', 2),
(41, '2024-04-22 08:00:00', '2024-04-28 18:00:00', 2),
(27, '2024-08-10 09:00:00', '2024-08-20 17:00:00', 1),
(14, '2024-06-01 09:00:00', '2024-06-05 17:00:00', 3),
(9, '2024-12-23 08:30:00', '2025-01-02 17:00:00', 2),
(30, '2024-10-05 09:00:00', '2024-10-06 17:00:00', 4),
(2, '2024-03-15 08:00:00', '2024-03-17 18:00:00', 1),
(46, '2024-06-20 08:00:00', '2024-06-22 18:00:00', 3),
(19, '2024-05-01 09:00:00', '2024-05-07 17:00:00', 2),
(25, '2024-09-12 09:00:00', '2024-09-14 17:00:00', 4),
(38, '2024-10-18 08:00:00', '2024-10-21 18:00:00', 2),
(17, '2024-01-10 09:00:00', '2024-01-13 17:00:00', 1),
(4, '2024-02-05 09:00:00', '2024-02-06 17:00:00', 4),
(10, '2024-11-22 08:00:00', '2024-11-26 18:00:00', 3),
(35, '2024-07-01 09:00:00', '2024-07-10 17:00:00', 1),
(16, '2024-08-05 09:00:00', '2024-08-08 17:00:00', 3),
(29, '2024-03-22 09:00:00', '2024-03-23 17:00:00', 4),
(1, '2024-04-01 08:00:00', '2024-04-04 18:00:00', 2),
(11, '2024-09-01 08:00:00', '2024-09-03 18:00:00', 1),
(50, '2024-10-25 09:00:00', '2024-10-28 17:00:00', 4),
(23, '2024-05-18 09:00:00', '2024-05-20 17:00:00', 3),
(6, '2024-06-10 08:30:00', '2024-06-13 18:00:00', 1),
(31, '2024-07-14 09:00:00', '2024-07-16 17:00:00', 0),
(44, '2024-12-10 08:00:00', '2024-12-15 18:00:00', 2),
(39, '2024-08-18 09:00:00', '2024-08-22 17:00:00', 1),
(3, '2024-01-20 09:00:00', '2024-01-22 17:00:00', 1),
(8, '2024-02-14 08:00:00', '2024-02-18 18:00:00', 2),
(13, '2024-03-10 09:00:00', '2024-03-12 17:00:00', 4),
(21, '2024-04-07 08:30:00', '2024-04-09 17:00:00', 3),
(24, '2024-05-25 09:00:00', '2024-05-28 17:00:00', 1),
(15, '2024-06-15 08:00:00', '2024-06-19 18:00:00', 2),
(36, '2024-07-05 09:00:00', '2024-07-08 17:00:00', 3),
(40, '2024-08-19 09:00:00', '2024-08-27 17:00:00', 0),
(28, '2024-09-10 09:00:00', '2024-09-12 17:00:00', 1),
(32, '2024-10-14 08:00:00', '2024-10-18 18:00:00', 2),
(20, '2024-11-03 09:00:00', '2024-11-05 17:00:00', 3),
(26, '2024-12-01 08:00:00', '2024-12-03 18:00:00', 4),
(34, '2024-06-23 09:00:00', '2024-06-26 17:00:00', 1),
(51, '2025-05-12 10:18:02', '2025-05-27 10:18:02', 3),
(47, '2024-08-12 09:00:00', '2024-08-14 17:00:00', 2),
(48, '2024-09-20 08:00:00', '2024-09-23 18:00:00', 4),
(45, '2024-10-03 09:00:00', '2024-10-04 17:00:00', 1),
(42, '2024-11-10 08:00:00', '2024-11-13 18:00:00', 3),
(49, '2024-12-01 09:00:00', '2024-12-21 17:00:00', 4),
(37, '2024-05-08 09:00:00', '2024-05-09 17:00:00', 4),
(51, '2025-05-09 10:20:05', '2025-05-22 10:20:05', 2),
(50, '2024-03-30 09:00:00', '2024-04-01 17:00:00', 3),
(1, '2024-07-17 08:00:00', '2024-07-20 18:00:00', 2),
(13, '2025-04-23 00:00:00', '2025-04-21 00:00:00', 2),
(4, '2025-01-05 10:23:44', '2025-05-27 10:23:45', 2),
(4, '2025-01-02 10:24:05', '2025-05-08 10:24:05', 2),
(33, '2025-05-14 18:54:44', '2025-05-16 18:54:44', 2);

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  idmotif int NOT NULL,
  libelle varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (idmotif, libelle) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  idpersonnel int NOT NULL,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  prenom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  tel varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  mail varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  idservice int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, nom, prenom, tel, mail, idservice) VALUES
(1, 'Durand', 'Alice', '0661829475', 'alice.durand@example.com', 1),
(2, 'Martin', 'Julien', '0765482390', 'julien.martin@example.com', 2),
(3, 'Petit', 'Sophie', '0672941856', 'sophie.petit@example.com', 3),
(4, 'Lefevre', 'Lucas', '0759816432', 'lucas.lefevre@example.com', 1),
(5, 'Moreau', 'Emma', '0678392041', 'emma.moreau@example.com', 2),
(6, 'Garcia', 'Nathan', '0763298471', 'nathan.garcia@example.com', 3),
(7, 'Roux', 'Chloé', '0675128934', 'chloe.roux@example.com', 1),
(8, 'Fournier', 'Hugo', '0678239456', 'hugo.fournier@example.com', 2),
(9, 'Girard', 'Léa', '0667948203', 'lea.girard@example.com', 3),
(11, 'Mercier', 'Manon', '0672198354', 'manon.mercier@example.com', 2),
(13, 'Guerin', 'Camille', '0679821345', 'camille.guerin@example.com', 1),
(15, 'Meyer', 'Anna', '0663948275', 'anna.meyer@example.com', 3),
(16, 'Lucas', 'Thomas', '0758213946', 'thomas.lucas@example.com', 1),
(17, 'Henry', 'Jade', '0673192847', 'jade.henry@example.com', 2),
(18, 'Faure', 'Noah', '0767429831', 'noah.faure@example.com', 3),
(19, 'Robin', 'Eva', '0665894732', 'eva.robin@example.com', 1),
(20, 'Gauthier', 'Tom', '0679138452', 'tom.gauthier@example.com', 2),
(21, 'Masson', 'Inès', '0753287491', 'ines.masson@example.com', 3),
(22, 'Perrin', 'Enzo', '0661429387', 'enzo.perrin@example.com', 1),
(23, 'Marchand', 'Sarah', '0678932154', 'sarah.marchand@example.com', 2),
(24, 'Clement', 'Axel', '0761238745', 'axel.clement@example.com', 3),
(25, 'Weber', 'Lina', '0679321846', 'lina.weber@example.com', 1),
(26, 'Fernandez', 'Ethan', '0664827391', 'ethan.fernandez@example.com', 2),
(27, 'Legrand', 'Mila', '0671983254', 'mila.legrand@example.com', 3),
(28, 'Colin', 'Noémie', '0759821437', 'noemie.colin@example.com', 1),
(29, 'Picard', 'Antoine', '0667482193', 'antoine.picard@example.com', 2),
(30, 'Renard', 'Laura', '0671832954', 'laura.renard@example.com', 3),
(32, 'Rolland', 'Eléa', '0662918374', 'elea.rolland@example.com', 2),
(33, 'Boyer', 'Clément', '0674192853', 'clement.boyer@example.com', 3),
(34, 'Dumas', 'Lucie', '0668492375', 'lucie.dumas@example.com', 1),
(35, 'Lopez', 'Rayan', '0759832741', 'rayan.lopez@example.com', 2),
(36, 'Jean', 'Maëlle', '0673298417', 'maelle.jean@example.com', 3),
(38, 'Rey', 'Margaux', '0679428136', 'margaux.rey@example.com', 2),
(39, 'Charles', 'Sacha', '0661983724', 'sacha.charles@example.com', 3),
(41, 'Lambert', 'Loris', '0662139847', 'loris.lambert@example.com', 2),
(42, 'Renaud', 'Nina', '0678142936', 'nina.renaud@example.com', 3),
(44, 'Perrot', 'Salomé', '0667483912', 'salome.perrot@example.com', 2),
(45, 'Gilbert', 'Aaron', '0671839425', 'aaron.gilbert@example.com', 3),
(46, 'Leclerc', 'Zoé', '0765923814', 'zoe.leclerc@example.com', 1),
(47, 'Payet', 'Eliott', '0679283146', 'eliott.payet@example.com', 2),
(48, 'Navarro', 'Léna', '0661829375', 'lena.navarro@example.com', 3),
(49, 'Bouchard', 'Oscar', '0675928134', 'oscar.bouchard@example.com', 1),
(50, 'Guichard', 'Iris', '0761293847', 'iris.guichard@example.com', 2);

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  pwd varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('admin', 'cb1b41f926c55589b41f3824112ea5a80249beccdff63e4265189d7db31f8f04');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE service (
  idservice int NOT NULL,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (idservice, nom) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (idpersonnel,datedebut),
  ADD KEY idmotif (idmotif);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (idmotif);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (idpersonnel),
  ADD KEY idservice (idservice);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (idservice);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY idmotif int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY idpersonnel int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY idservice int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

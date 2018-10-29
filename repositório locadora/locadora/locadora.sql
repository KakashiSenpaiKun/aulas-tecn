-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 17-Set-2018 às 14:07
-- Versão do servidor: 10.1.33-MariaDB
-- PHP Version: 7.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `locadora`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `carro`
--

CREATE TABLE `carro` (
  `placa` varchar(8) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `ano_fabri` int(4) NOT NULL,
  `valor_diaria` float NOT NULL,
  `status` tinyint(1) NOT NULL,
  `imagem` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `carro`
--

INSERT INTO `carro` (`placa`, `modelo`, `ano_fabri`, `valor_diaria`, `status`, `imagem`) VALUES
('aaa-000', 'relampago', 2005, 322, 0, 'download.jpg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `rg` varchar(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `tel` varchar(9) NOT NULL,
  `cel` varchar(10) NOT NULL,
  `cnh` varchar(14) NOT NULL,
  `categoria` varchar(6) NOT NULL,
  `data_validade` varchar(30) NOT NULL,
  `bairro` varchar(100) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `estado` varchar(2) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `data_nasc` varchar(30) NOT NULL,
  `email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`rg`, `nome`, `cpf`, `tel`, `cel`, `cnh`, `categoria`, `data_validade`, `bairro`, `endereco`, `cep`, `estado`, `cidade`, `data_nasc`, `email`) VALUES
('123456789', 'joão', '123456789', '12345678', '123456789', '123', 'b', '12/09/2013', 'vila do além', 'rua joaquim', '02302034', 'sp', 'sp', '12/09/1987', 'f@f.f'),
('78654648', 'jose', '4623456', '2278', '22', '2278', 'a', '22/09/2018', 'asdfg', 'fghjklp', '45655', 'df', 'fdzfsdgfd', '12/02/1982', 'd@d.com');

-- --------------------------------------------------------

--
-- Estrutura da tabela `movimento`
--

CREATE TABLE `movimento` (
  `placa` varchar(8) NOT NULL,
  `rg` varchar(11) NOT NULL,
  `data_retira` varchar(30) NOT NULL,
  `data_dev` varchar(30) NOT NULL,
  `diarias` decimal(20,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `movimento`
--

INSERT INTO `movimento` (`placa`, `rg`, `data_retira`, `data_dev`, `diarias`) VALUES
('aaa-000', '78654648', '2018-09-17 08:08:31.969555', '2018-09-17 08:08:31.973544', '0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `carro`
--
ALTER TABLE `carro`
  ADD PRIMARY KEY (`placa`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`rg`);

--
-- Indexes for table `movimento`
--
ALTER TABLE `movimento`
  ADD PRIMARY KEY (`placa`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

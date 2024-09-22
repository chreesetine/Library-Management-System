-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 22, 2024 at 04:00 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `libsys`
--

-- --------------------------------------------------------

--
-- Table structure for table `app_users`
--

CREATE TABLE `app_users` (
  `id` int(15) NOT NULL,
  `fname` varchar(25) NOT NULL,
  `lname` varchar(15) NOT NULL,
  `library_id` varchar(15) NOT NULL,
  `password` varchar(10) NOT NULL,
  `user_type` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `app_users`
--

INSERT INTO `app_users` (`id`, `fname`, `lname`, `library_id`, `password`, `user_type`) VALUES
(1, 'Kristen', 'Stewart', '1234', '0000', 'admin'),
(2, 'Marie', 'Lopez', '987', '3456', 'admin'),
(3, 'Beatriz', 'Roxas', '678', '4567', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `book_id` varchar(15) NOT NULL,
  `title` varchar(40) NOT NULL,
  `isbn` varchar(25) NOT NULL,
  `author` varchar(30) NOT NULL,
  `genre` varchar(30) NOT NULL,
  `quantity` varchar(10) NOT NULL,
  `date_returned` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`book_id`, `title`, `isbn`, `author`, `genre`, `quantity`, `date_returned`) VALUES
('1', 'Harry Potter', '‎9780439708180', 'JK Rowling', 'Fantasy', '12', 'Dec 13 2022'),
('10', 'The Hunger Games', '9780439023481', 'Suzanne Collins', 'Fiction', '19', 'Sep 19 2024'),
('11', 'meow', '1234567', 'mascara', 'Fantasy', '4', 'Sep 19 2024'),
('2', 'Flipped', '9780375825446', 'Wendelin Van Draanen', 'Romance', '3', 'Dec 09 2022'),
('3', 'Diary of a Wimpy Kid', '9781439582633', 'Jeff Kinney', 'Children\'s Literature', '22', 'Dec 13 2022'),
('4', 'Mathematics', '9780486409160', 'Sarah Lopez', 'Education', '2', 'Dec 14 2022'),
('5', 'Christine', '9781501144189', 'Stephen King', 'Novel', '10', 'Dec 14 2022'),
('6', 'Noli Me Tangere', '9780143039693', 'Jose Rizal', 'Fiction', '20', 'Dec 14 2022'),
('7', 'Little Women', '9781503280298', 'Louisa May Alcott', 'Drama', '15', 'Dec 14 2022'),
('8', 'Alice in Wonderland', '9781936594207', 'Lewis Caroll', 'Fantasy', '15', 'Dec 14 2022'),
('9', 'The Hunger Games', '9780439023481', 'Suzanne Collins', 'Novel', '10', 'Dec 19 2022');

-- --------------------------------------------------------

--
-- Table structure for table `student_info`
--

CREATE TABLE `student_info` (
  `student_id` varchar(20) NOT NULL,
  `sname` varchar(40) NOT NULL,
  `course` varchar(20) NOT NULL,
  `year` varchar(20) NOT NULL,
  `section` varchar(20) NOT NULL,
  `contact_no` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_info`
--

INSERT INTO `student_info` (`student_id`, `sname`, `course`, `year`, `section`, `contact_no`) VALUES
('202150000', 'Alexis Aballa', 'BSIT', '2', 'B', '09999868537'),
('2021500100', 'Jade Irish Diaz', 'BSIT', '2', 'B', '09998176756'),
('2021500101', 'Ariana Gomez', 'BSIT', '2', 'B', '09992317961'),
('2021500102', 'Selena Ortega', 'BSIT', '2', 'C', '09128461284'),
('2021500103', 'Dua Smith', 'BSIT', '3', 'A', '09318412734'),
('2021500104', 'Taylor Pascual', 'BSIT', '1', 'C', '09295240936'),
('2021500105', 'Nicki Adamson', 'BSIT', '4', 'A', '09214539012'),
('2021500307', 'Danielle Dela Cruz', 'BSIT', '2', 'B', '09198234567'),
('2021500470', 'Christine Haduca', 'BSIT', '2', 'B', '09997852239'),
('2021500967', 'Denise Villalobos', 'BSIT', '2', 'B', '09196453983');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `transaction_no` varchar(20) NOT NULL,
  `title` varchar(30) NOT NULL,
  `book_id` varchar(20) NOT NULL,
  `sname` varchar(30) NOT NULL,
  `student_id` varchar(20) NOT NULL,
  `date_borrowed` varchar(30) NOT NULL,
  `status` varchar(20) NOT NULL,
  `date_returned` varchar(30) NOT NULL,
  `due_date` varchar(30) NOT NULL,
  `penalty` varchar(20) NOT NULL,
  `received_by` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`transaction_no`, `title`, `book_id`, `sname`, `student_id`, `date_borrowed`, `status`, `date_returned`, `due_date`, `penalty`, `received_by`) VALUES
('1', 'Harry Potter', '1', 'Christine Haduca', '2021500470', 'Dec 19 2022', 'Returned', 'Dec 22 2022', 'Dec 20 2022', '300', 'Kristen'),
('2', 'Flipped', '2', 'Danielle Dela Cruz', '2021500307', 'Dec 19 2022', 'Not yet returned', 'N/A', 'Dec 23 2022', '300', 'N/A'),
('3', 'Mathematics', '4', 'Denise Villalobos', '2021500967', 'Sept 5 2022', 'Returned', 'Sept 10 2022', 'Sept 7 2022', '300', 'Beatriz'),
('4', 'Diary of a Wimpy Kid', '3', 'Alexis Aballa', '2021500000', 'Dec 19 2022', 'Returned', 'Dec 22 2022', 'Dec 22 2022', '0', 'Kristen'),
('5', 'Little Women', '7', 'Taylor Pascual', '2021500104', 'Dec 19 2022', 'Not yet returned', 'N/A', 'Dec 21 2022', '300', 'N/A'),
('6', 'The Hunger Games', '9', 'Nicki Adamson', '2021500105', 'Sep 19 2024', 'Not yet returned', 'N/A', 'Dec 23 2024', '0', 'Beatriz'),
('7', 'Harry Potter', '1', 'Winnie', '20216789', 'Sep 20 2024', 'Returned', 'Sep 20 2024', 'Sep 25 2024', '0', 'Kristen');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `app_users`
--
ALTER TABLE `app_users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`book_id`);

--
-- Indexes for table `student_info`
--
ALTER TABLE `student_info`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`transaction_no`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `app_users`
--
ALTER TABLE `app_users`
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=568;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

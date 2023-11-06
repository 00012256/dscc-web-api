-- Create Authors table
CREATE TABLE Authors (
    AuthorId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Biography NVARCHAR(MAX)
);

-- Create Posts table
CREATE TABLE Posts (
    PostId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Content NVARCHAR(MAX) NOT NULL,
    PublicationDate DATE NOT NULL,
    LastUpdated DATE NOT NULL,
    AuthorId INT,
    FOREIGN KEY (AuthorId) REFERENCES Authors (AuthorId)
);

-- Insert authors
INSERT INTO Authors (FirstName, LastName, Email, Biography)
VALUES
    ('Anvar', 'Rashidov', 'anvar@example.com', 'Biography for Anvar Rashidov'),
    ('Bobur', 'Xoliqulov', 'bobur@example.com', 'Biography for Bobur Xoliqulov'),
    ('Arslon', 'Boymurodov', 'arslon@example.com', 'Biography for Arslon Boymurodov'),
    ('Eldor', 'Jalilov', 'eldor@example.com', 'Biography for Eldor Jalilov'),
    ('Jamshid', 'Fayzullayeva', 'jamshid@example.com', 'Biography for Jamshid Fayzullayeva'),
    ('Dildora', 'Nosirova', 'dildora@example.com', 'Biography for Dildora Nosirova'),
    ('Nasiba', 'Odilova', 'nasiba@example.com', 'Biography for Nasiba Odilova'),
    ('Alisher', 'Nazarov', 'alisher@example.com', 'Biography for Alisher Nazarov'),
    ('Firuza', 'Usmanova', 'firuza@example.com', 'Biography for Firuza Usmanova'),
    ('Javohir', 'Xolmamatov', 'javohir@example.com', 'Biography for Javohir Xolmamatov'),
    ('Lola', 'Nurmatova', 'lola@example.com', 'Biography for Lola Nurmatova'),
    ('Olim', 'Ismoilov', 'olim@example.com', 'Biography for Olim Ismoilov'),
    ('Valijon', 'Rustamov', 'valijon@example.com', 'Biography for Valijon Rustamov'),
    ('Farida', 'Qosimova', 'farida@example.com', 'Biography for Farida Qosimova'),
    ('Xusniddin', 'Mirzayev', 'xusniddin@example.com', 'Biography for Xusniddin Mirzayev'),
    ('Nigora', 'Aminova', 'nigora@example.com', 'Biography for Nigora Aminova'),
    ('Shukhrat', 'Karimov', 'shukhrat@example.com', 'Biography for Shukhrat Karimov'),
    ('Aziz', 'Muminov', 'aziz@example.com', 'Biography for Aziz Muminov'),
    ('Gulnara', 'Salimova', 'gulnara@example.com', 'Biography for Gulnara Salimova'),
    ('Oybek', 'Usmonov', 'oybek@example.com', 'Biography for Oybek Usmonov'),
    ('Shirin', 'Zokirova', 'shirin@example.com', 'Biography for Shirin Zokirova'),
    ('Bahrom', 'Toshpulatov', 'bahrom@example.com', 'Biography for Bahrom Toshpulatov'),
    ('Ilhom', 'Nigmatov', 'ilhom@example.com', 'Biography for Ilhom Nigmatov'),
    ('Zilola', 'Azimova', 'zilola@example.com', 'Biography for Zilola Azimova'),
    ('Bekzod', 'Otaboev', 'bekzod@example.com', 'Biography for Bekzod Otaboev'),
    ('Muqaddas', 'Xatamova', 'muqaddas@example.com', 'Biography for Muqaddas Xatamova'),
    ('Shahzoda', 'Qosimova', 'shahzoda@example.com', 'Biography for Shahzoda Qosimova'),
    ('Botir', 'Shamsiyev', 'botir@example.com', 'Biography for Botir Shamsiyev'),
    ('Farrukh', 'Ravshanov', 'farrukh@example.com', 'Biography for Farrukh Ravshanov'),
    ('Shaxzod', 'Xolmurodov', 'shaxzod@example.com', 'Biography for Shaxzod Xolmurodov');

-- Insert posts
INSERT INTO Posts (Title, Content, PublicationDate, LastUpdated, AuthorId)
VALUES
    ('Post 1', 'Content for Post 1', '2023-09-01', '2023-09-02', 1),
    ('Post 2', 'Content for Post 2', '2023-09-02', '2023-09-03', 1),
    ('Post 3', 'Content for Post 3', '2023-09-03', '2023-09-04', 1),
    ('Post 4', 'Content for Post 4', '2023-09-04', '2023-09-05', 2),
    ('Post 5', 'Content for Post 5', '2023-09-05', '2023-09-06', 2),
    ('Post 6', 'Content for Post 6', '2023-09-06', '2023-09-07', 3),
    ('Post 7', 'Content for Post 7', '2023-09-07', '2023-09-08', 3),
    ('Post 8', 'Content for Post 8', '2023-09-08', '2023-09-09', 4),
    ('Post 9', 'Content for Post 9', '2023-09-09', '2023-09-10', 4),
    ('Post 10', 'Content for Post 10', '2023-09-10', '2023-09-11', 5),
    ('Post 11', 'Content for Post 11', '2023-09-11', '2023-09-12', 5),
    ('Post 12', 'Content for Post 12', '2023-09-12', '2023-09-13', 6),
    ('Post 13', 'Content for Post 13', '2023-09-13', '2023-09-14', 6),
    ('Post 14', 'Content for Post 14', '2023-09-14', '2023-09-15', 7),
    ('Post 15', 'Content for Post 15', '2023-09-15', '2023-09-16', 7),
    ('Post 16', 'Content for Post 16', '2023-09-16', '2023-09-17', 8),
    ('Post 17', 'Content for Post 17', '2023-09-17', '2023-09-18', 8),
    ('Post 18', 'Content for Post 18', '2023-09-18', '2023-09-19', 9),
    ('Post 19', 'Content for Post 19', '2023-09-19', '2023-09-20', 9),
    ('Post 20', 'Content for Post 20', '2023-09-20', '2023-09-21', 10),
    ('Post 21', 'Content for Post 21', '2023-09-21', '2023-09-22', 11),
    ('Post 22', 'Content for Post 22', '2023-09-22', '2023-09-23', 12),
    ('Post 23', 'Content for Post 23', '2023-09-23', '2023-09-24', 13),
    ('Post 24', 'Content for Post 24', '2023-09-24', '2023-09-25', 14),
    ('Post 25', 'Content for Post 25', '2023-09-25', '2023-09-26', 15),
    ('Post 26', 'Content for Post 26', '2023-09-26', '2023-09-27', 16),
    ('Post 27', 'Content for Post 27', '2023-09-27', '2023-09-28', 17),
    ('Post 28', 'Content for Post 28', '2023-09-28', '2023-09-29', 18),
    ('Post 29', 'Content for Post 29', '2023-09-29', '2023-09-30', 19),
    ('Post 30', 'Content for Post 30', '2023-09-30', '2023-10-01', 20),
    ('Post 31', 'Content for Post 31', '2023-10-01', '2023-10-02', 21),
    ('Post 32', 'Content for Post 32', '2023-10-02', '2023-10-03', 22),
    ('Post 33', 'Content for Post 33', '2023-10-03', '2023-10-04', 23),
    ('Post 34', 'Content for Post 34', '2023-10-04', '2023-10-05', 24),
    ('Post 35', 'Content for Post 35', '2023-10-05', '2023-10-06', 25),
    ('Post 36', 'Content for Post 36', '2023-10-06', '2023-10-07', 26),
    ('Post 37', 'Content for Post 37', '2023-10-07', '2023-10-08', 27),
    ('Post 38', 'Content for Post 38', '2023-10-08', '2023-10-09', 28),
    ('Post 39', 'Content for Post 39', '2023-10-09', '2023-10-10', 29),
    ('Post 40', 'Content for Post 40', '2023-10-10', '2023-10-11', 30);

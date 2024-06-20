
CREATE DATABASE TarunaCore;
GO

USE TarunaCore;
GO
-- Tabel Master Warga
CREATE TABLE Warga (
    ID_NIK VARCHAR(10) PRIMARY KEY,
    Nama_Warga NVARCHAR(50),
    Tgl_Lahir DATE,
    Alamat NVARCHAR(100),
    Nmr_Telepon NVARCHAR(13),
    Status VARCHAR(15),
    foto VARBINARY(MAX)
);

-- Insert Warga
CREATE PROCEDURE sp_InsertWarga
    @ID_NIK VARCHAR(10),
    @Nama_Warga NVARCHAR(50),
    @Tgl_Lahir DATE,
    @Alamat NVARCHAR(100),
    @Nmr_Telepon NVARCHAR(13),
    @Status VARCHAR(15),
    @foto VARBINARY(MAX)
AS
BEGIN
    INSERT INTO Warga (ID_NIK, Nama_Warga, Tgl_Lahir, Alamat, Nmr_Telepon, Status, foto)
    VALUES (@ID_NIK, @Nama_Warga, @Tgl_Lahir, @Alamat, @Nmr_Telepon, @Status, @foto);
END;
GO

-- Update Warga
CREATE PROCEDURE sp_UpdateWarga
    @ID_NIK VARCHAR(10),
    @Nama_Warga NVARCHAR(50),
    @Tgl_Lahir DATE,
    @Alamat NVARCHAR(100),
    @Nmr_Telepon NVARCHAR(13),
    @Status VARCHAR(15),
    @foto VARBINARY(MAX)
AS
BEGIN
    UPDATE Warga
    SET Nama_Warga = @Nama_Warga, Tgl_Lahir = @Tgl_Lahir, Alamat = @Alamat, Nmr_Telepon = @Nmr_Telepon, Status = @Status, foto = @foto
    WHERE ID_NIK = @ID_NIK;
END;
GO

-- Delete Warga
CREATE PROCEDURE sp_DeleteWarga
    @ID_NIK VARCHAR(10)
AS
BEGIN
    DELETE FROM Warga
    WHERE ID_NIK = @ID_NIK;
END;
GO
SELECT *FROM Warga 
DELETE FROM Warga WHERE ID_NIK = '2'
-- Tabel Master Jenis Keluhan
CREATE TABLE Jenis_Keluhan (
    ID_Jns_Keluhan VARCHAR(10) PRIMARY KEY,
    Judul NVARCHAR(20),
    Jenis_Keluhan NVARCHAR(20),
    Isi NVARCHAR(50),
    Status VARCHAR(15),
    foto VARBINARY(MAX) -- Tambahkan kolom foto
);

--Master_Jenis_Keluhan
CREATE PROCEDURE sp_InsertJenisKeluhan
    @ID_Jns_Keluhan VARCHAR(10),
    @Judul NVARCHAR(20),
    @Jenis_Keluhan NVARCHAR(20),
    @Isi NVARCHAR(50),
    @Status VARCHAR(15),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    INSERT INTO Jenis_Keluhan (ID_Jns_Keluhan, Judul, Jenis_Keluhan, Isi, Status, foto)
    VALUES (@ID_Jns_Keluhan, @Judul, @Jenis_Keluhan, @Isi, @Status, @foto);
END;
GO

--UPDATE
CREATE PROCEDURE sp_UpdateJenisKeluhan
    @ID_Jns_Keluhan VARCHAR(10),
    @Judul NVARCHAR(20),
    @Jenis_Keluhan NVARCHAR(20),
    @Isi NVARCHAR(50),
    @Status VARCHAR(15),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    UPDATE Jenis_Keluhan
    SET Judul = @Judul, Jenis_Keluhan = @Jenis_Keluhan, Isi = @Isi, Status = @Status, foto = @foto
    WHERE ID_Jns_Keluhan = @ID_Jns_Keluhan;
END;
GO

--DELETE
CREATE PROCEDURE sp_DeleteJenisKeluhan
    @ID_Jns_Keluhan VARCHAR(10)
AS
BEGIN
    DELETE FROM Jenis_Keluhan
    WHERE ID_Jns_Keluhan = @ID_Jns_Keluhan;
END;
GO

-- Tabel Master Role
CREATE TABLE Role (
    ID_Role VARCHAR(10) PRIMARY KEY,
    Nama_Role NVARCHAR(50),
    Status INT,
    foto VARBINARY(MAX) -- Tambahkan kolom foto
);

CREATE PROCEDURE sp_InsertRole
    @ID_Role VARCHAR(10),
    @Nama_Role NVARCHAR(50),
    @Status INT,
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    INSERT INTO Role (ID_Role, Nama_Role, Status, foto)
    VALUES (@ID_Role, @Nama_Role, @Status, @foto);
END;
GO

--UPDATE
CREATE PROCEDURE sp_UpdateRole
    @ID_Role VARCHAR(10),
    @Nama_Role NVARCHAR(50),
    @Status INT,
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    UPDATE Role
    SET Nama_Role = @Nama_Role, Status = @Status, foto = @foto
    WHERE ID_Role = @ID_Role;
END;
GO

--DELETE
CREATE PROCEDURE sp_DeleteRole
    @ID_Role VARCHAR(10)
AS
BEGIN
    DELETE FROM Role
    WHERE ID_Role = @ID_Role;
END;
GO

-- Tabel Master User
CREATE TABLE MasterUser (
    ID_User VARCHAR(10) PRIMARY KEY,
    Username VARCHAR(15),
    Password NVARCHAR(8),
    Status VARCHAR(15),
    ID_NIK VARCHAR(10),
    ID_Role VARCHAR(10),
    foto VARBINARY(MAX), -- Tambahkan kolom foto
    FOREIGN KEY (ID_NIK) REFERENCES Warga(ID_NIK),
    FOREIGN KEY (ID_Role) REFERENCES Role(ID_Role)
);

--Master_User
CREATE PROCEDURE sp_InsertUser
    @ID_User VARCHAR(10),
    @Username VARCHAR(15),
    @Password NVARCHAR(8),
    @Status VARCHAR(15),
    @ID_NIK VARCHAR(10),
    @ID_Role VARCHAR(10),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    INSERT INTO MasterUser (ID_User, Username, Password, Status, ID_NIK, ID_Role, foto)
    VALUES (@ID_User, @Username, @Password, @Status, @ID_NIK, @ID_Role, @foto);
END;
GO

--UPDATE
CREATE PROCEDURE sp_UpdateUser
    @ID_User VARCHAR(10),
    @Username VARCHAR(15),
    @Password NVARCHAR(8),
    @Status VARCHAR(15),
    @ID_NIK VARCHAR(10),
    @ID_Role VARCHAR(10),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    UPDATE MasterUser
    SET Username = @Username, Password = @Password, Status = @Status, ID_NIK = @ID_NIK, ID_Role = @ID_Role, foto = @foto
    WHERE ID_User = @ID_User;
END;
GO

--DELETE
CREATE PROCEDURE sp_DeleteUser
    @ID_User VARCHAR(10)
AS
BEGIN
    DELETE FROM MasterUser
    WHERE ID_User = @ID_User;
END;
GO

-- Tabel Master Jenis Barang
CREATE TABLE Jenis_Barang (
    ID_Jenis_Barang VARCHAR(10) PRIMARY KEY,
    Nama_Jenis NVARCHAR(50),
    Status VARCHAR(15),
    foto VARBINARY(MAX) -- Tambahkan kolom foto
);

CREATE PROCEDURE sp_InsertJenisBarang
    @ID_Jenis_Barang VARCHAR(10),
    @Nama_Jenis NVARCHAR(50),
    @Status VARCHAR(15),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    INSERT INTO Jenis_Barang (ID_Jenis_Barang, Nama_Jenis, Status, foto)
    VALUES (@ID_Jenis_Barang, @Nama_Jenis, @Status, @foto);
END;
GO

--UPDATE
CREATE PROCEDURE sp_UpdateJenisBarang
    @ID_Jenis_Barang VARCHAR(10),
    @Nama_Jenis NVARCHAR(50),
    @Status VARCHAR(15),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    UPDATE Jenis_Barang
    SET Nama_Jenis = @Nama_Jenis, Status = @Status, foto = @foto
    WHERE ID_Jenis_Barang = @ID_Jenis_Barang;
END;
GO

--DELETE
CREATE PROCEDURE sp_DeleteJenisBarang
    @ID_Jenis_Barang VARCHAR(10)
AS
BEGIN
    DELETE FROM Jenis_Barang
    WHERE ID_Jenis_Barang = @ID_Jenis_Barang;
END;
GO

-- Tabel Master Tempat
CREATE TABLE Tempat (
    ID_Tempat VARCHAR(10) PRIMARY KEY,
    Nama_Tempat NVARCHAR(50),
    Alamat NVARCHAR(100),
    Kapasitas INT,
    Status INT,
    foto VARBINARY(MAX) -- Tambahkan kolom foto
);

CREATE PROCEDURE sp_InsertTempat
    @ID_Tempat VARCHAR(10),
    @Nama_Tempat NVARCHAR(50),
    @Alamat NVARCHAR(100),
    @Kapasitas INT,
    @Status INT,
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    INSERT INTO Tempat (ID_Tempat, Nama_Tempat, Alamat, Kapasitas, Status, foto)
    VALUES (@ID_Tempat, @Nama_Tempat, @Alamat, @Kapasitas, @Status, @foto);
END;
GO

--UPDATE
CREATE PROCEDURE sp_UpdateTempat
    @ID_Tempat VARCHAR(10),
    @Nama_Tempat NVARCHAR(50),
    @Alamat NVARCHAR(100),
    @Kapasitas INT,
    @Status INT,
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    UPDATE Tempat
    SET Nama_Tempat = @Nama_Tempat, Alamat = @Alamat, Kapasitas = @Kapasitas, Status = @Status, foto = @foto
    WHERE ID_Tempat = @ID_Tempat;
END;
GO

--DELETE
CREATE PROCEDURE sp_DeleteTempat
    @ID_Tempat VARCHAR(10)
AS
BEGIN
    DELETE FROM Tempat
    WHERE ID_Tempat = @ID_Tempat;
END;
GO

-- Tabel Barang
CREATE TABLE Barang (
    ID_Barang VARCHAR(10) PRIMARY KEY,
    Nama_Barang NVARCHAR(50),
    Jumlah INT,
    Status INT,
    ID_Jenis_Barang VARCHAR(10),
    ID_Tempat VARCHAR(10),
    foto VARBINARY(MAX), -- Tambahkan kolom foto
    FOREIGN KEY (ID_Jenis_Barang) REFERENCES Jenis_Barang(ID_Jenis_Barang),
    FOREIGN KEY (ID_Tempat) REFERENCES Tempat(ID_Tempat)
);

-- INSERT Stored Procedure
CREATE PROCEDURE sp_InsertBarang
    @ID_Barang VARCHAR(10),
    @Nama_Barang NVARCHAR(50),
    @Jumlah INT,
    @Status INT,
    @ID_Jenis_Barang VARCHAR(10),
    @ID_Tempat VARCHAR(10),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    INSERT INTO Barang (ID_Barang, Nama_Barang, Jumlah, Status, ID_Jenis_Barang, ID_Tempat, foto)
    VALUES (@ID_Barang, @Nama_Barang, @Jumlah, @Status, @ID_Jenis_Barang, @ID_Tempat, @foto);
END;
GO

-- UPDATE Stored Procedure
CREATE PROCEDURE sp_UpdateBarang
    @ID_Barang VARCHAR(10),
    @Nama_Barang NVARCHAR(50),
    @Jumlah INT,
    @Status INT,
    @ID_Jenis_Barang VARCHAR(10),
    @ID_Tempat VARCHAR(10),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    UPDATE Barang
    SET Nama_Barang = @Nama_Barang, 
        Jumlah = @Jumlah, 
        Status = @Status, 
        ID_Jenis_Barang = @ID_Jenis_Barang, 
        ID_Tempat = @ID_Tempat,
        foto = @foto
    WHERE ID_Barang = @ID_Barang;
END;
GO

-- DELETE Stored Procedure
CREATE PROCEDURE sp_DeleteBarang
    @ID_Barang VARCHAR(10)
AS
BEGIN
    DELETE FROM Barang
    WHERE ID_Barang = @ID_Barang;
END;
GO

-- Tabel Master Berita
CREATE TABLE Berita (
    ID_Berita VARCHAR(10) PRIMARY KEY,
    Judul_Berita NVARCHAR(20),
    Tanggal DATE,
    Isi NVARCHAR(100),
    Status NVARCHAR(15),
    foto VARBINARY(MAX) -- Tambahkan kolom foto
);

CREATE PROCEDURE sp_InsertBerita
    @ID_Berita VARCHAR(10),
    @Judul_Berita NVARCHAR(20),
    @Tanggal DATE,
    @Isi NVARCHAR(100),
    @Status NVARCHAR(15),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    INSERT INTO Berita (ID_Berita, Judul_Berita, Tanggal, Isi, Status, foto)
    VALUES (@ID_Berita, @Judul_Berita, @Tanggal, @Isi, @Status, @foto);
END;
GO

--UPDATE
CREATE PROCEDURE sp_UpdateBerita
    @ID_Berita VARCHAR(10),
    @Judul_Berita NVARCHAR(20),
    @Tanggal DATE,
    @Isi NVARCHAR(100),
    @Status NVARCHAR(15),
    @foto VARBINARY(MAX) -- Tambahkan parameter foto
AS
BEGIN
    UPDATE Berita
    SET Judul_Berita = @Judul_Berita, Tanggal = @Tanggal, Isi = @Isi, Status = @Status, foto = @foto
    WHERE ID_Berita = @ID_Berita;
END;
GO

--DELETE
CREATE PROCEDURE sp_DeleteBerita
    @ID_Berita VARCHAR(10)
AS
BEGIN
    DELETE FROM Berita
    WHERE ID_Berita = @ID_Berita;
END;
GO


-- Tabel Transaksi Keluhan
CREATE TABLE Transaksi_Keluhan (
    ID_Trs_Keluhan VARCHAR(10) PRIMARY KEY,
    Tanggal DATE,
    Judul NVARCHAR(20),
    Isi NVARCHAR(50),
    ID_NIK VARCHAR(10),
    ID_Jns_Keluhan VARCHAR(10),
    FOREIGN KEY (ID_NIK) REFERENCES Warga(ID_NIK),
    FOREIGN KEY (ID_Jns_Keluhan) REFERENCES Jenis_Keluhan(ID_Jns_Keluhan)
);

--Transaksi_Keluhan
CREATE PROCEDURE sp_InsertTransaksiKeluhan
    @ID_Trs_Keluhan VARCHAR(10),
    @Tanggal DATE,
    @Judul NVARCHAR(20),
    @Isi NVARCHAR(50),
    @ID_NIK VARCHAR(10),
    @ID_Jns_Keluhan VARCHAR(10)
AS
BEGIN
    INSERT INTO Transaksi_Keluhan (ID_Trs_Keluhan, Tanggal, Judul, Isi, ID_NIK, ID_Jns_Keluhan)
    VALUES (@ID_Trs_Keluhan, @Tanggal, @Judul, @Isi, @ID_NIK, @ID_Jns_Keluhan);
END;
GO
--UPDATE
CREATE PROCEDURE sp_UpdateTransaksiKeluhan
    @ID_Trs_Keluhan VARCHAR(10),
    @Tanggal DATE,
    @Judul NVARCHAR(20),
    @Isi NVARCHAR(50),
    @ID_NIK VARCHAR(10),
    @ID_Jns_Keluhan VARCHAR(10)
AS
BEGIN
    UPDATE Transaksi_Keluhan
    SET Tanggal = @Tanggal, Judul = @Judul, Isi = @Isi, ID_NIK = @ID_NIK, ID_Jns_Keluhan = @ID_Jns_Keluhan
    WHERE ID_Trs_Keluhan = @ID_Trs_Keluhan;
END;
GO
--DELETE
CREATE PROCEDURE sp_DeleteTransaksiKeluhan
    @ID_Trs_Keluhan VARCHAR(10)
AS
BEGIN
    DELETE FROM Transaksi_Keluhan
    WHERE ID_Trs_Keluhan = @ID_Trs_Keluhan;
END;
GO


--Tabel Transaksi Peminjaman Pengembalian Barang
CREATE TABLE Transaksi_Peminjaman_Pengembalian_Barang (
    ID_Trs_Barang VARCHAR(10) PRIMARY KEY,
    Jumlah_Barang INT,
    Tgl_Peminjaman DATE,
    Tgl_Pengembalian DATE,
    ID_NIK VARCHAR(10),
    FOREIGN KEY (ID_NIK) REFERENCES Warga(ID_NIK)
);

CREATE PROCEDURE sp_InsertTransaksiPeminjamanPengembalianBarang
    @ID_Trs_Barang VARCHAR(10),
    @Jumlah_Barang INT,
    @Tgl_Peminjaman DATE,
    @Tgl_Pengembalian DATE,
    @ID_NIK VARCHAR(10)
AS
BEGIN
    INSERT INTO Transaksi_Peminjaman_Pengembalian_Barang (ID_Trs_Barang, Jumlah_Barang, Tgl_Peminjaman, Tgl_Pengembalian, ID_NIK)
    VALUES (@ID_Trs_Barang, @Jumlah_Barang, @Tgl_Peminjaman, @Tgl_Pengembalian, @ID_NIK);
END;
GO
--UPDATE 
CREATE PROCEDURE sp_UpdateTransaksiPeminjamanPengembalianBarang
    @ID_Trs_Barang VARCHAR(10),
    @Jumlah_Barang INT,
    @Tgl_Peminjaman DATE,
    @Tgl_Pengembalian DATE,
    @ID_NIK VARCHAR(10)
AS
BEGIN
    UPDATE Transaksi_Peminjaman_Pengembalian_Barang
    SET Jumlah_Barang = @Jumlah_Barang, Tgl_Peminjaman = @Tgl_Peminjaman, Tgl_Pengembalian = @Tgl_Pengembalian, ID_NIK = @ID_NIK
    WHERE ID_Trs_Barang = @ID_Trs_Barang;
END;
GO
--DELETE
CREATE PROCEDURE sp_DeleteTransaksiPeminjamanPengembalianBarang
    @ID_Trs_Barang VARCHAR(10)
AS
BEGIN
    DELETE FROM Transaksi_Peminjaman_Pengembalian_Barang
    WHERE ID_Trs_Barang = @ID_Trs_Barang;
END;
GO




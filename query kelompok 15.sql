
CREATE TABLE UserAccount (
UserID SERIAL PRIMARY KEY,
Username VARCHAR(50) UNIQUE NOT NULL,
Password VARCHAR(50) NOT NULL,
NamaLengkap VARCHAR(100),
Role VARCHAR(20) CHECK (Role IN ('Murid', 'Pengajar', 'Staf'))
);

CREATE TABLE Murid (
MuridID SERIAL PRIMARY KEY,
UserID INT REFERENCES UserAccount(UserID),
TanggalLahir DATE,
Alamat TEXT
);

CREATE TABLE Pengajar (
PengajarID SERIAL PRIMARY KEY,
UserID INT REFERENCES UserAccount(UserID),
Spesialisasi VARCHAR(100)
);

CREATE TABLE Staf (
StafID SERIAL PRIMARY KEY,
UserID INT REFERENCES UserAccount(UserID),
Jabatan VARCHAR(100)
);

CREATE TABLE Jadwal (
JadwalID SERIAL PRIMARY KEY,
Hari VARCHAR(10),
JamMulai TIME,
JamSelesai TIME,
KelasID INT,
PengajarID INT REFERENCES Pengajar(PengajarID)
);

namespace BimbelTime
{
public class User
{
public int UserID { get; set; }
public string Username { get; set; }
public string Password { get; set; }
public string NamaLengkap { get; set; }
public string Role { get; set; }
}
}

Kodemu barusan yang ini
Udah sesuai belom? Takut ga cocok ngulang lagi malas

-- User Staf
INSERT INTO "User" (UserID, Username, Password, NamaLengkap, Role)
VALUES (1, 'staf01', '1234', 'Admin Staf', 'Staf');

-- User Pengajar
INSERT INTO "User" (UserID, Username, Password, NamaLengkap, Role)
VALUES (2, 'guru01', '1234', 'Pak Budi', 'Pengajar');

-- User Murid
INSERT INTO "User" (UserID, Username, Password, NamaLengkap, Role)
VALUES (3, 'murid01', '1234', 'Erga', 'Murid');



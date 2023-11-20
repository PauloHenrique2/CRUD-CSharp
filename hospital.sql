CREATE DATABASE hospital;

USE hospital;

CREATE TABLE Consultas
(
 idConsulta INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
 dataConsulta DATE,
 horaInicio TIME,
 horaFim TIME,
 obs VARCHAR(50),
 fk_idMedico INT,
 fk_idPaciente INT,
 FOREIGN KEY (fk_idMedico) REFERENCES Medicos(idMedico),
 FOREIGN KEY (fk_idPaciente) REFERENCES Pacientes(idPaciente)
);

SELECT * FROM Consultas WHERE idConsulta = 3;

DROP TABLE Consultas;

CREATE TABLE Medicos
(
 idMedico INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
 nomeMedico VARCHAR(80),
 CRM CHAR(6)
);

SELECT * FROM Medicos WHERE idMedico = 1;

DROP TABLE Medicos;

CREATE TABLE Pacientes
(
 idPaciente INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
 nomePaciente VARCHAR(80),
 telefone CHAR(9)
);

UPDATE Pacientes SET nomePaciente = '{0}', telefone = '{1}' WHERE idPaciente = '{2}';

DELETE  FROM Pacientes WHERE idPaciente = '{0}';

SELECT * FROM Pacientes WHERE idPaciente = 1;

DROP TABLE Pacientes;
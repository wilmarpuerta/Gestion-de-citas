-- Active: 1717033767210@@b2xhtbhklufwqsdrpgwp-mysql.services.clever-cloud.com@3306


CREATE Table Pacientes (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Nombres VARCHAR(125),
    Apellidos VARCHAR(125),
    FechaNacimiento DATE,
    Correo VARCHAR(125),
    Telefono VARCHAR(75),
    Direccion VARCHAR(125),
    Estado ENUM("activo", "inactivo")
);

CREATE Table Especialidades (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(125),
    Descripcion TEXT,
    Estado ENUM("activo", "inactivo")
);

CREATE TABLE Medicos (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    NombreCompleto VARCHAR(125),
    Especialidad INT,
    Correo VARCHAR(125) UNIQUE,
    Telefono VARCHAR(75),
    Estado ENUM("activo", "inactivo"),
    Foreign Key (Especialidad) REFERENCES Especialidades(Id)
);


CREATE Table Citas (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    MedicoId INT,
    PacienteId INT,
    Fecha DATE,
    Estado ENUM("activo", "inactivo"),
    Foreign Key (MedicoId) REFERENCES Medicos(Id),
    Foreign Key (PacienteId) REFERENCES Pacientes(Id)
);

CREATE Table Tratamientos (
    Id INTEGER PRIMARY KEY AUTO_INCREMENT,
    CitaId INT,
    Descripcion TEXT,
    Estado ENUM("activo", "inactivo"),
    Foreign Key (CitaId) REFERENCES Citas(Id)
)

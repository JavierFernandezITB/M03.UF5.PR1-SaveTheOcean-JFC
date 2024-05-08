CREATE TABLE Animals (
    Id SERIAL PRIMARY KEY,
    Name varchar(255),
    Specie varchar(255),
    Weight DOUBLE PRECISION
);

CREATE TABLE Rescues (
    Id SERIAL PRIMARY KEY,
    Code varchar(32),
    Date varchar(64),
    AG int,
    Location varchar(32),
    AnimalId int
);
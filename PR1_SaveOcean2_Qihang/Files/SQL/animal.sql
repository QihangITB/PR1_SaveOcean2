CREATE TABLE IF NOT EXISTS animal (
    id SERIAL PRIMARY KEY,
    name VARCHAR NOT NULL,
    super_family VARCHAR NOT NULL,
    species VARCHAR NOT NULL,
    weight DECIMAL(10,2) NOT NULL
);

INSERT INTO animal (name, super_family, species, weight) VALUES ('Dall', 'Cetacean', 'Dolphin', 190.03);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Woby', 'Cetacean', 'Whale', 43200.20);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Samy', 'Cetacean', 'Killer Whale', 3500.12);

INSERT INTO animal (name, super_family, species, weight) VALUES ('Tim', 'Sea Bird', 'Seagull', 24.23);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Dally', 'Sea Bird', 'Penguin', 15.70);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Poppy', 'Sea Bird', 'Albatross', 8.46);

INSERT INTO animal (name, super_family, species, weight) VALUES ('Turt', 'Sea Turtle', 'Cheloniidae', 45.31);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Cary', 'Sea Turtle', 'Caretta Turtle', 12.02);
INSERT INTO animal (name, super_family, species, weight) VALUES ('Tito', 'Sea Turtle', 'Loggerhead Turtle', 32.50);
CREATE TABLE IF NOT EXISTS rescue (
    code VARCHAR PRIMARY KEY,
    date DATE NOT NULL,
    super_family VARCHAR NOT NULL,
    affectation_grade NUMERIC NOT NULL,
    location VARCHAR NOT NULL
);

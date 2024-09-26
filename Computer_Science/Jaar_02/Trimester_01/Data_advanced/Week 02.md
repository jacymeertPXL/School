````
CREATE INDEX index_name
ON table_name
(kolom_naam1,kolom_naam2, ...);

SElECT * FROM blocks WHERE shape = 'circle' and color = 'red'

CREATE INDEX color_index
on blocks
(color, shape);

```

--- Oefeningen

CREATE SEQUENCE hoofd_seq
    START WITH 1000
    INCREMENT BY 1
    MAXVALUE 1999
    NOCYCLE;

CREATE SEQUENCE opleidingen_seq
    START WITH 2000
    INCREMENT BY 1
    MAXVALUE 2999
    NOCYCLE;

CREATE SEQUENCE verkoop_seq
    START WITH 3000
    INCREMENT BY 1
    MAXVALUE 3999
    NOCYCLE;

CREATE SEQUENCE personeel_seq
    START WITH 4000
    INCREMENT BY 1
    MAXVALUE 4999
    NOCYCLE;

CREATE SEQUENCE productontwikkeling_seq
    START WITH 5000
    INCREMENT BY 1
    MAXVALUE 5999
    NOCYCLE;

CREATE SEQUENCE klantenservice_seq
    START WITH 6000
    INCREMENT BY 1
    MAXVALUE 6999
    NOCYCLE;

CREATE SEQUENCE neg_num_seq
    START WITH -100
    INCREMENT BY 2
    MINVALUE -100
    MAXVALUE 0
    NOCYCLE;

CREATE SEQUENCE graad_1_seq
    START WITH 1000
    INCREMENT BY 10
    NOCYCLE;

CREATE SEQUENCE graad_2_seq
    START WITH 2000
    INCREMENT BY 10
    NOCYCLE;

CREATE SEQUENCE subsidie_seq
    START WITH 10
    INCREMENT BY 10
    MAXVALUE 60
    CYCLE;

CREATE INDEX index_title ON films (title);
SELECT * 
FROM films 
WHERE title LIKE 'You%';

SELECT * 
FROM films
WHERE title LIKE 'You%'
ORDER BY imdb_rating DESC;

```
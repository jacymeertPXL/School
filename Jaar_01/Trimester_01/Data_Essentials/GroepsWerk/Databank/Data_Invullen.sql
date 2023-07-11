INSERT INTO werkzame_stoffen (
    werkzamestofid,
    werkzamestof,
    werkzamestofdoel
) VALUES (
    1,
    'test',
    'test tekst'
),
(
    2,
    'test2',
    'test tekst 2'
);

INSERT INTO verpakkingen (
    verpakkingsid,
    verpakking
) VALUES (
    1,
    'test tekst'
),
(
    2,
    'test tekst 2'
);

INSERT INTO artikels (
    artikelnr,
    arikelnaam,
    verpakkingsid,
    omschrijving_kort. omschrijving_lang,
    prijs,
    pluspunt,
    tips_gebruik,
    werkzamestofid
) VALUES (
    1,
    'test',,
    1,
    'test',
    'test',
    'test',
    350,
    'test',
    'test',
    'test'
),
(
    2,
    'test',
    2,
    'test',
    'test',
    'test',
    350,
    'test',
    'test',
    'test'
);

INSERT INTO ingredienten (
    ingredientid,
    ingredient,
    ingredienttype
) VALUES (
    1,
    'test',
    'test tekst'
),
(
    2,
    'test2',
    'test tekst 2'
);

INSERT INTO artikel_ingredienten (
    artikelnr,
    ingredientid
) VALUES (
    1,
    1
),
(
    2,
    2
);

INSERT INTO beloften (
    belofteid,
    belofte
) VALUES (
    1,
    'test'
),
(
    2,
    'test'
);

INSERT INTO artikel_beloften (
    artikelnr,
    belofteid
) VALUES (
    1,
    1
),
(
    2,
    2
);

INSERT INTO folders (
    actiecode,
    geschenk2
) VALUES (
    1,
    1
),
(
    2,
    2
);

INSERT INTO folder_artikels (
    actiecode,
    artikelnr
) VALUES (
    1,
    1
),
(
    2,
    2
);

INSERT INTO voordelen (
    voordeelid,
    voordeel
) VALUES (
    1,
    'test'
),
(
    2,
    'test'
);

INSERT INTO landen (
    landid,
    land
) VALUES (
    1,
    'test'
),
(
    2,
    'test'
);

INSERT INTO gemeenten (
    postcode,
    gemeente,
    landcode
) VALUES (
    'test',
    'test',
    1
),
(
    'test2',
    'test2',
    2
);

INSERT INTO adressen (
    adresid,
    huisnr,
    bus,
    straat. postcode
) VALUES (
    1,
    'test',
    'test ',
    'test',
    'test'
),
(
    2,
    'test',
    'test',
    'test',
    'test'
);

INSERT INTO klanten (
    klantnr,
    facturatienaam,
    facturatievoornaam,
    facturatiegeslacht. facturatie_adresid
) VALUES (
    1,
    'test',
    'test ',
    'test',
    1
),
(
    2,
    'test',
    'test',
    'test',
    2
);

INSERT INTO betalingswijzen (
    betalingsid,
    betalingswijze
) VALUES (
    1,
    'test'
),
(
    2,
    'test'
);

INSERT INTO bestellingen (
    actiecode,
    klantnr,
    besteldatum,
    betalingsid. verzendingskosten,
    toegangscode,
    leveringsnaam,
    leveringsvoornaam,
    leveringsgeslacht,
    leveringsgeslacht
) VALUES (
    1,
    1,
    DATE '2015-12-17',
    1,
    1,
    1,
    'test',
    'test',
    'test',
    1
),
(
    2,
    2,
    DATE '2015-12-17',
    2,
    2,
    2,
    'test',
    'test',
    'test',
    2
);

INSERT INTO Bestel_artikel (
    actiecode,
    klantnr,
    artikelnr
) VALUES (
    1,
    'test',
    'test tekst'
),
(
    2,
    'test2',
    'test tekst 2'
);

INSERT INTO Bestel_artikel_prijs (
    actiecode,
    artikelnr,
    te_betalen_prijs
) VALUES (
    1,
    1,
    1
),
(
    2,
    2,
    2
);
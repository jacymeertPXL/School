CREATE TABLE werkzame_stoffen (
  werkzamestofid NUMBER(5) CONSTRAINT wks_werkzamestofid PRIMARY KEY,
  werkzamestof VARCHAR2(50),
  werkzamestofdoel VARCHAR2(500)
);

CREATE TABLE verpakkingen (
  verpakkingsid NUMBER(5) CONSTRAINT ver_verpakkingsid PRIMARY KEY,
  verpakking VARCHAR2(50)
);

CREATE TABLE artikels (
  artikelnr NUMBER(5) CONSTRAINT art_artikelnr PRIMARY KEY,
  arikelnaam VARCHAR2(25) CONSTRAINT art_artikelnaam_nn NOT NULL,
  verpakkingsid NUMBER(2) CONSTRAINT art_verpakkingsid_fk REFERENCES verpakkingen (verpakkingsid),
  omschrijving_kort VARCHAR2(50),
  omschrijving_lang VARCHAR2(500),
  prijs NUMBER(5, 2),
  pluspunt VARCHAR2(50),
  tips_gebruik VARCHAR2(50),
  werkzamestofid NUMBER(3) CONSTRAINT art_werkzamestofid_fk REFERENCES werkzame_stoffen (werkzamestofid)
);

CREATE TABLE ingredienten (
  ingredientid NUMBER(5) CONSTRAINT ing_ingredientid PRIMARY KEY,
  ingredient VARCHAR2(100),
  ingredienttype VARCHAR2(50)
);

CREATE TABLE artikel_ingredienten (
  artikelnr NUMBER(5) CONSTRAINT ari_artikelnr_fk REFERENCES artikels (artikelnr),
  ingredientid NUMBER(5) CONSTRAINT ari_ingredientid_fk REFERENCES ingredienten (ingredientid),
  CONSTRAINT bep_pk PRIMARY KEY (artikelnr, ingredientid)
);

CREATE TABLE beloften (
  belofteid NUMBER(4) CONSTRAINT blf_belofteid PRIMARY KEY,
  belofte VARCHAR2(100)
);

CREATE TABLE artikel_beloften (
  artikelnr NUMBER(5) CONSTRAINT arb_artikelnr_fk REFERENCES artikels (artikelnr),
  belofteid NUMBER(4) CONSTRAINT arb_belofteid_fk REFERENCES beloften (belofteid),
  CONSTRAINT arb_pk PRIMARY KEY (artikelnr, belofteid)
);

CREATE TABLE folders (
  actiecode NUMBER(4) CONSTRAINT fol_actiecode PRIMARY KEY,
  geschenk2 NUMBER(5) CONSTRAINT fol_geschenk2_fk REFERENCES artikels (artikelnr)
);

CREATE TABLE folder_artikels (
  actiecode NUMBER(4) CONSTRAINT far_actiecode_fk REFERENCES folders (actiecode),
  artikelnr NUMBER(5) CONSTRAINT far_artikelnr_fk REFERENCES artikels (artikelnr),
  CONSTRAINT far_pk PRIMARY KEY (actiecode, artikelnr)
);

CREATE TABLE voordelen (
  voordeelid NUMBER(3) CONSTRAINT vor_voordeelid PRIMARY KEY,
  voordeel VARCHAR2(50)
);

CREATE TABLE folder_voordelen (
  actiecode NUMBER(4) CONSTRAINT fvd_actiecode_fk REFERENCES folders (actiecode),
  voordeelid NUMBER(3) CONSTRAINT fvd_voordeelid_fk REFERENCES voordelen (voordeelid),
  CONSTRAINT fvd_pk PRIMARY KEY (actiecode, klantnr)
);

CREATE TABLE landen (
  landid NUMBER(5) CONSTRAINT lnd_landid PRIMARY KEY,
  land VARCHAR2(50)
);

CREATE TABLE gemeenten (
  postcode VARCHAR2(10) CONSTRAINT gem_postcode PRIMARY KEY,
  gemeente VARCHAR2(25),
  landcode NUMBER(5) CONSTRAINT gem_landid_fk REFERENCES landen (landid)
);

CREATE TABLE adressen (
  adresid NUMBER(9) CONSTRAINT adr_adresid PRIMARY KEY,
  huisnr VARCHAR2(10),
  bus VARCHAR2(5),
  straat VARCHAR2(100),
  postcode VARCHAR2(10) CONSTRAINT adr_postcode_fk REFERENCES gemeenten (postcode)
);

CREATE TABLE klanten (
  klantnr NUMBER(9) CONSTRAINT klt_klantnr PRIMARY KEY,
  facturatienaam VARCHAR2(25),
  facturatievoornaam VARCHAR2(20),
  facturatiegeslacht VARCHAR2(20),
  facturatie_adresid NUMBER(9) CONSTRAINT klt_adresid_fk REFERENCES adressen (adresid)
);

CREATE TABLE betalingswijzen (
  betalingsid NUMBER(1) CONSTRAINT bet_betaling_id PRIMARY KEY,
  betalingswijze VARCHAR2(20)
);

CREATE TABLE bestellingen (
  actiecode NUMBER (4) CONSTRAINT bes_actiecode_fk REFERENCES folders (actiecode),
  klantnr NUMBER(9) CONSTRAINT bes_klantnr_fk REFERENCES klanten (klantnr),
  besteldatum DATE,
  betalingsid NUMBER(1) CONSTRAINT bes_betalingsid_fk REFERENCES betalingswijzen (betalingsid),
  verzendingskosten NUMBER(6, 2) CONSTRAINT bes_verzending_nn NOT NULL,
  toegangscode NUMBER(5),
  leveringsnaam VARCHAR2(25),
  leveringsvoornaam VARCHAR2(20),
  leveringsgeslacht VARCHAR2(20),
  leveringsgeslacht NUMBER(6) CONSTRAINT bes_levadresid_fk REFERENCES adressen (adresid),
  CONSTRAINT bes_pk PRIMARY KEY (actiecode, klantnr)
);

CREATE TABLE Bestel_artikel (
  actiecode NUMBER(4) CONSTRAINT bar_actiecode_fk REFERENCES bestellingen (actiecode),
  klantnr NUMBER(9) CONSTRAINT bar_actiecode_fk REFERENCES bestellingen (klantnr),
  artikelnr NUMBER(5)CONSTRAINT bar_klantnr_fk REFERENCES bestel_artikel_prijzen (artikelnr),
  CONSTRAINT bak_pk PRIMARY KEY (actiecode, klantnr, artikelnr)
);

CREATE TABLE Bestel_artikel_prijs (
  actiecode NUMBER(4) CONSTRAINT bap_actiecode_fk REFERENCES folder_artikels (actiecode),
  artikelnr NUMBER(5) bap_artikelnr_fk REFERENCES artikels (artikelnr),
  te_betalen_prijs NUMBER(3) CONSTRAINT bep_pk PRIMARY KEY (actiecode, artikelnr)
);
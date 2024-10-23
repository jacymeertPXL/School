## Database Objects
- **Sequences** genereren unieke waarden voor rijen in een tabel en kunnen worden aangepast of verwijderd met `CREATE`, `ALTER`, en `DROP`.
- **Indexen** verbeteren query-prestaties door gestructureerde zoekacties op kolommen. Ze kunnen simpel of multi-kolom zijn.
- **Synonyms** dienen als aliassen voor lange of onduidelijke objectnamen en kunnen met `CREATE`, `ALTER`, en `DROP` worden beheerd.

```sql
-- Sequence aanmaken voor automatische ID-waarden
CREATE SEQUENCE klant_seq
START WITH 1
INCREMENT BY 1;

INSERT INTO klanten (klant_id, naam) 
VALUES (klant_seq.NEXTVAL, 'Jan');

-- Index aanmaken voor snellere zoekopdrachten
CREATE INDEX idx_klanten_naam
ON klanten (naam);

-- Synonym aanmaken voor makkelijker gebruik van lange tabellenamen
CREATE SYNONYM klant_view FOR jan.klanten_view;
SELECT * FROM klant_view; 
```


## Triggers
- **Triggers** worden automatisch uitgevoerd bij bepaalde database-events (DML, DDL).
- **DML triggers** reageren op datawijzigingen zoals `INSERT`, `UPDATE`, of `DELETE`.
- Triggers kunnen voor en na een gebeurtenis worden uitgevoerd (**BEFORE** of **AFTER**).
- **Row triggers** werken per rij, terwijl **statement triggers** op de gehele actie werken.
- **Audit trails** kunnen met triggers worden opgezet voor logging.

```sql
CREATE OR REPLACE TRIGGER update_stock
AFTER INSERT ON orders
FOR EACH ROW
BEGIN
    UPDATE producten
    SET voorraad = voorraad - :NEW.aantal
    WHERE product_id = :NEW.product_id;
END;

-- Audit trail trigger voor het loggen van wijzigingen
CREATE OR REPLACE TRIGGER log_update
AFTER UPDATE ON klanten
FOR EACH ROW
BEGIN
    INSERT INTO audit_log (user, actie, datum)
    VALUES (USER, 'UPDATE', SYSDATE);
END;

-- DDL-trigger voor restricties op objectcreatie
CREATE OR REPLACE TRIGGER no_create_night
BEFORE CREATE ON SCHEMA
WHEN (to_number(to_char(SYSDATE, 'HH24')) NOT BETWEEN 8 AND 18)
BEGIN
    RAISE_APPLICATION_ERROR(-20000, 'Creaties zijn enkel overdag toegestaan');
END; 
```

## Schemas
- Een **schema** wordt automatisch aangemaakt bij het aanmaken van een gebruiker.
- Schema's zijn gekoppeld aan gebruikers en maken gebruik van **tablespaces**.
- Een gebruiker krijgt via **GRANT** specifieke rechten zoals `create session` en `create table`.
- **Roles** groeperen privileges en kunnen aan gebruikers worden toegekend.
- Rechten kunnen worden afgenomen via **REVOKE**, en gebruikers kunnen worden verwijderd met **DROP USER**.

### Voorbeelden:
```sql
-- Schema aanmaken
CREATE USER jan IDENTIFIED BY "pass123";

-- Tabel aanmaken binnen een schema
CREATE TABLE jan.producten (
    product_id NUMBER(10) PRIMARY KEY,
    product_naam VARCHAR2(50)
);

-- Rechten toekennen aan een gebruiker
GRANT CREATE SESSION TO jan;
GRANT CREATE TABLE TO jan;

-- Rol aanmaken en toekennen aan gebruikers
CREATE ROLE app_dev;
GRANT CREATE TABLE, CREATE VIEW TO app_dev;
GRANT app_dev TO jan;

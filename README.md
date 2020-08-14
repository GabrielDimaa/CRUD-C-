# CRUD-C-

## PostgreSQL
Tabelas e funções:

CREATE TABLE users (
    id serial NOT NULL,
    codigo integer NOT NULL UNIQUE,
    nome character varying(50) NOT NULL,
    idade integer NOT NULL,
    telefone character varying(14) NOT NULL,
    email character varying(45) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE log_users(
    operacao character varying(10) NOT NULL,
    usuario text NOT NULL,
    data timestamp NOT NULL,
    id integer NOT NULL,
    codigo integer NOT NULL,
    nome character varying(50) NOT NULL,
    idade integer NOT NULL,
    telefone character varying(14) NOT NULL,
    email character varying(45) NOT NULL
);

CREATE OR REPLACE FUNCTION processa_log_users() RETURNS TRIGGER AS $log_users$
    BEGIN
        IF (TG_OP = 'DELETE') THEN
            INSERT INTO log_users SELECT 'DELETE', user, now(), OLD.*;
            RETURN OLD;
        ELSIF (TG_OP = 'UPDATE') THEN
            INSERT INTO log_users SELECT 'UPDATE', user, now(), NEW.*;
            RETURN NEW;
        ELSIF (TG_OP = 'INSERT') THEN
            INSERT INTO log_users SELECT 'INSERT', user, now(), NEW.*;
            RETURN NEW;
        END IF;
            RETURN NULL; 
        AFTER
    END;
$log_users$ language plpgsql;

CREATE TRIGGER log_users
AFTER INSERT OR UPDATE OR DELETE ON users
    FOR EACH ROW EXECUTE PROCEDURE processa_log_users();

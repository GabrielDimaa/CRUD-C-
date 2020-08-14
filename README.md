# CRUD-C-

## PostgreSQL
Tabelas e funções:

CREATE TABLE users ( <br>
    id serial NOT NULL,<br>
    codigo integer NOT NULL UNIQUE,<br>
    nome character varying(50) NOT NULL,<br>
    idade integer NOT NULL,<br>
    telefone character varying(14) NOT NULL,<br>
    email character varying(45) NOT NULL,<br>
    PRIMARY KEY (id)<br>
);<br>
<br>
CREATE TABLE log_users(<br>
    operacao character varying(10) NOT NULL,<br>
    usuario text NOT NULL,<br>
    data timestamp NOT NULL,<br>
    id integer NOT NULL,<br>
    codigo integer NOT NULL,<br>
    nome character varying(50) NOT NULL,<br>
    idade integer NOT NULL,<br>
    telefone character varying(14) NOT NULL,<br>
    email character varying(45) NOT NULL<br>
);<br>
<br>
CREATE OR REPLACE FUNCTION processa_log_users() RETURNS TRIGGER AS $log_users$<br>
    BEGIN<br>
        IF (TG_OP = 'DELETE') THEN<br>
            INSERT INTO log_users SELECT 'DELETE', user, now(), OLD.*;<br>
            RETURN OLD;<br>
        ELSIF (TG_OP = 'UPDATE') THEN<br>
            INSERT INTO log_users SELECT 'UPDATE', user, now(), NEW.*;<br>
            RETURN NEW;<br>
        ELSIF (TG_OP = 'INSERT') THEN<br>
            INSERT INTO log_users SELECT 'INSERT', user, now(), NEW.*;<br>
            RETURN NEW;<br>
        END IF;<br>
            RETURN NULL; <br>
        AFTER<br>
    END;<br>
$log_users$ language plpgsql;<br>

CREATE TRIGGER log_users<br>
AFTER INSERT OR UPDATE OR DELETE ON users<br>
    FOR EACH ROW EXECUTE PROCEDURE processa_log_users();<br>

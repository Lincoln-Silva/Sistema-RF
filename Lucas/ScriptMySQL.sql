CREATE DATABASE Cadastro;
use Cadastro;

CREATE TABLE Usuario(
	Id int auto_increment primary key,
	Nome varchar(20),
	Senha varchar(40),
    admin bool
);

INSERT INTO Usuario
	(
		nome,
        senha,
        admin
	)VALUES
    (
		'Admin',
        'B45668EDFA23D0A2E3A68C7A78858188E9291FB4',
        TRUE
    ),
    (
		'Usuario',
        '3F7EFB965536EF90F7163DD8702FBF317EAF2581',
        FALSE
    );

CREATE TABLE Produto(
	RFID varchar(20) primary key,
	Nome varchar(40),
	Valor numeric(9,2),
    Quantidade int
);

DELIMITER //

CREATE PROCEDURE InsereProduto ( prfid VARCHAR(20), pnome VARCHAR(40), pvalor NUMERIC(9,2), pquantidade INT)

BEGIN
	IF EXISTS(SELECT 1 FROM produto WHERE rfid = prfid) THEN
		BEGIN
			UPDATE produto
            SET nome = pnome, quantidade = pquantidade, valor = pvalor
            WHERE rfid = prfid;
        END;
	ELSE
		BEGIN
			INSERT INTO produto
				(
					rfid,
                    nome,
                    quantidade,
                    valor
                )
                VALUES
                (
					prfid,
					pnome,
                    pquantidade,
                    pvalor
                );
        END;
	END IF;
END; //

DELIMITER ;
    

CREATE USER 'user'@'localhost' IDENTIFIED VIA mysql_native_password USING PASSWORD('user_password');
GRANT USAGE ON *.* TO `user`@`localhost` IDENTIFIED BY PASSWORD '*ADC3B5B27617732CD6320A2DA976258E149A7EC8';
GRANT SELECT, INSERT, UPDATE, DELETE ON `dinobazis`.* TO `user`@`localhost`;
DROP VIEW IF EXISTS dinoszauruszok;
CREATE VIEW dinoszauruszok AS
SELECT
	dinok.id,
    dinok.nev,
    felfedezok.nev as 'felfedezo',
    dinok.felfedezes_datuma,
    dinok.mikorelt,
    dinok.lelohelyek,
    dinok.elohelyek,
    dinok.taplalek,
    taplalkozasi_forma.nev as 'taplalkozasi_forma',
    taplalkozasi_forma.tud_elnevezes,
    dinok.testmeret,
    dinok.testtomeg,
    dinok.leiras,
    dinok.kep
FROM
    dinok
INNER JOIN felfedezok ON dinok.felfedezo_id = felfedezok.id
INNER JOIN taplalkozasi_forma on dinok.taplalkozasi_forma_id = taplalkozasi_forma.id;
CREATE ROLE R_TAICHINH;
CREATE ROLE R_NHANSU;
CREATE ROLE R_TRUONGDEAN;
/
-- TAI CHINH
alter session set "_ORACLE_SCRIPT"=true;
CREATE user TC01 IDENTIFIED BY TC01;
CREATE user TC02 IDENTIFIED BY TC02;
CREATE user TC03 IDENTIFIED BY TC03;
CREATE user TC04 IDENTIFIED BY TC04;
CREATE user TC05 IDENTIFIED BY TC05;
GRANT SELECT ON QLNV.NHANVIEN to R_TAICHINH;
GRANT SELECT ON QLNV.PHANCONG TO R_TAICHINH;
GRANT SELECT on QLNV.PHONGBAN to R_TAICHINH;
GRANT SELECT on QLNV.DEAN TO R_TAICHINH;
GRANT UPDATE ON QLNV.NHANVIEN TO R_TAICHINH;
grant select on QLNV.view_decrypt_NHANVIEN_LUONG_PHUCAP to R_TAICHINH;
grant select on QLNV.view_decrypt_TAICHINH_LUONG_PHUCAP to R_TAICHINH;

GRANT R_TAICHINH TO TC01;
GRANT CREATE session TO TC01;
GRANT R_TAICHINH TO TC02;
GRANT CREATE session TO TC02;
GRANT R_TAICHINH TO TC03;
GRANT CREATE session TO TC03;
GRANT R_TAICHINH TO TC04;
GRANT CREATE session TO TC04;
GRANT R_TAICHINH TO TC05;
GRANT CREATE session TO TC05;


-- NHAN SU
alter session set "_ORACLE_SCRIPT"=true;
CREATE user NS01 IDENTIFIED BY NS01;
CREATE user NS02 IDENTIFIED BY NS02;
CREATE user NS03 IDENTIFIED BY NS03;
CREATE user NS04 IDENTIFIED BY NS04;
CREATE user NS05 IDENTIFIED BY NS05;
GRANT SELECT ON QLNV.NHANVIEN to R_NHANSU;
GRANT SELECT ON QLNV.PHANCONG TO R_NHANSU;
GRANT SELECT ON QLNV.PHONGBAN to R_NHANSU;
GRANT SELECT ON QLNV.DEAN TO R_NHANSU;
GRANT UPDATE ON QLNV.NHANVIEN TO R_NHANSU;

GRANT INSERT ON QLNV.PHONGBAN TO R_NHANSU;
GRANT UPDATE ON QLNV.PHONGBAN TO R_NHANSU;
GRANT INSERT ON QLNV.NHANVIEN TO R_NHANSU;
grant select on QLNV.view_decrypt_NHANVIEN_LUONG_PHUCAP to R_NHANSU;

GRANT R_NHANSU TO NS01;
GRANT CREATE session TO NS01;
GRANT R_NHANSU TO NS02;
GRANT CREATE session TO NS02;
GRANT R_NHANSU TO NS03;
GRANT CREATE session TO NS03;
GRANT R_NHANSU TO NS04;
GRANT CREATE session TO NS04;
GRANT R_NHANSU TO NS05;
GRANT CREATE session TO NS05;
-- TRUONG DE AN
alter session set "_ORACLE_SCRIPT"=true;
CREATE user TDA01 IDENTIFIED BY TDA01;
CREATE user TDA02 IDENTIFIED BY TDA02;
CREATE user TDA03 IDENTIFIED BY TDA03;
CREATE user TDA04 IDENTIFIED BY TDA04;
CREATE user TDA05 IDENTIFIED BY TDA05;
GRANT SELECT ON QLNV.NHANVIEN to R_TRUONGDEAN;
GRANT SELECT ON QLNV.PHANCONG TO R_TRUONGDEAN;
GRANT SELECT ON QLNV.PHONGBAN to R_TRUONGDEAN;
GRANT SELECT ON QLNV.DEAN TO R_TRUONGDEAN;
GRANT UPDATE ON QLNV.NHANVIEN TO R_TRUONGDEAN;

GRANT INSERT ON QLNV.DEAN TO R_TRUONGDEAN;
GRANT DELETE ON QLNV.DEAN TO R_TRUONGDEAN;
GRANT UPDATE ON QLNV.DEAN TO R_TRUONGDEAN;
grant select on QLNV.view_decrypt_NHANVIEN_LUONG_PHUCAP to R_TRUONGDEAN;

GRANT R_TRUONGDEAN TO TDA01;
GRANT CREATE session TO TDA01;
GRANT R_TRUONGDEAN TO TDA02;
GRANT CREATE session TO TDA02;
GRANT R_TRUONGDEAN TO TDA03;
GRANT CREATE session TO TDA03;
CREATE ROLE R_NHANVIEN;
alter session set "_ORACLE_SCRIPT"=true;
CREATE user NV01 IDENTIFIED BY NV01;
GRANT SELECT ON QLNV.NHANVIEN to R_NHANVIEN;
GRANT SELECT ON QLNV.PHANCONG TO R_PHANCONG;
grant SELECT on QLNV.PHONGBAN to R_NHANVIEN;
grant SELECT on QLNV.DEAN TO R_NHANVIEN;
GRANT UPDATE ON QLNV.NHANVIEN TO R_NHANVIEN;

GRANT R_NHANVIEN TO NV01;
GRANT CREATE session TO NV01;
--ROle Truong Phong

CREATE ROLE R_TRUONGPHONG;
CREATE USER TP01 IDENTIFIED BY TP01;
GRANT SELECT ON QLNV.NHANVIEN to R_TRUONGPHONG;
GRANT SELECT ON QLNV.PHANCONG TO R_TRUONGPHONG;
grant SELECT on QLNV.PHONGBAN to R_TRUONGPHONG;
grant SELECT on QLNV.DEAN TO R_TRUONGPHONG;
GRANT UPDATE ON QLNV.NHANVIEN TO R_TRUONGPHONG;
GRANT INSERT, DELETE, UPDATE ON QLNV.PHANCONG TO R_TRUONGPHONG;

GRANT R_TRUONGPHONG TO TP01;
GRANT CREATE session TO TP01;
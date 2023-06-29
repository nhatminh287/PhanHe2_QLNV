SELECT VALUE FROM V$OPTION WHERE PARAMETER = 'Unified Auditing';
/
alter session set "_ORACLE_SCRIPT"=true;
/
GRANT CREATE SESSION TO QLNV;
GRANT ALL PRIVILEGES TO QLNV;
GRANT SYSDBA TO QLNV;
/
conn QLNV/9999;
ALTER SYSTEM SET audit_trail = db SCOPE = SPFILE;
/
/
-- 4a. Nhung nguoi da cap nhat truong thoi gian 
begin
    dbms_fga.add_policy(
        object_schema => 'QLNV',
        object_name => 'PHANCONG',
        policy_name => 'FGA_UPDATE_PHANCONG',
        audit_column => 'THOIGIAN',
        statement_types => 'update'
        );
end;      
/
-- Bat audit policy
BEGIN 
DBMS_FGA.ENABLE_POLICY(
    object_schema => 'QLNV',
    object_name => 'PHANCONG',
    policy_name => 'FGA_UPDATE_PHANCONG',
    enable => TRUE
);
END;
/
-- 4b. Những người đã đọc trên trường LUONG và PHUCAP của người khác.
begin
    dbms_fga.add_policy(
        object_schema => 'QLNV',
        object_name => 'NHANVIEN',
        policy_name => 'FGA_SELECT_LUONG_PHUCAP_NHANVIEN',
        audit_column => 'LUONG, PHUCAP',
        statement_types => 'SELECT',
        audit_column_opts => 'ALL_COLUMN'
        );
end;      
/
-- Bat audit policy
BEGIN 
DBMS_FGA.ENABLE_POLICY(
    object_schema => 'QLNV',
    object_name => 'NHANVIEN',
    policy_name => 'FGA_SELECT_LUONG_PHUCAP_NHANVIEN',
    enable => TRUE
);
END;
/
-- Cau 4c: Một người không thuộc vai trò “Tài chính” nhưng đã cập nhật thành công trên trường LUONG và PHUCAP. 
begin
    dbms_fga.add_policy(
        object_schema => 'QLNV',
        object_name => 'NHANVIEN',
        policy_name => 'FGA_UPDATE_LUONG_PHUCAP_NHANVIEN',
        audit_condition => 'VAITRO != ''Tài chính''',  
        audit_column => 'LUONG, PHUCAP',
        statement_types => 'UPDATE'
        );
end;      
/
-- Bat audit policy
BEGIN 
DBMS_FGA.ENABLE_POLICY(
    object_schema => 'QLNV',
    object_name => 'NHANVIEN',
    policy_name => 'FGA_UPDATE_LUONG_PHUCAP_NHANVIEN',
    enable => TRUE
);
END;
/
-- Cau 4d

-- TEST 4a
/
conn TP01/TP01;
update QLNV.PHANCONG set THOIGIAN = '10' where MANV = 'NV01';
/
update QLNV.PHANCONG set THOIGIAN = '20' where MANV = 'NV02';
/
update QLNV.PHANCONG set THOIGIAN = '20' where MANV = 'NV01';
/
update QLNV.PHANCONG set THOIGIAN = '11' where MANV = 'NV03';
/
select * 
FROM UNIFIED_AUDIT_TRAIL 
WHERE FGA_POLICY_NAME = 'FGA_UPDATE_PHANCONG';
/
SELECT CURRENT_USER, FGA_POLICY_NAME, ACTION_NAME, OBJECT_SCHEMA, OBJECT_NAME, SQL_TEXT, EVENT_TIMESTAMP 
FROM UNIFIED_AUDIT_TRAIL 
WHERE FGA_POLICY_NAME = 'FGA_UPDATE_PHANCONG';      
/
-- TEST 4b
connect NV01/NV01;
SELECT LUONG FROM QLNV.NHANVIEN WHERE MANV = 'NV01';
SELECT CURRENT_USER, FGA_POLICY_NAME, ACTION_NAME, OBJECT_SCHEMA, OBJECT_NAME, SQL_TEXT, EVENT_TIMESTAMP 
FROM UNIFIED_AUDIT_TRAIL     
WHERE FGA_POLICY_NAME = 'FGA_SELECT_LUONG_PHUCAP_NHANVIEN';
/
CONN QLNV/9999
/
disconnect
/
CONN TP01/TP01
/
SELECT LUONG FROM QLNV.NHANVIEN 
/
-- TEST 4c - bug

/
conn TC01/TC01;
update QLNV.NHANVIEN set LUONG = '10000' WHERE MANV= 'NV01'
/
connect NV01/NV01;
SELECT CURRENT_USER, FGA_POLICY_NAME, ACTION_NAME, OBJECT_SCHEMA, OBJECT_NAME, SQL_TEXT, EVENT_TIMESTAMP 
FROM UNIFIED_AUDIT_TRAIL     
WHERE FGA_POLICY_NAME = 'FGA_UPDATE_LUONG_PHUCAP_NHANVIEN';
/

-- KIEM TRA NHAT KY HE THONG
/
SELECT * 
FROM UNIFIED_AUDIT_TRAIL  
/
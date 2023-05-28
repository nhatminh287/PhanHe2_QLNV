-- TAO FUNCTION GIAI MA LUONG
create or replace function decrypt_LUONG (p_data in varchar2)  
    return varchar2  
as  
    output_string VARCHAR2 (200);
    decrypted_raw RAW (2000); -- stores decrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-24', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
begin  
    decrypted_raw := DBMS_CRYPTO.Decrypt
        (
            src => HEXTORAW(p_data),
            typ => encryption_type,
            key => v_key
        );
    output_string := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
    return output_string;  
end; 
/
-- TAO FUNCTION GIAI MA PHUCAP
create or replace function decrypt_PHUCAP (p_data in varchar2)  
    return varchar2  
as  
    output_string VARCHAR2 (200);
    decrypted_raw RAW (2000); -- stores decrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-24', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
begin  
    decrypted_raw := DBMS_CRYPTO.Decrypt
        (
            src => HEXTORAW(p_data),
            typ => encryption_type,
            key => v_key
        );
    output_string := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
    return output_string;  
end; 
/
-- View xem LUONG va PHUCAP cua chinh nhanvien do
create or replace view  view_decrypt_NHANVIEN_LUONG_PHUCAP as 
    select NV.MANV, NV.TENNV, NV.PHAI, NV.NGAYSINH, NV.DIACHI, NV.SODT, CAST (decrypt_LUONG(NV.LUONG) AS varchar2(255)) LUONG, CAST (decrypt_PHUCAP(NV.PHUCAP) AS varchar2(255)) PHUCAP, NV.VAITRO, NV.MANQL, NV.PHG,PC.MADA, PC.THOIGIAN 
    from NHANVIEN NV, PHANCONG PC
    where nv.MANV = (SELECT user FROM dual) and nv.MANV = pc.MANV;
/
-- View xem LUONG va PHUCAP cua role TAICHINH
create or replace view  view_decrypt_TAICHINH_LUONG_PHUCAP as 
    select NV.MANV, NV.TENNV, NV.PHAI, NV.NGAYSINH, NV.DIACHI, NV.SODT, CAST (decrypt_LUONG(NV.LUONG) AS varchar2(255)) LUONG, CAST (decrypt_PHUCAP(NV.PHUCAP) AS varchar2(255)) PHUCAP, NV.VAITRO, NV.MANQL, NV.PHG
    from NHANVIEN NV
/


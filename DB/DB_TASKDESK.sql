--------------------------------------------------------
-- Archivo creado  - martes-noviembre-14-2023   
--------------------------------------------------------
CREATE USER C##user_dev2 IDENTIFIED BY task;

GRANT CONNECT TO C##user_dev2;
GRANT UNLIMITED TABLESPACE TO C##user_dev2;

GRANT CREATE SESSION, CREATE ANY TABLE, CREATE PUBLIC SYNONYM, SELECT ANY
TABLE, INSERT ANY TABLE, UPDATE ANY TABLE, DELETE ANY TABLE TO C##user_dev2;

GRANT CREATE SEQUENCE TO C##user_dev2;
GRANT CREATE PROCEDURE TO C##user_dev2;
GRANT CREATE ANY TRIGGER TO C##user_dev2;
GRANT CREATE TYPE TO C##user_dev2;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_CATEGORIA
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_ID_CATEGORIA"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_TAREA
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_ID_TAREA"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 121 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_USUARIO
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_ID_USUARIO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 81 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
--------------------------------------------------------
--  DDL for Table CATEGORIAS
--------------------------------------------------------

  CREATE TABLE "CATEGORIAS" 
   (	"ID_CATEGORIA" NUMBER, 
	"NOMBRE_CATEGORIA" VARCHAR2(25 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table TAREAS
--------------------------------------------------------

  CREATE TABLE "TAREAS" 
   (	"ID_TAREA" NUMBER, 
	"DESCRIPCION" VARCHAR2(50 BYTE), 
	"FECHA_FINALIZADO" DATE, 
	"ESTADO" VARCHAR2(10 BYTE), 
	"ID_CATEGORIA" NUMBER, 
	"ID_USUARIO" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table USUARIOS
--------------------------------------------------------

  CREATE TABLE "USUARIOS" 
   (	"ID_USUARIO" NUMBER, 
	"USUARIO" VARCHAR2(30 BYTE), 
	"EMAIL" VARCHAR2(50 BYTE), 
	"CLAVE" VARCHAR2(30 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
REM INSERTING into CATEGORIAS
SET DEFINE OFF;
Insert into CATEGORIAS (ID_CATEGORIA,NOMBRE_CATEGORIA) values ('1','UNIVERSIDAD');
Insert into CATEGORIAS (ID_CATEGORIA,NOMBRE_CATEGORIA) values ('2','PROYECTOS');
Insert into CATEGORIAS (ID_CATEGORIA,NOMBRE_CATEGORIA) values ('3','FAMILIA');
Insert into CATEGORIAS (ID_CATEGORIA,NOMBRE_CATEGORIA) values ('4','FINANZAS');
Insert into CATEGORIAS (ID_CATEGORIA,NOMBRE_CATEGORIA) values ('5','TRABAJO');
Insert into CATEGORIAS (ID_CATEGORIA,NOMBRE_CATEGORIA) values ('6','PERSONAL');
Insert into CATEGORIAS (ID_CATEGORIA,NOMBRE_CATEGORIA) values ('7','VIAJES');
Insert into CATEGORIAS (ID_CATEGORIA,NOMBRE_CATEGORIA) values ('8','JUEGOS');
REM INSERTING into TAREAS
SET DEFINE OFF;
REM INSERTING into USUARIOS
SET DEFINE OFF;
Insert into USUARIOS (ID_USUARIO,USUARIO,EMAIL,CLAVE) values ('1','user-sysc','riosjulio117@gmail.com','1234');
--------------------------------------------------------
--  DDL for Index PK_ID_CATEGORIA
--------------------------------------------------------

  CREATE UNIQUE INDEX "PK_ID_CATEGORIA" ON "CATEGORIAS" ("ID_CATEGORIA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_ID_TAREA
--------------------------------------------------------

  CREATE UNIQUE INDEX "PK_ID_TAREA" ON "TAREAS" ("ID_TAREA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_ID_USUARIO
--------------------------------------------------------

  CREATE UNIQUE INDEX "PK_ID_USUARIO" ON "USUARIOS" ("ID_USUARIO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index UNQ_EMAIL
--------------------------------------------------------

  CREATE UNIQUE INDEX "UNQ_EMAIL" ON "USUARIOS" ("EMAIL") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_ID_CATEGORIA
--------------------------------------------------------

  CREATE UNIQUE INDEX "PK_ID_CATEGORIA" ON "CATEGORIAS" ("ID_CATEGORIA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_ID_TAREA
--------------------------------------------------------

  CREATE UNIQUE INDEX "PK_ID_TAREA" ON "TAREAS" ("ID_TAREA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_ID_USUARIO
--------------------------------------------------------

  CREATE UNIQUE INDEX "PK_ID_USUARIO" ON "USUARIOS" ("ID_USUARIO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index UNQ_EMAIL
--------------------------------------------------------

  CREATE UNIQUE INDEX "UNQ_EMAIL" ON "USUARIOS" ("EMAIL") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTO_CATE
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTO_CATE" 
BEFORE INSERT 
ON categorias
FOR EACH ROW
BEGIN
    SELECT seq_id_categoria.NEXTVAL INTO :NEW.id_categoria FROM dual;
END;
/
ALTER TRIGGER "TRG_INCREMENTO_CATE" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTO_TAREAS
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTO_TAREAS" 
BEFORE INSERT ON tareas
FOR EACH ROW
BEGIN
    SELECT seq_id_tarea.NEXTVAL INTO :NEW.id_tarea FROM dual;
END;
/
ALTER TRIGGER "TRG_INCREMENTO_TAREAS" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTO_USUARIOS
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTO_USUARIOS" 
BEFORE INSERT ON usuarios
FOR EACH ROW
BEGIN
    SELECT seq_id_usuario.NEXTVAL INTO :NEW.id_usuario FROM dual;
END;
/
ALTER TRIGGER "TRG_INCREMENTO_USUARIOS" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTO_CATE
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTO_CATE" 
BEFORE INSERT 
ON categorias
FOR EACH ROW
BEGIN
    SELECT seq_id_categoria.NEXTVAL INTO :NEW.id_categoria FROM dual;
END;
/
ALTER TRIGGER "TRG_INCREMENTO_CATE" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTO_TAREAS
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTO_TAREAS" 
BEFORE INSERT ON tareas
FOR EACH ROW
BEGIN
    SELECT seq_id_tarea.NEXTVAL INTO :NEW.id_tarea FROM dual;
END;
/
ALTER TRIGGER "TRG_INCREMENTO_TAREAS" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTO_USUARIOS
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTO_USUARIOS" 
BEFORE INSERT ON usuarios
FOR EACH ROW
BEGIN
    SELECT seq_id_usuario.NEXTVAL INTO :NEW.id_usuario FROM dual;
END;
/
ALTER TRIGGER "TRG_INCREMENTO_USUARIOS" ENABLE;
--------------------------------------------------------
--  DDL for Procedure CONSULTARTAREAS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "CONSULTARTAREAS" (
    p_id_usuario IN NUMBER,
    resultados OUT SYS_REFCURSOR
)
AS
BEGIN
  OPEN resultados FOR
    SELECT
      t.id_tarea "Id_Task",
      t.descripcion "Descripcion",
      t.fecha_finalizado "Fecha",
      t.estado "Estado",
      c.id_categoria "Id_Categoria",
      c.nombre_categoria "Nombre_Categoria",
      t.id_usuario
    FROM Tareas t
    INNER JOIN Categorias c ON t.id_categoria = c.id_categoria
    WHERE t.id_usuario = p_id_usuario;
END ConsultarTareas;

/
--------------------------------------------------------
--  DDL for Procedure CONSULTARUSUARIOS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "CONSULTARUSUARIOS" (resultados OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN resultados FOR
    SELECT
      id_usuario "id_usuario",
      usuario "usuario",
      email "email",
      clave "clave"
    FROM USUARIOS;
END ConsultarUsuarios;

/
--------------------------------------------------------
--  DDL for Procedure PRC_CAMBIARESTADOTAREA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_CAMBIARESTADOTAREA" (t_id_tarea IN NUMBER, t_nuevo_estado IN VARCHAR2)
AS
BEGIN
  UPDATE TAREAS SET ESTADO = t_nuevo_estado WHERE ID_TAREA = t_id_tarea;
  COMMIT;
END prc_CambiarEstadoTarea;

/
--------------------------------------------------------
--  DDL for Procedure PRC_ELIMINARTAREA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_ELIMINARTAREA" (
    t_id_task IN NUMBER,
    t_id_usuario IN NUMBER,
    eliminacion_exitosa OUT NUMBER
)
AS
BEGIN
    DELETE FROM Tareas WHERE id_tarea = t_id_task AND id_usuario = t_id_usuario;

    IF SQL%ROWCOUNT > 0 THEN
        eliminacion_exitosa := 1; -- Éxito
    ELSE
        eliminacion_exitosa := 0; -- No se encontró ninguna tarea con ese ID
    END IF;
END prc_eliminarTarea;

/
--------------------------------------------------------
--  DDL for Procedure PRC_ELIMINARTAREASCOMPLETAS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_ELIMINARTAREASCOMPLETAS" (
    t_id_usuario IN NUMBER
)
AS
BEGIN
    DELETE FROM Tareas WHERE estado = 'COMPLETE' AND id_usuario = t_id_usuario;
    COMMIT; 
END prc_eliminarTareasCompletas;

/
--------------------------------------------------------
--  DDL for Procedure PRC_FILTRARTAREASPORFECHA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_FILTRARTAREASPORFECHA" (
    t_fecha_seleccionada IN DATE,
    t_id_usuario IN NUMBER,
    resultados OUT SYS_REFCURSOR
)
AS
BEGIN
    OPEN resultados FOR
        SELECT ID_TAREA, DESCRIPCION, FECHA_FINALIZADO, ESTADO
        FROM TAREAS
        WHERE TO_DATE(FECHA_FINALIZADO, 'DD/MM/YYYY') = t_fecha_seleccionada AND id_usuario = t_id_usuario;
END prc_FiltrarTareasPorFecha;

/
--------------------------------------------------------
--  DDL for Procedure PRC_GET_ID_USUARIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_GET_ID_USUARIO" (
    u_email IN VARCHAR2,
    u_id_usuario OUT NUMBER
)
IS
BEGIN
    -- Obtener el id_usuario por email
    SELECT ID_USUARIO INTO u_id_usuario FROM Usuarios WHERE EMAIL = u_email;
    COMMIT;
END prc_get_id_usuario;

/
--------------------------------------------------------
--  DDL for Procedure PRC_INSERTARTAREA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_INSERTARTAREA" (
    descripcion Tareas.DESCRIPCION%TYPE,
    fecha Tareas.FECHA_FINALIZADO%TYPE,
    estado Tareas.ESTADO%TYPE,
    id_categoria Tareas.ID_CATEGORIA%TYPE,
    id_usuario Usuarios.ID_USUARIO%TYPE
)
IS
BEGIN
    INSERT INTO Tareas (DESCRIPCION,FECHA_FINALIZADO,ESTADO,ID_CATEGORIA,ID_USUARIO)
    VALUES (descripcion,fecha,estado,id_categoria,id_usuario);
    COMMIT;
END prc_InsertarTarea;

/
--------------------------------------------------------
--  DDL for Procedure PRC_INSERTARUSER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_INSERTARUSER" (    
    usuario USUARIOS.usuario%TYPE,
    email USUARIOS.email%TYPE,
    clave USUARIOS.clave%TYPE
)
IS
BEGIN
    INSERT INTO usuarios (usuario,email,clave)
    VALUES (usuario,email,clave);
    COMMIT;
END prc_InsertarUser;

/
--------------------------------------------------------
--  DDL for Procedure PRC_VALIDAREMAIL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_VALIDAREMAIL" (
    u_email IN VARCHAR2,
    cuenta_encontrada OUT NUMBER
)
AS
BEGIN
    SELECT COUNT(*) INTO cuenta_encontrada
    FROM usuarios
    WHERE email = u_email;
END prc_validarEmail;

/
--------------------------------------------------------
--  DDL for Procedure PRC_VALIDARUSUARIO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_VALIDARUSUARIO" (
   u_email IN usuarios.email%TYPE,
   u_clave IN usuarios.clave%TYPE,
   usuario_encontrado OUT NUMBER
)
AS
BEGIN
   SELECT COUNT(*) INTO usuario_encontrado
   FROM usuarios
   WHERE email = u_email AND clave = u_clave;
END prc_validarUsuario;

/
--------------------------------------------------------
--  DDL for Package PKG_TAREAS_PRC
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "PKG_TAREAS_PRC" AS

  PROCEDURE ConsultarTareas(
    p_id_usuario IN NUMBER,
    resultados OUT SYS_REFCURSOR
  );

  PROCEDURE ConsultarUsuarios(
    resultados OUT SYS_REFCURSOR
  );

  PROCEDURE prc_CambiarEstadoTarea(
    t_id_tarea IN NUMBER,
    t_nuevo_estado IN VARCHAR2
  );

  PROCEDURE prc_eliminarTarea (
    t_id_task IN NUMBER,
    t_id_usuario IN NUMBER,
    eliminacion_exitosa OUT NUMBER
  );

  PROCEDURE prc_eliminarTareasCompletas(
    t_id_usuario IN NUMBER
  );

  PROCEDURE prc_FiltrarTareasPorFecha (
    t_fecha_seleccionada IN DATE,
    t_id_usuario IN NUMBER,
    resultados OUT SYS_REFCURSOR
  );

  PROCEDURE prc_get_id_usuario(
    u_email IN VARCHAR2,
    u_id_usuario OUT NUMBER
  );

  PROCEDURE prc_InsertarTarea (
    descripcion Tareas.DESCRIPCION%TYPE,
    fecha Tareas.FECHA_FINALIZADO%TYPE,
    estado Tareas.ESTADO%TYPE,
    id_categoria Tareas.ID_CATEGORIA%TYPE,
    id_usuario Usuarios.ID_USUARIO%TYPE
  );

  PROCEDURE prc_InsertarUser (    
    usuario USUARIOS.usuario%TYPE,
    email USUARIOS.email%TYPE,
    clave USUARIOS.clave%TYPE
  );

  PROCEDURE prc_validarEmail (
    u_email IN VARCHAR2,
    cuenta_encontrada OUT NUMBER
  );

  PROCEDURE prc_validarUsuario(
    u_email IN usuarios.email%TYPE,
    u_clave IN usuarios.clave%TYPE,
    usuario_encontrado OUT NUMBER
  );

END PKG_TAREAS_PRC;

/
--------------------------------------------------------
--  DDL for Package Body PKG_TAREAS_PRC
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "PKG_TAREAS_PRC" AS

  PROCEDURE ConsultarTareas(
    p_id_usuario IN NUMBER,
    resultados OUT SYS_REFCURSOR
  ) AS
  BEGIN
    OPEN resultados FOR
      SELECT
        t.id_tarea "Id_Task",
        t.descripcion "Descripcion",
        t.fecha_finalizado "Fecha",
        t.estado "Estado",
        c.id_categoria "Id_Categoria",
        c.nombre_categoria "Nombre_Categoria",
        t.id_usuario
      FROM Tareas t
      INNER JOIN Categorias c ON t.id_categoria = c.id_categoria
      WHERE t.id_usuario = p_id_usuario;
  END ConsultarTareas;

  PROCEDURE ConsultarUsuarios(
    resultados OUT SYS_REFCURSOR
  ) AS
  BEGIN
    OPEN resultados FOR
      SELECT
        id_usuario "id_usuario",
        usuario "usuario",
        email "email",
        clave "clave"
      FROM USUARIOS;
  END ConsultarUsuarios;

  PROCEDURE prc_CambiarEstadoTarea(
    t_id_tarea IN NUMBER,
    t_nuevo_estado IN VARCHAR2
  ) AS
  BEGIN
    UPDATE TAREAS SET ESTADO = t_nuevo_estado WHERE ID_TAREA = t_id_tarea;
    COMMIT;
  END prc_CambiarEstadoTarea;

  PROCEDURE prc_eliminarTarea (
    t_id_task IN NUMBER,
    t_id_usuario IN NUMBER,
    eliminacion_exitosa OUT NUMBER
  ) AS
  BEGIN
    DELETE FROM Tareas WHERE id_tarea = t_id_task AND id_usuario = t_id_usuario;

    IF SQL%ROWCOUNT > 0 THEN
      eliminacion_exitosa := 1; -- Éxito
    ELSE
      eliminacion_exitosa := 0; -- No se encontró ninguna tarea con ese ID
    END IF;
  END prc_eliminarTarea;

  PROCEDURE prc_eliminarTareasCompletas(
    t_id_usuario IN NUMBER
  ) AS
  BEGIN
    DELETE FROM Tareas WHERE estado = 'COMPLETE' AND id_usuario = t_id_usuario;
    COMMIT; 
  END prc_eliminarTareasCompletas;

  PROCEDURE prc_FiltrarTareasPorFecha (
    t_fecha_seleccionada IN DATE,
    t_id_usuario IN NUMBER,
    resultados OUT SYS_REFCURSOR
  ) AS
  BEGIN
    OPEN resultados FOR
      SELECT ID_TAREA, DESCRIPCION, FECHA_FINALIZADO, ESTADO
      FROM TAREAS
      WHERE TO_DATE(FECHA_FINALIZADO, 'DD/MM/YYYY') = t_fecha_seleccionada AND id_usuario = t_id_usuario;
  END prc_FiltrarTareasPorFecha;

  PROCEDURE prc_get_id_usuario(
    u_email IN VARCHAR2,
    u_id_usuario OUT NUMBER
  ) AS
  BEGIN
    -- Obtener el id_usuario por email
    SELECT ID_USUARIO INTO u_id_usuario FROM Usuarios WHERE EMAIL = u_email;
    COMMIT;
  END prc_get_id_usuario;

  PROCEDURE prc_InsertarTarea (
    descripcion Tareas.DESCRIPCION%TYPE,
    fecha Tareas.FECHA_FINALIZADO%TYPE,
    estado Tareas.ESTADO%TYPE,
    id_categoria Tareas.ID_CATEGORIA%TYPE,
    id_usuario Usuarios.ID_USUARIO%TYPE
  ) AS
  BEGIN
    INSERT INTO Tareas (DESCRIPCION,FECHA_FINALIZADO,ESTADO,ID_CATEGORIA,ID_USUARIO)
    VALUES (descripcion,fecha,estado,id_categoria,id_usuario);
    COMMIT;
  END prc_InsertarTarea;

  PROCEDURE prc_InsertarUser (    
    usuario USUARIOS.usuario%TYPE,
    email USUARIOS.email%TYPE,
    clave USUARIOS.clave%TYPE
  ) AS
  BEGIN
    INSERT INTO usuarios (usuario,email,clave)
    VALUES (usuario,email,clave);
    COMMIT;
  END prc_InsertarUser;

  PROCEDURE prc_validarEmail (
    u_email IN VARCHAR2,
    cuenta_encontrada OUT NUMBER
  ) AS
  BEGIN
    SELECT COUNT(*) INTO cuenta_encontrada
    FROM usuarios
    WHERE email = u_email;
  END prc_validarEmail;

  PROCEDURE prc_validarUsuario(
    u_email IN usuarios.email%TYPE,
    u_clave IN usuarios.clave%TYPE,
    usuario_encontrado OUT NUMBER
  ) AS
  BEGIN
    SELECT COUNT(*) INTO usuario_encontrado
    FROM usuarios
    WHERE email = u_email AND clave = u_clave;
  END prc_validarUsuario;

END PKG_TAREAS_PRC;

/
--------------------------------------------------------
--  Constraints for Table CATEGORIAS
--------------------------------------------------------

  ALTER TABLE "CATEGORIAS" ADD CONSTRAINT "PK_ID_CATEGORIA" PRIMARY KEY ("ID_CATEGORIA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table TAREAS
--------------------------------------------------------

  ALTER TABLE "TAREAS" ADD CONSTRAINT "PK_ID_TAREA" PRIMARY KEY ("ID_TAREA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table USUARIOS
--------------------------------------------------------

  ALTER TABLE "USUARIOS" ADD CONSTRAINT "PK_ID_USUARIO" PRIMARY KEY ("ID_USUARIO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "USUARIOS" ADD CONSTRAINT "UNQ_EMAIL" UNIQUE ("EMAIL")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table TAREAS
--------------------------------------------------------

  ALTER TABLE "TAREAS" ADD CONSTRAINT "FK_ID_CATEGORIA" FOREIGN KEY ("ID_CATEGORIA")
	  REFERENCES "CATEGORIAS" ("ID_CATEGORIA") ENABLE;
  ALTER TABLE "TAREAS" ADD CONSTRAINT "FK_ID_USUARIO" FOREIGN KEY ("ID_USUARIO")
	  REFERENCES "USUARIOS" ("ID_USUARIO") ENABLE;

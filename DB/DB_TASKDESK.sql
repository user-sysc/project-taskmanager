--------------------------------------------------------
-- Archivo creado  - martes-noviembre-14-2023   
--------------------------------------------------------
CREATE USER C##user_dev IDENTIFIED BY task;

GRANT CONNECT TO C##user_dev;
GRANT UNLIMITED TABLESPACE TO C##user_dev;

GRANT CREATE SESSION, CREATE ANY TABLE, CREATE PUBLIC SYNONYM, SELECT ANY
TABLE, INSERT ANY TABLE, UPDATE ANY TABLE, DELETE ANY TABLE TO C##user_dev;

GRANT CREATE SEQUENCE TO C##user_dev;
GRANT CREATE PROCEDURE TO C##user_dev;
GRANT CREATE ANY TRIGGER TO C##user_dev;
GRANT CREATE TYPE TO C##user_dev;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_CATEGORIA
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_ID_CATEGORIA"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
--------------------------------------------------------
--  DDL for Sequence SEQ_TAREA
--------------------------------------------------------

   CREATE SEQUENCE  "SEQ_TAREA"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
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
	"P_NOMBRE" VARCHAR2(15 BYTE), 
	"S_NOMBRE" VARCHAR2(15 BYTE), 
	"P_APELLIDO" VARCHAR2(15 BYTE), 
	"S_APELLIDO" VARCHAR2(15 BYTE), 
	"EMAIL" VARCHAR2(50 BYTE), 
	"CLAVE" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
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
Insert into TAREAS (ID_TAREA,DESCRIPCION,FECHA_FINALIZADO,ESTADO,ID_CATEGORIA,ID_USUARIO) values ('5','ALO',to_date('16/11/23','DD/MM/RR'),'PENDING','3',null);
Insert into TAREAS (ID_TAREA,DESCRIPCION,FECHA_FINALIZADO,ESTADO,ID_CATEGORIA,ID_USUARIO) values ('4','TALLER',to_date('16/11/23','DD/MM/RR'),'PENDING','1',null);
REM INSERTING into USUARIOS
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENTO
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTO" 
BEFORE INSERT ON tareas
FOR EACH ROW
BEGIN
  :NEW.ID_TAREA := seq_tarea.NEXTVAL;
END;
/
ALTER TRIGGER "TRG_INCREMENTO" ENABLE;
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
--  DDL for Trigger TRG_INCREMENTO
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "TRG_INCREMENTO" 
BEFORE INSERT ON tareas
FOR EACH ROW
BEGIN
  :NEW.ID_TAREA := seq_tarea.NEXTVAL;
END;
/
ALTER TRIGGER "TRG_INCREMENTO" ENABLE;
--------------------------------------------------------
--  DDL for Procedure CONSULTARTAREAS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "CONSULTARTAREAS" (resultados OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN resultados FOR
    SELECT
      t.id_tarea "Id_Task",
      t.descripcion "Descripcion",
      t.fecha_finalizado "Fecha",
      t.estado "Estado",
      c.id_categoria "Id_Categoria",
      c.nombre_categoria "Nombre_Categoria"
    FROM Tareas t
    INNER JOIN Categorias c ON t.id_categoria = c.id_categoria;
END ConsultarTareas;

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
    eliminacion_exitosa OUT NUMBER
)
AS
BEGIN
    DELETE FROM Tareas WHERE id_tarea = t_id_task;

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

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_ELIMINARTAREASCOMPLETAS" 
AS
BEGIN
    DELETE FROM Tareas WHERE estado = 'COMPLETE';
    COMMIT; 
END prc_eliminarTareasCompletas;

/
--------------------------------------------------------
--  DDL for Procedure PRC_FILTRARTAREASPORFECHA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_FILTRARTAREASPORFECHA" (
    t_fecha_seleccionada IN DATE,
    resultados OUT SYS_REFCURSOR
)
AS
BEGIN
    OPEN resultados FOR
        SELECT ID_TAREA, DESCRIPCION, FECHA_FINALIZADO, ESTADO
        FROM TAREAS
        WHERE TO_DATE(FECHA_FINALIZADO, 'DD/MM/YYYY') = t_fecha_seleccionada;
END prc_FiltrarTareasPorFecha;

/
--------------------------------------------------------
--  DDL for Procedure PRC_INSERTARTAREA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE NONEDITIONABLE PROCEDURE "PRC_INSERTARTAREA" (
    id_task Tareas.ID_TAREA%TYPE,
    descripcion Tareas.DESCRIPCION%TYPE,
    fecha Tareas.FECHA_FINALIZADO%TYPE,
    estado Tareas.ESTADO%TYPE,
    id_categoria Tareas.ID_CATEGORIA%TYPE
)
IS
BEGIN
    INSERT INTO Tareas (ID_TAREA,DESCRIPCION,FECHA_FINALIZADO,ESTADO,ID_CATEGORIA)
    VALUES (id_task,descripcion,fecha,estado,id_categoria);
    COMMIT;
END prc_InsertarTarea;

/
--------------------------------------------------------
--  DDL for Package PKG_TAREAS_PRC
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE "PKG_TAREAS_PRC" AS
  -- Procedimientos de inserción
  PROCEDURE prc_InsertarTarea (
    id_task Tareas.ID_TAREA%TYPE,
    descripcion Tareas.DESCRIPCION%TYPE,
    fecha Tareas.FECHA_FINALIZADO%TYPE,
    estado Tareas.ESTADO%TYPE,
    id_categoria Tareas.ID_CATEGORIA%TYPE
  );

  -- Procedimiento de consulta
  PROCEDURE ConsultarTareas(resultados OUT SYS_REFCURSOR);

  -- Procedimiento de eliminación por ID
  PROCEDURE prc_eliminarTarea (
    t_id_task IN NUMBER,
    eliminacion_exitosa OUT NUMBER
  );

  -- Procedimiento de eliminación de tareas completas
  PROCEDURE prc_eliminarTareasCompletas;

  -- Procedimiento para cambiar el estado de una tarea
  PROCEDURE prc_CambiarEstadoTarea(t_id_tarea IN NUMBER, t_nuevo_estado IN VARCHAR2);

  -- Procedimiento para filtrar tareas por fecha
  PROCEDURE prc_FiltrarTareasPorFecha (
    t_fecha_seleccionada IN DATE,
    resultados OUT SYS_REFCURSOR
  );

END pkg_tareas_prc;

/
--------------------------------------------------------
--  DDL for Package Body PKG_TAREAS_PRC
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE PACKAGE BODY "PKG_TAREAS_PRC" AS
  PROCEDURE prc_InsertarTarea (
    id_task Tareas.ID_TAREA%TYPE,
    descripcion Tareas.DESCRIPCION%TYPE,
    fecha Tareas.FECHA_FINALIZADO%TYPE,
    estado Tareas.ESTADO%TYPE,
    id_categoria Tareas.ID_CATEGORIA%TYPE
  ) IS
  BEGIN
    INSERT INTO Tareas (ID_TAREA, DESCRIPCION, FECHA_FINALIZADO, ESTADO, ID_CATEGORIA)
    VALUES (id_task, descripcion, fecha, estado, id_categoria);
    COMMIT;
  END prc_InsertarTarea;

  PROCEDURE ConsultarTareas(resultados OUT SYS_REFCURSOR) IS
  BEGIN
    OPEN resultados FOR
      SELECT
        t.id_tarea "Id_Task",
        t.descripcion "Descripcion",
        t.fecha_finalizado "Fecha",
        t.estado "Estado",
        c.id_categoria "Id_Categoria",
        c.nombre_categoria "Nombre_Categoria"
      FROM Tareas t
      INNER JOIN Categorias c ON t.id_categoria = c.id_categoria;
  END ConsultarTareas;

  PROCEDURE prc_eliminarTarea (
    t_id_task IN NUMBER,
    eliminacion_exitosa OUT NUMBER
  ) IS
  BEGIN
    DELETE FROM Tareas WHERE id_tarea = t_id_task;

    IF SQL%ROWCOUNT > 0 THEN
      eliminacion_exitosa := 1; 
    ELSE
      eliminacion_exitosa := 0; 
    END IF;
  END prc_eliminarTarea;

  PROCEDURE prc_eliminarTareasCompletas IS
  BEGIN
    DELETE FROM Tareas WHERE estado = 'COMPLETE';
    COMMIT; 
  END prc_eliminarTareasCompletas;

  PROCEDURE prc_CambiarEstadoTarea(t_id_tarea IN NUMBER, t_nuevo_estado IN VARCHAR2) IS
  BEGIN
    UPDATE TAREAS SET ESTADO = t_nuevo_estado WHERE ID_TAREA = t_id_tarea;
    COMMIT;
  END prc_CambiarEstadoTarea;

  PROCEDURE prc_FiltrarTareasPorFecha (
    t_fecha_seleccionada IN DATE,
    resultados OUT SYS_REFCURSOR
  ) IS
  BEGIN
    OPEN resultados FOR
      SELECT ID_TAREA, DESCRIPCION, FECHA_FINALIZADO, ESTADO
      FROM TAREAS
      WHERE TO_DATE(FECHA_FINALIZADO, 'DD/MM/YYYY') = t_fecha_seleccionada;
  END prc_FiltrarTareasPorFecha;

END pkg_tareas_prc;

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

  ALTER TABLE "USUARIOS" MODIFY ("ID_USUARIO" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" MODIFY ("P_NOMBRE" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" MODIFY ("P_APELLIDO" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" MODIFY ("EMAIL" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" MODIFY ("CLAVE" NOT NULL ENABLE);
  ALTER TABLE "USUARIOS" ADD CONSTRAINT "PK_ID_USUARIO" PRIMARY KEY ("ID_USUARIO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table TAREAS
--------------------------------------------------------

  ALTER TABLE "TAREAS" ADD CONSTRAINT "FK_ID_CATEGORIA" FOREIGN KEY ("ID_CATEGORIA")
	  REFERENCES "CATEGORIAS" ("ID_CATEGORIA") ENABLE;
  ALTER TABLE "TAREAS" ADD CONSTRAINT "FK_ID_USUARIO" FOREIGN KEY ("ID_USUARIO")
	  REFERENCES "USUARIOS" ("ID_USUARIO") ENABLE;

/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: wxcvb_class
------------------------------------------------------------*/
CREATE TABLE wxcvb_class(
	id      INT IDENTITY (1,1) NOT NULL ,
	name    VARCHAR (50) NOT NULL ,
	level   VARCHAR (50) NOT NULL  ,
	CONSTRAINT wxcvb_class_PK PRIMARY KEY (id)
);


/*------------------------------------------------------------
-- Table: wxcvb_students
------------------------------------------------------------*/
CREATE TABLE wxcvb_students(
	id               INT IDENTITY (1,1) NOT NULL ,
	lastname         VARCHAR (50) NOT NULL ,
	firstname        VARCHAR (50) NOT NULL ,
	birthday         DATETIME NOT NULL ,
	id_wxcvb_class   INT  NOT NULL  ,
	CONSTRAINT wxcvb_students_PK PRIMARY KEY (id)

	,CONSTRAINT wxcvb_students_wxcvb_class_FK FOREIGN KEY (id_wxcvb_class) REFERENCES wxcvb_class(id)
);


/*------------------------------------------------------------
-- Table: wxcvb_subjects
------------------------------------------------------------*/
CREATE TABLE wxcvb_subjects(
	id     INT IDENTITY (1,1) NOT NULL ,
	name   VARCHAR (50) NOT NULL  ,
	CONSTRAINT wxcvb_subjects_PK PRIMARY KEY (id)
);


/*------------------------------------------------------------
-- Table: wxcvb_teacher
------------------------------------------------------------*/
CREATE TABLE wxcvb_teacher(
	id                  INT IDENTITY (1,1) NOT NULL ,
	lastname            VARCHAR (50) NOT NULL ,
	firstname           VARCHAR (50) NOT NULL ,
	mail                VARCHAR (255) NOT NULL ,
	id_wxcvb_subjects   INT  NOT NULL  ,
	CONSTRAINT wxcvb_teacher_PK PRIMARY KEY (id)

	,CONSTRAINT wxcvb_teacher_wxcvb_subjects_FK FOREIGN KEY (id_wxcvb_subjects) REFERENCES wxcvb_subjects(id)
);


/*------------------------------------------------------------
-- Table: wxcvb_note
------------------------------------------------------------*/
CREATE TABLE wxcvb_note(
	id                  INT IDENTITY (1,1) NOT NULL ,
	note                VARCHAR (50) NOT NULL ,
	appreciation        TEXT  NOT NULL ,
	id_wxcvb_students   INT  NOT NULL ,
	id_wxcvb_subjects   INT  NOT NULL  ,
	CONSTRAINT wxcvb_note_PK PRIMARY KEY (id)

	,CONSTRAINT wxcvb_note_wxcvb_students_FK FOREIGN KEY (id_wxcvb_students) REFERENCES wxcvb_students(id)
	,CONSTRAINT wxcvb_note_wxcvb_subjects0_FK FOREIGN KEY (id_wxcvb_subjects) REFERENCES wxcvb_subjects(id)
);


/*------------------------------------------------------------
-- Table: teacherperclass
------------------------------------------------------------*/
CREATE TABLE wxcvb_teacherperclass(
	id               INT  NOT NULL ,
	id_wxcvb_class   INT  NOT NULL  ,
	CONSTRAINT teacherperclass_PK PRIMARY KEY (id,id_wxcvb_class)

	,CONSTRAINT teacherperclass_wxcvb_teacher_FK FOREIGN KEY (id) REFERENCES wxcvb_teacher(id)
	,CONSTRAINT teacherperclass_wxcvb_class0_FK FOREIGN KEY (id_wxcvb_class) REFERENCES wxcvb_class(id)
);




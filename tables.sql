-- SQLite
PRAGMA foreign_keys = ON;
CREATE TABLE MainTasks (
  mainTask_id integer PRIMARY KEY,
  subject text NOT NULL,
  description text,
  done boolean CHECK(done <=1 AND done >=0) DEFAULT 0
);

CREATE TABLE SubTasks (
  subTask_id integer PRIMARY KEY,
  mainTask_id integer NOT NULL,
  subject text NOT NULL,   
  done boolean CHECK(done <=1 AND done >=0) DEFAULT 0,
  
  FOREIGN KEY (mainTask_id) REFERENCES MainTasks(mainTask_id) ON DELETE CASCADE
);



INSERT INTO MainTasks (subject, description) 
VALUES
('MainTask No 1', 'Blabla description'),
('MainTask No 2', 'Blabla description'),
('MainTask No 3', 'Blabla description');

INSERT INTO SubTasks (subject, mainTask_id) 
VALUES
('SubTask No 1', 1),
('SubTask No 2', 2),
('SubTask No 3', 2);
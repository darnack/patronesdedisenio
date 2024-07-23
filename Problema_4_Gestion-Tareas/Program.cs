using Problema_4_Gestion_Tareas.commands;
using Problema_4_Gestion_Tareas.managers;
using Problema_4_Gestion_Tareas.models;

var toDoManager = new ToDoManager();
var commanHandler = new CommandHandler();

var toDo1 = new ToDo("Hacer El Almuerzo");
var toDo2 = new ToDo("Hacer El Teabajo Sociales");

var createToDo1 = new CreateToDoCommand(toDo1, toDoManager);
var createToDo2 = new CreateToDoCommand(toDo2, toDoManager);
var completeToDo1 = new CompleteTodoCommand(toDo1, toDoManager);

commanHandler.ExecuteCommand(createToDo1);
commanHandler.ExecuteCommand(createToDo2);
toDoManager.ShowToDos();

commanHandler.ExecuteCommand(completeToDo1);

toDoManager.ShowToDos();

commanHandler.UndoLastCommand();

toDoManager.ShowToDos();

var newToDo1 = new ToDo("Calentar el Almuerzo");
var editedToDo1 = new EditToDoCommand(newToDo1, toDo1, toDoManager);
commanHandler.ExecuteCommand(editedToDo1);

toDoManager.ShowToDos();

commanHandler.UndoLastCommand();

toDoManager.ShowToDos();

Console.WriteLine("Finished");

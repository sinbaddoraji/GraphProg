 
COMPUTER GRAPHICS PROGRAMMING 2019 - 2020
TRIMESTER 2 COURSEWORK ASSIGNMENT 010
 
 
Introduction
The program created for the sake of this assignment is a basic 2D graphics application for drawing basic shapes. This report talks about the Implementation of this requested program and additional Features briefly. Other visual aids in the description are not available due to the writing limitations given to the assignment of two sides of an A4 paper. 
 
The features required of the program are
•	It should have a “Create” menu option with sub-menus of shapes
•	It should have a Select option. A method of selecting shapes and navigating through selected shapes
•	Selected shapes should be able to be moved using mouse clicks or keyboard.
•	There should be a “Transform” menu option that allows the movement or rotation of shapes either by keyboard input or mouse movement.
•	The program should be able to delete selected shapes
•	The application should be able to be terminated cleanly.
Explanation of Features
The program deployed alongside this report matches the required requirements stated in the preceding section. Further description of the features is below.
Shape Creation
Selection of shapes to be drawn can be made by clicking on the “Create” menu and selecting a shape from the sub-menu. Selection of shapes can also be caused by clicking on a shape icon at the left side of the interface. In addition to this, 13 extra shape options are available in the “Create” menu. 
Drawing shapes on the program’s canvas are done through rubber banding. To Draw a shape, the user must click on a starting point and drag the mouse until the point they wish to end the drawing. The program is interactive as it displays a preview of the drawing as dragging takes place 
Most of the drawing logic was done, attempting to avoid the use of GDI. Additional features to aid the shape drawing experience are listed:
•	Mouse position is displayed in the status bar to help drawing 
•	Shape size is shown in the status bar to help drawing

Selection of shapes
Selection of shapes can be made by first either clicking on the “Select” menu item or the finger icon at the programs left pane. When the program is on selection mode, the user can select a shape clicking within the shape boundary (Not a corner or vertex). In the event of clicking a location that many multiple shapes contain within their boundary; the user will be given an option to select which shapes to keep selected. The selected shapes are stored in a list to be used for reference in program,
Transformation of shapes
Transformation of shapes can only be done after selecting a shape and either clicking on the “Transform” menu item or right-click on the canvas and select “Transform”. Selecting the transform option launches a Dialog which allows the user to:
•	Modify the size of the Shape
•	Fill Shape with a specific colour which can also be chosen on the Dialog
•	Change the highlight colour of the Shape when selected
•	Change the shape boundary line colour
•	Change the shape line thickness
•	Change the Shape from one type to another
•	Rotate the Shape by a designated degree 
Movement of Shape
After shapes have been selected, they can either be moved around the canvas by means of drag and drop or by means of the arrow keys. Though when multiple shapes are selected at once, they can only be moved using arrow keys.
Deletion of shapes
After shapes have been selected, they can be deleted either by clicking on the delete button on the keyboard or selecting it in the context menu after right-clicking or selecting it in the “Edit” menu’s options.
Extra features
The extra features implemented in this program are: 
•	The ability to undo/Redo drawing actions (A list containing lists of shapes is used to achieve this)
•	The ability to fill shapes with colour
•	Improved User Interface
•	The ability to save graphics to image 
•	The ability to manipulate shape properties
•	Different shapes can be highlighted using different colours
•	Variable sided polygons and stars can be drawn to screen (Options in shape list)
•	Drawing of shapes do not use the C#’s “Draw Polygon” function
Limitations of the program
Although the program is functional and was built in a manner that it has reusable parts, the use of the C#’s graphical library could not be escaped totally. Regardless of this, the use of the graphical library was the minimal possible use the author could afford. 

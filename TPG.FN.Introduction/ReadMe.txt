
Introduction into FACNAV GUI developement

Restrictions:
Try to avoid code-behind as far as possible. This shall be a pure ViewModel-View project.

Tasks:
0. Creates estimates for the tasks

1. Add the TPG.Toolkit nuGet package to the project as a package reference

2. TODOs in App.xaml.cs

3. TODOs in MainViewModel.cs
- Create all string properties in the MainViewModel
- Make the ViewModel bindable
- Create the DelegateCommand property in the MainViewModel
- Add a property (SelectedEntity) to the MainViewModel with the type IEntityViewModel and create this interface
- Create a collection property of IEntityViewModel in MainViewModel
- Fill the collection with instances of each entity implementation type (at least one of each)

4. Create implementations of the IEntityViewModel for Track, DrawObject, Waypoint (see class diagram for properties)

5. TODOs in MainWindow.xaml 
- Use the MainViewModel as a viewmodel for the MainWindow for design time purposes
- Create controls to display/edit values from the viewmodel
- Add "headers" (HintAssist.Hint from TPG.UI.Toolkit) to all textboxes in MainWindow

6. Create a ResourceDictionary in the project and implement DataTemplates for the Track-, DrawObject- and Waypoint viewmodels
- Use this dictionary in the MainWindow
- Use the datatemplates to present the correct view from the selected entity somewhere in the MainWindow

7. Create a value converter that converts the state property of the TrackViewModel to a brush
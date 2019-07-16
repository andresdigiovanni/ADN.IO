# ADN.IO

# Content

- [DirectoryHelper](#T:ADN.IO.DirectoryHelper)

  - [CopyDirectory(source, destination, overwrite)](#DirectoryHelper.CopyDirectory(source,destination,overwrite))

- [FileHelper](#T:ADN.IO.FileHelper)

  - [IsFileOpen(file, fileAccess)](#FileHelper.IsFileOpen(file,fileAccess))

<a name='T:ADN.IO.DirectoryHelper'></a>


## DirectoryHelper

A static class of extension methods for .

<a name='DirectoryHelper.CopyDirectory(source,destination,overwrite)'></a>


### CopyDirectory(source, destination, overwrite)

Copy files from the source folder to destination folder overwriting the content.


#### Parameters

| Name | Description |
| ---- | ----------- |
| source | *System.String*<br>Source folder. |

#### Parameters

| destination | *System.String*<br>Destination folder. |

#### Parameters

| overwrite | *System.Boolean*<br>Overwrite destination file. |


#### Remarks

 This method check if is posible to override a file and retry it. 


#### Example

```csharp
var source = "sourceDir";
var destination = "destDir";
var overwrite = true;
DirectoryHelper.CopyDirectory(source, destination, overwrite);
```

<a name='T:ADN.IO.FileHelper'></a>


## FileHelper

A static class of extension methods for .

<a name='FileHelper.IsFileOpen(file,fileAccess)'></a>


### IsFileOpen(file, fileAccess)

Check if a file is open.


#### Parameters

| Name | Description |
| ---- | ----------- |
| file | *System.String*<br>File name. |

#### Parameters

| fileAccess | *System.IO.FileAccess*<br>File access. |


#### Returns

True if file is open, false otherwise.


#### Example

```csharp
var file= "foo";
var fileAccess = FileAccess.ReadWrite;
var fileIsOpen = FileHelper.IsFileOpen(file, fileAccess)

/*
fileIsOpen is true if file is open, false otherwise.
*/
```


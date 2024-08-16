# Comentsys.Toolkit

**Comentsys.Toolkit** is a **Toolkit** for **Binding** and **Asset** Support for **.NET Standard**.

## Change Log

### Version 1.1.0

- Add ActionCommand and Update AssetBase with AsString Methods

### Version 1.0.0

- Initial Release

## AssetBase

`AssetBase` can be used as the basis of an **Asset** Library that can be used in any **.NET Standard** Compatible **Application**.

### AsStream(root, path, sources, targets, extension)

As Stream

| Name | Description |
| ---- | ----------- |
| `root` | `System.String`<br>Root |
| `path` | `System.String`<br>Path |
| `sources` | `System.Drawing.Color[]?`<br>Sources |
| `targets` | `System.Drawing.Color[]?`<br>Targets |
| `extension` | `System.String`<br>Extension |

#### Returns

Resource Stream

### AsStream(root, path, source, target, extension)

As Stream

| Name | Description |
| ---- | ----------- |
| `root` | `System.String`<br>Root |
| `path` | `System.String`<br>Path |
| `source` | `System.Drawing.Color?`<br>Source |
| `target` | `System.Drawing.Color?`<br>Target |
| `extension` | `System.String`<br>Extension |

#### Returns

Resource Stream

### AsStream(root, path, extension)

As Stream

| Name | Description |
| ---- | ----------- |
| `root` | `System.String`<br>Root |
| `path` | `System.String`<br>Path |
| `extension` | `System.String`<br>Extension |

#### Returns

Resource Stream

### AsString(root, path, source, target, extension)

As String

| Name | Description |
| ---- | ----------- |
| root | *System.String*<br>Root |
| path | *System.String*<br>Path |
| source | *System.Nullable{System.Drawing.Color}*<br>Source |
| target | *System.Nullable{System.Drawing.Color}*<br>Target |
| extension | *System.String*<br>Extension |

#### Returns

Resource String

### AsString(root, path, extension)

As String

| Name | Description |
| ---- | ----------- |
| root | *System.String*<br>Root |
| path | *System.String*<br>Path |
| extension | *System.String*<br>Extension |

#### Returns

Resource Stream

## AssetResource

`AssetResource` is used by an **Asset** Library an an **Abstraction** to represent the contents of an **Asset** which is usually in **SVG** format and exposes a **Height** and **Width** for correct representation by clients if needed. 

### Constructor

Constructor

### Constructor(stream, height, width)

Constructor

| Name | Description |
| ---- | ----------- |
| `stream` | `System.IO.Stream`<br>Stream |
| `height` | `System.Int32`<br>Height |
| `width` | `System.Int32`<br>Width |

### Empty

Empty Asset Resource

### Height

Asset Resource Height

### Stream

Asset Resource Stream

### Width

Asset Resource Width

## ActionCommand

`ActionCommand` can be used with **Data Binding** and implements **Class** for `ActionCommandObservableBase` to support **Commanding** and supports **Nullable**.

### Constructor(action)

Action Command

| Name | Description |
| ---- | ----------- |
| action | *System.Action{System.Object}*<br>Action |

## ActionCommandHandler

`ActionCommandHandler` can be used with **Data Binding** and implements **Interface** for `ICommand` to support **Commanding** and supports **Nullable**.

### Constructor(action, canExecute)

Constructor

| Name | Description |
| ---- | ----------- |
| `action` | `System.Action{System.Object?}?`<br>Action |
| `canExecute` | `System.Func{System.Object,System.Boolean?}?`<br>Can Execute |

### Constructor(action)

Constructor

| Name | Description |
| ---- | ----------- |
| `action` | *`ystem.Action{System.Object?}?`<br>Action |

### CanExecute(parameter)

Can Execute

| Name | Description |
| ---- | ----------- |
| `parameter` | `System.Object?`<br>Parameter |

#### Returns

True

### CanExecuteChanged

Can Execute Changed

### Execute(parameter)

Execute

| Name | Description |
| ---- | ----------- |
| `parameter` | *`System.Object?`*<br>Parameter |

### UpdateCanExecute

Update Can Execute

## ActionCommandObservableBase

`ActionCommandObservableBase` is used in combination with the `ActionCommandHandler` to expose an **Observable** that supports **Commanding**.

### Constructor(handler, isEnabled)

Constructor

| Name | Description |
| ---- | ----------- |
| `handler` | `Comentsys.Toolkit.Binding.ActionCommandHandler`<br>Action Command Handler |
| `isEnabled` | `System.Boolean`<br>Is Enabled? |

### Command

Command

### IsEnabled

Enabled

## ObservableBase

`ObservableBase` provides the basis of an **Observable** by implementing the **Interface** for `INotifyPropertyChanged`

### OnPropertyChanged(propertyName)

On Property Changed

| Name | Description |
| ---- | ----------- |
| `propertyName` | `System.String`<br>Property Name |

### PropertyChanged

Property Changed Event Handler

## Licence

```
MIT License

Copyright (c) Comentsys

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

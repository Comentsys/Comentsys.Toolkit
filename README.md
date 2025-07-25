# Comentsys.Toolkit

**Comentsys.Toolkit** is a **Toolkit** for **Binding** and **Asset** Support for **.NET Standard**.

## Change Log

### Version 1.3.0

- Add ImageResource with ToPngBytes and ToBase64EncodedPngString, ImageBase with GetBase64EncodedString, AsStream, AsBytes and FromBytes Methods

### Version 1.2.1

- Update AssetResource ToBase64EncodedSvgString Method

### Version 1.2.0

- Update AssetResource with ToSvgString and ToBase64EncodedSvgString Methods, AssetBase with GetBase64EncodedString, FromStream, FromString and AsString Methods

### Version 1.1.0

- Add ActionCommand and Update AssetBase with AsString Methods

### Version 1.0.0

- Initial Release

## AssetBase

`AssetBase` can be used as the basis of an **Asset** Library using **SVG** format that can be used in any **.NET Standard** Compatible **Application**.

### AsStream(root, path, sources, targets, extension)

As Stream

| Name | Description |
| ---- | ----------- |
| root | *System.String*<br>Root |
| path | *System.String*<br>Path |
| sources | *System.Drawing.Color[]*<br>Sources |
| targets | *System.Drawing.Color[]*<br>Targets |
| extension | *System.String*<br>Extension |

#### Returns

Resource Stream

### AsStream(root, path, source, target, extension)

As Stream

| Name | Description |
| ---- | ----------- |
| root | *System.String*<br>Root |
| path | *System.String*<br>Path |
| source | *System.Nullable{System.Drawing.Color}*<br>Source |
| target | *System.Nullable{System.Drawing.Color}*<br>Target |
| extension | *System.String*<br>Extension |

#### Returns

Resource Stream

### AsStream(root, path, extension)

As Stream

| Name | Description |
| ---- | ----------- |
| root | *System.String*<br>Root |
| path | *System.String*<br>Path |
| extension | *System.String*<br>Extension |

#### Returns

Resource Stream

### AsString(content, sources, targets)

As String

| Name | Description |
| ---- | ----------- |
| content | *System.String*<br>Content |
| sources | *System.Drawing.Color[]*<br>Sources |
| targets | *System.Drawing.Color[]*<br>Targets |

#### Returns

Resource String

### AsString(content, source, target)

As String

| Name | Description |
| ---- | ----------- |
| content | *System.String*<br>Content |
| source | *System.Nullable{System.Drawing.Color}*<br>Source |
| target | *System.Nullable{System.Drawing.Color}*<br>Target |

#### Returns

Resource String

### AsString(root, path, sources, targets, extension)

As String

| Name | Description |
| ---- | ----------- |
| root | *System.String*<br>Root |
| path | *System.String*<br>Path |
| sources | *System.Drawing.Color[]*<br>Sources |
| targets | *System.Drawing.Color[]*<br>Targets |
| extension | *System.String*<br>Extension |

#### Returns

Resource String

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

### FromStream(stream, sources, targets)

From Stream

| Name | Description |
| ---- | ----------- |
| stream | *System.IO.Stream*<br>Stream |
| sources | *System.Drawing.Color[]*<br>Sources |
| targets | *System.Drawing.Color[]*<br>Targets |

#### Returns

Resource Stream

### FromStream(stream, source, target)

From Stream

| Name | Description |
| ---- | ----------- |
| stream | *System.IO.Stream*<br>Stream |
| source | *System.Nullable{System.Drawing.Color}*<br>Source |
| target | *System.Nullable{System.Drawing.Color}*<br>Target |

#### Returns

Resource Stream

### FromString(content, sources, targets)

From String

| Name | Description |
| ---- | ----------- |
| content | *System.String*<br>Content |
| sources | *System.Drawing.Color[]*<br>Sources |
| targets | *System.Drawing.Color[]*<br>Targets |

#### Returns

Resource Stream

### FromString(content, source, target)

From String

| Name | Description |
| ---- | ----------- |
| content | *System.String*<br>Content |
| source | *System.Nullable{System.Drawing.Color}*<br>Source |
| target | *System.Nullable{System.Drawing.Color}*<br>Target |

#### Returns

Resource Stream

### FromString(content)

From String

| Name | Description |
| ---- | ----------- |
| content | *System.String*<br>Content |

#### Returns

Resource Stream

### GetBase64EncodedString(value)

Get Base-64 Encoded String

| Name | Description |
| ---- | ----------- |
| value | *System.String*<br>Value |

#### Returns

Base-64 Encoded String

## AssetResource

`AssetResource` is used by an **Asset** Library as an **Abstraction** to represent the contents of an **Asset** in **SVG** format and exposes a **Height** and **Width** for correct representation by clients if needed. 

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

### ToBase64EncodedSvgString

Asset Resource Base-64 Encoded SVG String

#### Returns

Base-64 Encoded SVG String

### ToSvgString

Asset Resource SVG String

#### Returns

SVG String

## ImageBase

`AssetBase` can be used as the basis of an **Asset** Library using **PNG** format that can be used in any **.NET Standard** Compatible **Application**.

### AsStream(root, path, extension)

As Stream

| Name | Description |
| ---- | ----------- |
| root | *System.String*<br>Root |
| path | *System.String*<br>Path |
| extension | *System.String*<br>Extension |

#### Returns

Resource Stream

### AsStream(client, url)

As Stream

| Name | Description |
| ---- | ----------- |
| client | *System.Net.Http.HttpClient*<br>Http Client |
| url | *System.Uri*<br>Request Url |

#### Returns

Resource Stream

### AsBytes(root, path, extension)

As Bytes

| Name | Description |
| ---- | ----------- |
| root | *System.String*<br>Root |
| path | *System.String*<br>Path |
| extension | *System.String*<br>Extension |

#### Returns

Resource Bytes

### AsBytes(client, url)

As String

| Name | Description |
| ---- | ----------- |
| client | *System.Net.Http.HttpClient*<br>Http Client |
| url | *System.Uri*<br>Request Url |

#### Returns

Resource Bytes

### FromBytes(bytes)

From Bytes

| Name | Description |
| ---- | ----------- |
| bytes | *System.Byte[]*<br>Bytes |

#### Returns

Resource Stream

## ImageResource

`ImageResource` is used by an **Asset** Library as an **Abstraction** to represent the contents of an **Asset** in **PNG** format and exposes a **Height** and **Width** for correct representation by clients if needed. 

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

Empty Image Resource

### Height

Image Resource Height

### Stream

Image Resource Stream

### Width

Image Resource Width

### ToBase64EncodedPngString

Image Resource Base-64 Encoded PNG String

#### Returns

Base-64 Encoded PNG String

### ToPngBytes

Image Resource PNG Bytes

#### Returns

PNG Bytes

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

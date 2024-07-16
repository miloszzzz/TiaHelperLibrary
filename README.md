# TiaHelperLibrary

It's static class containing various methods for TIA Portal Add-Ins and Openness.

[TIA Portal Add-Ins](https://support.industry.siemens.com/cs/document/109773999/tia-add-ins?dti=0&lc=en-PL) on the official site.

[Add-Ins manual](https://support.industry.siemens.com/cs/mdm/109815056?c=160118411275&lc=en-WW)

## Installation

Add this solution or compiled .dll to your project.
```csharp
using static TiaHelperLibrary.TiaHelper;
```

## GetPlcSoftware()

This overloaded method returns PlcSoftware object which is essentail for any addin.

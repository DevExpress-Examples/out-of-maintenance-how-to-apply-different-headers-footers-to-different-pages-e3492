<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609391/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3492)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [StringSample.cs](./CS/StringSample.cs) (VB: [StringSample.vb](./VB/StringSample.vb))
<!-- default file list end -->
# How to apply different headers/footers to different pages


<p>This example illustrates how to start a new page with a header that is different from previous headers. To achieve this goal, add a new <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9553"><u>Section</u></a> to a document, unlink its header from previous headers by executing the <strong>ToggleHeaderFooterLinkToPreviousCommand</strong> and modify the unlinked header by using the approach from the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSection_BeginUpdateHeadertopic846"><u>Section.BeginUpdateHeader Method</u></a> help section. The entire document is generated programmatically.</p><p><strong>NB:</strong> Starting with version v2012 vol 1 you can use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSection_UnlinkHeaderFromPrevioustopic961"><u>Section.UnlinkHeaderFromPrevious Method</u></a> to unlink specific section header from previous without executing any commands.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E2265">SubDocument essentials - simple examples</a></p>

<br/>



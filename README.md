# What is Jayrock?

*Web services, the light and simple way!*

[Jayrock][jr] is a modest and an open source ([LGPL][lgpl]) implementation of
[JSON][json] and [JSON-RPC][jsonrpc] for the [Microsoft .NET Framework][dotet],
including [ASP.NET][aspnet]. What can you do with Jayrock? In a few words,
Jayrock allows clients, typically [JavaScript][js] in web pages, to be able to
call into server-side methods using JSON as the wire format and JSON-RPC as the
procedure invocation protocol. The methods can be called synchronously
or asynchronously.

* [Download Jayrock now!][releases] (see also [NuGet packages][nupkg])
* [Discuss Jayrock][discuss]
* [Latest daily/developer build][builds]
* [Commits Feed][commits], [Code coverage report][coverage]
* [Project foundry @ Google Code][repo], [Ohloh Metrics][ohloh]

Compatibility & compliance:

<a target="_blank" href="http://www.microsoft.com/windows/"><img src="www/images/cclogos/windows.gif" width="38" height="35" alt="Microsoft Windows" border="0" /></a>
<a target="_blank" href="http://www.linux.org/"><img src="www/images/cclogos/linux.gif" width="34" height="40" alt="Linux" border="0" /></a>
<a target="_blank" href="http://msdn.microsoft.com/netframework/"><img src="www/images/cclogos/dotnet.gif" width="68" height="35" alt="Microsoft .NET Framework" border="0" /></a>
<a target="_blank" href="http://www.go-mono.com/"><img src="www/images/cclogos/mono.gif" width="40" height="46" alt="Mono" border="0" /></a>
<a target="_blank" href="http://www.python.org/"><img src="www/images/cclogos/python.gif" width="39" height="39" alt="Python" border="0" /></a>
<a target="_blank" href="http://www.microsoft.com/ie/"><img src="www/images/cclogos/ie.gif" width="46" height="40" alt="Microsoft Internet Explorer" border="0" /></a>
<a target="_blank" href="http://www.getfirefox.com/"><img src="www/images/cclogos/ff.gif" width="50" height="44" alt="FireFox" border="0" /></a>
<a target="_blank" href="http://www.opera.com/"><img src="www/images/cclogos/opera.gif" width="53" height="43" alt="Opera" border="0" /></a>
<a target="_blank" href="http://www.opensource.org/docs/definition.php"><img src="www/images/cclogos/osi-certified.gif" width="60" height="42" alt="Open Source (OSI) Certified" border="0" /></a>

No time for Jayrock right now? Got [del.icio.us](http://del.icio.us/)? Bookmark
it and come back later&hellip;

## Where is the Source, Luke?

You can obtain the latest source of code of Jayrock from the [Mercurial][hg]
repository [hosted at Google Code][gcph]. Needless to say, you will need a
[Mercurial client][hgcli] for your platform to access the repository. If you
don't have a Mercurial client handy and just wish to [browse the source code,
you can do so online](http://code.google.com/p/jayrock/source/browse/).

The respository is located at http://jayrock.googlecode.com/hg/. The
command-line for the Mercurial client would therefore be:

    hg clone http://jayrock.googlecode.com/hg/ jayrock

The third argument, `jayrock`, is the directory name where the local working
copy will be downloaded so this can be another name if you like.

If you want a snapshot of the latest files without bothering to go through the
source repository then you can simply download them from the [Files][files]
section of the project.

Jayrock was originally maintained in a [Subversion repository][svnrepo] that is
still available in case you want to consult its earlier history using
[Subversion clients][svncli].

### Search the Source

<form method="get" action="http://www.google.com/codesearch">
    <p>
        <a href="http://www.google.com/codesearch">Google</a>:
        <input name="q" value="package:jayrock" title="Query" />
        <input type="submit" value="Search" title="Search using Google Code Search" />
        <a href="http://code.google.com/p/jayrock/source/browse/">Browse</a>
    </p>
</form>

Bear in mind that search engine(s) maintain a periodically crawled and cached
copy of the source code so results may be inaccurate sometimes due to
differences from [the original][hgrepo].

## Compiling

**Note:** For quicker setup instructions, see the section *Setting Up Jayrock*.

Once you have checked out a working copy of the source from the respository,
you can compile Jayrock in one of two ways. You can either open the included
[Microsoft Visual Studio][vs] solution files and use the IDE to compile the
projects or you can use the included [NAnt][nant] build script to compile from
the command-line.

### Compiling with NAnt

You do not need [NAnt][nant] installed on your machine to compile Jayrock. The
right version of all required tools ([NAnt][nant], [NUnit][nunit],
[NCover][ncover] and [NCoverExplorer][ncovere]) is already included under the
`tools` directory. If you are on the Windows platform, you can simply run the
`build.cmd` batch script to invoke NAnt and have it build all the targets.
To invoke NAnt explicitly, otherwise, use the following command (assuming you
are in the root of the working directory):

    tools\NAnt\NAnt -f:nant.build

A full build compiles the debug and release assemblies (inlcuding unit testing)
for Jayrock and Jayrock.Json for whichever of the following platforms are
available on the build machine:

* Microsoft .NET Framework 1.x
* Microsoft .NET Framework 2.0
* Microsoft .NET Framework 4.0
* Mono 2.0

### Compiling with Microsoft Visual Studio

Jayrock comes with [Microsoft Visual Studio][vs] project and solution files
that compile assemblies for Microsoft .NET Framework 4.0. There is little to
know except open the desired solution in Visual Studio and build away! The two
solutions that you will find under src and tests are:

* **Jayrock**: The complete solution that includes and builds the JSON-RPC,
  JSON and some experimental sandbox (playground) bits.
* **Jayrock.Tests**: Solution that contains a test-view of the project, with
  references and sources for unit tests.

The Visual Studio solutions target .NET Framework 4.0 only. To compile for
other versions, use the NAnt as described in the previous section.

## Contributing to the Project

[![Open Source Initiative](http://opensource.org/trademarks/osi-certified/web/osi-certified-60x50.gif)][osidef]
Jayrock is provided as open source and free software (as per [Open Source
Definition][osidef] and under [LGPL][lgpl]) for two principal reasons. First,
an open source community provides a way for individuals and companies to
collaborate on projects that none could achieve on their own. Second, the open
source model has the technical advantage of turning users into potential
co-developers. With source code readily available, users can help debug quickly
and promote rapid code enhancements. In short, *you are encouraged and invited
to contribute!*

Please contact [Atif Aziz][contact] (principal developer and project leader) if
you are interested in contributing.

You don't have to necessarily contribute in the form of code submissions only.
Contributions are appreciated and needed in any of the following forms:

* Help diagnose and [report problems][issues]
* Suggest fixes or [send in your patches][issues]
* Improve the code
* Help with unit and end-to-end testing
* Provide [peer support on mailing lists, forums or newsgroups][discuss].

For more information, see Jayrock on Google Code.

### How Else?

The above things require time and energy and if you can donate it then there is
nothing better for Jayrock. Honestly! On the other hand, there is only this to
consider. Has Jayrock helped you in a project at your daytime job? Well, a lot
of companies happily profit from open source projects in terms of time and
money (especially if time is money), so talk to your manager or development
lead about making a small donation. If you or your company wish to be listed as
a donor, then send along any or all of the following information to be directly
listed here: your name, company you work for and a link to your and/or
company's home page (would also be nice to know the country). Thanks!

<form action="https://www.paypal.com/cgi-bin/webscr" method="post">
    <input type="hidden" name="cmd" value="_s-xclick" />
    <input type="image" src="https://www.paypal.com/en_US/i/btn/x-click-but04.gif" name="submit" alt="Make donation with PayPal to Jayrock" />
    <img alt="" border="0" src="https://www.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1" />
    <input type="hidden" name="encrypted" value="-----BEGIN PKCS7-----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-----END PKCS7-----" />
</form>

### Community & Discussions

Jayrock is an open source project and so naturally relies on to build, leverage
and enjoy peer support from a community of users with a shared interest in the
project. Assessing if Jayrock is right the right solution for you? Having
trouble using some aspect of it? Want to simply provide feedback or ideas for
further development? Then [Jayrock Google Group][discuss] is the place to go.

<table style="border: 1px solid #aa0033; font-size: small" align="center">
    <tr>
        <td rowspan="2"><img src="https://cloud.githubusercontent.com/assets/20511/3342395/253cd292-f892-11e3-8a4e-ad16782a5fb1.gif" height="58" width="150" alt="Google Groups" /></td>
        <td align="center"><b>Jayrock</b></td>
    </tr>
    <tr>
        <td align="center"><a href="http://groups.google.com/group/jayrock">Browse Archives</a>
            at <a href="http://groups.google.com">groups.google.com</a></td>
    </tr>
</table>

## Setting Up Jayrock

1.  Open the Microsoft Visual Studio solution file called `Samples.sln`
    under `samples` and build the entire solution to compile all contained
    projects.

1.  Select `Demo.ashx` in the `AspNetDemo` Web Site project and then choose
    **View in Browser** from the file's context menu.

## ASP.NET Quick Start

**IMPORTANT!** This quick start tutorial and its code illustrations are based
on `$Rev: 790 $` of Jayrock. If you are using an older build then some of this
tutorial may not make sense or work. In that case, use the tutorial supplied
with the version you have instead if you cannot upgrade right away.

To use Jayrock in your ASP.NET project, add a reference to the `Jayrock.dll`
and `Jayrock.Json.dll` assemblies add a copy of `json.js` (distributed with
Jayrock and found in `www` subdirectory) to the root of your web. A JSON-RPC
service is best exposed using Jayrock by creating an ASP.NET HTTP handler. In
this quick start, we will create a JSON-RPC service called `HelloWorld`. Begin
by creating a file called `helloworld.ashx` in the root your ASP.NET
application. Add the following code to the file:

```
<%@ WebHandler Class="JayrockWeb.HelloWorld" %>

namespace JayrockWeb
{
    using System;
    using System.Web;
    using Jayrock.Json;
    using Jayrock.JsonRpc;
    using Jayrock.JsonRpc.Web;

    public class HelloWorld : JsonRpcHandler
    {
        [ JsonRpcMethod("greetings") ]
        public string Greetings()
        {
            return "Welcome to Jayrock!";
        }
    }
}
```

There are a few interesting things to note about this code. First of all,
`HelloWorld` inherits from the `Jayrock.JsonRpc.Web.JsonRpcHandler` class. This
is all that is needed to make your service callable using the standard JSON-RPC
protocol. Second, the `Greetings` method is decorated with the `JsonRpcMethod`
attribute. This is required to tell Jayrock that your method should be callable
over JSON-RPC. By default, public methods of your class are not exposed
automatically. Next, the first parameter to the `JsonRpcMethod` attribute is
the client-side name of the method, which in this case happens to be
`greetings`. This is optional, and if omitted, will default to the actual
method name as it appears in the source (that is, `Greetings` with the capital
letter G). Since [JavaScript][js] programs usually adopt the [camel
case][camelcase] naming convention, providing an alternate and client-side
version of your method's internal name via the `JsonRpcMethod` attribute is
always a good idea. You are now almost ready to test your service. The last
item needed is the addition of a few sections in the `web.config` of your
ASP.NET application:

```
<!--
    Note: As of version 0.9.8316, the configuration shown here is the assumed
    default and not required in web.config anymore. For the purpose of this
    tutorial, you may skip adding the following sections to your web.config.
-->
<configSections>
    ...
    <sectionGroup name="jayrock">
        <sectionGroup name="jsonrpc">
            <section
                name="features"
                type="Jayrock.JsonRpc.Web.JsonRpcFeaturesSectionHandler, Jayrock" />
        </sectionGroup>
    </sectionGroup>
    ...
</configSections>
...
<jayrock>
    <jsonrpc>
        <features>
            <add name="rpc"
                 type="Jayrock.JsonRpc.Web.JsonRpcExecutive, Jayrock" />
            <add name="getrpc"
                 type="Jayrock.JsonRpc.Web.JsonRpcGetProtocol, Jayrock" />
            <add name="proxy"
                 type="Jayrock.JsonRpc.Web.JsonRpcProxyGenerator, Jayrock" />
            <add name="pyproxy"
                 type="Jayrock.JsonRpc.Web.JsonRpcPythonProxyGenerator, Jayrock" />
            <add name="help"
                 type="Jayrock.JsonRpc.Web.JsonRpcHelp, Jayrock" />
            <add name="test"
                 type="Jayrock.JsonRpc.Web.JsonRpcTester, Jayrock" />
        </features>
    </jsonrpc>
</jayrock>
```

The above configuration lines enable various features on top of your service.
These features are accessed by using the feature's name in the query string to
your handler's URL, as in *`?feature`* (very similar to how you request the
WSDL document for an ASP.NET Web Service). First and foremost, there is the
`rpc` feature. It is responsible for actually making the JSON-RPC invocation on
your service upon receiving a request over HTTP POST. Without this feature,
your service is JSON-RPC ready but won't be callable by anyone. The `getrpc`
feature is similar except it makes the services methods callable over HTTP GET.

The `proxy` feature dynamically generates JavaScript code for the client-side
proxy. This code will contain a class that you can instantiate and use to call
the server methods either synchronously and asynchronously. In an HTML page,
you can import the proxy by using your handler's URL as the script source and
using `?proxy` as the query string:

```
<script
    type="text/javascript"
    src="http://localhost/foobar/helloworld.ashx?proxy">
</script>
```

The `help` feature provides a simple help page in HTML that provides a summary
of your service and methods it exposes. Finally, the test feature provides a
simple way to test the methods of your service from right within the browser.
This is exactly what we are going to work with next. Open up a browser window
and point it to the URL of your ASP.NET handler. For example, if your ASP.NET
application is called `foobar` and is running on your local machine, then type
`http://localhost/foobar/helloworld.ashx`. You should now see a page appear
that lists the methods exposed by your service:

![HelloWorld Help](www/images/HelloWorldHelp.png)

Notice that there are two methods, namely `greetings` and `system.listMethods`.
The `system.listMethods` is always there and inheirted by all services that
inherit from the `JsonRpcHandler` class. It provides introspection similar to
some XML-RPC implementations. As this point, you are looking at the help page
generated by the help feature. Notice, though, you did not have to specify the
`?help` query string. That's because `JsonRpcHandler` defaults to the help
feature when it sees a plain HTTP GET request for your service. You should
also be able to see a link to the test page from where you can invoke and test
each individual method. Click on this link now, which should yield a page
similar to the one shown here:

![HelloWorld Test](www/images/HelloWorldTest.png)

To see if everything is working correctly, select the `greetings` method from
the drop-down list and click the button labeled `Test`. If all goes well, you
should see the string `"Welcome to Jayrock!"` returned in the response box of
the page.

Great. So far we have the service running and tested. Now it is time to try and
call the service from JavaScript within a web page. In the same directory as
where you placed `helloworld.ashx`, create a plain text file called
`hello.html` and put the following HTML source in there:

```html
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en" xml:lang="en">
<head>
    <title>Hello Jayrock</title>
    <script type="text/javascript" src="json.js"></script>
    <script type="text/javascript" src="helloworld.ashx?proxy"></script>
    <script type="text/javascript">
/* <![CDATA[ */

window.onload = function()
{
    var s = new HelloWorld();

    alert("sync:" + s.greetings());

    s.greetings(function(response) {
      alert("async:" + response.result)
    });
}

/* ]]> */
    </script>
</head>
<body>
    <p>This page tests the HelloWorld service with Jayrock.</p>
</body>
```

This page references two scripts. The first one is `json.js`, (distributed with
Jayrock) which contains code for converting JavaScript values into JSON text
and vice versa. This is required by the second script reference, which points
to the JavaScript proxy that will be dynamically generated by Jayrock from the
server so that we can call the service. The third script is embedded in the
page and causes the `greetings` method to be called on the `HelloWorld` service
twice. In its first form, `greetings` is called synchronously whereas in its
second form, it is called asynchronously. How is that? If the proxy sees that
the last parameter supplied is a JavaScript function then it treats it as a
callback. The call is made to the service and control returned immediately.
When the response becomes available, the proxy invokes the callback function
and sends it the JSON-RPC response object as the first and only parameter.
The result property of this object can then be consulted to obtain the return
value from the server-side RPC method. On failure, the response object instead
contains an error property.

Back in the browser, type the URL `http://localhost/jayrock/hello.html` in the
address bar. As soon as the page loads, you should see two message boxes show
up one after the other and which display the string `"Welcome to Jayrock!"`
returned from our JSON-RPC service method `greetings`. The first message box
will be from the synchronous execution whereas the second from the asynchronous
one.

### Calling Services from Windows Script Host (WSH)

One of the interesting things about the JavaScript proxy (the one dynamically
served by Jayrock for your service) is that it can also be used from outside a
web page and therefore the whole web browser environment. More specifically,
you can use the proxy without any modifications from within a [WSH][wsh]
script. This enables a number of key scenarios like:

* Write batch scripts
* Provide a command-line and scriptable interface to your service
* Allow administrators and operators to call your service for maintenance
  purposes
* Run performance test scripts

Let's take the same `HelloWorld` service developed in the previous section and
try to call it from a WSH script. Put the following markup into a [Windows
Script Host Script][wsf] file called `hello.wsf`.

```
<job>
    <script language="JScript" src="http://localhost/jayrock/json.js" />
    <script language="JScript" src="http://localhost/jayrock/helloworld.ashx?proxy" />
    <script language="JScript">
var s = new HelloWorld();
WScript.Echo(s.greetings());
    </script>
</job>
```

Open a Window Command Prompt, change to the directory where you saved
`hello.wsf` and simply type hello to execute it. If that does not work, you may
have to type the full command-line, as in `cscript hello.wsf` or
`wscript hello.wsf`. When the script runs, it should display the greeting
message from the service.

Just as in the case of the web page, the WSH script references the JSON and
service proxy script files as external sources to be imported at run-time. In
fact, since the scripts will be fetched from the web server, the WSH script
will pick up changes automatically by downloading the latest copy. Notice also
that the references to the external scripts use absolute URLs since the WSH
script will in reality live at an independent location from the web server.

That's it! We're done. Hope you enjoyed this quick tour.

## Samples & Demos

You can find a number of JSON-RPC methods demonstrating various features in
the supplied demo service. See `http://localhost/jayrock/demo.ashx` on your
machine for a working copy of the demo.

### Documents

* **[An Introduction to JavaScript Object Notation (JSON) in JavaScript
  and .NET](http://msdn2.microsoft.com/en-us/library/bb299886.aspx)**: An
  [MSDN][msdn] article that takes a cursory look at JSON, its origins and then
  its application from within JavaScript and C#. Reading and writing JSON text
  from C# is demonstrated using classes from Jayrock. See the [Working with
  JSON in the .NET Framework][msdn5] section of the article for more.
* **[Jayrock Project Presentation][jrpptpdf]**: This presentation contains
  illustrations that briefly cover the architecture of Jayrock's JSON and
  JSON-RPC implementations. Beware, however, that some bits may be obsolete
  now since the presentation is based on a very early build.

## Got Questions?

If you don't see your questions or concerns addressed below, then try over at
the [Jayrock discussion group][discuss].

### What is Jayrock?

Jayrock is a modest and an open source implementation of JSON and JSON-RPC for
the Microsoft .NET Framework, including ASP.NET. What's so *modest* about it?
Well, modest as in plain and basic and no work of genius.

### What can I do with Jayrock?

Two things come to mind:

1. You can use just the Jayrock's JSON infrastructure for manipulating JSON
   data and text without all the JSON-RPC fuss. Just use the stand-alone
   `Jayrock.Json` assembly.
1. In addition to the above, you can use Jayrock to expose light-weight
   services with procedures from within your ASP.NET application. You can then
   invoke the procedures on those services over HTTP using JSON-RPC as the
   protocol. A typical use case would be some JavaScript code embedded inside
   a web page calling back into your services on the web server.

### So wait, is Jayrock yet another Ajax framework?

That depends on what fits your bill for or definition and expectation of an
Ajax framework. While you can certainly use Jayrock to write rich and
interactive web page enabled by the [Ajax][ajax] style of development, you'll
be a more enlightened soul to believe that it has a wider applicability. You
can build light-weight services in ASP.NET and then deploy them on your web
server, but beyond that, any client with HTTP capability, be that scripts or
console applications, can benefit from Jayrock by remotely invoking procedures
of your services. If you have a JSON-RPC client library for your language,
environment or platform then all the better. If not, Jayrock comes with one
for JavaScript to get you started off the ground in [Microsoft Internet
Explorer][msie], [FireFox][firefox] and even [WSH (Windows Script Host)][wsh].
Given a service, Jayrock can dynamically provide a JavaScript proxy that
implements the JSON-RPC protocol to call back into your service (synchronously
and asynchronously). Jayrock, however, does not provide any client-side
whiz-bang widgets or controls that you may have come to generally expect from
other and more ambitious Ajax frameworks. For that, you are recommended to shop
around elsewhere, like [Dojo toolkit][dojo], [Microsoft ASP.NET AJAX][msajax],
[Yahoo! UI Library][yui] or [many others][ajaxetc].

### Which versions of the Microsoft .NET Framework are supported?

Jayrock is compiled and delivered for Microsoft .NET Framework 1.x, 2.0 and
4.0. Just toss the corresponding assemblies at your application and you are
good to go.

### What is JSON?

[JSON][json] stands for JavaScript Object Notation. It is a simple,
human-readable, text-based and portable data format that is ideal for
representing and exchanging application data. It has only 5 data types
(Boolean, Number, String, Object and Array) that are commonly used across a
wide number of applications and programming languages. For more information,
see [RFC 4627][rfc4627].

### What is JSON-RPC?

[JSON-RPC][jsonrpc] is a light-weight remote procedure call protocol that
relies on JSON for the wire format. All it does is provide a simple way to
express a call frame as a JSON Object and the result or an error resulting from
the invocation as another JSON Object. For details, see the
[JSON-RPC specification][jsonrpc-spec].

## Notes

### Breaking Changes in v0.9.8316

These notes are designed for users of previously released versions of Jayrock
up to, but not including, v0.9.8316. It is not a comprehensive list of breaking
changes. For additional help with breaking compilations, post your issue to the
[Jayrock discussion group][discuss].

* The `Jayrock` assembly has been permanently split into two assemblies. The
  `Jayrock` assembly now mainly contains all types related to services and
  JSON-RPC. The other assembly, called `Jayrock.Json`, is used by `Jayrock` and
  contains types and functionality related to the JSON data format. The
  `Jayrock` assembly therefore depends on `Jayrock.Json` and both must be
  deployed together for the JSON-RPC functionality. To work with the JSON data
  format without any relation to JSON-RPC, only `Jayrock.Json` is needed.
* The `Jayrock.Json.Rpc` namespace has been renamed to `Jayrock.JsonRpc`. You
  must update all references in source and configuration files from the
  previous namespace to the new one.
* The types `JArray`, `JObject` and `JNull` from the `Jayrock.Json` namespace
  have been renamed to `JsonArray`, `JsonObject` and `JsonNull`, respectively.
* `Jayrock.Json.Rpc.JsonRpcParamsAttribute` has been removed. Instead, just use
  the regular `params` keyword from C# (`ParamArray` in Visual Basic).
* `IJsonFormatter` has been replaced by `Jayrock.Json.Conversion.IExporter`,
  which continues to serve a similar purpose.
* `IJsonFormattable` has been replaced by
  `Jayrock.Json.Conversion.IJsonExportable`, which continues to serve a similar
  purpose.
* `JsonParser`, `JsonReader.DeserializeNext` and `IParseOutput` have been
  removed. Use `JsonConvert.Import` from the `Jayrock.Json.Conversion`
  namespace instead for similar functionality.
* `JsonWriter.WriteValue` has been removed. Use `JsonConvert.Export` from the
  `Jayrock.Json.Conversion` namespace instead for similar functionality.
* The configuration section `jayrock/json.rpc` has been renamed to
  `jayrock.jsonrpc`. Jayrock will still pick up the section under the old name,
  but you are advised to move to the new name as soon as possible.


  [jr]: http://code.google.com/p/jayrock/
  [lgpl]: http://www.opensource.org/licenses/lgpl-license.php
  [json]: http://www.json.org/
  [jsonrpc]: http://www.json-rpc.org/
  [js]: http://en.wikipedia.org/wiki/JavaScript
  [aspnet]: http://www.asp.net/
  [releases]: http://code.google.com/p/jayrock/downloads/list
  [nupkg]: https://www.nuget.org/packages?q=jayrock
  [discuss]: http://groups.google.com/group/jayrock
  [builds]: ftp://ftp.berlios.de/pub/jayrock
  [commits]: http://code.google.com/feeds/p/jayrock/hgchanges/basic
  [repo]: http://code.google.com/p/jayrock/
  [ohloh]: http://www.ohloh.net/projects/jayrock
  [coverage]: http://jayrock.berlios.de/coverage-report.html
  [hg]: http://mercurial.selenic.com/
  [gcph]: http://code.google.com/hosting/
  [hgcli]: http://mercurial.selenic.com/downloads/
  [files]: http://code.google.com/p/jayrock/downloads/list
  [svnrepo]: http://jayrock.googlecode.com/svn/
  [svncli]: http://subversion.apache.org/packages.html
  [hgrepo]: http://jayrock.googlecode.com/hg/
  [vs]: http://msdn.microsoft.com/vstudio/
  [nant]: http://nant.sourceforge.net/
  [nunit]: http://www.nunit.org/
  [ncover]: http://ncover.org/
  [ncovere]: http://www.kiwidude.com/blog/2006/01/ncoverexplorer-debut.html
  [osidef]: http://www.opensource.org/docs/definition.php
  [contact]: http://www.raboof.com/contact.aspx
  [issues]: http://code.google.com/p/jayrock/issues/list
  [camelcase]: http://en.wikipedia.org/wiki/Camel_Case
  [wsh]: http://msdn2.microsoft.com/en-us/library/9bbdkx3k.aspx
  [wsf]: http://msdn2.microsoft.com/en-us/library/15x4407c.aspx
  [msdn]: https://msdn.microsoft.com/en-us/library/bb299886.aspx#intro_to_json_topic5
  [ajax]: http://en.wikipedia.org/wiki/AJAX
  [dojo]: http://dojotoolkit.org/
  [msajax]: http://ajax.asp.net/
  [yui]: http://developer.yahoo.com/yui/
  [ajaxetc]: http://ajaxpatterns.org/Ajax_Frameworks
  [rfc4627]: http://www.ietf.org/rfc/rfc4627.txt
  [jsonrpc-spec]: http://json-rpc.org/wiki/specification
  [msdn]: http://msdn.microsoft.com/
  [msdn5]: http://msdn2.microsoft.com/en-us/library/bb299886.aspx#intro_to_json_topic5
  [jrpptpdf]: https://atifaziz.github.io/projects/jayrock/Jayrock.pdf
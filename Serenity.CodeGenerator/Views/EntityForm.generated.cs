﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Serenity.CodeGenerator.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class EntityForm : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden
 public dynamic Model { get; set; } 
        public override void Execute()
        {


WriteLiteral(Environment.NewLine);



                                                   
    var dotModule = Model.Module == null ? "" : ("." + Model.Module);
    var moduleDot = Model.Module == null ? "" : (Model.Module + ".");


WriteLiteral("namespace ");


      Write(Model.RootNamespace);


                            Write(dotModule);

WriteLiteral(".Forms" + Environment.NewLine + "{" + Environment.NewLine + "    using Serenity;" + Environment.NewLine + "    using Serenity.ComponentModel;" + Environment.NewLine + "    using Ser" +
"enity.Data;" + Environment.NewLine + "    using System;" + Environment.NewLine + "    using System.ComponentModel;" + Environment.NewLine + "    using Syst" +
"em.Collections.Generic;" + Environment.NewLine + "    using System.IO;" + Environment.NewLine + Environment.NewLine + "    [FormScript(\"");


             Write(moduleDot);


                         Write(Model.ClassName);

WriteLiteral("\")]" + Environment.NewLine + "    [BasedOnRow(typeof(Entities.");


                            Write(Model.RowClassName);

WriteLiteral("))]" + Environment.NewLine + "    public class ");


             Write(Model.ClassName);


                                   WriteLiteral("Form" + Environment.NewLine + "    {");

      foreach (EntityField x in Model.Fields)
    {
        if (x.Ident != Model.IdField)
        {
WriteLiteral(Environment.NewLine + "        public ");


          Write(x.DataType);

WriteLiteral(" ");


                      Write(x.Ident);

WriteLiteral(" { get; set; }");


                                                        }
    }

WriteLiteral(Environment.NewLine + "    }" + Environment.NewLine + "}");


        }
    }
}
#pragma warning restore 1591

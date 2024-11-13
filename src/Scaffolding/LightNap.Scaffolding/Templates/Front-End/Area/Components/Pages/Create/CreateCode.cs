﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace LightNap.Scaffolding.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CreateCode : LightNap.Scaffolding.Templates.BaseTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
import { CommonModule } from ""@angular/common"";
import { Component, inject } from ""@angular/core"";
import { FormBuilder, ReactiveFormsModule, Validators } from ""@angular/forms"";
import { ActivatedRoute, Router, RouterLink } from ""@angular/router"";
import { BlockUiService, ErrorListComponent, throwIfApiError } from ""@core"";
import { ButtonModule } from ""primeng/button"";
import { CalendarModule } from ""primeng/calendar"";
import { CardModule } from ""primeng/card"";
import { CheckboxModule } from ""primeng/checkbox"";
import { InputNumberModule } from ""primeng/inputnumber"";
import { InputTextModule } from ""primeng/inputtext"";
import { finalize } from ""rxjs"";
import { Create");
            
            #line 19 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.PascalName));
            
            #line default
            #line hidden
            this.Write("Request } from \"src/app/");
            
            #line 19 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.KebabNamePlural));
            
            #line default
            #line hidden
            this.Write("/models/request/create-");
            
            #line 19 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.KebabName));
            
            #line default
            #line hidden
            this.Write("-request\";\r\nimport { ");
            
            #line 20 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.PascalName));
            
            #line default
            #line hidden
            this.Write("Service } from \"src/app/");
            
            #line 20 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.KebabNamePlural));
            
            #line default
            #line hidden
            this.Write("/services/");
            
            #line 20 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.KebabName));
            
            #line default
            #line hidden
            this.Write(@".service"";

@Component({
  standalone: true,
  templateUrl: ""./create.component.html"",
  imports: [
    CommonModule,
    CardModule,
    ReactiveFormsModule,
    RouterLink,
    CalendarModule,
    ButtonModule,
    InputTextModule,
    InputNumberModule,
    CheckboxModule,
    ErrorListComponent,
  ],
})
export class CreateComponent {
  #");
            
            #line 39 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.CamelName));
            
            #line default
            #line hidden
            this.Write("Service = inject(");
            
            #line 39 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.PascalName));
            
            #line default
            #line hidden
            this.Write(@"Service);
  #router = inject(Router);
  #activeRoute = inject(ActivatedRoute);
  #fb = inject(FormBuilder);
  #blockUi = inject(BlockUiService);

  errors = new Array<string>();

  form = this.#fb.group({
	// TODO: Update these fields to match the right parameters.
");
            
            #line 49 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
  foreach (var property in Parameters.SetProperties) {
        switch (property.FrontEndType) {
            case "boolean": 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 52 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            
            #line default
            #line hidden
            this.Write(": this.#fb.control(false, [");
            
            #line 52 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!property.IsNullable ? "Validators.required" : ""));
            
            #line default
            #line hidden
            this.Write("]),\r\n");
            
            #line 53 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
              break;
            case "number": 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 55 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            
            #line default
            #line hidden
            this.Write(": this.#fb.control(0, [");
            
            #line 55 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!property.IsNullable ? "Validators.required" : ""));
            
            #line default
            #line hidden
            this.Write("]),\r\n");
            
            #line 56 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
              break;
            case "Date": 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 58 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            
            #line default
            #line hidden
            this.Write(": this.#fb.control(new Date(), [");
            
            #line 58 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!property.IsNullable ? "Validators.required" : ""));
            
            #line default
            #line hidden
            this.Write("]),\r\n");
            
            #line 59 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
              break;
            default:
                if (property.BackEndType == "Guid") { 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 62 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            
            #line default
            #line hidden
            this.Write(": this.#fb.control(\"a0641a12-dead-beef-f00d-f1acc1d171e5\", [");
            
            #line 62 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!property.IsNullable ? "Validators.required" : ""));
            
            #line default
            #line hidden
            this.Write("]),\r\n");
            
            #line 63 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
              }
                else if (property.BackEndType == "TimeSpan") { 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 65 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            
            #line default
            #line hidden
            this.Write(": this.#fb.control(\"01:00:00\", [");
            
            #line 65 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!property.IsNullable ? "Validators.required" : ""));
            
            #line default
            #line hidden
            this.Write("]),\r\n");
            
            #line 66 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
              }
                else { 
            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 68 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.CamelName));
            
            #line default
            #line hidden
            this.Write(": this.#fb.control(\"");
            
            #line 68 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\", [");
            
            #line 68 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(!property.IsNullable ? "Validators.required" : ""));
            
            #line default
            #line hidden
            this.Write("]),\r\n");
            
            #line 69 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
              }
            break;
        }
    }
            
            #line default
            #line hidden
            this.Write("  });\r\n\r\n  createClicked() {\r\n    this.errors = [];\r\n\r\n    const request = <Creat" +
                    "e");
            
            #line 78 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.PascalName));
            
            #line default
            #line hidden
            this.Write("Request>this.form.value;\r\n\r\n    this.#blockUi.show({message: \"Creating...\"});\r\n  " +
                    "  this.#");
            
            #line 81 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.CamelName));
            
            #line default
            #line hidden
            this.Write("Service\r\n      .create");
            
            #line 82 "C:\Users\edkai\source\repos\SharpLogic\LightNap\src\Scaffolding\LightNap.Scaffolding\Templates\Front-End\Area\Components\Pages\Create\CreateCode.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Parameters.PascalName));
            
            #line default
            #line hidden
            this.Write(@"(request)
      .pipe(
        throwIfApiError(),
        finalize(() => this.#blockUi.hide())
      )
      .subscribe({
        next: response => this.#router.navigate([response.result.id], { relativeTo: this.#activeRoute.parent }),
        error: response => (this.errors = response.errorMessages),
      });
  }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}

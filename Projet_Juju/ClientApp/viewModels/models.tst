${
    // Enable extension methods by adding using Typewriter.Extensions.*
    using Typewriter.Extensions.Types;

    // Uncomment the constructor to change template settings.
    Template(Settings settings)
    {
        //settings.IncludeProject("Project.Name");
        settings.OutputFilenameFactory = f => {
			
			int indexExt = f.Name.IndexOf("ViewModel");
			string fileName = f.Name.Substring(0, indexExt) + ".tsx";
			return fileName.ToLowerInvariant();		
		};
		//settings.OutputExtension = ".tsx";
    }

    // Custom extension methods can be used in the template by adding a $ prefix e.g. $LoudName
    //string LoudName(Property property)
    //{
        //return property.Name.ToUpperInvariant();
    //}
	
	string Props(Property prop)
     { 
        string result = string.Empty;

        if(!string.IsNullOrWhiteSpace(prop?.DocComment?.Summary))
        {
            result = "// "+prop.DocComment.Summary+Environment.NewLine+"       ";
        }

        if(prop.name != "this[]")
        {
            if (prop.Type.IsNullable)
            {
                result +=  prop.name + "?: " + prop.Type.Name + ";" ;
            }
            else
            {
                result +=  prop.name + ": " + prop.Type.Name + ";" ;
            }
        }
		return result;
     }
}

declare module Projet_Juju.ClientApp.models {
    $Classes(ViewModels.*ViewModel)[
	// $DocComment[$Summary]
	export interface $Name$TypeParameters $BaseClass[extends $Name] {
		$Properties[$Props
		]
	}

	$NestedClasses[
	export interface $Name$TypeParameters $BaseClass[extends $Name] {
		$Properties[$Props
		]
	}
	]
    ]    
}
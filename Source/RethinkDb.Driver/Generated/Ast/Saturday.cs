








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Saturday : ReqlQuery {
    
    
        public Saturday (object arg) : this(new Arguments(arg), null) {
        }
        public Saturday (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Saturday (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.SATURDAY, args, optargs) {
        }

    protected Saturday (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Saturday FromArgs(params object[] args){
         return new Saturday (new Arguments(args), null);
        }


    

    


    
    }
}
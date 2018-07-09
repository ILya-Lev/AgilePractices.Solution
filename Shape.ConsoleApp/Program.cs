using Shape.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shape.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ShapeFactory();
            var shape = factory.Make<Square.Square>();
            Console.WriteLine(shape.Name);
            Console.WriteLine(ValidateAsync("aaa").Result.GetErrors());
        }

        private static async Task<IdentityResult> ValidateAsync(string item)
        {
            var errors = Validate(item).ToArray();
            if (errors.Length != 0)
                return new IdentityResult(errors);
            return IdentityResult.Success;
        }

        private static IEnumerable<string> Validate(string item)
        {
            yield return item;
        }
    }

    internal class IdentityResult
    {
        private readonly IEnumerable<string> _errors;

        public static IdentityResult Success = new IdentityResult(new string[0]);
        public IdentityResult(IEnumerable<string> errors)
        {
            _errors = errors;
        }

        public string GetErrors() => string.Join(", ", _errors ?? Enumerable.Empty<string>());
    }
}

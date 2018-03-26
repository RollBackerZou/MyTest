using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MyTest
{
   public class ExpressionLam
    {
       public static void LambdaMethod()
       {
           ParameterExpression a = Expression.Parameter(typeof(int),"i");
           ParameterExpression b = Expression.Parameter(typeof(int),"j");
           BinaryExpression r1 = Expression.Multiply(a,b);


           ParameterExpression c = Expression.Parameter(typeof(int), "k");
           ParameterExpression d = Expression.Parameter(typeof(int), "m");
           BinaryExpression r2 = Expression.Multiply(c, d);

           BinaryExpression result = Expression.Add(r1,r2);

           //lambda不是可执行代码，需要用下面的compile（）方法
           Expression<Func<int, int, int, int, int>> lambda = Expression.Lambda<Func<int, int, int, int, int>>(result,a,b,c,d);//创建表达式树

           Func<int, int, int, int, int> func = lambda.Compile();

           Console.WriteLine(func(1,1,1,1));


           Expression<Func<string, string, string>> exp = (x, y) => x+y;
           var explambda = exp.Compile();
           Console.WriteLine(explambda("Hello", "World"));
       }
    }
}

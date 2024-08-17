/*

But sometimes, we see this guy:

Expression<MyFunc<T, bool>> predicate


It turns this into a completely different guy. It's no longer an anonymous function. It's a data structure.

In fact it's a mini-syntax tree.

We can turn it into a executable function, though by compiling it.

            var compiled = predicate.Compile();
            foreach (var item in list)
            {
                if (compiled(item))
                {
                    yield return item;
                }
            }

And it operates much the same.

Because it's a mini syntax tree, bodied anonymous functions won't work. Anonymous delegates won't work.

This is because they are not intended to be decomposed into a syntax tree.

So what are they for?

Well. It’s a nod towards an advanced reflection technique, gloriously named 'homoiconicity' 

Really a more accurate way of explaining this would be 'code as data'. It's giving the ability to reflect across statements rather than the more traditional reflection capability of reading type information.


 */
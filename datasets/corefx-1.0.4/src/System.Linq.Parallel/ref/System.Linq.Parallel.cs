// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------


namespace System.Linq
{
    public partial class OrderedParallelQuery<TSource> : System.Linq.ParallelQuery<TSource>
    {
        internal OrderedParallelQuery() { }
        public override System.Collections.Generic.IEnumerator<TSource> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TSource>); }
    }
    public static partial class ParallelEnumerable
    {
        public static TSource Aggregate<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TSource, TSource> func) { return default(TSource); }
        public static TAccumulate Aggregate<TSource, TAccumulate>(this System.Linq.ParallelQuery<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> func) { return default(TAccumulate); }
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.Linq.ParallelQuery<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> updateAccumulatorFunc, System.Func<TAccumulate, TAccumulate, TAccumulate> combineAccumulatorsFunc, System.Func<TAccumulate, TResult> resultSelector) { return default(TResult); }
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.Linq.ParallelQuery<TSource> source, TAccumulate seed, System.Func<TAccumulate, TSource, TAccumulate> func, System.Func<TAccumulate, TResult> resultSelector) { return default(TResult); }
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TAccumulate> seedFactory, System.Func<TAccumulate, TSource, TAccumulate> updateAccumulatorFunc, System.Func<TAccumulate, TAccumulate, TAccumulate> combineAccumulatorsFunc, System.Func<TAccumulate, TResult> resultSelector) { return default(TResult); }
        public static bool All<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(bool); }
        public static bool Any<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(bool); }
        public static bool Any<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(bool); }
        public static System.Collections.Generic.IEnumerable<TSource> AsEnumerable<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Collections.Generic.IEnumerable<TSource>); }
        public static System.Linq.ParallelQuery AsOrdered(this System.Linq.ParallelQuery source) { return default(System.Linq.ParallelQuery); }
        public static System.Linq.ParallelQuery<TSource> AsOrdered<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery AsParallel(this System.Collections.IEnumerable source) { return default(System.Linq.ParallelQuery); }
        public static System.Linq.ParallelQuery<TSource> AsParallel<TSource>(this System.Collections.Concurrent.Partitioner<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> AsParallel<TSource>(this System.Collections.Generic.IEnumerable<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Collections.Generic.IEnumerable<TSource> AsSequential<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Collections.Generic.IEnumerable<TSource>); }
        public static System.Linq.ParallelQuery<TSource> AsUnordered<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
        public static decimal Average(this System.Linq.ParallelQuery<decimal> source) { return default(decimal); }
        public static double Average(this System.Linq.ParallelQuery<double> source) { return default(double); }
        public static double Average(this System.Linq.ParallelQuery<int> source) { return default(double); }
        public static double Average(this System.Linq.ParallelQuery<long> source) { return default(double); }
        public static System.Nullable<decimal> Average(this System.Linq.ParallelQuery<System.Nullable<decimal>> source) { return default(System.Nullable<decimal>); }
        public static System.Nullable<double> Average(this System.Linq.ParallelQuery<System.Nullable<double>> source) { return default(System.Nullable<double>); }
        public static System.Nullable<double> Average(this System.Linq.ParallelQuery<System.Nullable<int>> source) { return default(System.Nullable<double>); }
        public static System.Nullable<double> Average(this System.Linq.ParallelQuery<System.Nullable<long>> source) { return default(System.Nullable<double>); }
        public static System.Nullable<float> Average(this System.Linq.ParallelQuery<System.Nullable<float>> source) { return default(System.Nullable<float>); }
        public static float Average(this System.Linq.ParallelQuery<float> source) { return default(float); }
        public static decimal Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, decimal> selector) { return default(decimal); }
        public static double Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, double> selector) { return default(double); }
        public static double Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int> selector) { return default(double); }
        public static double Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, long> selector) { return default(double); }
        public static System.Nullable<decimal> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<decimal>> selector) { return default(System.Nullable<decimal>); }
        public static System.Nullable<double> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<double>> selector) { return default(System.Nullable<double>); }
        public static System.Nullable<double> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<int>> selector) { return default(System.Nullable<double>); }
        public static System.Nullable<double> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<long>> selector) { return default(System.Nullable<double>); }
        public static System.Nullable<float> Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<float>> selector) { return default(System.Nullable<float>); }
        public static float Average<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, float> selector) { return default(float); }
        public static System.Linq.ParallelQuery<TResult> Cast<TResult>(this System.Linq.ParallelQuery source) { return default(System.Linq.ParallelQuery<TResult>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TSource> Concat<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Concat<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
        public static bool Contains<TSource>(this System.Linq.ParallelQuery<TSource> source, TSource value) { return default(bool); }
        public static bool Contains<TSource>(this System.Linq.ParallelQuery<TSource> source, TSource value, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
        public static int Count<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(int); }
        public static int Count<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(int); }
        public static System.Linq.ParallelQuery<TSource> DefaultIfEmpty<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> DefaultIfEmpty<TSource>(this System.Linq.ParallelQuery<TSource> source, TSource defaultValue) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Distinct<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Distinct<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
        public static TSource ElementAt<TSource>(this System.Linq.ParallelQuery<TSource> source, int index) { return default(TSource); }
        public static TSource ElementAtOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source, int index) { return default(TSource); }
        public static System.Linq.ParallelQuery<TResult> Empty<TResult>() { return default(System.Linq.ParallelQuery<TResult>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TSource> Except<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TSource> Except<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Except<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Except<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
        public static TSource First<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
        public static TSource First<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(TSource); }
        public static TSource FirstOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
        public static TSource FirstOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(TSource); }
        public static void ForAll<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Action<TSource> action) { }
        public static System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TSource>>); }
        public static System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TSource>>); }
        public static System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { return default(System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TElement>>); }
        public static System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<System.Linq.IGrouping<TKey, TElement>>); }
        public static System.Linq.ParallelQuery<TResult> GroupBy<TSource, TKey, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> GroupBy<TSource, TKey, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TSource>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Func<TKey, System.Collections.Generic.IEnumerable<TElement>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Linq.ParallelQuery<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Linq.ParallelQuery<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, System.Collections.Generic.IEnumerable<TInner>, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TSource> Intersect<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TSource> Intersect<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Intersect<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Intersect<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Linq.ParallelQuery<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this System.Linq.ParallelQuery<TOuter> outer, System.Linq.ParallelQuery<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, System.Func<TOuter, TInner, TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ParallelQuery<TResult>); }
        public static TSource Last<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
        public static TSource Last<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(TSource); }
        public static TSource LastOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
        public static TSource LastOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(TSource); }
        public static long LongCount<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(long); }
        public static long LongCount<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(long); }
        public static decimal Max(this System.Linq.ParallelQuery<decimal> source) { return default(decimal); }
        public static double Max(this System.Linq.ParallelQuery<double> source) { return default(double); }
        public static int Max(this System.Linq.ParallelQuery<int> source) { return default(int); }
        public static long Max(this System.Linq.ParallelQuery<long> source) { return default(long); }
        public static System.Nullable<decimal> Max(this System.Linq.ParallelQuery<System.Nullable<decimal>> source) { return default(System.Nullable<decimal>); }
        public static System.Nullable<double> Max(this System.Linq.ParallelQuery<System.Nullable<double>> source) { return default(System.Nullable<double>); }
        public static System.Nullable<int> Max(this System.Linq.ParallelQuery<System.Nullable<int>> source) { return default(System.Nullable<int>); }
        public static System.Nullable<long> Max(this System.Linq.ParallelQuery<System.Nullable<long>> source) { return default(System.Nullable<long>); }
        public static System.Nullable<float> Max(this System.Linq.ParallelQuery<System.Nullable<float>> source) { return default(System.Nullable<float>); }
        public static float Max(this System.Linq.ParallelQuery<float> source) { return default(float); }
        public static TSource Max<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
        public static decimal Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, decimal> selector) { return default(decimal); }
        public static double Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, double> selector) { return default(double); }
        public static int Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int> selector) { return default(int); }
        public static long Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, long> selector) { return default(long); }
        public static System.Nullable<decimal> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<decimal>> selector) { return default(System.Nullable<decimal>); }
        public static System.Nullable<double> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<double>> selector) { return default(System.Nullable<double>); }
        public static System.Nullable<int> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<int>> selector) { return default(System.Nullable<int>); }
        public static System.Nullable<long> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<long>> selector) { return default(System.Nullable<long>); }
        public static System.Nullable<float> Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<float>> selector) { return default(System.Nullable<float>); }
        public static float Max<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, float> selector) { return default(float); }
        public static TResult Max<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TResult> selector) { return default(TResult); }
        public static decimal Min(this System.Linq.ParallelQuery<decimal> source) { return default(decimal); }
        public static double Min(this System.Linq.ParallelQuery<double> source) { return default(double); }
        public static int Min(this System.Linq.ParallelQuery<int> source) { return default(int); }
        public static long Min(this System.Linq.ParallelQuery<long> source) { return default(long); }
        public static System.Nullable<decimal> Min(this System.Linq.ParallelQuery<System.Nullable<decimal>> source) { return default(System.Nullable<decimal>); }
        public static System.Nullable<double> Min(this System.Linq.ParallelQuery<System.Nullable<double>> source) { return default(System.Nullable<double>); }
        public static System.Nullable<int> Min(this System.Linq.ParallelQuery<System.Nullable<int>> source) { return default(System.Nullable<int>); }
        public static System.Nullable<long> Min(this System.Linq.ParallelQuery<System.Nullable<long>> source) { return default(System.Nullable<long>); }
        public static System.Nullable<float> Min(this System.Linq.ParallelQuery<System.Nullable<float>> source) { return default(System.Nullable<float>); }
        public static float Min(this System.Linq.ParallelQuery<float> source) { return default(float); }
        public static TSource Min<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
        public static decimal Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, decimal> selector) { return default(decimal); }
        public static double Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, double> selector) { return default(double); }
        public static int Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int> selector) { return default(int); }
        public static long Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, long> selector) { return default(long); }
        public static System.Nullable<decimal> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<decimal>> selector) { return default(System.Nullable<decimal>); }
        public static System.Nullable<double> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<double>> selector) { return default(System.Nullable<double>); }
        public static System.Nullable<int> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<int>> selector) { return default(System.Nullable<int>); }
        public static System.Nullable<long> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<long>> selector) { return default(System.Nullable<long>); }
        public static System.Nullable<float> Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<float>> selector) { return default(System.Nullable<float>); }
        public static float Min<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, float> selector) { return default(float); }
        public static TResult Min<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TResult> selector) { return default(TResult); }
        public static System.Linq.ParallelQuery<TResult> OfType<TResult>(this System.Linq.ParallelQuery source) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.OrderedParallelQuery<TSource> OrderBy<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.OrderedParallelQuery<TSource>); }
        public static System.Linq.OrderedParallelQuery<TSource> OrderBy<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.OrderedParallelQuery<TSource>); }
        public static System.Linq.OrderedParallelQuery<TSource> OrderByDescending<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.OrderedParallelQuery<TSource>); }
        public static System.Linq.OrderedParallelQuery<TSource> OrderByDescending<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.OrderedParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<int> Range(int start, int count) { return default(System.Linq.ParallelQuery<int>); }
        public static System.Linq.ParallelQuery<TResult> Repeat<TResult>(TResult element, int count) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TSource> Reverse<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TResult> Select<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TResult> selector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> Select<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int, TResult> selector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> SelectMany<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> selector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> SelectMany<TSource, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TResult>> selector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> SelectMany<TSource, TCollection, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> SelectMany<TSource, TCollection, TResult>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static bool SequenceEqual<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(bool); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static bool SequenceEqual<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
        public static bool SequenceEqual<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(bool); }
        public static bool SequenceEqual<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(bool); }
        public static TSource Single<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
        public static TSource Single<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(TSource); }
        public static TSource SingleOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource); }
        public static TSource SingleOrDefault<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(TSource); }
        public static System.Linq.ParallelQuery<TSource> Skip<TSource>(this System.Linq.ParallelQuery<TSource> source, int count) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> SkipWhile<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> SkipWhile<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int, bool> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
        public static decimal Sum(this System.Linq.ParallelQuery<decimal> source) { return default(decimal); }
        public static double Sum(this System.Linq.ParallelQuery<double> source) { return default(double); }
        public static int Sum(this System.Linq.ParallelQuery<int> source) { return default(int); }
        public static long Sum(this System.Linq.ParallelQuery<long> source) { return default(long); }
        public static System.Nullable<decimal> Sum(this System.Linq.ParallelQuery<System.Nullable<decimal>> source) { return default(System.Nullable<decimal>); }
        public static System.Nullable<double> Sum(this System.Linq.ParallelQuery<System.Nullable<double>> source) { return default(System.Nullable<double>); }
        public static System.Nullable<int> Sum(this System.Linq.ParallelQuery<System.Nullable<int>> source) { return default(System.Nullable<int>); }
        public static System.Nullable<long> Sum(this System.Linq.ParallelQuery<System.Nullable<long>> source) { return default(System.Nullable<long>); }
        public static System.Nullable<float> Sum(this System.Linq.ParallelQuery<System.Nullable<float>> source) { return default(System.Nullable<float>); }
        public static float Sum(this System.Linq.ParallelQuery<float> source) { return default(float); }
        public static decimal Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, decimal> selector) { return default(decimal); }
        public static double Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, double> selector) { return default(double); }
        public static int Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int> selector) { return default(int); }
        public static long Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, long> selector) { return default(long); }
        public static System.Nullable<decimal> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<decimal>> selector) { return default(System.Nullable<decimal>); }
        public static System.Nullable<double> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<double>> selector) { return default(System.Nullable<double>); }
        public static System.Nullable<int> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<int>> selector) { return default(System.Nullable<int>); }
        public static System.Nullable<long> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<long>> selector) { return default(System.Nullable<long>); }
        public static System.Nullable<float> Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, System.Nullable<float>> selector) { return default(System.Nullable<float>); }
        public static float Sum<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, float> selector) { return default(float); }
        public static System.Linq.ParallelQuery<TSource> Take<TSource>(this System.Linq.ParallelQuery<TSource> source, int count) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> TakeWhile<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> TakeWhile<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int, bool> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.OrderedParallelQuery<TSource> ThenBy<TSource, TKey>(this System.Linq.OrderedParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.OrderedParallelQuery<TSource>); }
        public static System.Linq.OrderedParallelQuery<TSource> ThenBy<TSource, TKey>(this System.Linq.OrderedParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.OrderedParallelQuery<TSource>); }
        public static System.Linq.OrderedParallelQuery<TSource> ThenByDescending<TSource, TKey>(this System.Linq.OrderedParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.OrderedParallelQuery<TSource>); }
        public static System.Linq.OrderedParallelQuery<TSource> ThenByDescending<TSource, TKey>(this System.Linq.OrderedParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Linq.OrderedParallelQuery<TSource>); }
        public static TSource[] ToArray<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(TSource[]); }
        public static System.Collections.Generic.Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Collections.Generic.Dictionary<TKey, TSource>); }
        public static System.Collections.Generic.Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.Dictionary<TKey, TSource>); }
        public static System.Collections.Generic.Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { return default(System.Collections.Generic.Dictionary<TKey, TElement>); }
        public static System.Collections.Generic.Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Collections.Generic.Dictionary<TKey, TElement>); }
        public static System.Collections.Generic.List<TSource> ToList<TSource>(this System.Linq.ParallelQuery<TSource> source) { return default(System.Collections.Generic.List<TSource>); }
        public static System.Linq.ILookup<TKey, TSource> ToLookup<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector) { return default(System.Linq.ILookup<TKey, TSource>); }
        public static System.Linq.ILookup<TKey, TSource> ToLookup<TSource, TKey>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ILookup<TKey, TSource>); }
        public static System.Linq.ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) { return default(System.Linq.ILookup<TKey, TElement>); }
        public static System.Linq.ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { return default(System.Linq.ILookup<TKey, TElement>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TSource> Union<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TSource> Union<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Union<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Union<TSource>(this System.Linq.ParallelQuery<TSource> first, System.Linq.ParallelQuery<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Where<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, bool> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> Where<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Func<TSource, int, bool> predicate) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> WithCancellation<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Threading.CancellationToken cancellationToken) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> WithDegreeOfParallelism<TSource>(this System.Linq.ParallelQuery<TSource> source, int degreeOfParallelism) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> WithExecutionMode<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Linq.ParallelExecutionMode executionMode) { return default(System.Linq.ParallelQuery<TSource>); }
        public static System.Linq.ParallelQuery<TSource> WithMergeOptions<TSource>(this System.Linq.ParallelQuery<TSource> source, System.Linq.ParallelMergeOptions mergeOptions) { return default(System.Linq.ParallelQuery<TSource>); }
        [System.ObsoleteAttribute("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
        public static System.Linq.ParallelQuery<TResult> Zip<TFirst, TSecond, TResult>(this System.Linq.ParallelQuery<TFirst> first, System.Collections.Generic.IEnumerable<TSecond> second, System.Func<TFirst, TSecond, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
        public static System.Linq.ParallelQuery<TResult> Zip<TFirst, TSecond, TResult>(this System.Linq.ParallelQuery<TFirst> first, System.Linq.ParallelQuery<TSecond> second, System.Func<TFirst, TSecond, TResult> resultSelector) { return default(System.Linq.ParallelQuery<TResult>); }
    }
    public enum ParallelExecutionMode
    {
        Default = 0,
        ForceParallelism = 1,
    }
    public enum ParallelMergeOptions
    {
        AutoBuffered = 2,
        Default = 0,
        FullyBuffered = 3,
        NotBuffered = 1,
    }
    public partial class ParallelQuery : System.Collections.IEnumerable
    {
        internal ParallelQuery() { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
    public partial class ParallelQuery<TSource> : System.Linq.ParallelQuery, System.Collections.Generic.IEnumerable<TSource>, System.Collections.IEnumerable
    {
        internal ParallelQuery() { }
        public virtual System.Collections.Generic.IEnumerator<TSource> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TSource>); }
    }
}
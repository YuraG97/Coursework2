using System;
using System.Collections.Generic;

namespace EasyTransport.Data
{
    public interface IGraphNode<T> where T:IGraphNode<T>
    {
        List<IGraphNode<T>> GetNearNodes(Func<IGraphNode<T>,bool> selector);
    }
}
using Domain.Models ; 
namespace Services.Services;

public class PostService
{
    List<Post> posts = new List<Post>();
    public List<Post> GetPost() 
     {
        return posts;
     }
     public void AddCourse(Post post)
     {
        posts.Add(post) ; 
     } 
     public void Updait(Post post , int Id)
     {
        for(int i = 0 ; i < posts.ToArray().Length ; i ++)
        { 
            if( posts[i].Id == Id )
            {
                posts[i] = post ; 
                break ; 
            }
        }
     }
      public Post GetPostsById(int Id)
     {
        Post post = new Post() ;   
        for(int i = 0 ; i < posts.ToArray().Length ; i ++)
        { 
            if( posts[i].Id == Id )
            {
                post = posts[i] ; 
            }
        }
        return post ; 
     }
      public void DeletePosts(int Id)
     {   
        for(int i = 0 ; i < posts.ToArray().Length ; i ++)
        { 
            if( posts[i].Id == Id )
            {
                posts.RemoveAt(i) ;  
            }
        }
     }
      public int CountPosts()
     {
        return posts.Count() ; 
     } 
}

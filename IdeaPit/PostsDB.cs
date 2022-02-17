using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaPit
{
    class PostsDB
    {
        UserContext db;
        public int user;

        public PostsDB() 
        {
            db = new UserContext(); 
        }
        public PostsDB(int id)
        {
            db = new UserContext(); 
            user = id;
        }

        public Idea newIdea(string Name, string Discr, string type, bool isfree)
        {
            Idea idea = db.Idea.Where(p => (p.Name == Name) & (p.Description == Discr) & (p.Type == type) & (p.IsFree == isfree)).FirstOrDefault();

            string ask = "Select * from Idea";
            DataTable table = new DataTable();
            table = GetData(ask);

            int id;
            if (table.Rows.Count != 0)
                id = table.Rows[table.Rows.Count - 1].Field<int>("ID_idea") + 1;
            else id = 1;

            if (idea != null)
            {
                return null; 
            }
            else
            {
                Idea i = new Idea();
                i.ID_idea = id;
                i.Name = Name;
                i.Description = Discr;
                i.Type = type;
                i.IdeaRating = 0;
                i.CreatingDate = DateTime.Today;
                i.IsFree = isfree;

                Post post = new Post();

                ask = "Select * from Post";
                table = new DataTable();
                table = GetData(ask);

                int id_post;
                if (table.Rows.Count != 0)
                    id_post = table.Rows[table.Rows.Count - 1].Field<int>("ID_post") + 1;
                else id_post = 0;

                ask = "Select * from Tag where TagName = \'" + type + "\'";
                table = new DataTable();
                table = GetData(ask);

                if (table.Rows.Count != 0)
                {
                    int tagFK = table.Rows[0].Field<int>("TagNum");

                    ask = "Select * from IdeaTag";
                    table = new DataTable();
                    table = GetData(ask);

                    int id_tag;
                    if (table.Rows.Count != 0)
                        id_tag = table.Rows[table.Rows.Count - 1].Field<int>("ID_tag") + 1;
                    else id_tag = 0;

                    IdeaTag tag = new IdeaTag();
                    tag.ID_tag = id_tag;
                    tag.ID_idea = id;
                    tag.TagNum = tagFK;
                    db.IdeaTag.Add(tag);
                }
                else
                {
                    ask = "Select * from Tag";
                    table = new DataTable();
                    table = GetData(ask);

                    int tagtype_id;
                    if (table.Rows.Count != 0)
                        tagtype_id = table.Rows[table.Rows.Count - 1].Field<int>("TagNum") + 1;
                    else tagtype_id = 0;

                    Tag tagtype = new Tag();
                    tagtype.TagNum = tagtype_id;
                    tagtype.TagName = Name;
                    tagtype.IntCategory = Name;
                    db.Tag.Add(tagtype);

                    ask = "Select * from IdeaTag";
                    table = new DataTable();
                    table = GetData(ask);

                    int id_tag;
                    if (table.Rows.Count != 0)
                        id_tag = table.Rows[table.Rows.Count - 1].Field<int>("ID_tag") + 1;
                    else id_tag = 0;

                    IdeaTag tag = new IdeaTag();
                    tag.ID_tag = id_tag;
                    tag.ID_idea = id;
                    tag.TagNum = tagtype_id;
                    db.IdeaTag.Add(tag);
                }

                post.ID_post = id_post;
                post.ID_user = user;
                post.ID_idea = id;

                db.Post.Add(post);
                db.Idea.Add(i);
                db.SaveChanges();
                return idea;
            }
        }

        public Boolean UpdateIdea(int id, string Name, string Discr, string type, bool isfree)
        {
            Idea idea = db.Idea.Find(id);
            if (idea != null)
            {
                idea.Name = Name;
                idea.Description = Discr;
                idea.Type = type;
                idea.IdeaRating = 0;
                idea.CreatingDate = DateTime.Today;
                idea.IsFree = isfree;
                db.SaveChanges();
                return true;

            }
            else return false;
        }

        public Boolean UpdateIdea(Idea idea, string Name, string Discr, string type, bool isfree)
        {
            if (idea != null)
            {
                idea.Name = Name;
                idea.Description = Discr;
                idea.Type = type;
                idea.IdeaRating = 0;
                idea.CreatingDate = DateTime.Today;
                idea.IsFree = isfree;
                db.SaveChanges();
                return true;
            }
            else return false;
        }

        public Boolean DeleteIdea(int id, int user)
        {
            Commentary comm = db.Commentary.Where(p => p.ID_idea == id).FirstOrDefault();
            IdeaTag ideaTag = db.IdeaTag.Where(p => p.ID_idea == id).FirstOrDefault();
            Post post = db.Post.Where(p => p.ID_idea == id).FirstOrDefault();
            Idea idea = db.Idea.Find(id);

            if (idea != null & post!=null) 
            {
                while (comm != null)
                {
                    db.Commentary.Remove(comm);
                    db.SaveChanges();
                    comm = db.Commentary.Where(p => p.ID_idea == id).FirstOrDefault();
                }
                while (post != null)
                {
                    db.Post.Remove(post);
                    db.SaveChanges();
                    post = db.Post.Where(p => p.ID_idea == id).FirstOrDefault();
                }
                while (ideaTag != null)
                {
                    db.IdeaTag.Remove(ideaTag);
                    db.SaveChanges();
                    ideaTag = db.IdeaTag.Where(p => p.ID_idea == id).FirstOrDefault();
                }
                db.Idea.Remove(idea);
                db.SaveChanges(); 
                return true;
            }
            else return false;
        }

        public Boolean DeleteIdea(Idea idea, Users user)
        {
            Post post = db.Post.Where(p => p.ID_idea == idea.ID_idea & p.ID_user == user.ID_user).FirstOrDefault();
            if (idea != null)
            {
                db.Post.Remove(post);
                db.Idea.Remove(idea);
                db.SaveChanges(); 
                return true;
            }
            else return false;
        }
        public DataTable GetIdeas()
        {
            string ask = "";
            ask += "SELECT * FROM Users WHERE ID_user = \'" + user + "\'";
            DataTable ds = new DataTable();
            ds = GetData(ask);
            return ds;
        }

        private static DataTable GetData(string sqlCommand)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Ideas; Integrated Security=True";
            SqlConnection cardConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sqlCommand, cardConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            return table;
        }


    }
}

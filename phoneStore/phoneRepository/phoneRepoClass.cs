using System.Data.SqlClient;
using phoneRepository;

namespace PhoneRepository;
public class phoneRepoClass
{

    public phoneRepoMapper Get_mapper()
    {
        return mapper;
    }

   
    public void Set_mapper(phoneRepoMapper value)
    {
        mapper = value;
    }

    readonly string connectionString = "$Server=tcp:narmeenserver.database.windows.net,1433;Initial Catalog=CosmoDB;Persist Security Info=False;User ID=narmeenServer;Password=pass;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


    public phoneRepoClass()
    {
        // this._repo = r;
        this.Set_mapper(new phoneRepoMapper());
    }

    public List<Member> MembersList()
    {
        string myQuery1 = "SELECT * FROM _Members;
        using (SqlConnection query1 = new SqlConnection(connectionString))
        {
            command.Connection.Open();
            SqlDataReader results = command.ExecuteReader();

            List<Member> m1 = new List<Member>();
            while (results.Read())
            {
                Member m = this.Get_mapper().DboToMember(results);
                m1.add(m);     

            query1.Close();
            return m1;
        }

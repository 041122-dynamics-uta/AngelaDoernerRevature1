using phoneModels;
using PhoneRepository;

namespace phoneBusiness;
public class DomainClass
{
    public PhoneRepository.phoneRepoClass _repo { get; set; }
    public DomainClass(phoneRepoClass r)
    {
        this._repo = r;
    }

    public List<Member> MembersList()
    {
        List<Member> ml = _repo.MembersList();
        return ml;
    }


}
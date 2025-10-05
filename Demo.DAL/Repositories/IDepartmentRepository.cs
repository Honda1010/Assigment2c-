
namespace Demo.DAL.Repositories
{
	public interface IDepartmentRepository
	{
		int Add(Department department);
		IEnumerable<Department> GetAll(bool withtracking = false);
		Department GetById(int? id);
		int Remove(Department department);
		int Update(Department department);
	}
}
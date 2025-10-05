using Demo.BL2.DTOS;

namespace Demo.BL2.Services
{
	public interface IDepartmentService
	{
		int Add(CreatedDepartmentDto createdDepartmentDto);
		IEnumerable<DepartmentDto> GetAll();
		DepartmentDetailsDto GetById(int? id);
		bool Remove(int id);
		int Update(UpdatedDepartmentDto updatedDepartmentDto);
	}
}
using Demo.BL2.DTOS;
using Demo.DAL.Data.DBContexts;
using Demo.DAL.Models;
using Demo.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL2.Services
{
	internal class DepartmentService(IDepartmentRepository _departmentRepository)
	{
		public IEnumerable<DepartmentDto> GetAll()
		{
			var departments = _departmentRepository.GetAll();
			var departmentDtos = departments.Select(d => new DepartmentDto
			{
				DeptId = d.Id,
				Name = d.Name,
				Code = d.Code,
				Description = d.Description,
				DateOfCreation = DateOnly.FromDateTime(d.CreatedOn)
			});
			return departmentDtos;
		}
	}
}

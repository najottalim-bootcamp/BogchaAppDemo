using Bogcha.Infrastructure.Services.AttendanceServices.AttendanceDto;

namespace Bogcha.Infrastructure.Services.AttendanceServices
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceService;
        private readonly IStudentRepository studentService;
        private  IMapper mapper;
        public AttendanceService(IAttendanceRepository context ,IMapper mapper ,IStudentRepository studentRepository) 
        { _attendanceService = context; this.mapper = mapper; this.studentService = studentService; }
        public async ValueTask<bool> CreateAsync(CreateAttendanceDto crtAttendance )
        {
            Attendance attendance = mapper.Map<Attendance>(crtAttendance);
            return await _attendanceService.CreateAsync(attendance);
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            return await _attendanceService.DeleteAsync(id);
        }

        public async ValueTask<IEnumerable<ViewAttendanceDto>> GetAllAsync()
        {
            IEnumerable<Attendance> attendances = await _attendanceService.GetAllAsync();
            IEnumerable<Student> students = await studentService.GetAllAsync();
            if(!(students.Any() &&  att.Any())) return Enumerable.Empty<ViewAttendanceDto>();
            IEnumerable<ViewAttendanceDto> viewAttendanceDtos =
                attendances.Join(students, attendance => attendance.ChId, student => student.CHId,
                (attandence, student) => new ViewAttendanceDto{
                
                Id=attandence.Id,
                ChFName = student.ChFName,
                chLName=student.ChLName,
                SignIn_Time = attandence.SignIn_Time,
                SignOut_Time =attandence.SignOut_Time,
                }
                );
            return viewAttendanceDtos;
        }

        public async ValueTask<ViewAttendanceDto> GetByIdAsync(int id)
        {
            Attendance attendance = await _attendanceService.GetByIdAsync(id);
            Student student = await studentService.GetByIdAsync(attendance.ChId);

            if (attendance is null || student is null) return null;
            ViewAttendanceDto viewAttendance = new ViewAttendanceDto
            {
                Id = attendance.Id,
                ChFName = student.ChFName,
                SignIn_Time = attendance.SignIn_Time,
                SignOut_Time = attendance.SignOut_Time,
                chLName = student.ChLName,

            };
            return viewAttendance;
        }

        public async ValueTask<bool> UpdateAsync(int id,UpdateAttendanceDto UpdateAttendance)
        {
            Attendance attendances = await _attendanceService.GetByIdAsync(id);
            
            Attendance attendance = mapper.Map<Attendance>(UpdateAttendance);
            attendance.Id = id;
            attendance.SignIn_Time=attendances.SignIn_Time;
            attendance.ChId = attendances.ChId;
            
            return await _attendanceService.UpdateAsync(attendance);
        }
    }
}

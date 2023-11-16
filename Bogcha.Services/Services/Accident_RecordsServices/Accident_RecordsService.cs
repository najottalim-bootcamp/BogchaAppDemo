namespace Bogcha.Infrastructure.Services.Accident_RecordsServices;

    public class Accident_RecordsService : IAccident_RecordsService
    {
        private readonly IAccident_RecordsRepository accident_RecordsRepository;
        private readonly IStudentRepository studentRepository;
        private IMapper mapper;
        public Accident_RecordsService(
            IAccident_RecordsRepository context,
            IMapper mapper,
            IStudentRepository studentRepository
            )
        {
            this.mapper = mapper;
            this.studentRepository = studentRepository;
            accident_RecordsRepository = context;
        }
        public async ValueTask<bool> CreateAsync(CreateAccident_RecordsDto accident_RecordsDto)
        {
            AccidentRecords accident_Records = mapper.Map<AccidentRecords>(accident_RecordsDto);
            var accidentRecords = await accident_RecordsRepository.CreateAsync(accident_Records);
            return accidentRecords;

        }


        public async ValueTask<bool> DeleteAsync(int id)
        {
            var accidentRecord = await accident_RecordsRepository.DeleteAsync(id);
            return accidentRecord;
        }

        public async ValueTask<IEnumerable<ViewAccident_RecordsDto>> GetAllAsync()
        {
            IEnumerable<AccidentRecords> accidentRecords = await accident_RecordsRepository.GetAllAsync();
            IEnumerable<Student> students = await studentRepository.GetAllAsync();
            if (!(accidentRecords.Any() && students.Any()))
            {
                return Enumerable.Empty<ViewAccident_RecordsDto>();
            }
            IEnumerable<ViewAccident_RecordsDto> viewAccident_records = accidentRecords.Join(
                students,
                accident_rec => accident_rec.ChId,
                student => student.CHId,
                (accident_rec, student) => new ViewAccident_RecordsDto()
                {
                    AccNo = accident_rec.AccNo,
                    ChFName = student.ChFName,
                    ChLName = student.ChLName,
                    AccidentDate = accident_rec.AccidentDate,
                    TypeOfAccident = accident_rec.TypeOfAccident,
                    Location = accident_rec.Location,
                    FirstAid = accident_rec.FirstAid
                });

            return viewAccident_records;
        }

        public async ValueTask<ViewAccident_RecordsDto> GetByIdAsync(int id)
        {
            AccidentRecords accident_rec = await accident_RecordsRepository.GetByIdAsync(id);
            Student student = await studentRepository.GetByIdAsync(accident_rec.ChId);
            if (accident_rec is null || student is null)
            {
                return null;
            }
            ViewAccident_RecordsDto viewAccident_records = new ViewAccident_RecordsDto()
            {
                AccNo = accident_rec.AccNo,
                ChFName = student.ChFName,
                ChLName = student.ChLName,
                AccidentDate = accident_rec.AccidentDate,
                TypeOfAccident = accident_rec.TypeOfAccident,
                Location = accident_rec.Location,
                FirstAid = accident_rec.FirstAid
            };

            return viewAccident_records;

        }

        public async ValueTask<bool> UpdateAsync(int id, UpdateAccident_RecordsDto updateAccident_Records)
        {
            AccidentRecords accident_ = mapper.Map<AccidentRecords>(updateAccident_Records);
            accident_.AccNo = id;
            return await accident_RecordsRepository.UpdateAsync(accident_);
        }

    }


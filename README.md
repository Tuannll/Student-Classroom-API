# Student Classroom Web API

Ung dung Web API theo chuan RESTful API de quan ly thong tin sinh vien, lop mon hoc va danh sach sinh vien trong lop.

## Cong nghe su dung

- ASP.NET Core Web API
- .NET 10
- Entity Framework Core
- SQL Server
- OpenAPI

## Mo ta bai toan

He thong quan ly cac thong tin sau:

- Sinh vien:
  - Id
  - Ten sinh vien, toi da 50 ky tu
  - Ma so sinh vien
  - Ngay sinh

- Lop mon hoc:
  - Id
  - Ten lop, toi da 50 ky tu
  - Ma lop, toi thieu 5 ky tu
  - So sinh vien toi da, phai lon hon 0

- Quan he sinh vien - lop mon hoc:
  - Id
  - Id sinh vien
  - Id lop mon hoc

## Chuc nang yeu cau

- Them sinh vien
- Them lop mon hoc
- Them nhieu sinh vien vao lop hoc bang danh sach, so luong phan tu phai lon hon 0
- Cap nhat thong tin sinh vien theo id
- Cap nhat thong tin lop mon hoc theo id
- Lay thong tin chi tiet sinh vien theo id
- Lay thong tin chi tiet lop mon hoc theo id
- Lay danh sach sinh vien
- Lay danh sach lop mon hoc
- Lay danh sach sinh vien trong lop theo id lop bang `Join` hoac LINQ query join
- Xoa sinh vien theo id
- Xoa lop mon hoc theo id, kem theo xoa danh sach sinh vien trong lop
- Xu ly action trong controller bang `try-catch`
- To chuc code theo service layer
- Kiem tra rang buoc du lieu trong cac model them va cap nhat
- Quan ly danh sach sinh vien bang collection `List`

## Cau truc thu muc

```text
TH5/
├── Controller/              # Chua cac API controller
├── Data/
│   └── AppDbContext.cs      # Cau hinh DbContext
├── DTOs/                    # Chua cac DTO them, sua, tra ve du lieu
├── Entities/
│   ├── Classroom.cs
│   ├── Student.cs
│   └── StudentClassroom.cs
├── Services/                # Chua service layer xu ly nghiep vu
├── Program.cs               # Cau hinh ung dung
├── TH5.csproj
└── debai.txt                # Noi dung de bai
```

## Cach chay du an

1. Khoi phuc package:

```bash
dotnet restore
```

2. Build du an:

```bash
dotnet build
```

3. Chay ung dung:

```bash
dotnet run
```

4. Mo OpenAPI khi chay o moi truong Development:

```text
https://localhost:<port>/openapi/v1.json
```

Port cu the co the xem trong file `Properties/launchSettings.json` hoac output cua lenh `dotnet run`.

## Goi y endpoint RESTful

### Student

| Method | Endpoint | Mo ta |
| --- | --- | --- |
| GET | `/api/students` | Lay danh sach sinh vien |
| GET | `/api/students/{id}` | Lay chi tiet sinh vien |
| POST | `/api/students` | Them sinh vien |
| PUT | `/api/students/{id}` | Cap nhat sinh vien |
| DELETE | `/api/students/{id}` | Xoa sinh vien |

### Classroom

| Method | Endpoint | Mo ta |
| --- | --- | --- |
| GET | `/api/classrooms` | Lay danh sach lop mon hoc |
| GET | `/api/classrooms/{id}` | Lay chi tiet lop mon hoc |
| GET | `/api/classrooms/{id}/students` | Lay danh sach sinh vien trong lop |
| POST | `/api/classrooms` | Them lop mon hoc |
| POST | `/api/classrooms/{id}/students` | Them nhieu sinh vien vao lop |
| PUT | `/api/classrooms/{id}` | Cap nhat lop mon hoc |
| DELETE | `/api/classrooms/{id}` | Xoa lop mon hoc |

## Ghi chu

File `README.md` nay duoc viet dua tren noi dung trong `debai.txt` va cau truc hien tai cua project.

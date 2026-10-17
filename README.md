# Arduino Pneumatic Debug Tool

## Giới thiệu
Ứng dụng debug tool để test và kiểm tra mạch Arduino điều khiển hệ thống khí (pneumatic) trong fixture. Cho phép gửi lệnh, nhận phản hồi và theo dõi log giao tiếp.

## Tính năng

### 1. Kết nối Serial
- Tự động phát hiện cổng COM có sẵn
- Hỗ trợ nhiều baud rate: 9600, 19200, 38400, 57600, 115200, 230400, 460800, 921600
- Hiển thị trạng thái kết nối real-time

### 2. Điều khiển hệ thống khí
- **Nguồn khí**: AIR ON/OFF
- **Van điều khiển**: 4 van (VALVE1-4) ON/OFF
- **Xi lanh**: CYL UP/DOWN/FWD/REV
- **Áp suất**: Đặt áp suất, tăng/giảm áp suất
- **Bơm khí**: PUMP ON/OFF
- **Cảm biến**: Đọc áp suất, nhiệt độ, tất cả

### 3. Lệnh hệ thống
- **STATUS**: Kiểm tra trạng thái hệ thống
- **RESET**: Reset hệ thống
- **VERSION**: Xem phiên bản firmware
- **HELP**: Hiển thị danh sách lệnh
- **ESTOP**: Dừng khẩn cấp

### 4. Test tự động
- **SEQUENCE TEST**: Test tuần tự các chức năng
- **CYCLE TEST**: Test chu kỳ lặp lại

### 5. Lệnh tùy chỉnh
- Nhập lệnh tùy ý và gửi đến Arduino
- Hỗ trợ gửi bằng phím Enter

### 6. Log giao tiếp
- Hiển thị log real-time với màu phân biệt
- Lưu log ra file txt
- Xóa log

## Cách sử dụng

### Kết nối
1. Kết nối Arduino với máy tính qua USB
2. Chọn cổng COM tương ứng
3. Chọn baud rate (mặc định 115200)
4. Nhấn **Connect**

### Gửi lệnh
- Sử dụng các nút điều khiển có sẵn, HOẶC
- Nhập lệnh tùy chỉnh vào ô Command và nhấn **SEND** hoặc **Enter**

### Test hệ thống
1. Kết nối với Arduino
2. Nhấn **AIR ON** để bật nguồn khí
3. Test từng van bằng cách nhấn các nút V1-V4 ON/OFF
4. Test xi lanh bằng các nút CYL UP/DOWN/FWD/REV
5. Đặt áp suất bằng ô SET PRESSURE
6. Nhấn **READ ALL** để đọc giá trị cảm biến
7. Nhấn **ESTOP** để dừng khẩn cấp khi cần

## Danh sách lệnh Arduino

| Lệnh | Mô tả |
|------|-------|
| AIR_ON | Bật nguồn khí |
| AIR_OFF | Tắt nguồn khí |
| VALVE1_ON | Bật van 1 |
| VALVE1_OFF | Tắt van 1 |
| VALVE2_ON | Bật van 2 |
| VALVE2_OFF | Tắt van 2 |
| VALVE3_ON | Bật van 3 |
| VALVE3_OFF | Tắt van 3 |
| VALVE4_ON | Bật van 4 |
| VALVE4_OFF | Tắt van 4 |
| CYL_UP | Xi lanh lên |
| CYL_DOWN | Xi lanh xuống |
| CYL_FWD | Xi lanh tiến |
| CYL_REV | Xi lanh lùi |
| PUMP_ON | Bật bơm khí |
| PUMP_OFF | Tắt bơm khí |
| PRESS_UP | Tăng áp suất |
| PRESS_DOWN | Giảm áp suất |
| PRESS_SET <value> | Đặt áp suất (bar) |
| READ_PRESSURE | Đọc áp suất |
| READ_TEMP | Đọc nhiệt độ |
| READ_ALL | Đọc tất cả cảm biến |
| ESTOP | Dừng khẩn cấp |
| RESET | Reset hệ thống |
| STATUS | Trạng thái hệ thống |
| VERSION | Phiên bản firmware |
| HELP | Danh sách lệnh |
| SEQ_TEST_START | Bắt đầu test tuần tự |
| CYCLE_TEST | Test chu kỳ |

## Yêu cầu hệ thống
- Windows 10/11
- .NET 8.0 Runtime
- Arduino với firmware tương thích

## Build từ source

```bash
dotnet build
dotnet run
```

## Tác giả
HAN Electronics
# DebugTestTool

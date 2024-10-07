# AuraSkin
# Đề tài: quản lý cửa hàng mỹ phẩm - Desktop app
# Phạm vi đề tài: app dành cho nhân viên thu ngân bán hàng trực tiếp tại cửa hàng và nhân viên quản lý thống kê doanh thu của cửa hàng
# Khảo sát nghiệp vụ: quy trình quản lý cửa hàng mỹ phẩm

## 1. Quy trình đăng nhập nhân viên thu ngân
- **Bắt đầu**: Nhân viên mở ứng dụng và tiến hành đăng nhập bằng tài khoản cá nhân (username và mật khẩu).
- **Xác thực**: Hệ thống kiểm tra thông tin đăng nhập.
  - Nếu đúng: Nhân viên sẽ được phân quyền (chỉ truy cập các chức năng liên quan đến bán hàng).
  - Nếu sai: Hệ thống hiển thị thông báo đăng nhập thất bại và yêu cầu thử lại.
- **Kết thúc**: Nhân viên đăng nhập thành công và có thể bắt đầu sử dụng các chức năng của hệ thống.

## 2. Quy trình quét mã sản phẩm và thêm vào hóa đơn
- **Bắt đầu**: Khi khách hàng đã chọn xong sản phẩm và muốn yêu cầu thanh toán, nhân viên thu ngân quét mã sản phẩm qua thiết bị quét mã vạch hoặc nhập mã sản phẩm.
- **Xử lý mã sản phẩm**:
  - Hệ thống tra cứu mã sản phẩm trong cơ sở dữ liệu và hiển thị thông tin chi tiết: tên sản phẩm, đơn giá, số lượng tồn kho, và chương trình khuyến mãi (nếu có).
  - Hệ thống tự động tính toán tổng tiền sản phẩm bao gồm cả giảm giá.
- **Cập nhật giỏ hàng**: Sản phẩm được thêm vào giỏ hàng và hiển thị trên màn hình hóa đơn.
- **Kiểm tra tồn kho**: Nếu số lượng tồn kho không đủ, hệ thống sẽ thông báo cho nhân viên thu ngân.
- **Kết thúc**: Nhân viên có thể tiếp tục quét thêm sản phẩm hoặc điều chỉnh số lượng trong giỏ hàng.

## 3. Quy trình quản lý giỏ hàng
- **Bắt đầu**: Nhân viên xem thông tin giỏ hàng bao gồm danh sách sản phẩm, số lượng, và tổng tiền.
- **Thêm/xóa sản phẩm**: Nhân viên có thể thêm hoặc xóa sản phẩm khỏi giỏ hàng.
- **Điều chỉnh số lượng**: Nhân viên có thể điều chỉnh số lượng sản phẩm trong giỏ hàng, và hệ thống tự động cập nhật lại giá tiền.
- **Kết thúc**: Khi giỏ hàng đã hoàn tất, nhân viên có thể tiến hành thanh toán.

## 4. Quy trình xác nhận tài khoản khách hàng
- **Bắt đầu**: Sau khi quét các sản phẩm, nhân viên hỏi khách hàng có tài khoản cửa hàng hay không.
  - Nếu khách hàng có tài khoản:
    - Nhân viên nhập số điện thoại hoặc email của khách hàng để tìm kiếm tài khoản trong hệ thống.
    - Hệ thống liên kết hóa đơn với tài khoản khách hàng đó.
  - Nếu khách hàng không có tài khoản:
    - Hệ thống lưu hóa đơn dưới dạng "khách hàng vãng lai".
- **Kết thúc**: Tiếp tục quy trình thanh toán.

## 5. Quy trình thanh toán
- **Bắt đầu**: Nhân viên thu ngân kiểm tra giỏ hàng và tổng số tiền thanh toán.
- **Tính toán tổng tiền**:
  - Hệ thống tính tổng tiền bao gồm sản phẩm có giảm giá (nếu có chương trình khuyến mãi).
  - Nếu có thay đổi trong giỏ hàng, hệ thống sẽ cập nhật lại tổng số tiền.
- **Chọn phương thức thanh toán**: Hiện tại, hệ thống chỉ hỗ trợ thanh toán bằng tiền mặt.
- **In hóa đơn**: Sau khi thanh toán thành công, hệ thống in hóa đơn cho khách hàng.
- **Kết thúc**: Giao dịch hoàn tất và hóa đơn được lưu vào hệ thống.

## 6. Quy trình quản lý lịch sử mua hàng
- **Bắt đầu**: Nhân viên có thể xem lại lịch sử mua hàng của khách hàng dựa trên số tài khoản hoặc tìm kiếm bằng số điện thoại/email.
- **Hiển thị lịch sử**: Hệ thống hiển thị danh sách các hóa đơn mà khách hàng đã mua, bao gồm chi tiết sản phẩm, ngày mua, và số tiền.
- **Kết thúc**: Nhân viên có thể in lại hóa đơn hoặc cung cấp thông tin cho khách hàng.

## 7. Quy trình xem số lượng tồn kho
- **Bắt đầu**: Khi nhân viên quét mã sản phẩm, hệ thống sẽ hiển thị số lượng sản phẩm còn tồn kho.
  - Nếu sản phẩm hết hàng: Nhân viên sẽ thông báo cho khách hàng.
- **Kết thúc**: Thông tin tồn kho được hiển thị và nhân viên có thể xử lý đơn hàng tiếp theo.

## 8. Quy trình quản lý khuyến mãi
- **Bắt đầu**: Nhân viên quản lý hoặc admin có thể thêm mới, chỉnh sửa hoặc xóa các chương trình khuyến mãi.
- **Xử lý khuyến mãi**:
  - Mỗi sản phẩm có thể có một chương trình khuyến mãi đi kèm, hệ thống tự động tính giá theo % giảm giá nếu sản phẩm đang được khuyến mãi.
- **Kiểm tra khuyến mãi**: Nhân viên thu ngân có thể tra cứu thông tin khuyến mãi của từng sản phẩm trong hệ thống.
- **Kết thúc**: Thông tin khuyến mãi được cập nhật và áp dụng cho các giao dịch bán hàng.

## 9. Quy trình thống kê
- **Bắt đầu**: Nhân viên hoặc admin có thể truy cập vào chức năng thống kê từ giao diện chính.
- **Thống kê doanh thu**:
  - Hệ thống hiển thị doanh thu theo khoảng thời gian (ngày, tuần, tháng), bao gồm số lượng hóa đơn và tổng số tiền bán hàng.
- **Thống kê sản phẩm bán chạy**:
  - Hệ thống thống kê những sản phẩm bán chạy nhất dựa trên số lượng đã bán trong khoảng thời gian nhất định.
- **Thống kê sản phẩm khuyến mãi**:
  - Hệ thống tạo báo cáo về các sản phẩm đã được bán thông qua chương trình khuyến mãi, bao gồm số lượng và hiệu quả của chương trình khuyến mãi.
- **Thống kê khách hàng**:
  - Hệ thống phân loại khách hàng thành hai nhóm: có tài khoản và không có tài khoản.
- **Kết thúc**: Nhân viên hoặc admin có thể xuất báo cáo và in ra nếu cần.

# Thuật toán áp dụng: 
## Sử dụng thuật toán Entropy để tạo % giảm giá sản phẩm
### Mô tả:
Hệ thống sử dụng **thuật toán Entropy** để phân tích dữ liệu mua hàng, từ đó xác định mức % giảm giá cho từng giao dịch. Entropy là một chỉ số đo lường mức độ hỗn loạn hoặc độ không chắc chắn trong dữ liệu. Bằng cách sử dụng thuật toán này, hệ thống có thể đánh giá các yếu tố khác nhau như ngày trong tuần, số lượng mua hàng, và các yếu tố khác để đưa ra các quyết định khuyến mãi tối ưu.

### Các yếu tố ảnh hưởng đến % giảm giá:
- **Ngày trong tuần**: Hệ thống có thể phân tích lịch sử mua hàng để tìm ra những ngày có lượng giao dịch thấp, từ đó đưa ra % giảm giá cao hơn để khuyến khích mua sắm.
- **Số lượng mua hàng**: Mức giảm giá có thể được tăng dần dựa trên số lượng sản phẩm khách hàng mua trong mỗi giao dịch. Các giao dịch có số lượng lớn hơn sẽ được hưởng % giảm giá cao hơn.
- **Sản phẩm bán chạy**: Dựa trên dữ liệu về sản phẩm bán chạy trong khoảng thời gian cụ thể, hệ thống sẽ điều chỉnh % giảm giá cho những sản phẩm ít phổ biến hơn nhằm tăng doanh số cho các mặt hàng này.
- **Thời điểm trong ngày**: Hệ thống có thể xác định khoảng thời gian nào trong ngày có lưu lượng mua sắm thấp, từ đó áp dụng chương trình khuyến mãi nhằm tăng doanh số trong thời gian đó.

### Quy trình tính toán:
1. **Thu thập dữ liệu**: Hệ thống thu thập dữ liệu từ các giao dịch trước đó như ngày mua, giờ mua, số lượng sản phẩm, và loại sản phẩm.
2. **Tính toán Entropy**: Thuật toán Entropy sẽ được áp dụng lên các biến này để đo lường độ không chắc chắn và tìm ra các mẫu đặc biệt trong dữ liệu.
3. **Xác định % giảm giá**: Dựa trên kết quả tính toán, hệ thống sẽ điều chỉnh % giảm giá phù hợp nhằm khuyến khích khách hàng mua sắm nhiều hơn trong các điều kiện không chắc chắn (ví dụ: ngày bán hàng ít, giờ bán hàng thấp).
4. **Áp dụng giảm giá**: Hệ thống tự động áp dụng mức % giảm giá đã tính cho từng sản phẩm và hiển thị trên hóa đơn của khách hàng.

### Mục tiêu:
- Tối ưu hóa doanh thu bằng cách khuyến khích khách hàng mua sắm vào các thời điểm ít phổ biến.
- Tăng lượng mua hàng thông qua các chương trình giảm giá dựa trên dữ liệu thực tế.
- Cải thiện hiệu quả các chương trình khuyến mãi bằng cách tận dụng dữ liệu lịch sử và dự đoán nhu cầu.



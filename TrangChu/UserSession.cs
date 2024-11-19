using System;

public static class UserSession
{
    // Thuộc tính tĩnh để lưu thông tin người dùng
    public static UserInfo CurrentUser { get; set; }

    // Phương thức để lưu thông tin người dùng
    public static void SaveUserInfo(string username, string email, string role)
    {
        CurrentUser = new UserInfo(username, email, role);
    }

    // Phương thức để xóa thông tin người dùng (nếu cần)
    public static void ClearUserInfo()
    {
        CurrentUser = null;
    }
}

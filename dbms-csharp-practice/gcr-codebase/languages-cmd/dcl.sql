
-- SECURITY
CREATE LOGIN app_user WITH PASSWORD = 'Password@123';
CREATE USER app_user FOR LOGIN app_user;

-- GRANT
GRANT SELECT, INSERT, UPDATE ON Employees TO app_user;

-- DENY
DENY DELETE ON Employees TO app_user;

-- REVOKE
REVOKE INSERT ON Employees FROM app_user;

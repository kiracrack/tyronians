Imports System.IO

Module UpdateEngine
    Dim engineupdated As Boolean = False
    Dim features As String = ""

    Public Sub SystemUpdateChecker()
        On Error Resume Next
        Dim updateVersion As String = ""
          
        updateVersion = "2016-03-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglobalchapters` ADD COLUMN `region` VARCHAR(5) NOT NULL AFTER `countrycode`, ADD COLUMN `province` VARCHAR(5) NOT NULL AFTER `region`, ADD COLUMN `area` VARCHAR(5) NOT NULL AFTER `province`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalmembers` MODIFY COLUMN `fullname` VARCHAR(200) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalmembers` ADD INDEX `Index_1`(`memberid`, `fullname`), ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalchapters` MODIFY COLUMN `chaptername` VARCHAR(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, ADD INDEX `Index_1`(`chaptername`), ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalmembers` CHARACTER SET utf8 COLLATE utf8_unicode_ci ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-03-07"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglobalmembers` ADD COLUMN `relationshipstatus` VARCHAR(45) AFTER `birthplace`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalmembers` ADD COLUMN `insurance` VARCHAR(45) NOT NULL DEFAULT '' AFTER `emailadd`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalmembers` ADD COLUMN `incase_birthdate` DATE AFTER `incase_contactname`, ADD COLUMN `incase_datecompanion` DATE AFTER `incase_contact`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-03-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tbllocalchapter` (  `code` int(10) unsigned NOT NULL AUTO_INCREMENT,  `chaptercode` varchar(15) NOT NULL,  `chaptername` varchar(100) NOT NULL,  PRIMARY KEY (`code`)) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalmembers` ADD COLUMN `localchapter` VARCHAR(45) NOT NULL DEFAULT '' AFTER `chaptercode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblcollections` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `memberid` varchar(45) NOT NULL,  `chaptercode` varchar(45) NOT NULL,  `localchapter` varchar(45) NOT NULL,  `accountname` varchar(100) NOT NULL,  `receiptno` varchar(45) NOT NULL,  `amount` double NOT NULL,  `postingdate` date NOT NULL,  `datetrn` datetime NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        If engineupdated = True Then
            MessageBox.Show("Your database engine was successfully updated", "Tyronians Central", MessageBoxButtons.OK, MessageBoxIcon.Information)
            engineupdated = False
        End If
    End Sub

    Public Function DatabaseUpdateLogs(ByVal nVersions As String, ByVal strQuery As String)
        com.CommandText = "insert into tbldatabaseupdatelogs set databaseversion='" & nVersions & "',dateupdate=current_timestamp,appliedquery='" & strQuery & "'" : com.ExecuteNonQuery()
        Return 0
    End Function
 End Module

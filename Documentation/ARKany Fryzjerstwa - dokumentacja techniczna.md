<a name='assembly'></a>
# ARKanyFryzjerstwa

<a name='T-ARKanyFryzjerstwa-About'></a>
## O aplikacji ARKany Fryzjerstwa
Głównym założeniem aplikacji ARKany Fryzjerstwa jest ułatwienie zarządzania salonem fryzjerskim. Osiągane jest to poprzez oferowane funkcjonalności.

### Funkcjonalności
<ul>
	<li> Harmonogram  - pozwala na planowanie i śledzenie wizyt klientów. Udostępnia takie informacje jak planowana usługa, potrzebne zasoby, czas trwania, koszt oraz dane klienta. Umożliwia anulowanie oraz zakończenie wizyt.</li>
	<li> Panel usług - przechowuje informacje na temat oferowanych usług. Zapisywany jest czas trwania, cena oraz wymagane zasoby.</li>
	<li> Panel zasobów - zapisywany jest w nim stan zasobów.</li>
	<li> Panel klientów - zawiera dane klientów, takie jak imię i nazwisko, numer telefonu oraz email.</li>
	<li> Panel salonu - pozwala zarządzać pracownikami.</li>
</ul>

Panel usług, zasobów oraz klientów umożliwia sortowanie, wyszukiwanie, zaawansowane filtrowanie oraz modyfikowanie danych.

## Spis treści
- [O aplikacji ARKany Fryzjerstwa](#T-ARKanyFryzjerstwa-About)
- [Wymagania](#T-ARKanyFryzjerstwa-Requirements)
- [Instalacja](#T-ARKanyFryzjerstwa-Installation)
- [ARKanyResources](#T-ARKanyFryzjerstwa-Resources-ARKanyResources 'ARKanyFryzjerstwa.Resources.ARKanyResources')
  - [Add](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-Add 'ARKanyFryzjerstwa.Resources.ARKanyResources.Add')
  - [AddEmployeeAccount](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-AddEmployeeAccount 'ARKanyFryzjerstwa.Resources.ARKanyResources.AddEmployeeAccount')
  - [AddingEmployeeSuccessMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-AddingEmployeeSuccessMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.AddingEmployeeSuccessMsg')
  - [AnonymousClientName](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-AnonymousClientName 'ARKanyFryzjerstwa.Resources.ARKanyResources.AnonymousClientName')
  - [Cancel](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-Cancel 'ARKanyFryzjerstwa.Resources.ARKanyResources.Cancel')
  - [ChangeColor](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ChangeColor 'ARKanyFryzjerstwa.Resources.ARKanyResources.ChangeColor')
  - [ChangePassword](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ChangePassword 'ARKanyFryzjerstwa.Resources.ARKanyResources.ChangePassword')
  - [ChangingPasswordErrorMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ChangingPasswordErrorMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.ChangingPasswordErrorMsg')
  - [ChangingPasswordSuccessMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ChangingPasswordSuccessMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.ChangingPasswordSuccessMsg')
  - [Close](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-Close 'ARKanyFryzjerstwa.Resources.ARKanyResources.Close')
  - [ConfirmNewPassword](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ConfirmNewPassword 'ARKanyFryzjerstwa.Resources.ARKanyResources.ConfirmNewPassword')
  - [CreationEmployeeAccountMailBody](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-CreationEmployeeAccountMailBody 'ARKanyFryzjerstwa.Resources.ARKanyResources.CreationEmployeeAccountMailBody')
  - [CreationEmployeeAccountMailSubject](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-CreationEmployeeAccountMailSubject 'ARKanyFryzjerstwa.Resources.ARKanyResources.CreationEmployeeAccountMailSubject')
  - [Culture](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-Culture 'ARKanyFryzjerstwa.Resources.ARKanyResources.Culture')
  - [Email](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-Email 'ARKanyFryzjerstwa.Resources.ARKanyResources.Email')
  - [EmailHintText](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-EmailHintText 'ARKanyFryzjerstwa.Resources.ARKanyResources.EmailHintText')
  - [Employees](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-Employees 'ARKanyFryzjerstwa.Resources.ARKanyResources.Employees')
  - [ErrorTitle](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ErrorTitle 'ARKanyFryzjerstwa.Resources.ARKanyResources.ErrorTitle')
  - [FirstName](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-FirstName 'ARKanyFryzjerstwa.Resources.ARKanyResources.FirstName')
  - [GetAllEmployeesErrorMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-GetAllEmployeesErrorMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.GetAllEmployeesErrorMsg')
  - [IncompleteDataWarningMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-IncompleteDataWarningMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.IncompleteDataWarningMsg')
  - [InfoTitle](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-InfoTitle 'ARKanyFryzjerstwa.Resources.ARKanyResources.InfoTitle')
  - [InvalidFormErrorMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-InvalidFormErrorMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.InvalidFormErrorMsg')
  - [InvalidVerificationCodeErrorDescription](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-InvalidVerificationCodeErrorDescription 'ARKanyFryzjerstwa.Resources.ARKanyResources.InvalidVerificationCodeErrorDescription')
  - [LastName](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-LastName 'ARKanyFryzjerstwa.Resources.ARKanyResources.LastName')
  - [LoginInputLabel](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-LoginInputLabel 'ARKanyFryzjerstwa.Resources.ARKanyResources.LoginInputLabel')
  - [NameHintText](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-NameHintText 'ARKanyFryzjerstwa.Resources.ARKanyResources.NameHintText')
  - [NewPassword](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-NewPassword 'ARKanyFryzjerstwa.Resources.ARKanyResources.NewPassword')
  - [NoPerrmisionErrorMessage](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-NoPerrmisionErrorMessage 'ARKanyFryzjerstwa.Resources.ARKanyResources.NoPerrmisionErrorMessage')
  - [PasswordResetLink](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-PasswordResetLink 'ARKanyFryzjerstwa.Resources.ARKanyResources.PasswordResetLink')
  - [ResetPasswordVerificationCodeMailBody](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ResetPasswordVerificationCodeMailBody 'ARKanyFryzjerstwa.Resources.ARKanyResources.ResetPasswordVerificationCodeMailBody')
  - [ResetPasswordVerificationCodeMailSubject](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ResetPasswordVerificationCodeMailSubject 'ARKanyFryzjerstwa.Resources.ARKanyResources.ResetPasswordVerificationCodeMailSubject')
  - [ResourceManager](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ResourceManager 'ARKanyFryzjerstwa.Resources.ARKanyResources.ResourceManager')
  - [Salon](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-Salon 'ARKanyFryzjerstwa.Resources.ARKanyResources.Salon')
  - [SalonRegisterErrorMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-SalonRegisterErrorMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.SalonRegisterErrorMsg')
  - [SalonRegisterLink](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-SalonRegisterLink 'ARKanyFryzjerstwa.Resources.ARKanyResources.SalonRegisterLink')
  - [SalonRegisterSuccessMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-SalonRegisterSuccessMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.SalonRegisterSuccessMsg')
  - [Save](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-Save 'ARKanyFryzjerstwa.Resources.ARKanyResources.Save')
  - [SavingEmployeeColorErrorMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-SavingEmployeeColorErrorMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.SavingEmployeeColorErrorMsg')
  - [SavingEmployeeColorSuccessMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-SavingEmployeeColorSuccessMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.SavingEmployeeColorSuccessMsg')
  - [ServiceResourcesAssigmentSelectInfo](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-ServiceResourcesAssigmentSelectInfo 'ARKanyFryzjerstwa.Resources.ARKanyResources.ServiceResourcesAssigmentSelectInfo')
  - [SuccessTitle](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-SuccessTitle 'ARKanyFryzjerstwa.Resources.ARKanyResources.SuccessTitle')
  - [UnknowErrorMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-UnknowErrorMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.UnknowErrorMsg')
  - [UserNotFoundErrorMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-UserNotFoundErrorMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.UserNotFoundErrorMsg')
  - [VerificationCode](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-VerificationCode 'ARKanyFryzjerstwa.Resources.ARKanyResources.VerificationCode')
  - [VerificationCodeInfo](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-VerificationCodeInfo 'ARKanyFryzjerstwa.Resources.ARKanyResources.VerificationCodeInfo')
  - [VerificationCodeSendedMsg](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-VerificationCodeSendedMsg 'ARKanyFryzjerstwa.Resources.ARKanyResources.VerificationCodeSendedMsg')
  - [WarningTitle](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-WarningTitle 'ARKanyFryzjerstwa.Resources.ARKanyResources.WarningTitle')
  - [WrongHexColorFormatExceptionMessage](#P-ARKanyFryzjerstwa-Resources-ARKanyResources-WrongHexColorFormatExceptionMessage 'ARKanyFryzjerstwa.Resources.ARKanyResources.WrongHexColorFormatExceptionMessage')
- [AccountController](#T-ARKanyFryzjerstwa-Controllers-AccountController 'ARKanyFryzjerstwa.Controllers.AccountController')
  - [Index()](#M-ARKanyFryzjerstwa-Controllers-AccountController-Index 'ARKanyFryzjerstwa.Controllers.AccountController.Index')
  - [Login()](#M-ARKanyFryzjerstwa-Controllers-AccountController-Login 'ARKanyFryzjerstwa.Controllers.AccountController.Login')
  - [Login(model)](#M-ARKanyFryzjerstwa-Controllers-AccountController-Login-ARKanyFryzjerstwa-Models-LoginModel- 'ARKanyFryzjerstwa.Controllers.AccountController.Login(ARKanyFryzjerstwa.Models.LoginModel)')
  - [Logout()](#M-ARKanyFryzjerstwa-Controllers-AccountController-Logout 'ARKanyFryzjerstwa.Controllers.AccountController.Logout')
  - [PasswordReset()](#M-ARKanyFryzjerstwa-Controllers-AccountController-PasswordReset 'ARKanyFryzjerstwa.Controllers.AccountController.PasswordReset')
  - [PasswordReset(model)](#M-ARKanyFryzjerstwa-Controllers-AccountController-PasswordReset-ARKanyFryzjerstwa-Models-PasswordResetModel- 'ARKanyFryzjerstwa.Controllers.AccountController.PasswordReset(ARKanyFryzjerstwa.Models.PasswordResetModel)')
  - [RegisterSalon()](#M-ARKanyFryzjerstwa-Controllers-AccountController-RegisterSalon 'ARKanyFryzjerstwa.Controllers.AccountController.RegisterSalon')
  - [RegisterSalon(model)](#M-ARKanyFryzjerstwa-Controllers-AccountController-RegisterSalon-ARKanyFryzjerstwa-Models-RegisterSalonModel- 'ARKanyFryzjerstwa.Controllers.AccountController.RegisterSalon(ARKanyFryzjerstwa.Models.RegisterSalonModel)')
  - [SendPasswordResetVerificationCode(login)](#M-ARKanyFryzjerstwa-Controllers-AccountController-SendPasswordResetVerificationCode-System-String- 'ARKanyFryzjerstwa.Controllers.AccountController.SendPasswordResetVerificationCode(System.String)')
- [AccountService](#T-ARKanyFryzjerstwa-Services-AccountService 'ARKanyFryzjerstwa.Services.AccountService')
  - [GetUserByLogin(login)](#M-ARKanyFryzjerstwa-Services-AccountService-GetUserByLogin-System-String- 'ARKanyFryzjerstwa.Services.AccountService.GetUserByLogin(System.String)')
  - [GetUserNote(employeeId)](#M-ARKanyFryzjerstwa-Services-AccountService-GetUserNote-System-String- 'ARKanyFryzjerstwa.Services.AccountService.GetUserNote(System.String)')
  - [GetUsernameByLogin(login)](#M-ARKanyFryzjerstwa-Services-AccountService-GetUsernameByLogin-System-String- 'ARKanyFryzjerstwa.Services.AccountService.GetUsernameByLogin(System.String)')
  - [PasswordReset(model)](#M-ARKanyFryzjerstwa-Services-AccountService-PasswordReset-ARKanyFryzjerstwa-Models-PasswordResetModel- 'ARKanyFryzjerstwa.Services.AccountService.PasswordReset(ARKanyFryzjerstwa.Models.PasswordResetModel)')
  - [RegisterSalon(model)](#M-ARKanyFryzjerstwa-Services-AccountService-RegisterSalon-ARKanyFryzjerstwa-Models-RegisterSalonModel- 'ARKanyFryzjerstwa.Services.AccountService.RegisterSalon(ARKanyFryzjerstwa.Models.RegisterSalonModel)')
  - [SaveUserNote(note,employeeId)](#M-ARKanyFryzjerstwa-Services-AccountService-SaveUserNote-System-String,System-String- 'ARKanyFryzjerstwa.Services.AccountService.SaveUserNote(System.String,System.String)')
  - [SendPasswordResetVerificationCode(login,url)](#M-ARKanyFryzjerstwa-Services-AccountService-SendPasswordResetVerificationCode-System-String,Microsoft-AspNetCore-Mvc-IUrlHelper- 'ARKanyFryzjerstwa.Services.AccountService.SendPasswordResetVerificationCode(System.String,Microsoft.AspNetCore.Mvc.IUrlHelper)')
  - [ValidatePasswordResetVerificationCode(userId,code,requestDateTime)](#M-ARKanyFryzjerstwa-Services-AccountService-ValidatePasswordResetVerificationCode-System-String,System-String,System-DateTime- 'ARKanyFryzjerstwa.Services.AccountService.ValidatePasswordResetVerificationCode(System.String,System.String,System.DateTime)')
- [AppointmentController](#T-ARKanyFryzjerstwa-Controllers-AppointmentController 'ARKanyFryzjerstwa.Controllers.AppointmentController')
  - [CreateAppointment(appointmentAddModel)](#M-ARKanyFryzjerstwa-Controllers-AppointmentController-CreateAppointment-ARKanyFryzjerstwa-Models-AppointmentAddModel- 'ARKanyFryzjerstwa.Controllers.AppointmentController.CreateAppointment(ARKanyFryzjerstwa.Models.AppointmentAddModel)')
  - [DoAppointmentsOverlap(appointmentAddModel)](#M-ARKanyFryzjerstwa-Controllers-AppointmentController-DoAppointmentsOverlap-ARKanyFryzjerstwa-Models-AppointmentAddModel- 'ARKanyFryzjerstwa.Controllers.AppointmentController.DoAppointmentsOverlap(ARKanyFryzjerstwa.Models.AppointmentAddModel)')
  - [GetAppointmentCreationData()](#M-ARKanyFryzjerstwa-Controllers-AppointmentController-GetAppointmentCreationData 'ARKanyFryzjerstwa.Controllers.AppointmentController.GetAppointmentCreationData')
  - [GetClientPhoneNumberAndEmail(clientId)](#M-ARKanyFryzjerstwa-Controllers-AppointmentController-GetClientPhoneNumberAndEmail-System-Int32- 'ARKanyFryzjerstwa.Controllers.AppointmentController.GetClientPhoneNumberAndEmail(System.Int32)')
- [AppointmentDao](#T-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao')
  - [AddAppointment(appointment)](#M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-AddAppointment-ARKanyFryzjerstwa-Data-Appointment- 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao.AddAppointment(ARKanyFryzjerstwa.Data.Appointment)')
  - [GetAppointmentById(appointmentId)](#M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetAppointmentById-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao.GetAppointmentById(System.Int32)')
  - [GetAppointmentsByClientId(clientId)](#M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetAppointmentsByClientId-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao.GetAppointmentsByClientId(System.Int32)')
  - [GetAppointmetsByEmployeeIdsAndDate(employees,date)](#M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetAppointmetsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime- 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao.GetAppointmetsByEmployeeIdsAndDate(System.Collections.Generic.IList{System.String},System.DateTime)')
  - [GetCompletedAppointmentsByEmployeeIdsAndDate(employeeId,date)](#M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetCompletedAppointmentsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime- 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao.GetCompletedAppointmentsByEmployeeIdsAndDate(System.Collections.Generic.IList{System.String},System.DateTime)')
  - [GetNotCanceledAppointmetsByEmployeeIdsAndDate(employees,date)](#M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetNotCanceledAppointmetsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime- 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao.GetNotCanceledAppointmetsByEmployeeIdsAndDate(System.Collections.Generic.IList{System.String},System.DateTime)')
  - [GetScheduledAppointmentsByEmployeeIdsAndDate(employees,date)](#M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetScheduledAppointmentsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime- 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao.GetScheduledAppointmentsByEmployeeIdsAndDate(System.Collections.Generic.IList{System.String},System.DateTime)')
  - [UpdateAppointment(appointment)](#M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-UpdateAppointment-ARKanyFryzjerstwa-Data-Appointment- 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao.UpdateAppointment(ARKanyFryzjerstwa.Data.Appointment)')
  - [UpdateAppointments(appointments)](#M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-UpdateAppointments-System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Appointment}- 'ARKanyFryzjerstwa.DataAccessObjects.AppointmentDao.UpdateAppointments(System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Appointment})')
- [AppointmentService](#T-ARKanyFryzjerstwa-Services-AppointmentService 'ARKanyFryzjerstwa.Services.AppointmentService')
  - [CancelAppointment(appointmentId)](#M-ARKanyFryzjerstwa-Services-AppointmentService-CancelAppointment-System-Int32- 'ARKanyFryzjerstwa.Services.AppointmentService.CancelAppointment(System.Int32)')
  - [CompleteAppointment(appointmentCompletionData)](#M-ARKanyFryzjerstwa-Services-AppointmentService-CompleteAppointment-ARKanyFryzjerstwa-Models-AppointmentCompletionDataModel- 'ARKanyFryzjerstwa.Services.AppointmentService.CompleteAppointment(ARKanyFryzjerstwa.Models.AppointmentCompletionDataModel)')
  - [ConvertAppointmentAddModel(appointmentAddModel,authorId,salonId)](#M-ARKanyFryzjerstwa-Services-AppointmentService-ConvertAppointmentAddModel-ARKanyFryzjerstwa-Models-AppointmentAddModel,System-String,System-Int32- 'ARKanyFryzjerstwa.Services.AppointmentService.ConvertAppointmentAddModel(ARKanyFryzjerstwa.Models.AppointmentAddModel,System.String,System.Int32)')
  - [CreateAppointment(appointmentAddModel,authorId,salonId)](#M-ARKanyFryzjerstwa-Services-AppointmentService-CreateAppointment-ARKanyFryzjerstwa-Models-AppointmentAddModel,System-String,System-Int32- 'ARKanyFryzjerstwa.Services.AppointmentService.CreateAppointment(ARKanyFryzjerstwa.Models.AppointmentAddModel,System.String,System.Int32)')
  - [DoAppointmentsOverlap(appointmentAddModel)](#M-ARKanyFryzjerstwa-Services-AppointmentService-DoAppointmentsOverlap-ARKanyFryzjerstwa-Models-AppointmentAddModel- 'ARKanyFryzjerstwa.Services.AppointmentService.DoAppointmentsOverlap(ARKanyFryzjerstwa.Models.AppointmentAddModel)')
  - [GetAppointmentCreationClients(salonId)](#M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentCreationClients-System-Int32- 'ARKanyFryzjerstwa.Services.AppointmentService.GetAppointmentCreationClients(System.Int32)')
  - [GetAppointmentCreationData(salonId)](#M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentCreationData-System-Int32- 'ARKanyFryzjerstwa.Services.AppointmentService.GetAppointmentCreationData(System.Int32)')
  - [GetAppointmentCreationEmployees(salonId)](#M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentCreationEmployees-System-Int32- 'ARKanyFryzjerstwa.Services.AppointmentService.GetAppointmentCreationEmployees(System.Int32)')
  - [GetAppointmentCreationServices(salonId)](#M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentCreationServices-System-Int32- 'ARKanyFryzjerstwa.Services.AppointmentService.GetAppointmentCreationServices(System.Int32)')
  - [GetAppointmentServiceModel(appointmentId)](#M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentServiceModel-System-Int32- 'ARKanyFryzjerstwa.Services.AppointmentService.GetAppointmentServiceModel(System.Int32)')
  - [GetAppointmentStartAndEndDate(appointmentAddModel)](#M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentStartAndEndDate-ARKanyFryzjerstwa-Models-AppointmentAddModel- 'ARKanyFryzjerstwa.Services.AppointmentService.GetAppointmentStartAndEndDate(ARKanyFryzjerstwa.Models.AppointmentAddModel)')
  - [GetClient(appointmentAddModel)](#M-ARKanyFryzjerstwa-Services-AppointmentService-GetClient-ARKanyFryzjerstwa-Models-AppointmentAddModel- 'ARKanyFryzjerstwa.Services.AppointmentService.GetClient(ARKanyFryzjerstwa.Models.AppointmentAddModel)')
  - [GetPhoneAndEmail(clientId)](#M-ARKanyFryzjerstwa-Services-AppointmentService-GetPhoneAndEmail-System-Int32- 'ARKanyFryzjerstwa.Services.AppointmentService.GetPhoneAndEmail(System.Int32)')
- [BaseController](#T-ARKanyFryzjerstwa-Controllers-BaseController 'ARKanyFryzjerstwa.Controllers.BaseController')
  - [_userManager](#F-ARKanyFryzjerstwa-Controllers-BaseController-_userManager 'ARKanyFryzjerstwa.Controllers.BaseController._userManager')
  - [CurrentSalonId](#P-ARKanyFryzjerstwa-Controllers-BaseController-CurrentSalonId 'ARKanyFryzjerstwa.Controllers.BaseController.CurrentSalonId')
  - [CurrentUser](#P-ARKanyFryzjerstwa-Controllers-BaseController-CurrentUser 'ARKanyFryzjerstwa.Controllers.BaseController.CurrentUser')
  - [UserSalonId](#P-ARKanyFryzjerstwa-Controllers-BaseController-UserSalonId 'ARKanyFryzjerstwa.Controllers.BaseController.UserSalonId')
- [BaseDao](#T-ARKanyFryzjerstwa-DataAccessObjects-BaseDao 'ARKanyFryzjerstwa.DataAccessObjects.BaseDao')
  - [GetModificationDateTimeForTableBySalonIdAndTable()](#M-ARKanyFryzjerstwa-DataAccessObjects-BaseDao-GetModificationDateTimeForTableBySalonIdAndTable 'ARKanyFryzjerstwa.DataAccessObjects.BaseDao.GetModificationDateTimeForTableBySalonIdAndTable')
  - [IsUpToDate(cacheModification)](#M-ARKanyFryzjerstwa-DataAccessObjects-BaseDao-IsUpToDate-System-DateTime- 'ARKanyFryzjerstwa.DataAccessObjects.BaseDao.IsUpToDate(System.DateTime)')
  - [SetModificationDateTimeToNow()](#M-ARKanyFryzjerstwa-DataAccessObjects-BaseDao-SetModificationDateTimeToNow 'ARKanyFryzjerstwa.DataAccessObjects.BaseDao.SetModificationDateTimeToNow')
- [ClientDao](#T-ARKanyFryzjerstwa-DataAccessObjects-ClientDao 'ARKanyFryzjerstwa.DataAccessObjects.ClientDao')
  - [AddClient(client)](#M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-AddClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.DataAccessObjects.ClientDao.AddClient(ARKanyFryzjerstwa.Data.Client)')
  - [AssingClientToSalon(clientId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-AssingClientToSalon-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ClientDao.AssingClientToSalon(System.Int32)')
  - [GetClientById(clientId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-GetClientById-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ClientDao.GetClientById(System.Int32)')
  - [GetClientsForSalon(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-GetClientsForSalon-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ClientDao.GetClientsForSalon(System.Int32)')
  - [IsClientDuplicate(client)](#M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-IsClientDuplicate-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.DataAccessObjects.ClientDao.IsClientDuplicate(ARKanyFryzjerstwa.Data.Client)')
  - [RemoveClient(client)](#M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-RemoveClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.DataAccessObjects.ClientDao.RemoveClient(ARKanyFryzjerstwa.Data.Client)')
  - [RemoveClients(clientsToRemove)](#M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-RemoveClients-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Client}- 'ARKanyFryzjerstwa.DataAccessObjects.ClientDao.RemoveClients(System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Client})')
  - [UpdateClient(client)](#M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-UpdateClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.DataAccessObjects.ClientDao.UpdateClient(ARKanyFryzjerstwa.Data.Client)')
- [ClientsController](#T-ARKanyFryzjerstwa-Controllers-ClientsController 'ARKanyFryzjerstwa.Controllers.ClientsController')
  - [AddNewClient(client)](#M-ARKanyFryzjerstwa-Controllers-ClientsController-AddNewClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.Controllers.ClientsController.AddNewClient(ARKanyFryzjerstwa.Data.Client)')
  - [DuplicateClientVerification(client)](#M-ARKanyFryzjerstwa-Controllers-ClientsController-DuplicateClientVerification-ARKanyFryzjerstwa-Models-ClientModel- 'ARKanyFryzjerstwa.Controllers.ClientsController.DuplicateClientVerification(ARKanyFryzjerstwa.Models.ClientModel)')
  - [Index()](#M-ARKanyFryzjerstwa-Controllers-ClientsController-Index 'ARKanyFryzjerstwa.Controllers.ClientsController.Index')
  - [RemoveClient(clientId)](#M-ARKanyFryzjerstwa-Controllers-ClientsController-RemoveClient-System-Int32- 'ARKanyFryzjerstwa.Controllers.ClientsController.RemoveClient(System.Int32)')
  - [RemoveClients(clientsIds)](#M-ARKanyFryzjerstwa-Controllers-ClientsController-RemoveClients-System-Collections-Generic-List{System-Int32}- 'ARKanyFryzjerstwa.Controllers.ClientsController.RemoveClients(System.Collections.Generic.List{System.Int32})')
  - [UpdateClient(client)](#M-ARKanyFryzjerstwa-Controllers-ClientsController-UpdateClient-ARKanyFryzjerstwa-Models-ClientModel- 'ARKanyFryzjerstwa.Controllers.ClientsController.UpdateClient(ARKanyFryzjerstwa.Models.ClientModel)')
- [ClientsService](#T-ARKanyFryzjerstwa-Services-ClientsService 'ARKanyFryzjerstwa.Services.ClientsService')
  - [ConvertClient(client)](#M-ARKanyFryzjerstwa-Services-ClientsService-ConvertClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.Services.ClientsService.ConvertClient(ARKanyFryzjerstwa.Data.Client)')
  - [ConvertClientModel(client)](#M-ARKanyFryzjerstwa-Services-ClientsService-ConvertClientModel-ARKanyFryzjerstwa-Models-ClientModel- 'ARKanyFryzjerstwa.Services.ClientsService.ConvertClientModel(ARKanyFryzjerstwa.Models.ClientModel)')
  - [CreateClient(client)](#M-ARKanyFryzjerstwa-Services-ClientsService-CreateClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.Services.ClientsService.CreateClient(ARKanyFryzjerstwa.Data.Client)')
  - [EmailValidation(email)](#M-ARKanyFryzjerstwa-Services-ClientsService-EmailValidation-System-String- 'ARKanyFryzjerstwa.Services.ClientsService.EmailValidation(System.String)')
  - [GetClientsModel(salonId)](#M-ARKanyFryzjerstwa-Services-ClientsService-GetClientsModel-System-Int32- 'ARKanyFryzjerstwa.Services.ClientsService.GetClientsModel(System.Int32)')
  - [IsClientDuplicate(clientModel)](#M-ARKanyFryzjerstwa-Services-ClientsService-IsClientDuplicate-ARKanyFryzjerstwa-Models-ClientModel- 'ARKanyFryzjerstwa.Services.ClientsService.IsClientDuplicate(ARKanyFryzjerstwa.Models.ClientModel)')
  - [RemoveClient(clientId)](#M-ARKanyFryzjerstwa-Services-ClientsService-RemoveClient-System-Int32- 'ARKanyFryzjerstwa.Services.ClientsService.RemoveClient(System.Int32)')
  - [RemoveClients(clientIds)](#M-ARKanyFryzjerstwa-Services-ClientsService-RemoveClients-System-Collections-Generic-List{System-Int32}- 'ARKanyFryzjerstwa.Services.ClientsService.RemoveClients(System.Collections.Generic.List{System.Int32})')
  - [UpdateClient(client)](#M-ARKanyFryzjerstwa-Services-ClientsService-UpdateClient-ARKanyFryzjerstwa-Models-ClientModel- 'ARKanyFryzjerstwa.Services.ClientsService.UpdateClient(ARKanyFryzjerstwa.Models.ClientModel)')
  - [ValidateClientModel(client)](#M-ARKanyFryzjerstwa-Services-ClientsService-ValidateClientModel-ARKanyFryzjerstwa-Models-ClientModel- 'ARKanyFryzjerstwa.Services.ClientsService.ValidateClientModel(ARKanyFryzjerstwa.Models.ClientModel)')
- [DateTimeExtension](#T-ARKanyFryzjerstwa-Extensions-DateTimeExtension 'ARKanyFryzjerstwa.Extensions.DateTimeExtension')
  - [GetFirstDayOfWeek(dateTime)](#M-ARKanyFryzjerstwa-Extensions-DateTimeExtension-GetFirstDayOfWeek-System-DateTime- 'ARKanyFryzjerstwa.Extensions.DateTimeExtension.GetFirstDayOfWeek(System.DateTime)')
  - [ToDayTitle(date,culture)](#M-ARKanyFryzjerstwa-Extensions-DateTimeExtension-ToDayTitle-System-DateTime,System-String- 'ARKanyFryzjerstwa.Extensions.DateTimeExtension.ToDayTitle(System.DateTime,System.String)')
  - [ToMonthTitle(date,culture)](#M-ARKanyFryzjerstwa-Extensions-DateTimeExtension-ToMonthTitle-System-DateTime,System-String- 'ARKanyFryzjerstwa.Extensions.DateTimeExtension.ToMonthTitle(System.DateTime,System.String)')
- [DecimalExtensions](#T-ARKanyFryzjerstwa-Extensions-DecimalExtensions 'ARKanyFryzjerstwa.Extensions.DecimalExtensions')
  - [ToPriceString(price)](#M-ARKanyFryzjerstwa-Extensions-DecimalExtensions-ToPriceString-System-Decimal- 'ARKanyFryzjerstwa.Extensions.DecimalExtensions.ToPriceString(System.Decimal)')
- [DictionaryExtensions](#T-ARKanyFryzjerstwa-Extensions-DictionaryExtensions 'ARKanyFryzjerstwa.Extensions.DictionaryExtensions')
  - [IsNullOrEmpty\`\`2(dictionary)](#M-ARKanyFryzjerstwa-Extensions-DictionaryExtensions-IsNullOrEmpty``2-System-Collections-Generic-IDictionary{``0,``1}- 'ARKanyFryzjerstwa.Extensions.DictionaryExtensions.IsNullOrEmpty``2(System.Collections.Generic.IDictionary{``0,``1})')
- [Generator](#T-ARKanyFryzjerstwa-Extensions-Generator 'ARKanyFryzjerstwa.Extensions.Generator')
  - [GeneratePassword()](#M-ARKanyFryzjerstwa-Extensions-Generator-GeneratePassword 'ARKanyFryzjerstwa.Extensions.Generator.GeneratePassword')
  - [GenerateVerificationCode(length)](#M-ARKanyFryzjerstwa-Extensions-Generator-GenerateVerificationCode-System-Int32- 'ARKanyFryzjerstwa.Extensions.Generator.GenerateVerificationCode(System.Int32)')
  - [RandomChar(chars)](#M-ARKanyFryzjerstwa-Extensions-Generator-RandomChar-System-String- 'ARKanyFryzjerstwa.Extensions.Generator.RandomChar(System.String)')
- [HomeController](#T-ARKanyFryzjerstwa-Controllers-HomeController 'ARKanyFryzjerstwa.Controllers.HomeController')
  - [Error()](#M-ARKanyFryzjerstwa-Controllers-HomeController-Error 'ARKanyFryzjerstwa.Controllers.HomeController.Error')
  - [GetLowResources()](#M-ARKanyFryzjerstwa-Controllers-HomeController-GetLowResources 'ARKanyFryzjerstwa.Controllers.HomeController.GetLowResources')
  - [GetStats()](#M-ARKanyFryzjerstwa-Controllers-HomeController-GetStats 'ARKanyFryzjerstwa.Controllers.HomeController.GetStats')
  - [GetUserNote()](#M-ARKanyFryzjerstwa-Controllers-HomeController-GetUserNote 'ARKanyFryzjerstwa.Controllers.HomeController.GetUserNote')
  - [Index()](#M-ARKanyFryzjerstwa-Controllers-HomeController-Index 'ARKanyFryzjerstwa.Controllers.HomeController.Index')
  - [SaveUserNote(note)](#M-ARKanyFryzjerstwa-Controllers-HomeController-SaveUserNote-System-String- 'ARKanyFryzjerstwa.Controllers.HomeController.SaveUserNote(System.String)')
- [HsvColor](#T-ARKanyFryzjerstwa-Models-Colors-HsvColor 'ARKanyFryzjerstwa.Models.Colors.HsvColor')
  - [Hue](#P-ARKanyFryzjerstwa-Models-Colors-HsvColor-Hue 'ARKanyFryzjerstwa.Models.Colors.HsvColor.Hue')
  - [Saturation](#P-ARKanyFryzjerstwa-Models-Colors-HsvColor-Saturation 'ARKanyFryzjerstwa.Models.Colors.HsvColor.Saturation')
  - [Value](#P-ARKanyFryzjerstwa-Models-Colors-HsvColor-Value 'ARKanyFryzjerstwa.Models.Colors.HsvColor.Value')
  - [ToHexColor()](#M-ARKanyFryzjerstwa-Models-Colors-HsvColor-ToHexColor 'ARKanyFryzjerstwa.Models.Colors.HsvColor.ToHexColor')
  - [ToRgbColor()](#M-ARKanyFryzjerstwa-Models-Colors-HsvColor-ToRgbColor 'ARKanyFryzjerstwa.Models.Colors.HsvColor.ToRgbColor')
- [IAccountService](#T-ARKanyFryzjerstwa-Services-IServices-IAccountService 'ARKanyFryzjerstwa.Services.IServices.IAccountService')
  - [GetUserNote(employeeId)](#M-ARKanyFryzjerstwa-Services-IServices-IAccountService-GetUserNote-System-String- 'ARKanyFryzjerstwa.Services.IServices.IAccountService.GetUserNote(System.String)')
  - [GetUsernameByLogin(login)](#M-ARKanyFryzjerstwa-Services-IServices-IAccountService-GetUsernameByLogin-System-String- 'ARKanyFryzjerstwa.Services.IServices.IAccountService.GetUsernameByLogin(System.String)')
  - [PasswordReset(model)](#M-ARKanyFryzjerstwa-Services-IServices-IAccountService-PasswordReset-ARKanyFryzjerstwa-Models-PasswordResetModel- 'ARKanyFryzjerstwa.Services.IServices.IAccountService.PasswordReset(ARKanyFryzjerstwa.Models.PasswordResetModel)')
  - [RegisterSalon(model)](#M-ARKanyFryzjerstwa-Services-IServices-IAccountService-RegisterSalon-ARKanyFryzjerstwa-Models-RegisterSalonModel- 'ARKanyFryzjerstwa.Services.IServices.IAccountService.RegisterSalon(ARKanyFryzjerstwa.Models.RegisterSalonModel)')
  - [SaveUserNote(note,employeeId)](#M-ARKanyFryzjerstwa-Services-IServices-IAccountService-SaveUserNote-System-String,System-String- 'ARKanyFryzjerstwa.Services.IServices.IAccountService.SaveUserNote(System.String,System.String)')
  - [SendPasswordResetVerificationCode(login,url)](#M-ARKanyFryzjerstwa-Services-IServices-IAccountService-SendPasswordResetVerificationCode-System-String,Microsoft-AspNetCore-Mvc-IUrlHelper- 'ARKanyFryzjerstwa.Services.IServices.IAccountService.SendPasswordResetVerificationCode(System.String,Microsoft.AspNetCore.Mvc.IUrlHelper)')
- [IAppointmentDao](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao')
  - [AddAppointment(appointment)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-AddAppointment-ARKanyFryzjerstwa-Data-Appointment- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao.AddAppointment(ARKanyFryzjerstwa.Data.Appointment)')
  - [GetAppointmentById(appointmentId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetAppointmentById-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao.GetAppointmentById(System.Int32)')
  - [GetAppointmentsByClientId(clientId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetAppointmentsByClientId-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao.GetAppointmentsByClientId(System.Int32)')
  - [GetAppointmetsByEmployeeIdsAndDate(employees,date)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetAppointmetsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao.GetAppointmetsByEmployeeIdsAndDate(System.Collections.Generic.IList{System.String},System.DateTime)')
  - [GetCompletedAppointmentsByEmployeeIdsAndDate(employeeId,date)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetCompletedAppointmentsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao.GetCompletedAppointmentsByEmployeeIdsAndDate(System.Collections.Generic.IList{System.String},System.DateTime)')
  - [GetNotCanceledAppointmetsByEmployeeIdsAndDate(employees,date)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetNotCanceledAppointmetsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao.GetNotCanceledAppointmetsByEmployeeIdsAndDate(System.Collections.Generic.IList{System.String},System.DateTime)')
  - [GetScheduledAppointmentsByEmployeeIdsAndDate(employees,date)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetScheduledAppointmentsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao.GetScheduledAppointmentsByEmployeeIdsAndDate(System.Collections.Generic.IList{System.String},System.DateTime)')
  - [UpdateAppointment(appointment)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-UpdateAppointment-ARKanyFryzjerstwa-Data-Appointment- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao.UpdateAppointment(ARKanyFryzjerstwa.Data.Appointment)')
  - [UpdateAppointments(appointments)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-UpdateAppointments-System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Appointment}- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IAppointmentDao.UpdateAppointments(System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Appointment})')
- [IAppointmentService](#T-ARKanyFryzjerstwa-Services-IServices-IAppointmentService 'ARKanyFryzjerstwa.Services.IServices.IAppointmentService')
  - [CancelAppointment(appointmentId)](#M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-CancelAppointment-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IAppointmentService.CancelAppointment(System.Int32)')
  - [CompleteAppointment(appointmentCompletionData)](#M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-CompleteAppointment-ARKanyFryzjerstwa-Models-AppointmentCompletionDataModel- 'ARKanyFryzjerstwa.Services.IServices.IAppointmentService.CompleteAppointment(ARKanyFryzjerstwa.Models.AppointmentCompletionDataModel)')
  - [CreateAppointment(appointmentAddModel,authorId,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-CreateAppointment-ARKanyFryzjerstwa-Models-AppointmentAddModel,System-String,System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IAppointmentService.CreateAppointment(ARKanyFryzjerstwa.Models.AppointmentAddModel,System.String,System.Int32)')
  - [DoAppointmentsOverlap(appointmentAddModel)](#M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-DoAppointmentsOverlap-ARKanyFryzjerstwa-Models-AppointmentAddModel- 'ARKanyFryzjerstwa.Services.IServices.IAppointmentService.DoAppointmentsOverlap(ARKanyFryzjerstwa.Models.AppointmentAddModel)')
  - [GetAppointmentCreationData(salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-GetAppointmentCreationData-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IAppointmentService.GetAppointmentCreationData(System.Int32)')
  - [GetAppointmentServiceModel(appointmentId)](#M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-GetAppointmentServiceModel-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IAppointmentService.GetAppointmentServiceModel(System.Int32)')
  - [GetPhoneAndEmail(clientId)](#M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-GetPhoneAndEmail-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IAppointmentService.GetPhoneAndEmail(System.Int32)')
- [IBaseDaoGetters](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IBaseDaoGetters 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IBaseDaoGetters')
- [IBaseDaoSetters](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IBaseDaoSetters 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IBaseDaoSetters')
  - [SetModificationDateTimeToNow()](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IBaseDaoSetters-SetModificationDateTimeToNow 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IBaseDaoSetters.SetModificationDateTimeToNow')
- [IClientDao](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IClientDao')
  - [AddClient(client)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-AddClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IClientDao.AddClient(ARKanyFryzjerstwa.Data.Client)')
  - [GetClientById(clientId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-GetClientById-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IClientDao.GetClientById(System.Int32)')
  - [GetClientsForSalon(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-GetClientsForSalon-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IClientDao.GetClientsForSalon(System.Int32)')
  - [IsClientDuplicate(client)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-IsClientDuplicate-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IClientDao.IsClientDuplicate(ARKanyFryzjerstwa.Data.Client)')
  - [RemoveClient(client)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-RemoveClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IClientDao.RemoveClient(ARKanyFryzjerstwa.Data.Client)')
  - [RemoveClients(clientsToRemove)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-RemoveClients-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Client}- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IClientDao.RemoveClients(System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Client})')
  - [UpdateClient(client)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-UpdateClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IClientDao.UpdateClient(ARKanyFryzjerstwa.Data.Client)')
- [IClientsService](#T-ARKanyFryzjerstwa-Services-IServices-IClientsService 'ARKanyFryzjerstwa.Services.IServices.IClientsService')
  - [ConvertClient(client)](#M-ARKanyFryzjerstwa-Services-IServices-IClientsService-ConvertClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.Services.IServices.IClientsService.ConvertClient(ARKanyFryzjerstwa.Data.Client)')
  - [CreateClient(client)](#M-ARKanyFryzjerstwa-Services-IServices-IClientsService-CreateClient-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.Services.IServices.IClientsService.CreateClient(ARKanyFryzjerstwa.Data.Client)')
  - [GetClientsModel(salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IClientsService-GetClientsModel-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IClientsService.GetClientsModel(System.Int32)')
  - [IsClientDuplicate(clientModel)](#M-ARKanyFryzjerstwa-Services-IServices-IClientsService-IsClientDuplicate-ARKanyFryzjerstwa-Models-ClientModel- 'ARKanyFryzjerstwa.Services.IServices.IClientsService.IsClientDuplicate(ARKanyFryzjerstwa.Models.ClientModel)')
  - [RemoveClient(clientId)](#M-ARKanyFryzjerstwa-Services-IServices-IClientsService-RemoveClient-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IClientsService.RemoveClient(System.Int32)')
  - [RemoveClients(clientIds)](#M-ARKanyFryzjerstwa-Services-IServices-IClientsService-RemoveClients-System-Collections-Generic-List{System-Int32}- 'ARKanyFryzjerstwa.Services.IServices.IClientsService.RemoveClients(System.Collections.Generic.List{System.Int32})')
  - [UpdateClient(client)](#M-ARKanyFryzjerstwa-Services-IServices-IClientsService-UpdateClient-ARKanyFryzjerstwa-Models-ClientModel- 'ARKanyFryzjerstwa.Services.IServices.IClientsService.UpdateClient(ARKanyFryzjerstwa.Models.ClientModel)')
- [IResourceDao](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IResourceDao')
  - [AddResource(resource)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-AddResource-ARKanyFryzjerstwa-Data-Resource- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IResourceDao.AddResource(ARKanyFryzjerstwa.Data.Resource)')
  - [GetResourceById(resourceId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-GetResourceById-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IResourceDao.GetResourceById(System.Int32)')
  - [GetResourcesBySalonId(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-GetResourcesBySalonId-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IResourceDao.GetResourcesBySalonId(System.Int32)')
  - [GetResourcesGettingLow(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-GetResourcesGettingLow-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IResourceDao.GetResourcesGettingLow(System.Int32)')
  - [RemoveResource(resource)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-RemoveResource-ARKanyFryzjerstwa-Data-Resource- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IResourceDao.RemoveResource(ARKanyFryzjerstwa.Data.Resource)')
  - [RemoveResources(resourcesToRemove)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-RemoveResources-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Resource}- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IResourceDao.RemoveResources(System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Resource})')
  - [UpdateResource(resource)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-UpdateResource-ARKanyFryzjerstwa-Data-Resource- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IResourceDao.UpdateResource(ARKanyFryzjerstwa.Data.Resource)')
- [IResourcesService](#T-ARKanyFryzjerstwa-Services-IServices-IResourcesService 'ARKanyFryzjerstwa.Services.IServices.IResourcesService')
  - [AddNewResource(resource,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-AddNewResource-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IResourcesService.AddNewResource(ARKanyFryzjerstwa.Models.ResourceModel,System.Int32)')
  - [GetResourcesGettingLow(salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-GetResourcesGettingLow-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IResourcesService.GetResourcesGettingLow(System.Int32)')
  - [GetResourcesModel(salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-GetResourcesModel-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IResourcesService.GetResourcesModel(System.Int32)')
  - [RemoveResource(resourceId,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-RemoveResource-System-Int32,System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IResourcesService.RemoveResource(System.Int32,System.Int32)')
  - [RemoveResources(resourceIds,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-RemoveResources-System-Collections-Generic-List{System-Int32},System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IResourcesService.RemoveResources(System.Collections.Generic.List{System.Int32},System.Int32)')
  - [UpdateResource(resource,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-UpdateResource-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IResourcesService.UpdateResource(ARKanyFryzjerstwa.Models.ResourceModel,System.Int32)')
  - [UpdateServiceResources(serviceResourceModels)](#M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-UpdateServiceResources-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ResourceUsageModel}- 'ARKanyFryzjerstwa.Services.IServices.IResourcesService.UpdateServiceResources(System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ResourceUsageModel})')
- [ISalonDao](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-ISalonDao 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.ISalonDao')
  - [GetEmployeesColorsForSalon(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-ISalonDao-GetEmployeesColorsForSalon-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.ISalonDao.GetEmployeesColorsForSalon(System.Int32)')
  - [GetServicesForSalon(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-ISalonDao-GetServicesForSalon-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.ISalonDao.GetServicesForSalon(System.Int32)')
  - [InsertSalon(salon)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-ISalonDao-InsertSalon-ARKanyFryzjerstwa-Data-Salon- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.ISalonDao.InsertSalon(ARKanyFryzjerstwa.Data.Salon)')
- [IScheduleService](#T-ARKanyFryzjerstwa-Services-IServices-IScheduleService 'ARKanyFryzjerstwa.Services.IServices.IScheduleService')
  - [GetAppointmentsForWeek(date,employees,forceCacheRefresh,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IScheduleService-GetAppointmentsForWeek-System-DateTime,System-Collections-Generic-IList{System-String},System-Boolean,System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IScheduleService.GetAppointmentsForWeek(System.DateTime,System.Collections.Generic.IList{System.String},System.Boolean,System.Int32)')
  - [GetScheduleDays(date,employeeIds,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IScheduleService-GetScheduleDays-System-DateTime,System-Collections-Generic-IList{System-String},System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IScheduleService.GetScheduleDays(System.DateTime,System.Collections.Generic.IList{System.String},System.Int32)')
  - [GetScheduleModel(salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IScheduleService-GetScheduleModel-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IScheduleService.GetScheduleModel(System.Int32)')
- [IServiceDao](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceDao')
  - [AddService(service)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-AddService-ARKanyFryzjerstwa-Data-Service- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceDao.AddService(ARKanyFryzjerstwa.Data.Service)')
  - [GetActiveServicesForSalon(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-GetActiveServicesForSalon-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceDao.GetActiveServicesForSalon(System.Int32)')
  - [GetServiceById(serviceId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-GetServiceById-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceDao.GetServiceById(System.Int32)')
  - [GetServicesBySalonId(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-GetServicesBySalonId-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceDao.GetServicesBySalonId(System.Int32)')
  - [UpdateService(service)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-UpdateService-ARKanyFryzjerstwa-Data-Service- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceDao.UpdateService(ARKanyFryzjerstwa.Data.Service)')
  - [UpdateServices(services)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Service}- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceDao.UpdateServices(System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Service})')
- [IServiceResourceDao](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceResourceDao 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceResourceDao')
  - [GetServiceResources(serviceId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceResourceDao-GetServiceResources-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceResourceDao.GetServiceResources(System.Int32)')
  - [UpdateServiceResources(resources,serviceId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceResourceDao-UpdateServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IServiceResourceDao.UpdateServiceResources(System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel},System.Int32)')
- [IServicesService](#T-ARKanyFryzjerstwa-Services-IServices-IServicesService 'ARKanyFryzjerstwa.Services.IServices.IServicesService')
  - [AddNewService(service,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IServicesService-AddNewService-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IServicesService.AddNewService(ARKanyFryzjerstwa.Models.ServiceModel,System.Int32)')
  - [GetSalonResources(salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IServicesService-GetSalonResources-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IServicesService.GetSalonResources(System.Int32)')
  - [GetServiceModelById(serviceId)](#M-ARKanyFryzjerstwa-Services-IServices-IServicesService-GetServiceModelById-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IServicesService.GetServiceModelById(System.Int32)')
  - [GetServiceResources(serviceId)](#M-ARKanyFryzjerstwa-Services-IServices-IServicesService-GetServiceResources-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IServicesService.GetServiceResources(System.Int32)')
  - [GetServicesModel(salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IServicesService-GetServicesModel-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IServicesService.GetServicesModel(System.Int32)')
  - [SaveServiceResources(resources,serviceId)](#M-ARKanyFryzjerstwa-Services-IServices-IServicesService-SaveServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IServicesService.SaveServiceResources(System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel},System.Int32)')
  - [UpdateService(service,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IServicesService-UpdateService-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IServicesService.UpdateService(ARKanyFryzjerstwa.Models.ServiceModel,System.Int32)')
  - [UpdateServices(services,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IServicesService-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ServiceModel},System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IServicesService.UpdateServices(System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ServiceModel},System.Int32)')
- [ISettingsService](#T-ARKanyFryzjerstwa-Services-IServices-ISettingsService 'ARKanyFryzjerstwa.Services.IServices.ISettingsService')
  - [AddNewEmployee(model,salonId,url)](#M-ARKanyFryzjerstwa-Services-IServices-ISettingsService-AddNewEmployee-ARKanyFryzjerstwa-Models-EmployeeToAddModel,System-Int32,Microsoft-AspNetCore-Mvc-IUrlHelper- 'ARKanyFryzjerstwa.Services.IServices.ISettingsService.AddNewEmployee(ARKanyFryzjerstwa.Models.EmployeeToAddModel,System.Int32,Microsoft.AspNetCore.Mvc.IUrlHelper)')
  - [GetEmployees(salonId)](#M-ARKanyFryzjerstwa-Services-IServices-ISettingsService-GetEmployees-System-Int32- 'ARKanyFryzjerstwa.Services.IServices.ISettingsService.GetEmployees(System.Int32)')
  - [SaveEmployeeColor(color,employeeId)](#M-ARKanyFryzjerstwa-Services-IServices-ISettingsService-SaveEmployeeColor-System-String,System-String- 'ARKanyFryzjerstwa.Services.IServices.ISettingsService.SaveEmployeeColor(System.String,System.String)')
- [IStatisticsService](#T-ARKanyFryzjerstwa-Services-IServices-IStatisticsService 'ARKanyFryzjerstwa.Services.IServices.IStatisticsService')
  - [GetHomepageStatistics(employeeId,salonId)](#M-ARKanyFryzjerstwa-Services-IServices-IStatisticsService-GetHomepageStatistics-System-String,System-Int32- 'ARKanyFryzjerstwa.Services.IServices.IStatisticsService.GetHomepageStatistics(System.String,System.Int32)')
- [IUserDao](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IUserDao')
  - [GetEmployeesByEmployeeIds(employeeIds)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-GetEmployeesByEmployeeIds-System-Collections-Generic-IList{System-String}- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IUserDao.GetEmployeesByEmployeeIds(System.Collections.Generic.IList{System.String})')
  - [GetEmployeesBySalonId(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-GetEmployeesBySalonId-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IUserDao.GetEmployeesBySalonId(System.Int32)')
  - [GetUserNamesStartsWith(value)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-GetUserNamesStartsWith-System-String- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IUserDao.GetUserNamesStartsWith(System.String)')
  - [GetUserNote(employeeId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-GetUserNote-System-String- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IUserDao.GetUserNote(System.String)')
  - [SaveUserNote(note,employeeId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-SaveUserNote-System-String,System-String- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IUserDao.SaveUserNote(System.String,System.String)')
  - [UpdateEmployeeColor(employeeId,color)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-UpdateEmployeeColor-System-String,System-String- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IUserDao.UpdateEmployeeColor(System.String,System.String)')
- [IVerificationCodeDao](#T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IVerificationCodeDao 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IVerificationCodeDao')
  - [AddVerificationCode(code,userId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IVerificationCodeDao-AddVerificationCode-System-String,System-String- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IVerificationCodeDao.AddVerificationCode(System.String,System.String)')
  - [GetLastUserVerificationCode(userId)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IVerificationCodeDao-GetLastUserVerificationCode-System-String- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IVerificationCodeDao.GetLastUserVerificationCode(System.String)')
  - [Update(verificationCode)](#M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IVerificationCodeDao-Update-ARKanyFryzjerstwa-Data-VerificationCode- 'ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IVerificationCodeDao.Update(ARKanyFryzjerstwa.Data.VerificationCode)')
- [IdentityErrorResources](#T-ARKanyFryzjerstwa-Resources-IdentityErrorResources 'ARKanyFryzjerstwa.Resources.IdentityErrorResources')
  - [ConcurrencyFailure](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-ConcurrencyFailure 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.ConcurrencyFailure')
  - [Culture](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-Culture 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.Culture')
  - [DefaultError](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DefaultError 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DefaultError')
  - [DuplicateEmail](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateEmail 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DuplicateEmail')
  - [DuplicateRoleName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateRoleName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DuplicateRoleName')
  - [DuplicateUserName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateUserName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DuplicateUserName')
  - [InvalidEmail](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidEmail 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidEmail')
  - [InvalidRoleName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidRoleName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidRoleName')
  - [InvalidToken](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidToken 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidToken')
  - [InvalidUserName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidUserName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidUserName')
  - [LoginAlreadyAssociated](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-LoginAlreadyAssociated 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.LoginAlreadyAssociated')
  - [PasswordMismatch](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordMismatch 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordMismatch')
  - [PasswordRequiresDigit](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresDigit 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordRequiresDigit')
  - [PasswordRequiresLower](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresLower 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordRequiresLower')
  - [PasswordRequiresNonAlphanumeric](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresNonAlphanumeric 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordRequiresNonAlphanumeric')
  - [PasswordRequiresUniqueChars](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresUniqueChars 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordRequiresUniqueChars')
  - [PasswordRequiresUpper](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresUpper 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordRequiresUpper')
  - [PasswordTooShort](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordTooShort 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordTooShort')
  - [RecoveryCodeRedemptionFailed](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-RecoveryCodeRedemptionFailed 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.RecoveryCodeRedemptionFailed')
  - [ResourceManager](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-ResourceManager 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.ResourceManager')
  - [UserAlreadyHasPassword](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserAlreadyHasPassword 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.UserAlreadyHasPassword')
  - [UserAlreadyInRole](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserAlreadyInRole 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.UserAlreadyInRole')
  - [UserLockoutNotEnabled](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserLockoutNotEnabled 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.UserLockoutNotEnabled')
  - [UserNotInRole](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserNotInRole 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.UserNotInRole')
  - [FormatDuplicateEmail(email)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatDuplicateEmail-System-String- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatDuplicateEmail(System.String)')
  - [FormatDuplicateRoleName(roleName)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatDuplicateRoleName-System-String- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatDuplicateRoleName(System.String)')
  - [FormatDuplicateUserName(userName)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatDuplicateUserName-System-String- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatDuplicateUserName(System.String)')
  - [FormatInvalidEmail(email)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatInvalidEmail-System-String- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatInvalidEmail(System.String)')
  - [FormatInvalidRoleName(roleName)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatInvalidRoleName-System-String- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatInvalidRoleName(System.String)')
  - [FormatInvalidUserName(userName)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatInvalidUserName-System-String- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatInvalidUserName(System.String)')
  - [FormatPasswordRequiresUniqueChars(uniqueChars)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatPasswordRequiresUniqueChars-System-Int32- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatPasswordRequiresUniqueChars(System.Int32)')
  - [FormatPasswordTooShort(length)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatPasswordTooShort-System-Int32- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatPasswordTooShort(System.Int32)')
  - [FormatUserAlreadyInRole(roleName)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatUserAlreadyInRole-System-String- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatUserAlreadyInRole(System.String)')
  - [FormatUserNotInRole(roleName)](#M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatUserNotInRole-System-String- 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.FormatUserNotInRole(System.String)')
- [IntExtensions](#T-ARKanyFryzjerstwa-Extensions-IntExtensions 'ARKanyFryzjerstwa.Extensions.IntExtensions')
  - [MinutesToDurationString(minutes)](#M-ARKanyFryzjerstwa-Extensions-IntExtensions-MinutesToDurationString-System-Int32- 'ARKanyFryzjerstwa.Extensions.IntExtensions.MinutesToDurationString(System.Int32)')
  - [ToHex(number)](#M-ARKanyFryzjerstwa-Extensions-IntExtensions-ToHex-System-Int32- 'ARKanyFryzjerstwa.Extensions.IntExtensions.ToHex(System.Int32)')
  - [ToLeftPadHex(number,width,padChar)](#M-ARKanyFryzjerstwa-Extensions-IntExtensions-ToLeftPadHex-System-Int32,System-Int32,System-Char- 'ARKanyFryzjerstwa.Extensions.IntExtensions.ToLeftPadHex(System.Int32,System.Int32,System.Char)')
- [ListExtension](#T-ARKanyFryzjerstwa-Extensions-ListExtension 'ARKanyFryzjerstwa.Extensions.ListExtension')
  - [IsEqualTo\`\`1(list1,list2)](#M-ARKanyFryzjerstwa-Extensions-ListExtension-IsEqualTo``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IList{``0}- 'ARKanyFryzjerstwa.Extensions.ListExtension.IsEqualTo``1(System.Collections.Generic.IList{``0},System.Collections.Generic.IList{``0})')
  - [IsNullOrEmpty\`\`1(list)](#M-ARKanyFryzjerstwa-Extensions-ListExtension-IsNullOrEmpty``1-System-Collections-Generic-IList{``0}- 'ARKanyFryzjerstwa.Extensions.ListExtension.IsNullOrEmpty``1(System.Collections.Generic.IList{``0})')
  - [Shuffle\`\`1(values)](#M-ARKanyFryzjerstwa-Extensions-ListExtension-Shuffle``1-System-Collections-Generic-IEnumerable{``0}- 'ARKanyFryzjerstwa.Extensions.ListExtension.Shuffle``1(System.Collections.Generic.IEnumerable{``0})')
- [MailService](#T-ARKanyFryzjerstwa-Services-MailService 'ARKanyFryzjerstwa.Services.MailService')
  - [Send(to,subject,body)](#M-ARKanyFryzjerstwa-Services-MailService-Send-System-String,System-String,System-String- 'ARKanyFryzjerstwa.Services.MailService.Send(System.String,System.String,System.String)')
  - [Send(to,cc,bcc,subject,body)](#M-ARKanyFryzjerstwa-Services-MailService-Send-System-Collections-Generic-IList{System-String},System-Collections-Generic-IList{System-String},System-Collections-Generic-IList{System-String},System-String,System-String- 'ARKanyFryzjerstwa.Services.MailService.Send(System.Collections.Generic.IList{System.String},System.Collections.Generic.IList{System.String},System.Collections.Generic.IList{System.String},System.String,System.String)')
  - [Send(mail)](#M-ARKanyFryzjerstwa-Services-MailService-Send-MimeKit-MimeMessage- 'ARKanyFryzjerstwa.Services.MailService.Send(MimeKit.MimeMessage)')
  - [SendCreationEmployeeAccountMailBody(user,password)](#M-ARKanyFryzjerstwa-Services-MailService-SendCreationEmployeeAccountMailBody-ARKanyFryzjerstwa-Data-User,System-String,System-String- 'ARKanyFryzjerstwa.Services.MailService.SendCreationEmployeeAccountMailBody(ARKanyFryzjerstwa.Data.User,System.String,System.String)')
  - [SendResetPasswordVerificationCodeMail(user,code,expirationDate,url)](#M-ARKanyFryzjerstwa-Services-MailService-SendResetPasswordVerificationCodeMail-ARKanyFryzjerstwa-Data-User,System-String,System-DateTime,System-String- 'ARKanyFryzjerstwa.Services.MailService.SendResetPasswordVerificationCodeMail(ARKanyFryzjerstwa.Data.User,System.String,System.DateTime,System.String)')
- [MenuHelper](#T-ARKanyFryzjerstwa-Extensions-MenuHelper 'ARKanyFryzjerstwa.Extensions.MenuHelper')
  - [GetTabClassActive(currentPath,tabPath)](#M-ARKanyFryzjerstwa-Extensions-MenuHelper-GetTabClassActive-System-String,System-String- 'ARKanyFryzjerstwa.Extensions.MenuHelper.GetTabClassActive(System.String,System.String)')
- [PolishIdentityErrorDescriber](#T-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber')
  - [ConcurrencyFailure()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-ConcurrencyFailure 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.ConcurrencyFailure')
  - [DefaultError()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-DefaultError 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.DefaultError')
  - [DuplicateEmail(email)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-DuplicateEmail-System-String- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.DuplicateEmail(System.String)')
  - [DuplicateRoleName(role)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-DuplicateRoleName-System-String- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.DuplicateRoleName(System.String)')
  - [DuplicateUserName(userName)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-DuplicateUserName-System-String- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.DuplicateUserName(System.String)')
  - [InvalidEmail(email)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-InvalidEmail-System-String- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.InvalidEmail(System.String)')
  - [InvalidRoleName(role)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-InvalidRoleName-System-String- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.InvalidRoleName(System.String)')
  - [InvalidToken()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-InvalidToken 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.InvalidToken')
  - [InvalidUserName(userName)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-InvalidUserName-System-String- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.InvalidUserName(System.String)')
  - [LoginAlreadyAssociated()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-LoginAlreadyAssociated 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.LoginAlreadyAssociated')
  - [PasswordMismatch()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordMismatch 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.PasswordMismatch')
  - [PasswordRequiresDigit()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresDigit 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.PasswordRequiresDigit')
  - [PasswordRequiresLower()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresLower 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.PasswordRequiresLower')
  - [PasswordRequiresNonAlphanumeric()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresNonAlphanumeric 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.PasswordRequiresNonAlphanumeric')
  - [PasswordRequiresUniqueChars(uniqueChars)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresUniqueChars-System-Int32- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.PasswordRequiresUniqueChars(System.Int32)')
  - [PasswordRequiresUpper()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresUpper 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.PasswordRequiresUpper')
  - [PasswordTooShort(length)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordTooShort-System-Int32- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.PasswordTooShort(System.Int32)')
  - [RecoveryCodeRedemptionFailed()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-RecoveryCodeRedemptionFailed 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.RecoveryCodeRedemptionFailed')
  - [UserAlreadyHasPassword()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-UserAlreadyHasPassword 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.UserAlreadyHasPassword')
  - [UserAlreadyInRole(role)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-UserAlreadyInRole-System-String- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.UserAlreadyInRole(System.String)')
  - [UserLockoutNotEnabled()](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-UserLockoutNotEnabled 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.UserLockoutNotEnabled')
  - [UserNotInRole(role)](#M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-UserNotInRole-System-String- 'ARKanyFryzjerstwa.Data.PolishIdentityErrorDescriber.UserNotInRole(System.String)')
- [ResourceDao](#T-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao 'ARKanyFryzjerstwa.DataAccessObjects.ResourceDao')
  - [AddResource(resource)](#M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-AddResource-ARKanyFryzjerstwa-Data-Resource- 'ARKanyFryzjerstwa.DataAccessObjects.ResourceDao.AddResource(ARKanyFryzjerstwa.Data.Resource)')
  - [GetResourceById(resourceId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-GetResourceById-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ResourceDao.GetResourceById(System.Int32)')
  - [GetResourcesBySalonId(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-GetResourcesBySalonId-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ResourceDao.GetResourcesBySalonId(System.Int32)')
  - [GetResourcesGettingLow(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-GetResourcesGettingLow-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ResourceDao.GetResourcesGettingLow(System.Int32)')
  - [RemoveResource(resource)](#M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-RemoveResource-ARKanyFryzjerstwa-Data-Resource- 'ARKanyFryzjerstwa.DataAccessObjects.ResourceDao.RemoveResource(ARKanyFryzjerstwa.Data.Resource)')
  - [RemoveResources(resourcesToRemove)](#M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-RemoveResources-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Resource}- 'ARKanyFryzjerstwa.DataAccessObjects.ResourceDao.RemoveResources(System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Resource})')
  - [UpdateResource(resource)](#M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-UpdateResource-ARKanyFryzjerstwa-Data-Resource- 'ARKanyFryzjerstwa.DataAccessObjects.ResourceDao.UpdateResource(ARKanyFryzjerstwa.Data.Resource)')
- [ResourcesController](#T-ARKanyFryzjerstwa-Controllers-ResourcesController 'ARKanyFryzjerstwa.Controllers.ResourcesController')
  - [AddNewResource(resource)](#M-ARKanyFryzjerstwa-Controllers-ResourcesController-AddNewResource-ARKanyFryzjerstwa-Models-ResourceModel- 'ARKanyFryzjerstwa.Controllers.ResourcesController.AddNewResource(ARKanyFryzjerstwa.Models.ResourceModel)')
  - [Index()](#M-ARKanyFryzjerstwa-Controllers-ResourcesController-Index 'ARKanyFryzjerstwa.Controllers.ResourcesController.Index')
  - [RemoveResource(resourceId)](#M-ARKanyFryzjerstwa-Controllers-ResourcesController-RemoveResource-System-Int32- 'ARKanyFryzjerstwa.Controllers.ResourcesController.RemoveResource(System.Int32)')
  - [RemoveResources(resourcesIds)](#M-ARKanyFryzjerstwa-Controllers-ResourcesController-RemoveResources-System-Collections-Generic-List{System-Int32}- 'ARKanyFryzjerstwa.Controllers.ResourcesController.RemoveResources(System.Collections.Generic.List{System.Int32})')
  - [UpdateResource(resource)](#M-ARKanyFryzjerstwa-Controllers-ResourcesController-UpdateResource-ARKanyFryzjerstwa-Models-ResourceModel- 'ARKanyFryzjerstwa.Controllers.ResourcesController.UpdateResource(ARKanyFryzjerstwa.Models.ResourceModel)')
- [ResourcesService](#T-ARKanyFryzjerstwa-Services-ResourcesService 'ARKanyFryzjerstwa.Services.ResourcesService')
  - [AddNewResource(resource,salonId)](#M-ARKanyFryzjerstwa-Services-ResourcesService-AddNewResource-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32- 'ARKanyFryzjerstwa.Services.ResourcesService.AddNewResource(ARKanyFryzjerstwa.Models.ResourceModel,System.Int32)')
  - [ConvertResource(resource)](#M-ARKanyFryzjerstwa-Services-ResourcesService-ConvertResource-ARKanyFryzjerstwa-Data-Resource- 'ARKanyFryzjerstwa.Services.ResourcesService.ConvertResource(ARKanyFryzjerstwa.Data.Resource)')
  - [ConvertResourceModel(resource,salonId)](#M-ARKanyFryzjerstwa-Services-ResourcesService-ConvertResourceModel-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32- 'ARKanyFryzjerstwa.Services.ResourcesService.ConvertResourceModel(ARKanyFryzjerstwa.Models.ResourceModel,System.Int32)')
  - [ConvertServiceResource(serviceResource)](#M-ARKanyFryzjerstwa-Services-ResourcesService-ConvertServiceResource-ARKanyFryzjerstwa-Data-ServiceResource- 'ARKanyFryzjerstwa.Services.ResourcesService.ConvertServiceResource(ARKanyFryzjerstwa.Data.ServiceResource)')
  - [ConvertServiceResources(serviceResources)](#M-ARKanyFryzjerstwa-Services-ResourcesService-ConvertServiceResources-System-Collections-Generic-ICollection{ARKanyFryzjerstwa-Data-ServiceResource}- 'ARKanyFryzjerstwa.Services.ResourcesService.ConvertServiceResources(System.Collections.Generic.ICollection{ARKanyFryzjerstwa.Data.ServiceResource})')
  - [GetResourcesGettingLow(salonId)](#M-ARKanyFryzjerstwa-Services-ResourcesService-GetResourcesGettingLow-System-Int32- 'ARKanyFryzjerstwa.Services.ResourcesService.GetResourcesGettingLow(System.Int32)')
  - [GetResourcesModel(salonId)](#M-ARKanyFryzjerstwa-Services-ResourcesService-GetResourcesModel-System-Int32- 'ARKanyFryzjerstwa.Services.ResourcesService.GetResourcesModel(System.Int32)')
  - [RemoveResource(resourceId,salonId)](#M-ARKanyFryzjerstwa-Services-ResourcesService-RemoveResource-System-Int32,System-Int32- 'ARKanyFryzjerstwa.Services.ResourcesService.RemoveResource(System.Int32,System.Int32)')
  - [RemoveResources(resourceIds,salonId)](#M-ARKanyFryzjerstwa-Services-ResourcesService-RemoveResources-System-Collections-Generic-List{System-Int32},System-Int32- 'ARKanyFryzjerstwa.Services.ResourcesService.RemoveResources(System.Collections.Generic.List{System.Int32},System.Int32)')
  - [UpdateResource(resource,salonId)](#M-ARKanyFryzjerstwa-Services-ResourcesService-UpdateResource-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32- 'ARKanyFryzjerstwa.Services.ResourcesService.UpdateResource(ARKanyFryzjerstwa.Models.ResourceModel,System.Int32)')
  - [UpdateServiceResources(serviceResourceModels)](#M-ARKanyFryzjerstwa-Services-ResourcesService-UpdateServiceResources-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ResourceUsageModel}- 'ARKanyFryzjerstwa.Services.ResourcesService.UpdateServiceResources(System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ResourceUsageModel})')
  - [ValidateResourceModel(resource)](#M-ARKanyFryzjerstwa-Services-ResourcesService-ValidateResourceModel-ARKanyFryzjerstwa-Models-ResourceModel- 'ARKanyFryzjerstwa.Services.ResourcesService.ValidateResourceModel(ARKanyFryzjerstwa.Models.ResourceModel)')
- [RgbColor](#T-ARKanyFryzjerstwa-Models-Colors-RgbColor 'ARKanyFryzjerstwa.Models.Colors.RgbColor')
  - [Blue](#P-ARKanyFryzjerstwa-Models-Colors-RgbColor-Blue 'ARKanyFryzjerstwa.Models.Colors.RgbColor.Blue')
  - [Green](#P-ARKanyFryzjerstwa-Models-Colors-RgbColor-Green 'ARKanyFryzjerstwa.Models.Colors.RgbColor.Green')
  - [Red](#P-ARKanyFryzjerstwa-Models-Colors-RgbColor-Red 'ARKanyFryzjerstwa.Models.Colors.RgbColor.Red')
  - [Set(red,green,blue)](#M-ARKanyFryzjerstwa-Models-Colors-RgbColor-Set-System-Int32,System-Int32,System-Int32- 'ARKanyFryzjerstwa.Models.Colors.RgbColor.Set(System.Int32,System.Int32,System.Int32)')
  - [ToHsvColor()](#M-ARKanyFryzjerstwa-Models-Colors-RgbColor-ToHsvColor 'ARKanyFryzjerstwa.Models.Colors.RgbColor.ToHsvColor')
- [RolesFactory](#T-ARKanyFryzjerstwa-Extensions-RolesFactory 'ARKanyFryzjerstwa.Extensions.RolesFactory')
  - [GetName(role)](#M-ARKanyFryzjerstwa-Extensions-RolesFactory-GetName-ARKanyFryzjerstwa-Extensions-Role- 'ARKanyFryzjerstwa.Extensions.RolesFactory.GetName(ARKanyFryzjerstwa.Extensions.Role)')
- [SalonDao](#T-ARKanyFryzjerstwa-DataAccessObjects-SalonDao 'ARKanyFryzjerstwa.DataAccessObjects.SalonDao')
  - [GetEmployeesColorsForSalon(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-SalonDao-GetEmployeesColorsForSalon-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.SalonDao.GetEmployeesColorsForSalon(System.Int32)')
  - [GetServicesForSalon(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-SalonDao-GetServicesForSalon-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.SalonDao.GetServicesForSalon(System.Int32)')
  - [InsertSalon(salon)](#M-ARKanyFryzjerstwa-DataAccessObjects-SalonDao-InsertSalon-ARKanyFryzjerstwa-Data-Salon- 'ARKanyFryzjerstwa.DataAccessObjects.SalonDao.InsertSalon(ARKanyFryzjerstwa.Data.Salon)')
- [ScheduleController](#T-ARKanyFryzjerstwa-Controllers-ScheduleController 'ARKanyFryzjerstwa.Controllers.ScheduleController')
  - [CancelAppointment(appointmentId)](#M-ARKanyFryzjerstwa-Controllers-ScheduleController-CancelAppointment-System-Int32- 'ARKanyFryzjerstwa.Controllers.ScheduleController.CancelAppointment(System.Int32)')
  - [CompleteAppointment(appointmentCompletionData)](#M-ARKanyFryzjerstwa-Controllers-ScheduleController-CompleteAppointment-ARKanyFryzjerstwa-Models-AppointmentCompletionDataModel- 'ARKanyFryzjerstwa.Controllers.ScheduleController.CompleteAppointment(ARKanyFryzjerstwa.Models.AppointmentCompletionDataModel)')
  - [GetAllResources()](#M-ARKanyFryzjerstwa-Controllers-ScheduleController-GetAllResources 'ARKanyFryzjerstwa.Controllers.ScheduleController.GetAllResources')
  - [GetAppointmentServiceModel(appointmentId)](#M-ARKanyFryzjerstwa-Controllers-ScheduleController-GetAppointmentServiceModel-System-Int32- 'ARKanyFryzjerstwa.Controllers.ScheduleController.GetAppointmentServiceModel(System.Int32)')
  - [GetAppointmentsForWeek(date,employees,forceCacheRefresh)](#M-ARKanyFryzjerstwa-Controllers-ScheduleController-GetAppointmentsForWeek-System-DateTime,System-Collections-Generic-IList{System-String},System-Boolean- 'ARKanyFryzjerstwa.Controllers.ScheduleController.GetAppointmentsForWeek(System.DateTime,System.Collections.Generic.IList{System.String},System.Boolean)')
  - [Index()](#M-ARKanyFryzjerstwa-Controllers-ScheduleController-Index 'ARKanyFryzjerstwa.Controllers.ScheduleController.Index')
- [ScheduleService](#T-ARKanyFryzjerstwa-Services-ScheduleService 'ARKanyFryzjerstwa.Services.ScheduleService')
  - [ConvertAppointments(appointments,clients,employees,services,startHour,endHour)](#M-ARKanyFryzjerstwa-Services-ScheduleService-ConvertAppointments-System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Appointment},System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Client},System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-User},System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Service},System-Int32@,System-Int32@- 'ARKanyFryzjerstwa.Services.ScheduleService.ConvertAppointments(System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Appointment},System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Client},System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.User},System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Service},System.Int32@,System.Int32@)')
  - [GetAppointmentsForWeek(date,employees,forceCacheRefresh,salonId)](#M-ARKanyFryzjerstwa-Services-ScheduleService-GetAppointmentsForWeek-System-DateTime,System-Collections-Generic-IList{System-String},System-Boolean,System-Int32- 'ARKanyFryzjerstwa.Services.ScheduleService.GetAppointmentsForWeek(System.DateTime,System.Collections.Generic.IList{System.String},System.Boolean,System.Int32)')
  - [GetScheduleDays(date,employeeIds,salonId)](#M-ARKanyFryzjerstwa-Services-ScheduleService-GetScheduleDays-System-DateTime,System-Collections-Generic-IList{System-String},System-Int32- 'ARKanyFryzjerstwa.Services.ScheduleService.GetScheduleDays(System.DateTime,System.Collections.Generic.IList{System.String},System.Int32)')
  - [GetScheduleModel(salonId)](#M-ARKanyFryzjerstwa-Services-ScheduleService-GetScheduleModel-System-Int32- 'ARKanyFryzjerstwa.Services.ScheduleService.GetScheduleModel(System.Int32)')
- [ServiceDao](#T-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao 'ARKanyFryzjerstwa.DataAccessObjects.ServiceDao')
  - [AddService(service)](#M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-AddService-ARKanyFryzjerstwa-Data-Service- 'ARKanyFryzjerstwa.DataAccessObjects.ServiceDao.AddService(ARKanyFryzjerstwa.Data.Service)')
  - [GetActiveServicesForSalon(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-GetActiveServicesForSalon-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ServiceDao.GetActiveServicesForSalon(System.Int32)')
  - [GetServiceById(serviceId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-GetServiceById-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ServiceDao.GetServiceById(System.Int32)')
  - [GetServicesBySalonId(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-GetServicesBySalonId-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ServiceDao.GetServicesBySalonId(System.Int32)')
  - [UpdateService(service)](#M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-UpdateService-ARKanyFryzjerstwa-Data-Service- 'ARKanyFryzjerstwa.DataAccessObjects.ServiceDao.UpdateService(ARKanyFryzjerstwa.Data.Service)')
  - [UpdateServices(services)](#M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Service}- 'ARKanyFryzjerstwa.DataAccessObjects.ServiceDao.UpdateServices(System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Service})')
- [ServiceResourceDao](#T-ARKanyFryzjerstwa-DataAccessObjects-ServiceResourceDao 'ARKanyFryzjerstwa.DataAccessObjects.ServiceResourceDao')
  - [GetServiceResources(serviceId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ServiceResourceDao-GetServiceResources-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ServiceResourceDao.GetServiceResources(System.Int32)')
  - [UpdateServiceResources(resources,serviceId)](#M-ARKanyFryzjerstwa-DataAccessObjects-ServiceResourceDao-UpdateServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.ServiceResourceDao.UpdateServiceResources(System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel},System.Int32)')
- [ServicesController](#T-ARKanyFryzjerstwa-Controllers-ServicesController 'ARKanyFryzjerstwa.Controllers.ServicesController')
  - [AddNewService(service)](#M-ARKanyFryzjerstwa-Controllers-ServicesController-AddNewService-ARKanyFryzjerstwa-Models-ServiceModel- 'ARKanyFryzjerstwa.Controllers.ServicesController.AddNewService(ARKanyFryzjerstwa.Models.ServiceModel)')
  - [GetSalonResources()](#M-ARKanyFryzjerstwa-Controllers-ServicesController-GetSalonResources 'ARKanyFryzjerstwa.Controllers.ServicesController.GetSalonResources')
  - [GetServiceResources(serviceId)](#M-ARKanyFryzjerstwa-Controllers-ServicesController-GetServiceResources-System-Int32- 'ARKanyFryzjerstwa.Controllers.ServicesController.GetServiceResources(System.Int32)')
  - [Index()](#M-ARKanyFryzjerstwa-Controllers-ServicesController-Index 'ARKanyFryzjerstwa.Controllers.ServicesController.Index')
  - [SaveServiceResources(resources,serviceId)](#M-ARKanyFryzjerstwa-Controllers-ServicesController-SaveServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32- 'ARKanyFryzjerstwa.Controllers.ServicesController.SaveServiceResources(System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel},System.Int32)')
  - [UpdateServiceData(service)](#M-ARKanyFryzjerstwa-Controllers-ServicesController-UpdateServiceData-ARKanyFryzjerstwa-Models-ServiceModel- 'ARKanyFryzjerstwa.Controllers.ServicesController.UpdateServiceData(ARKanyFryzjerstwa.Models.ServiceModel)')
  - [UpdateServices(services)](#M-ARKanyFryzjerstwa-Controllers-ServicesController-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ServiceModel}- 'ARKanyFryzjerstwa.Controllers.ServicesController.UpdateServices(System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ServiceModel})')
- [ServicesService](#T-ARKanyFryzjerstwa-Services-ServicesService 'ARKanyFryzjerstwa.Services.ServicesService')
  - [AddNewService(service,salonId)](#M-ARKanyFryzjerstwa-Services-ServicesService-AddNewService-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32- 'ARKanyFryzjerstwa.Services.ServicesService.AddNewService(ARKanyFryzjerstwa.Models.ServiceModel,System.Int32)')
  - [ConvertService(service)](#M-ARKanyFryzjerstwa-Services-ServicesService-ConvertService-ARKanyFryzjerstwa-Data-Service- 'ARKanyFryzjerstwa.Services.ServicesService.ConvertService(ARKanyFryzjerstwa.Data.Service)')
  - [ConvertServiceModel(service,salonId)](#M-ARKanyFryzjerstwa-Services-ServicesService-ConvertServiceModel-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32- 'ARKanyFryzjerstwa.Services.ServicesService.ConvertServiceModel(ARKanyFryzjerstwa.Models.ServiceModel,System.Int32)')
  - [GetSalonResources(salonId)](#M-ARKanyFryzjerstwa-Services-ServicesService-GetSalonResources-System-Int32- 'ARKanyFryzjerstwa.Services.ServicesService.GetSalonResources(System.Int32)')
  - [GetServiceModelById(serviceId)](#M-ARKanyFryzjerstwa-Services-ServicesService-GetServiceModelById-System-Int32- 'ARKanyFryzjerstwa.Services.ServicesService.GetServiceModelById(System.Int32)')
  - [GetServiceResources(serviceId)](#M-ARKanyFryzjerstwa-Services-ServicesService-GetServiceResources-System-Int32- 'ARKanyFryzjerstwa.Services.ServicesService.GetServiceResources(System.Int32)')
  - [GetServicesModel(salonId)](#M-ARKanyFryzjerstwa-Services-ServicesService-GetServicesModel-System-Int32- 'ARKanyFryzjerstwa.Services.ServicesService.GetServicesModel(System.Int32)')
  - [SaveServiceResources(resources,serviceId)](#M-ARKanyFryzjerstwa-Services-ServicesService-SaveServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32- 'ARKanyFryzjerstwa.Services.ServicesService.SaveServiceResources(System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel},System.Int32)')
  - [UpdateService(service,salonId)](#M-ARKanyFryzjerstwa-Services-ServicesService-UpdateService-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32- 'ARKanyFryzjerstwa.Services.ServicesService.UpdateService(ARKanyFryzjerstwa.Models.ServiceModel,System.Int32)')
  - [UpdateServices(services,salonId)](#M-ARKanyFryzjerstwa-Services-ServicesService-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ServiceModel},System-Int32- 'ARKanyFryzjerstwa.Services.ServicesService.UpdateServices(System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ServiceModel},System.Int32)')
  - [ValidateServiceModel(service)](#M-ARKanyFryzjerstwa-Services-ServicesService-ValidateServiceModel-ARKanyFryzjerstwa-Models-ServiceModel- 'ARKanyFryzjerstwa.Services.ServicesService.ValidateServiceModel(ARKanyFryzjerstwa.Models.ServiceModel)')
- [SessionExtensions](#T-ARKanyFryzjerstwa-Extensions-SessionExtensions 'ARKanyFryzjerstwa.Extensions.SessionExtensions')
  - [Get\`\`1(session,key)](#M-ARKanyFryzjerstwa-Extensions-SessionExtensions-Get``1-Microsoft-AspNetCore-Http-ISession,System-String- 'ARKanyFryzjerstwa.Extensions.SessionExtensions.Get``1(Microsoft.AspNetCore.Http.ISession,System.String)')
  - [Set\`\`1(session,key,value)](#M-ARKanyFryzjerstwa-Extensions-SessionExtensions-Set``1-Microsoft-AspNetCore-Http-ISession,System-String,``0- 'ARKanyFryzjerstwa.Extensions.SessionExtensions.Set``1(Microsoft.AspNetCore.Http.ISession,System.String,``0)')
- [SettingsController](#T-ARKanyFryzjerstwa-Controllers-SettingsController 'ARKanyFryzjerstwa.Controllers.SettingsController')
  - [AddNewEmployee(model)](#M-ARKanyFryzjerstwa-Controllers-SettingsController-AddNewEmployee-ARKanyFryzjerstwa-Models-EmployeeToAddModel- 'ARKanyFryzjerstwa.Controllers.SettingsController.AddNewEmployee(ARKanyFryzjerstwa.Models.EmployeeToAddModel)')
  - [GetEmployees()](#M-ARKanyFryzjerstwa-Controllers-SettingsController-GetEmployees 'ARKanyFryzjerstwa.Controllers.SettingsController.GetEmployees')
  - [Index()](#M-ARKanyFryzjerstwa-Controllers-SettingsController-Index 'ARKanyFryzjerstwa.Controllers.SettingsController.Index')
  - [SaveEmployeeColor(color,employeeId)](#M-ARKanyFryzjerstwa-Controllers-SettingsController-SaveEmployeeColor-System-String,System-String- 'ARKanyFryzjerstwa.Controllers.SettingsController.SaveEmployeeColor(System.String,System.String)')
- [SettingsService](#T-ARKanyFryzjerstwa-Services-SettingsService 'ARKanyFryzjerstwa.Services.SettingsService')
  - [AddNewEmployee(model,salonId,url)](#M-ARKanyFryzjerstwa-Services-SettingsService-AddNewEmployee-ARKanyFryzjerstwa-Models-EmployeeToAddModel,System-Int32,Microsoft-AspNetCore-Mvc-IUrlHelper- 'ARKanyFryzjerstwa.Services.SettingsService.AddNewEmployee(ARKanyFryzjerstwa.Models.EmployeeToAddModel,System.Int32,Microsoft.AspNetCore.Mvc.IUrlHelper)')
  - [ConvertToEmployeeModel(employee)](#M-ARKanyFryzjerstwa-Services-SettingsService-ConvertToEmployeeModel-ARKanyFryzjerstwa-Data-User- 'ARKanyFryzjerstwa.Services.SettingsService.ConvertToEmployeeModel(ARKanyFryzjerstwa.Data.User)')
  - [GenerateEmployeeColor(salonId)](#M-ARKanyFryzjerstwa-Services-SettingsService-GenerateEmployeeColor-System-Int32- 'ARKanyFryzjerstwa.Services.SettingsService.GenerateEmployeeColor(System.Int32)')
  - [GenerateEmployeeUserName(model)](#M-ARKanyFryzjerstwa-Services-SettingsService-GenerateEmployeeUserName-ARKanyFryzjerstwa-Models-EmployeeToAddModel- 'ARKanyFryzjerstwa.Services.SettingsService.GenerateEmployeeUserName(ARKanyFryzjerstwa.Models.EmployeeToAddModel)')
  - [GetEmployees(salonId)](#M-ARKanyFryzjerstwa-Services-SettingsService-GetEmployees-System-Int32- 'ARKanyFryzjerstwa.Services.SettingsService.GetEmployees(System.Int32)')
  - [SaveEmployeeColor(color,employeeId)](#M-ARKanyFryzjerstwa-Services-SettingsService-SaveEmployeeColor-System-String,System-String- 'ARKanyFryzjerstwa.Services.SettingsService.SaveEmployeeColor(System.String,System.String)')
- [StatisticsService](#T-ARKanyFryzjerstwa-Services-StatisticsService 'ARKanyFryzjerstwa.Services.StatisticsService')
  - [GetEmployeesAppointmentsCount(employees,dates)](#M-ARKanyFryzjerstwa-Services-StatisticsService-GetEmployeesAppointmentsCount-System-Collections-Generic-List{System-String},System-Collections-Generic-List{System-DateTime}- 'ARKanyFryzjerstwa.Services.StatisticsService.GetEmployeesAppointmentsCount(System.Collections.Generic.List{System.String},System.Collections.Generic.List{System.DateTime})')
  - [GetHomepageStatistics(employeeId,salonId)](#M-ARKanyFryzjerstwa-Services-StatisticsService-GetHomepageStatistics-System-String,System-Int32- 'ARKanyFryzjerstwa.Services.StatisticsService.GetHomepageStatistics(System.String,System.Int32)')
  - [GetNotCanceledClientAppointmentsCount(clientId)](#M-ARKanyFryzjerstwa-Services-StatisticsService-GetNotCanceledClientAppointmentsCount-System-Int32- 'ARKanyFryzjerstwa.Services.StatisticsService.GetNotCanceledClientAppointmentsCount(System.Int32)')
- [StringExtensions](#T-ARKanyFryzjerstwa-Extensions-StringExtensions 'ARKanyFryzjerstwa.Extensions.StringExtensions')
  - [GetMinutesFromDurationString(durationString)](#M-ARKanyFryzjerstwa-Extensions-StringExtensions-GetMinutesFromDurationString-System-String- 'ARKanyFryzjerstwa.Extensions.StringExtensions.GetMinutesFromDurationString(System.String)')
  - [GetPrice(priceString)](#M-ARKanyFryzjerstwa-Extensions-StringExtensions-GetPrice-System-String- 'ARKanyFryzjerstwa.Extensions.StringExtensions.GetPrice(System.String)')
  - [HexToInt(hex)](#M-ARKanyFryzjerstwa-Extensions-StringExtensions-HexToInt-System-String- 'ARKanyFryzjerstwa.Extensions.StringExtensions.HexToInt(System.String)')
  - [IsNotOnlyWhitespaces(str)](#M-ARKanyFryzjerstwa-Extensions-StringExtensions-IsNotOnlyWhitespaces-System-String- 'ARKanyFryzjerstwa.Extensions.StringExtensions.IsNotOnlyWhitespaces(System.String)')
  - [NormalizeUserName(userName)](#M-ARKanyFryzjerstwa-Extensions-StringExtensions-NormalizeUserName-System-String- 'ARKanyFryzjerstwa.Extensions.StringExtensions.NormalizeUserName(System.String)')
  - [ReplaceToNormalizedChars(match)](#M-ARKanyFryzjerstwa-Extensions-StringExtensions-ReplaceToNormalizedChars-System-Text-RegularExpressions-Match- 'ARKanyFryzjerstwa.Extensions.StringExtensions.ReplaceToNormalizedChars(System.Text.RegularExpressions.Match)')
- [UserDao](#T-ARKanyFryzjerstwa-DataAccessObjects-UserDao 'ARKanyFryzjerstwa.DataAccessObjects.UserDao')
  - [GetEmployeesByEmployeeIds(employeeIds)](#M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-GetEmployeesByEmployeeIds-System-Collections-Generic-IList{System-String}- 'ARKanyFryzjerstwa.DataAccessObjects.UserDao.GetEmployeesByEmployeeIds(System.Collections.Generic.IList{System.String})')
  - [GetEmployeesBySalonId(salonId)](#M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-GetEmployeesBySalonId-System-Int32- 'ARKanyFryzjerstwa.DataAccessObjects.UserDao.GetEmployeesBySalonId(System.Int32)')
  - [GetUserNamesStartsWith(value)](#M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-GetUserNamesStartsWith-System-String- 'ARKanyFryzjerstwa.DataAccessObjects.UserDao.GetUserNamesStartsWith(System.String)')
  - [GetUserNote(employeeId)](#M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-GetUserNote-System-String- 'ARKanyFryzjerstwa.DataAccessObjects.UserDao.GetUserNote(System.String)')
  - [SaveUserNote(note,employeeId)](#M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-SaveUserNote-System-String,System-String- 'ARKanyFryzjerstwa.DataAccessObjects.UserDao.SaveUserNote(System.String,System.String)')
  - [UpdateEmployeeColor(employeeId,color)](#M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-UpdateEmployeeColor-System-String,System-String- 'ARKanyFryzjerstwa.DataAccessObjects.UserDao.UpdateEmployeeColor(System.String,System.String)')
- [UserExtensions](#T-ARKanyFryzjerstwa-Extensions-UserExtensions 'ARKanyFryzjerstwa.Extensions.UserExtensions')
  - [DisplayName(client)](#M-ARKanyFryzjerstwa-Extensions-UserExtensions-DisplayName-ARKanyFryzjerstwa-Data-Client- 'ARKanyFryzjerstwa.Extensions.UserExtensions.DisplayName(ARKanyFryzjerstwa.Data.Client)')
  - [DisplayName(user)](#M-ARKanyFryzjerstwa-Extensions-UserExtensions-DisplayName-ARKanyFryzjerstwa-Data-User- 'ARKanyFryzjerstwa.Extensions.UserExtensions.DisplayName(ARKanyFryzjerstwa.Data.User)')
  - [GetUser(userManager,user)](#M-ARKanyFryzjerstwa-Extensions-UserExtensions-GetUser-Microsoft-AspNetCore-Identity-UserManager{ARKanyFryzjerstwa-Data-User},System-Security-Claims-ClaimsPrincipal- 'ARKanyFryzjerstwa.Extensions.UserExtensions.GetUser(Microsoft.AspNetCore.Identity.UserManager{ARKanyFryzjerstwa.Data.User},System.Security.Claims.ClaimsPrincipal)')
  - [IsInRole(user,role)](#M-ARKanyFryzjerstwa-Extensions-UserExtensions-IsInRole-System-Security-Claims-ClaimsPrincipal,ARKanyFryzjerstwa-Extensions-Role- 'ARKanyFryzjerstwa.Extensions.UserExtensions.IsInRole(System.Security.Claims.ClaimsPrincipal,ARKanyFryzjerstwa.Extensions.Role)')
  - [IsNotInRole(user,role)](#M-ARKanyFryzjerstwa-Extensions-UserExtensions-IsNotInRole-System-Security-Claims-ClaimsPrincipal,ARKanyFryzjerstwa-Extensions-Role- 'ARKanyFryzjerstwa.Extensions.UserExtensions.IsNotInRole(System.Security.Claims.ClaimsPrincipal,ARKanyFryzjerstwa.Extensions.Role)')
- [VerificationCodeDao](#T-ARKanyFryzjerstwa-DataAccessObjects-VerificationCodeDao 'ARKanyFryzjerstwa.DataAccessObjects.VerificationCodeDao')
  - [AddVerificationCode(code,userId)](#M-ARKanyFryzjerstwa-DataAccessObjects-VerificationCodeDao-AddVerificationCode-System-String,System-String- 'ARKanyFryzjerstwa.DataAccessObjects.VerificationCodeDao.AddVerificationCode(System.String,System.String)')
  - [GetLastUserVerificationCode(userId)](#M-ARKanyFryzjerstwa-DataAccessObjects-VerificationCodeDao-GetLastUserVerificationCode-System-String- 'ARKanyFryzjerstwa.DataAccessObjects.VerificationCodeDao.GetLastUserVerificationCode(System.String)')
  - [Update(verificationCode)](#M-ARKanyFryzjerstwa-DataAccessObjects-VerificationCodeDao-Update-ARKanyFryzjerstwa-Data-VerificationCode- 'ARKanyFryzjerstwa.DataAccessObjects.VerificationCodeDao.Update(ARKanyFryzjerstwa.Data.VerificationCode)')

<a name='T-ARKanyFryzjerstwa-Requirements'></a>
## Wymagania
### Hosting
W celu umieszczenia aplikacji ARKany Fryzjerstwa na hostingu, wymagana jest obsługa następujących technologii:
<ul>
	<li> .NET 6 (ASP.NET Core 6) </li>
	<li> Entity Framework Core 6.0 </li>
</ul>

### Użytkowanie
ARKany Fryzjerstwa to aplikacja internetowa, która do działania wymaga jedynie urządzenia z zainstalowaną przeglądarką internetową.

<a name='T-ARKanyFryzjerstwa-Installation'></a>
## Instalacja
### Hosting
Sposób umieszczenia aplikacji ARKany Fryzjerstwa na hostingu zależy od serwera oraz wykorzystywanych narzędzi.

Poniżej opisany został jeden z możliwych sposób zamieszczenia aplikacji na serwerze:
<ol>
	<li> Otwórz solucję ARKany Fryzjerstwa w Visual Studio.</li>
	<li> Otwórz plik appsettings.json i zmień dane serwera bazodanowego oraz pocztowego.</li>
	<li> Skompiluj i uruchom aplikację w celu sprawdzenia poprawności konfiguracji oraz działania środowiska.</li>
	<li> W eksploratorze rozwiązań, kliknij prawym przyciskiem myszy na projekt ARKanyFryzjerstwa. </li>
	<li> Wybierz opcję "Opublikuj". </li>
	<li> W otwartym oknie wybierz "Folder". </li>
	<li> Wybierz lokalizację docelową, kliknij "Koniec", a następnie "Zamknij". </li>
	<li> Kliknij "Pokaż wszystkie ustawienia". </li>
	<li> W otwartym oknie zmień opcję "Tryb wdrożenia" na "Samodzielny", a następnie kliknij "Zapisz". </li>
	<li> Kliknij przycisk "Publikuj". Po opublikowaniu powinna zostać wyświetlona informacja o pomyślnym zakończeniu akcji, a pliki powinny zostać umieszczone we wskazanym wcześniej folderze.
		<ul>
			<li> Ważne: Należy zwrócić uwagę na długość ścieżki docelowej. Jeśli będzie ona zbyt długa, publikacja zakończy się niepowodzeniem</li>
		</ul>
	</li>
	<li> Umieść opublikowane pliki na hostingu. 
		<ul>
				<li> Proces postępowania w celu umieszczenia plików na serwerze zależy od hostingu. </li>
			</ul>
	</li>
</ol>

### Użytkowanie
ARKany Fryzjerstwa to aplikacja internetowa, a więc nie wymaga instalacji ze strony użytkownika końcowego.


<a name='T-ARKanyFryzjerstwa-Resources-ARKanyResources'></a>
## ARKanyResources `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Resources

##### Podsumowanie

Klasa zasobu wymagająca zdefiniowania typu do wyszukiwania zlokalizowanych ciągów itd.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-Add'></a>
### Add `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Dodaj.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-AddEmployeeAccount'></a>
### AddEmployeeAccount `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Dodaj konto pracownika.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-AddingEmployeeSuccessMsg'></a>
### AddingEmployeeSuccessMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Pomyślnie utworzono konto dla pracownika..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-AnonymousClientName'></a>
### AnonymousClientName `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Klient anonimowy.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-Cancel'></a>
### Cancel `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Anuluj.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ChangeColor'></a>
### ChangeColor `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Zmień kolor.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ChangePassword'></a>
### ChangePassword `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Zmień hasło.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ChangingPasswordErrorMsg'></a>
### ChangingPasswordErrorMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Zmiana hasła zakończyła się niepowodzeniem. Upewnij się, że poprawnie wprowadziłeś dane..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ChangingPasswordSuccessMsg'></a>
### ChangingPasswordSuccessMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Zmiana hasła zakończona sukcesem..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-Close'></a>
### Close `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Zamknij.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ConfirmNewPassword'></a>
### ConfirmNewPassword `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Powtórz nowe hasło.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-CreationEmployeeAccountMailBody'></a>
### CreationEmployeeAccountMailBody `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu <h3>Witaj {0} {1}!</h3>
<p>W aplikacji <a href="{2}">ARKany Fryzjerstwa</a> zostało utworzone dla Ciebie konto. </p>
<p>Twoje dane:</p>
<div style="width: fit-content;border-radius: 10px;background-color: #ddd;margin:5px auto;padding:15px;font-size: 18px;">
<b>Email:</b> {3}<br>
<b>Login:</b> {4}
</div>
<br>
<p>Aby ustawić hasło i móc korzystać z konta należy przejść proces zresetowania hasła dostępny pod adresem <a href="{5}">{5}</a>.</p>
<br>
<p>W razie problemów pozostajemy do dyspozycji.</p>

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-CreationEmployeeAccountMailSubject'></a>
### CreationEmployeeAccountMailSubject `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu ARKany Fryzjerstwa - Nowe konto.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-Culture'></a>
### Culture `właściwość`

##### Podsumowanie

Przesłania właściwość CurrentUICulture bieżącego wątku dla wszystkich
  przypadków przeszukiwania zasobów za pomocą tej klasy zasobów wymagającej zdefiniowania typu.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-Email'></a>
### Email `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Email.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-EmailHintText'></a>
### EmailHintText `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu • Pole wymagane
• Format adresu email.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-Employees'></a>
### Employees `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Pracownicy.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ErrorTitle'></a>
### ErrorTitle `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Błąd.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-FirstName'></a>
### FirstName `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Imię.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-GetAllEmployeesErrorMsg'></a>
### GetAllEmployeesErrorMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nie udało się poprawnie załadować listy wszystkich pracowników..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-IncompleteDataWarningMsg'></a>
### IncompleteDataWarningMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Uzupełnij wymagane dane..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-InfoTitle'></a>
### InfoTitle `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Informacja.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-InvalidFormErrorMsg'></a>
### InvalidFormErrorMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Uzupełnij poprawnie dane..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-InvalidVerificationCodeErrorDescription'></a>
### InvalidVerificationCodeErrorDescription `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Niepoprawny kod weryfikacyjny..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-LastName'></a>
### LastName `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nazwisko.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-LoginInputLabel'></a>
### LoginInputLabel `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nazwa użytkownika / Email.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-NameHintText'></a>
### NameHintText `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu • Pole wymagane
• Min. 3 znaki
• Może zawierać tylko litery.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-NewPassword'></a>
### NewPassword `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nowe hasło.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-NoPerrmisionErrorMessage'></a>
### NoPerrmisionErrorMessage `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Odmowa dostępu. Nie posiadasz odpowiednich uprawnień..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-PasswordResetLink'></a>
### PasswordResetLink `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nie pamiętasz hasła?.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ResetPasswordVerificationCodeMailBody'></a>
### ResetPasswordVerificationCodeMailBody `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu <h3>Witaj {0} {1}!</h3>
<p>Otrzymaliśmy prośbę o zresetowanie hasła do Twojego konta w aplikacji ARKany Fryzjerstwa. </p>
<p>Twój kod weryfikacyjny to:</p>
<div style="width: fit-content;text-align: center;letter-spacing: 5px;border-radius: 40px;background-color: #ddd;margin:5px auto;padding:15px;font-size: 26px;">
<span><b>{2}</b></span>
</div>
<br>
<p>Kod jest ważny do {3}.</p>
<p>Hasło zresetujesz pod adresem <a href="{4}">{4}</a>.</p>
<p>W razie problemów pozostajemy do dyspozycji.</p>
<br>

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ResetPasswordVerificationCodeMailSubject'></a>
### ResetPasswordVerificationCodeMailSubject `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu ARKany Fryzjerstwa - kod weryfkacyjny.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ResourceManager'></a>
### ResourceManager `właściwość`

##### Podsumowanie

Zwraca buforowane wystąpienie ResourceManager używane przez tę klasę.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-Salon'></a>
### Salon `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Salon.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-SalonRegisterErrorMsg'></a>
### SalonRegisterErrorMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nie udało się zarejestrować salonu. Upewnij się, że poprawnie wypełniłeś formularz i spróbuj ponownie..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-SalonRegisterLink'></a>
### SalonRegisterLink `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Zarejestruj swój salon.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-SalonRegisterSuccessMsg'></a>
### SalonRegisterSuccessMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Pomyślnie zarejestrowano salon. Zaloguj się używając podanego adresu e-mail i hasła..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-Save'></a>
### Save `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Zapisz.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-SavingEmployeeColorErrorMsg'></a>
### SavingEmployeeColorErrorMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nie udało się zaaktualizować się koloru pracownika..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-SavingEmployeeColorSuccessMsg'></a>
### SavingEmployeeColorSuccessMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Kolor pracownika został pomyślnie zaaktualizowany.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-ServiceResourcesAssigmentSelectInfo'></a>
### ServiceResourcesAssigmentSelectInfo `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Wybierz zasób, który chcesz przypisać do usługi.
Zostanie on dodany do listy poniżej..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-SuccessTitle'></a>
### SuccessTitle `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Sukces.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-UnknowErrorMsg'></a>
### UnknowErrorMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Wystąpił nieznany błąd..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-UserNotFoundErrorMsg'></a>
### UserNotFoundErrorMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nie znaleziono użytkownika o podanych danych..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-VerificationCode'></a>
### VerificationCode `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Kod weryfikacyjny.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-VerificationCodeInfo'></a>
### VerificationCodeInfo `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Do zmiany hasła wymagane jest podanie kodu weryfikacyjnego wysłanego na adres e-mail..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-VerificationCodeSendedMsg'></a>
### VerificationCodeSendedMsg `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Kod weryfikacyjny został pomyślnie wysłany na adres e-mail powiązany z kontem..

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-WarningTitle'></a>
### WarningTitle `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Ostrzeżenie.

<a name='P-ARKanyFryzjerstwa-Resources-ARKanyResources-WrongHexColorFormatExceptionMessage'></a>
### WrongHexColorFormatExceptionMessage `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nieporawny format przekazanego koloru..

<a name='T-ARKanyFryzjerstwa-Controllers-AccountController'></a>
## AccountController `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Controllers

<a name='M-ARKanyFryzjerstwa-Controllers-AccountController-Index'></a>
### Index() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /Account

##### Zwraca

Przekierowuje do akcji Index kontrolera Home.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-AccountController-Login'></a>
### Login() `metoda`

##### Podsumowanie

Obsługuje żadanie GET: /Account/Login

##### Zwraca

Dla zalogowanego użytkownika przekierowuje do akcji Index kontrolera Home, dla niezalogowanego zwraca [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony logowania.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-AccountController-Login-ARKanyFryzjerstwa-Models-LoginModel-'></a>
### Login(model) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Account/Login

##### Zwraca

W przypadku logowania zakończonego sukcesem przekierowuje do akcji Index kontrolera Home, inaczej zwraca [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony logowania z informacjami o błędach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.LoginModel](#T-ARKanyFryzjerstwa-Models-LoginModel 'ARKanyFryzjerstwa.Models.LoginModel') | Dane wypełnione w formularzu logowania. |

<a name='M-ARKanyFryzjerstwa-Controllers-AccountController-Logout'></a>
### Logout() `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Account/Logout

##### Zwraca

Przekierowuje do akcji Index kontrolera Home.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-AccountController-PasswordReset'></a>
### PasswordReset() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /Account/PasswordReset

##### Zwraca

Dla zalogowanego użytkownika przekierowuje do akcji Index kontrolera Home, dla niezalogowanego zwraca [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony zmiany hasła.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-AccountController-PasswordReset-ARKanyFryzjerstwa-Models-PasswordResetModel-'></a>
### PasswordReset(model) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Account/PasswordReset

##### Zwraca

W przypadku resetu hasła zakończonego sukcesem przekierowuje do akcji Login, inaczej zwraca [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony resetu hasła z informacjami o błędach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.PasswordResetModel](#T-ARKanyFryzjerstwa-Models-PasswordResetModel 'ARKanyFryzjerstwa.Models.PasswordResetModel') | Dane wypełnione w formularzu resetu hasła. |

<a name='M-ARKanyFryzjerstwa-Controllers-AccountController-RegisterSalon'></a>
### RegisterSalon() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /Account/RegisterSalon

##### Zwraca

Dla zalogowanego użytkownika przekierowuje do akcji Index kontrolera Home, dla niezalogowanego zwraca [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony rejestracji salonu.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-AccountController-RegisterSalon-ARKanyFryzjerstwa-Models-RegisterSalonModel-'></a>
### RegisterSalon(model) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Account/RegisterSalon

##### Zwraca

W przypadku rejestrcji zakończonej sukcesem przekierowuje do akcji Login, inaczej zwraca [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony rejestracji salonu z informacjami o błędach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.RegisterSalonModel](#T-ARKanyFryzjerstwa-Models-RegisterSalonModel 'ARKanyFryzjerstwa.Models.RegisterSalonModel') | Dane wypełnione w formularzu rejestracji salonu. |

<a name='M-ARKanyFryzjerstwa-Controllers-AccountController-SendPasswordResetVerificationCode-System-String-'></a>
### SendPasswordResetVerificationCode(login) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Account/SendPasswordResetVerificationCode

##### Zwraca

Obiekt [NotificationModel](#T-ARKanyFryzjerstwa-Models-NotificationModel 'ARKanyFryzjerstwa.Models.NotificationModel') w formacie JSON z informacją o rezultacie wysłania kodu weryfikacyjnego.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| login | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Login użytkownika, któremu ma zostać wysłany kod weryfikacyjny. |

<a name='T-ARKanyFryzjerstwa-Services-AccountService'></a>
## AccountService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services

<a name='M-ARKanyFryzjerstwa-Services-AccountService-GetUserByLogin-System-String-'></a>
### GetUserByLogin(login) `metoda`

##### Podsumowanie

Zwraca użytkownika na podstawie loginu (nazwy użytkownika lub emailu).

##### Zwraca

Obiekt [User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') z danymi o użytkowniku lub wartość null, jeśli użytkownik o podanym loginie nie istnieje.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| login | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nazwa użytkownika lub email. |

<a name='M-ARKanyFryzjerstwa-Services-AccountService-GetUserNote-System-String-'></a>
### GetUserNote(employeeId) `metoda`

##### Podsumowanie

Zwraca notatkę dla podanego pracownika.

##### Zwraca

Tekst notatki.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |

<a name='M-ARKanyFryzjerstwa-Services-AccountService-GetUsernameByLogin-System-String-'></a>
### GetUsernameByLogin(login) `metoda`

##### Podsumowanie

Zwraca nazwę użytkownika na podstawie podanego loginu (nazwy użytkownika lub emailu).

##### Zwraca

Ciąg znaków będący nazwą użytkownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| login | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nazwa użytkownika lub email. |

<a name='M-ARKanyFryzjerstwa-Services-AccountService-PasswordReset-ARKanyFryzjerstwa-Models-PasswordResetModel-'></a>
### PasswordReset(model) `metoda`

##### Podsumowanie

Resetuje hasło użytkownika.

##### Zwraca

True, jeśli pomyślnie zmieniono hasło. 
W przypadku niepowodzenia, do modelu dodany zostaje [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') z informacją o błędzie oraz zwrócona zostaje wartość false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.PasswordResetModel](#T-ARKanyFryzjerstwa-Models-PasswordResetModel 'ARKanyFryzjerstwa.Models.PasswordResetModel') | Obiekt [PasswordResetModel](#T-ARKanyFryzjerstwa-Models-PasswordResetModel 'ARKanyFryzjerstwa.Models.PasswordResetModel') z danymi do zresetowania hasła. |

<a name='M-ARKanyFryzjerstwa-Services-AccountService-RegisterSalon-ARKanyFryzjerstwa-Models-RegisterSalonModel-'></a>
### RegisterSalon(model) `metoda`

##### Podsumowanie

Tworzy i dodaje do bazy danych salon oraz właściciela.

##### Zwraca

True, jeśli pomyślnie utworzono salon. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.RegisterSalonModel](#T-ARKanyFryzjerstwa-Models-RegisterSalonModel 'ARKanyFryzjerstwa.Models.RegisterSalonModel') | Obiekt [RegisterSalonModel](#T-ARKanyFryzjerstwa-Models-RegisterSalonModel 'ARKanyFryzjerstwa.Models.RegisterSalonModel') z danymi salonu oraz właściciela. |

<a name='M-ARKanyFryzjerstwa-Services-AccountService-SaveUserNote-System-String,System-String-'></a>
### SaveUserNote(note,employeeId) `metoda`

##### Podsumowanie

Zapisuje notatkę dla podanego pracownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| note | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Tekst notatki. |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Uniklany Id pracownika. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Notatka przekracza dozwoloną ilość znaków. |

<a name='M-ARKanyFryzjerstwa-Services-AccountService-SendPasswordResetVerificationCode-System-String,Microsoft-AspNetCore-Mvc-IUrlHelper-'></a>
### SendPasswordResetVerificationCode(login,url) `metoda`

##### Podsumowanie

Wysyła maila z kodem weryfikacyjnym oraz instrukcją zmiany hasła.

##### Zwraca

Obiekt [NotificationModel](#T-ARKanyFryzjerstwa-Models-NotificationModel 'ARKanyFryzjerstwa.Models.NotificationModel') z danymi powiadomienia.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| login | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Login użytkownika resetującego hasło. |
| url | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') | Obiekt [IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') służący do wygenerowania adresu URL. |

<a name='M-ARKanyFryzjerstwa-Services-AccountService-ValidatePasswordResetVerificationCode-System-String,System-String,System-DateTime-'></a>
### ValidatePasswordResetVerificationCode(userId,code,requestDateTime) `metoda`

##### Podsumowanie

Sprawdza, czy podany kod weryfikacyjny jest poprawny.

##### Zwraca

True, jeśli kod jest poprawny. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id użytkownika. |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Kod weryfikacyjny. |
| requestDateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data i czas żądania zmiany hasła. |

<a name='T-ARKanyFryzjerstwa-Controllers-AppointmentController'></a>
## AppointmentController `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Controllers

<a name='M-ARKanyFryzjerstwa-Controllers-AppointmentController-CreateAppointment-ARKanyFryzjerstwa-Models-AppointmentAddModel-'></a>
### CreateAppointment(appointmentAddModel) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Appointment/CreateAppointment

##### Zwraca

Obiekt [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') w formacie JSON z danymi utworzonej wizyty.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentAddModel | [ARKanyFryzjerstwa.Models.AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') | Dane z formularza dodawania nowej wizyty. |

<a name='M-ARKanyFryzjerstwa-Controllers-AppointmentController-DoAppointmentsOverlap-ARKanyFryzjerstwa-Models-AppointmentAddModel-'></a>
### DoAppointmentsOverlap(appointmentAddModel) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Appointment/DoAppointmentsOverlap

##### Zwraca

Obiekt [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') w formacie JSON informujący, czy występują nakładające się wizyty.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentAddModel | [ARKanyFryzjerstwa.Models.AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') | Dane z formularza dodawanej wizyty. |

<a name='M-ARKanyFryzjerstwa-Controllers-AppointmentController-GetAppointmentCreationData'></a>
### GetAppointmentCreationData() `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Appointment/GetAppointmentCreationData

##### Zwraca

Obiekt [AppointmentCreationDataModel](#T-ARKanyFryzjerstwa-Models-AppointmentCreationDataModel 'ARKanyFryzjerstwa.Models.AppointmentCreationDataModel') w formacie JSON z danymi dla aktualnego salonu.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-AppointmentController-GetClientPhoneNumberAndEmail-System-Int32-'></a>
### GetClientPhoneNumberAndEmail(clientId) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Appointment/GetClientPhoneNumberAndEmail

##### Zwraca

Obiekt [ContactData](#T-ARKanyFryzjerstwa-Models-ContactData 'ARKanyFryzjerstwa.Models.ContactData') w formacie JSON z danymi dla aktualneo salonu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny identyfikator klienta. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao'></a>
## AppointmentDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-AddAppointment-ARKanyFryzjerstwa-Data-Appointment-'></a>
### AddAppointment(appointment) `metoda`

##### Podsumowanie

Dodaje wizytę do bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointment | [ARKanyFryzjerstwa.Data.Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') | Wizyta do dodania. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Microsoft.EntityFrameworkCore.DbUpdateException](#T-Microsoft-EntityFrameworkCore-DbUpdateException 'Microsoft.EntityFrameworkCore.DbUpdateException') | jeśli wizyta przed doadaniem ma przypisane id, lub nieuzupełnione wymagane pole. |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | jeśli appointment == null. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetAppointmentById-System-Int32-'></a>
### GetAppointmentById(appointmentId) `metoda`

##### Zwraca

Jeśli wizyta o podanym id istnieje zwraca obiekt [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment'), w przeciwnym razie zwraca `null`.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny nr Id wizyty |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetAppointmentsByClientId-System-Int32-'></a>
### GetAppointmentsByClientId(clientId) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę wizyt dla danego klienta.

##### Zwraca

Lista wizyt danego klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Id klienta. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetAppointmetsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime-'></a>
### GetAppointmetsByEmployeeIdsAndDate(employees,date) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę wizyt dla danych pracowników i dnia.

##### Zwraca

Lista wizyt dla podanych pracowników i dnia.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employees | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista pracowników, dla których należy szukać danych |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Dzień, w którym należy szukać wizyt. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetCompletedAppointmentsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime-'></a>
### GetCompletedAppointmentsByEmployeeIdsAndDate(employeeId,date) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę zakończonych wizyt dla danych pracowników i dnia.

##### Zwraca

Lista ukończonych wizyt.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Id pracownika. |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Dzień, w którym należy szukać wizyt. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetNotCanceledAppointmetsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime-'></a>
### GetNotCanceledAppointmetsByEmployeeIdsAndDate(employees,date) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę nieanulowanych wizyt dla danych pracowników i dnia.

##### Zwraca

Lista wizyt, które nie zostały anulowane.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employees | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista pracowników, dla których należy szukać danych. |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Dzień, w którym należy szukać wizyt. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-GetScheduledAppointmentsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime-'></a>
### GetScheduledAppointmentsByEmployeeIdsAndDate(employees,date) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę zaplanowanych wizyt dla danych pracowników i dnia.

##### Zwraca

Lista zaplanowanych wizyt.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employees | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista pracowników, dla których należy szukać danych. |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Dzień, w którym należy szukać wizyt. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-UpdateAppointment-ARKanyFryzjerstwa-Data-Appointment-'></a>
### UpdateAppointment(appointment) `metoda`

##### Podsumowanie

Aktualizuje wizytę w bazie danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointment | [ARKanyFryzjerstwa.Data.Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') | Wizyta do aktualizacji. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | jeśli appointment == null. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-AppointmentDao-UpdateAppointments-System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Appointment}-'></a>
### UpdateAppointments(appointments) `metoda`

##### Podsumowanie

Aktualizuje podane wizyty w bazie danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointments | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Appointment}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Appointment}') | Lista obiektów [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') zawierających informacje o wizytach do aktualizacji. |

<a name='T-ARKanyFryzjerstwa-Services-AppointmentService'></a>
## AppointmentService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-CancelAppointment-System-Int32-'></a>
### CancelAppointment(appointmentId) `metoda`

##### Podsumowanie

Anuluje wizytę.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id wizyt do anulowania. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Wizyta z takim Id nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-CompleteAppointment-ARKanyFryzjerstwa-Models-AppointmentCompletionDataModel-'></a>
### CompleteAppointment(appointmentCompletionData) `metoda`

##### Podsumowanie

Zakańcza wizytę.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentCompletionData | [ARKanyFryzjerstwa.Models.AppointmentCompletionDataModel](#T-ARKanyFryzjerstwa-Models-AppointmentCompletionDataModel 'ARKanyFryzjerstwa.Models.AppointmentCompletionDataModel') | Dane kończonej wizyty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Podana wizyta nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-ConvertAppointmentAddModel-ARKanyFryzjerstwa-Models-AppointmentAddModel,System-String,System-Int32-'></a>
### ConvertAppointmentAddModel(appointmentAddModel,authorId,salonId) `metoda`

##### Podsumowanie

Konwertuje obiekt [AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') na obiekt [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment').

##### Zwraca

Obiekt [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') z danymi o wizycie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentAddModel | [ARKanyFryzjerstwa.Models.AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') | Obiekt z danymi o dodawanej wizycie do przekonwertowania. |
| authorId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id autora wizyty. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-CreateAppointment-ARKanyFryzjerstwa-Models-AppointmentAddModel,System-String,System-Int32-'></a>
### CreateAppointment(appointmentAddModel,authorId,salonId) `metoda`

##### Podsumowanie

Tworzy nową wizytę.

##### Zwraca

Obiekt [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') z danymi o utworzonej wizycie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentAddModel | [ARKanyFryzjerstwa.Models.AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') | Dane nowej wizyty. |
| authorId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika dodającego nową wizytę. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu, w którym dodawana jest wizyta. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-DoAppointmentsOverlap-ARKanyFryzjerstwa-Models-AppointmentAddModel-'></a>
### DoAppointmentsOverlap(appointmentAddModel) `metoda`

##### Podsumowanie

Sprawdza, czy dodawana wizyta konfliktuje z już istniejącą dla danego pracownika.

##### Zwraca

True, jeśli wizyta konfliktuje z już istniejącą. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentAddModel | [ARKanyFryzjerstwa.Models.AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') | Dane dodawanej wizyty. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentCreationClients-System-Int32-'></a>
### GetAppointmentCreationClients(salonId) `metoda`

##### Podsumowanie

Zwraca słownik klientów dla danego salonu.

##### Zwraca

Słownik, którego kluczami są numery Id klientów, a wartościami - ich wyświetlane nazwy.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentCreationData-System-Int32-'></a>
### GetAppointmentCreationData(salonId) `metoda`

##### Podsumowanie

Zwraca dane potrzebne do utworzenia wizyty.

##### Zwraca

Obiekt [AppointmentCreationDataModel](#T-ARKanyFryzjerstwa-Models-AppointmentCreationDataModel 'ARKanyFryzjerstwa.Models.AppointmentCreationDataModel') z danymi potrzebnymi do utworzenia wizyty.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentCreationEmployees-System-Int32-'></a>
### GetAppointmentCreationEmployees(salonId) `metoda`

##### Podsumowanie

Zwraca słownik pracowników dla danego salonu.

##### Zwraca

Słownik, którego kluczami są Id pracowników, a wartościami - ich wyświetlane nazwy.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentCreationServices-System-Int32-'></a>
### GetAppointmentCreationServices(salonId) `metoda`

##### Podsumowanie

Zwraca listę usług dla danego salonu.

##### Zwraca

Lista obiektów [AppointmentServiceModel](#T-ARKanyFryzjerstwa-Models-AppointmentServiceModel 'ARKanyFryzjerstwa.Models.AppointmentServiceModel') z informacjami o usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentServiceModel-System-Int32-'></a>
### GetAppointmentServiceModel(appointmentId) `metoda`

##### Podsumowanie

Zwraca informacje o usłudze przypisanej do danej wizyty.

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi o usłudze.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id wizyty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Wizyta o podanym Id nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-GetAppointmentStartAndEndDate-ARKanyFryzjerstwa-Models-AppointmentAddModel-'></a>
### GetAppointmentStartAndEndDate(appointmentAddModel) `metoda`

##### Podsumowanie

Zwraca datę i czas początku oraz końca wizyty.

##### Zwraca

Para obiektów [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') zawierająca datę oraz czas początku i końca wizyty.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentAddModel | [ARKanyFryzjerstwa.Models.AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') | Dane dodawanej wizyty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Czas zakończenia nie może być równy wartości null. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-GetClient-ARKanyFryzjerstwa-Models-AppointmentAddModel-'></a>
### GetClient(appointmentAddModel) `metoda`

##### Podsumowanie

Zwraca klienta przypisanego do dodawanej wizyty.

##### Zwraca

Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') z informacjami o kliencie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentAddModel | [ARKanyFryzjerstwa.Models.AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') | Dane dodawanej wizyty. |

<a name='M-ARKanyFryzjerstwa-Services-AppointmentService-GetPhoneAndEmail-System-Int32-'></a>
### GetPhoneAndEmail(clientId) `metoda`

##### Podsumowanie

Zwraca numer telefonu i/lub email podanego klienta.

##### Zwraca

Obiekt [ContactData](#T-ARKanyFryzjerstwa-Models-ContactData 'ARKanyFryzjerstwa.Models.ContactData') z numerem telefonu i/lub emailem klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id klienta. |

<a name='T-ARKanyFryzjerstwa-Controllers-BaseController'></a>
## BaseController `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Controllers

<a name='F-ARKanyFryzjerstwa-Controllers-BaseController-_userManager'></a>
### _userManager `constants`

##### Podsumowanie

Obiekt [UserManager\`1](#T-Microsoft-AspNetCore-Identity-UserManager`1 'Microsoft.AspNetCore.Identity.UserManager`1'). Niedostępny spoza kontrolera.

<a name='P-ARKanyFryzjerstwa-Controllers-BaseController-CurrentSalonId'></a>
### CurrentSalonId `właściwość`

##### Podsumowanie

Unikalny identyfikator salonu zalogowanego użytkownika.

<a name='P-ARKanyFryzjerstwa-Controllers-BaseController-CurrentUser'></a>
### CurrentUser `właściwość`

##### Podsumowanie

Obiekt [User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') zalogowanego użytkownika.

<a name='P-ARKanyFryzjerstwa-Controllers-BaseController-UserSalonId'></a>
### UserSalonId `właściwość`

##### Podsumowanie

Unikalny identyfikator salonu zalogowanego użytkownika lub null w przypadku niezalogowanego.

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-BaseDao'></a>
## BaseDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-BaseDao-GetModificationDateTimeForTableBySalonIdAndTable'></a>
### GetModificationDateTimeForTableBySalonIdAndTable() `metoda`

##### Podsumowanie

Pobiera datę i czas modyfikacji danych w tabeli.

##### Zwraca

Obiekt [TableModification](#T-ARKanyFryzjerstwa-Data-TableModification 'ARKanyFryzjerstwa.Data.TableModification') lub, jeśli informacje o danej tabeli nie istnieją, wartość null.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-BaseDao-IsUpToDate-System-DateTime-'></a>
### IsUpToDate(cacheModification) `metoda`

##### Podsumowanie

Sprawdza, czy dane w cache są aktualne.

##### Zwraca

True, jeśli dane są aktualne, w przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| cacheModification | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data i czas zamieszczenia danych w cache. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-BaseDao-SetModificationDateTimeToNow'></a>
### SetModificationDateTimeToNow() `metoda`

##### Podsumowanie

Ustawia datę i czas modyfikacji danych na aktualną.

##### Parametry

This method has no parameters.

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-ClientDao'></a>
## ClientDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-AddClient-ARKanyFryzjerstwa-Data-Client-'></a>
### AddClient(client) `metoda`

##### Podsumowanie

Dodaje klienta do bazy danych.

##### Zwraca

Unikalny numer id klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o kliencie. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-AssingClientToSalon-System-Int32-'></a>
### AssingClientToSalon(clientId) `metoda`

##### Podsumowanie

Przypisuje danego klienta do aktualnego salonu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id klienta do przypisania. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-GetClientById-System-Int32-'></a>
### GetClientById(clientId) `metoda`

##### Podsumowanie

Pobiera dane o kliencie na podstawie podanego Id.

##### Zwraca

Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o kliencie. Jeśli klient o podanych Id nie istnieje, zwrócony zostaje null.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer id klienta. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-GetClientsForSalon-System-Int32-'></a>
### GetClientsForSalon(salonId) `metoda`

##### Podsumowanie

Pobiera dane wszystkich klientach dla danego salonu.

##### Zwraca

Lista obiektów [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierających informacje o klientach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-IsClientDuplicate-ARKanyFryzjerstwa-Data-Client-'></a>
### IsClientDuplicate(client) `metoda`

##### Podsumowanie

Sprawdza, czy klient o podanych danych istnieje już w bazie danych.

##### Zwraca

True, jeśli klient o podanych danych istnieje już w bazie danych. W przeciwnym wypadku zwraca false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o kliencie. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-RemoveClient-ARKanyFryzjerstwa-Data-Client-'></a>
### RemoveClient(client) `metoda`

##### Podsumowanie

Usuwa klienta z bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o kliencie do usunięcia. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-RemoveClients-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Client}-'></a>
### RemoveClients(clientsToRemove) `metoda`

##### Podsumowanie

Usuwa klientów z bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientsToRemove | [System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Client}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Client}') | Lista obiektów [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierających informacje o klientach do usunięcia. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ClientDao-UpdateClient-ARKanyFryzjerstwa-Data-Client-'></a>
### UpdateClient(client) `metoda`

##### Podsumowanie

Aktualizuje dane klienta w bazie danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o dodawanym kliencie. |

<a name='T-ARKanyFryzjerstwa-Controllers-ClientsController'></a>
## ClientsController `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Controllers

<a name='M-ARKanyFryzjerstwa-Controllers-ClientsController-AddNewClient-ARKanyFryzjerstwa-Data-Client-'></a>
### AddNewClient(client) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Clients/AddNewClient

##### Zwraca

Obiekt [ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') w formacie JSON z danymi utworzonego klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Klient do dodania. |

<a name='M-ARKanyFryzjerstwa-Controllers-ClientsController-DuplicateClientVerification-ARKanyFryzjerstwa-Models-ClientModel-'></a>
### DuplicateClientVerification(client) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Clients/DuplicateClientVerification

##### Zwraca

Obiekt [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') w formacie JSON informujący czy klient ma duplikat.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Models.ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') | Klient do weryfikacji duplikatu. |

<a name='M-ARKanyFryzjerstwa-Controllers-ClientsController-Index'></a>
### Index() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /Clients

##### Zwraca

Obiekt [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony z listą klientów salonu.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-ClientsController-RemoveClient-System-Int32-'></a>
### RemoveClient(clientId) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Clients/RemoveClient

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny identyfikator klienta. |

<a name='M-ARKanyFryzjerstwa-Controllers-ClientsController-RemoveClients-System-Collections-Generic-List{System-Int32}-'></a>
### RemoveClients(clientsIds) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Clients/RemoveClients

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientsIds | [System.Collections.Generic.List{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Int32}') | Unikalny identyfikator klienta. |

<a name='M-ARKanyFryzjerstwa-Controllers-ClientsController-UpdateClient-ARKanyFryzjerstwa-Models-ClientModel-'></a>
### UpdateClient(client) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Clients/UpdateClient

##### Zwraca

Obiekt [ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') w formacie JSON z danymi zaktualizowanego klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Models.ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') | Klient do zauktualizowania. |

<a name='T-ARKanyFryzjerstwa-Services-ClientsService'></a>
## ClientsService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-ConvertClient-ARKanyFryzjerstwa-Data-Client-'></a>
### ConvertClient(client) `metoda`

##### Podsumowanie

Konwertuje obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') na obiekt [ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel').

##### Zwraca

Obiekt [ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') z danymi o kliencie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt z danymi klienta do przekonwertowania. |

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-ConvertClientModel-ARKanyFryzjerstwa-Models-ClientModel-'></a>
### ConvertClientModel(client) `metoda`

##### Podsumowanie

Konwertuje obiekt [ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') na obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client').

##### Zwraca

Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') z danymi klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Models.ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') | Obiekt z danymi o kliencie do przekonwertowania. |

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-CreateClient-ARKanyFryzjerstwa-Data-Client-'></a>
### CreateClient(client) `metoda`

##### Podsumowanie

Tworzy nowego klienta.

##### Zwraca

Unikalny numer Id nowo utworzonego klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Dane klienta do utworzenia. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Dane klienta są niepoprawne. |

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-EmailValidation-System-String-'></a>
### EmailValidation(email) `metoda`

##### Podsumowanie

Sprawdza, czy podany email jest poprawny.

##### Zwraca

True, jeśli podany email jest poprawny. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Email do sprawdzenia. |

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-GetClientsModel-System-Int32-'></a>
### GetClientsModel(salonId) `metoda`

##### Podsumowanie

Zwraca klientów dla danego salonu.

##### Zwraca

Obiekt [ClientsModel](#T-ARKanyFryzjerstwa-Models-ClientsModel 'ARKanyFryzjerstwa.Models.ClientsModel') z danymi klientów.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-IsClientDuplicate-ARKanyFryzjerstwa-Models-ClientModel-'></a>
### IsClientDuplicate(clientModel) `metoda`

##### Podsumowanie

Sprawdza, czy klient o podanych danych już istnieje.

##### Zwraca

True, jeśli klient o podanych danych już istnieje. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientModel | [ARKanyFryzjerstwa.Models.ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') | Dane klienta do sprawdzenia. |

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-RemoveClient-System-Int32-'></a>
### RemoveClient(clientId) `metoda`

##### Podsumowanie

Usuwa klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id klienta do usunięcia. |

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-RemoveClients-System-Collections-Generic-List{System-Int32}-'></a>
### RemoveClients(clientIds) `metoda`

##### Podsumowanie

Usuwa klientów.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientIds | [System.Collections.Generic.List{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Int32}') | Lista unikalnym numerów Id klientów do usunięcia. |

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-UpdateClient-ARKanyFryzjerstwa-Models-ClientModel-'></a>
### UpdateClient(client) `metoda`

##### Podsumowanie

Aktualizuje informacje o kliencie.

##### Zwraca

Obiekt [ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') z zaktualizowanymi danymi o kliencie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Models.ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') | Dane klienta do zaktualizowania. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Dane klienta są niepoprawne. |

<a name='M-ARKanyFryzjerstwa-Services-ClientsService-ValidateClientModel-ARKanyFryzjerstwa-Models-ClientModel-'></a>
### ValidateClientModel(client) `metoda`

##### Podsumowanie

Sprawdza, czy podane dane klienta są poprawne.

##### Zwraca

True, jeśli dane są poprawne. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Models.ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') | Dane klienta do sprawdzenia. |

<a name='T-ARKanyFryzjerstwa-Extensions-DateTimeExtension'></a>
## DateTimeExtension `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-DateTimeExtension-GetFirstDayOfWeek-System-DateTime-'></a>
### GetFirstDayOfWeek(dateTime) `metoda`

##### Podsumowanie

Zwraca datę pierwszego dnia tygodnia.

##### Zwraca

Obiekt [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') reprezentujący pierwszy dzień tygodnia.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data, dla której ma zostać zwrócony pierwszy dzień tygodnia. |

<a name='M-ARKanyFryzjerstwa-Extensions-DateTimeExtension-ToDayTitle-System-DateTime,System-String-'></a>
### ToDayTitle(date,culture) `metoda`

##### Podsumowanie

Zwraca datę w postaci "dddd, dd.MM.yyyy".

##### Zwraca

Data w postaci "dddd, dd.MM.yyyy".

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data, która ma zostać sformatowana. |
| culture | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Kultura, w której formacie ma zostać zapisany zwracany tekst. |

<a name='M-ARKanyFryzjerstwa-Extensions-DateTimeExtension-ToMonthTitle-System-DateTime,System-String-'></a>
### ToMonthTitle(date,culture) `metoda`

##### Podsumowanie

Zwraca miesiąc i rok z podanej daty w postaci "MMMM yyyy".

##### Zwraca

Data w postaci "MMMM yyyy".

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data, z której ma zostać zwrócona określona część. |
| culture | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Kultura, w której formacie ma zostać zapisany zwracany tekst. |

<a name='T-ARKanyFryzjerstwa-Extensions-DecimalExtensions'></a>
## DecimalExtensions `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-DecimalExtensions-ToPriceString-System-Decimal-'></a>
### ToPriceString(price) `metoda`

##### Podsumowanie

Zwraca cenę w postaci "X.XX zł".

##### Zwraca

Cena w postaci "X.XX zł".

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| price | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') | Cena, która ma zostać sformatowana. |

<a name='T-ARKanyFryzjerstwa-Extensions-DictionaryExtensions'></a>
## DictionaryExtensions `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-DictionaryExtensions-IsNullOrEmpty``2-System-Collections-Generic-IDictionary{``0,``1}-'></a>
### IsNullOrEmpty\`\`2(dictionary) `metoda`

##### Podsumowanie

Sprawdza, czy słownik jest pusty lub równy null.

##### Zwraca

True, jeśli słownik jest pusty lub równy wartości null. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| dictionary | [System.Collections.Generic.IDictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary 'System.Collections.Generic.IDictionary{``0,``1}') | Słownik, który ma zostać sprawdzony. |

<a name='T-ARKanyFryzjerstwa-Extensions-Generator'></a>
## Generator `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-Generator-GeneratePassword'></a>
### GeneratePassword() `metoda`

##### Podsumowanie

Generuje losowe hasło spełniające określone warunki:

##### Zwraca

Wygenerowane hasło.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Extensions-Generator-GenerateVerificationCode-System-Int32-'></a>
### GenerateVerificationCode(length) `metoda`

##### Podsumowanie

Generuje kod weryfikacyjny używany przy resetowaniu hasła.

##### Zwraca

Wygenerowany kod.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Długość kodu. |

<a name='M-ARKanyFryzjerstwa-Extensions-Generator-RandomChar-System-String-'></a>
### RandomChar(chars) `metoda`

##### Podsumowanie

Wybiera losowy znak z ciągu znaków.

##### Zwraca

Losowo wybrany znak.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| chars | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Ciąg znaków, z których ma zostać wybrany jeden losowy. |

<a name='T-ARKanyFryzjerstwa-Controllers-HomeController'></a>
## HomeController `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Controllers

<a name='M-ARKanyFryzjerstwa-Controllers-HomeController-Error'></a>
### Error() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /Home/Error

##### Zwraca

Obiekt [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony z informacją o błędzie.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-HomeController-GetLowResources'></a>
### GetLowResources() `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Home/GetLowResources

##### Zwraca

Obiekt [ResourcesModel](#T-ARKanyFryzjerstwa-Models-ResourcesModel 'ARKanyFryzjerstwa.Models.ResourcesModel') w formacie JSON z danymi o kończących się zasobach.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-HomeController-GetStats'></a>
### GetStats() `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Home/GetStats

##### Zwraca

Obiekt [HomepageStatisticsModel](#T-ARKanyFryzjerstwa-Models-HomepageStatisticsModel 'ARKanyFryzjerstwa.Models.HomepageStatisticsModel') w formacie JSON ze statystykami dla aktualnego salonu.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-HomeController-GetUserNote'></a>
### GetUserNote() `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Home/GetUserNote

##### Zwraca

Notatka użytkownika.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-HomeController-Index'></a>
### Index() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /

##### Zwraca

Obiekt [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony głównej.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-HomeController-SaveUserNote-System-String-'></a>
### SaveUserNote(note) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Home/SaveUserNote

##### Zwraca

"Success".

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| note | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The note. |

<a name='T-ARKanyFryzjerstwa-Models-Colors-HsvColor'></a>
## HsvColor `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Models.Colors

<a name='P-ARKanyFryzjerstwa-Models-Colors-HsvColor-Hue'></a>
### Hue `właściwość`

##### Podsumowanie

Pobiera lub ustawia wartość odcienia koloru (kąt stożka - wartości w przedziale [0, 360)).

<a name='P-ARKanyFryzjerstwa-Models-Colors-HsvColor-Saturation'></a>
### Saturation `właściwość`

##### Podsumowanie

Pobiera lub ustawia poziom nasycenia koloru (promień podstawy stożka - wartości od 0 do 1).

<a name='P-ARKanyFryzjerstwa-Models-Colors-HsvColor-Value'></a>
### Value `właściwość`

##### Podsumowanie

Pobiera lub ustawia jasność koloru (wysokość stożka - wartości od 0 do 1).

<a name='M-ARKanyFryzjerstwa-Models-Colors-HsvColor-ToHexColor'></a>
### ToHexColor() `metoda`

##### Podsumowanie

Konwertue kolor w formacie HSV do zapisu szesnastkowego.

##### Zwraca

Tekst z zapisem szesnastkowym koloru.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Models-Colors-HsvColor-ToRgbColor'></a>
### ToRgbColor() `metoda`

##### Podsumowanie

Konwertuje kolor w formacie HSV do formatu RGB.

##### Zwraca

Kolor RGB

##### Parametry

This method has no parameters.

<a name='T-ARKanyFryzjerstwa-Services-IServices-IAccountService'></a>
## IAccountService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services.IServices

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAccountService-GetUserNote-System-String-'></a>
### GetUserNote(employeeId) `metoda`

##### Podsumowanie

Zwraca notatkę dla podanego pracownika.

##### Zwraca

Tekst notatki.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAccountService-GetUsernameByLogin-System-String-'></a>
### GetUsernameByLogin(login) `metoda`

##### Podsumowanie

Zwraca nazwę użytkownika na podstawie podanego loginu (nazwy użytkownika lub emailu).

##### Zwraca

Ciąg znaków będący nazwą użytkownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| login | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nazwa użytkownika lub email. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAccountService-PasswordReset-ARKanyFryzjerstwa-Models-PasswordResetModel-'></a>
### PasswordReset(model) `metoda`

##### Podsumowanie

Resetuje hasło użytkownika.

##### Zwraca

True, jeśli pomyślnie zmieniono hasło. 
W przypadku niepowodzenia, do modelu dodany zostaje [](#!-IdentityError 'IdentityError') z informacją o błędzie oraz zwrócona zostaje wartość false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.PasswordResetModel](#T-ARKanyFryzjerstwa-Models-PasswordResetModel 'ARKanyFryzjerstwa.Models.PasswordResetModel') | Obiekt [PasswordResetModel](#T-ARKanyFryzjerstwa-Models-PasswordResetModel 'ARKanyFryzjerstwa.Models.PasswordResetModel') z danymi do zresetowania hasła. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAccountService-RegisterSalon-ARKanyFryzjerstwa-Models-RegisterSalonModel-'></a>
### RegisterSalon(model) `metoda`

##### Podsumowanie

Tworzy i dodaje do bazy danych salon oraz właściciela.

##### Zwraca

True, jeśli pomyślnie utworzono salon. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.RegisterSalonModel](#T-ARKanyFryzjerstwa-Models-RegisterSalonModel 'ARKanyFryzjerstwa.Models.RegisterSalonModel') | Obiekt [RegisterSalonModel](#T-ARKanyFryzjerstwa-Models-RegisterSalonModel 'ARKanyFryzjerstwa.Models.RegisterSalonModel') z danymi salonu oraz właściciela. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAccountService-SaveUserNote-System-String,System-String-'></a>
### SaveUserNote(note,employeeId) `metoda`

##### Podsumowanie

Zapisuje notatkę dla podanego pracownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| note | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Tekst notatki. |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Uniklany Id pracownika. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Notatka przekracza dozwoloną ilość znaków. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAccountService-SendPasswordResetVerificationCode-System-String,Microsoft-AspNetCore-Mvc-IUrlHelper-'></a>
### SendPasswordResetVerificationCode(login,url) `metoda`

##### Podsumowanie

Wysyła maila z kodem weryfikacyjnym oraz instrukcją zmiany hasła.

##### Zwraca

Obiekt [NotificationModel](#T-ARKanyFryzjerstwa-Models-NotificationModel 'ARKanyFryzjerstwa.Models.NotificationModel') z danymi powiadomienia.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| login | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Login użytkownika resetującego hasło. |
| url | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') | Obiekt [IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') służący do wygenerowania adresu URL. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao'></a>
## IAppointmentDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-AddAppointment-ARKanyFryzjerstwa-Data-Appointment-'></a>
### AddAppointment(appointment) `metoda`

##### Podsumowanie

Dodaje wizytę do bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointment | [ARKanyFryzjerstwa.Data.Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') | Wizyta do dodania. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetAppointmentById-System-Int32-'></a>
### GetAppointmentById(appointmentId) `metoda`

##### Zwraca

Jeśli wizyta o podanym id istnieje zwraca obiekt [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment'), w przeciwnym razie zwraca `null`.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny nr Id wizyty |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetAppointmentsByClientId-System-Int32-'></a>
### GetAppointmentsByClientId(clientId) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę wizyt dla danego klienta.

##### Zwraca

Lista wizyt danego klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Id klienta. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetAppointmetsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime-'></a>
### GetAppointmetsByEmployeeIdsAndDate(employees,date) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę wizyt dla danych pracowników i dnia.

##### Zwraca

Lista wizyt dla podanych pracowników i dnia.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employees | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista pracowników, dla których należy szukać danych |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Dzień, w którym należy szukać wizyt. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetCompletedAppointmentsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime-'></a>
### GetCompletedAppointmentsByEmployeeIdsAndDate(employeeId,date) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę zakończonych wizyt dla danych pracowników i dnia.

##### Zwraca

Lista ukończonych wizyt.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Id pracownika. |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Dzień, w którym należy szukać wizyt. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetNotCanceledAppointmetsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime-'></a>
### GetNotCanceledAppointmetsByEmployeeIdsAndDate(employees,date) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę nieanulowanych wizyt dla danych pracowników i dnia.

##### Zwraca

Lista wizyt, które nie zostały anulowane.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employees | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista pracowników, dla których należy szukać danych. |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Dzień, w którym należy szukać wizyt. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-GetScheduledAppointmentsByEmployeeIdsAndDate-System-Collections-Generic-IList{System-String},System-DateTime-'></a>
### GetScheduledAppointmentsByEmployeeIdsAndDate(employees,date) `metoda`

##### Podsumowanie

Wyszukuje i zwraca listę zaplanowanych wizyt dla danych pracowników i dnia.

##### Zwraca

Lista zaplanowanych wizyt.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employees | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista pracowników, dla których należy szukać danych. |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Dzień, w którym należy szukać wizyt. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-UpdateAppointment-ARKanyFryzjerstwa-Data-Appointment-'></a>
### UpdateAppointment(appointment) `metoda`

##### Podsumowanie

Aktualizuje wizytę w bazie danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointment | [ARKanyFryzjerstwa.Data.Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') | Wizyta do aktualizacji. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IAppointmentDao-UpdateAppointments-System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Appointment}-'></a>
### UpdateAppointments(appointments) `metoda`

##### Podsumowanie

Aktualizuje podane wizyty w bazie danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointments | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Appointment}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Appointment}') | Lista obiektów [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') zawierających informacje o wizytach do aktualizacji. |

<a name='T-ARKanyFryzjerstwa-Services-IServices-IAppointmentService'></a>
## IAppointmentService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services.IServices

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-CancelAppointment-System-Int32-'></a>
### CancelAppointment(appointmentId) `metoda`

##### Podsumowanie

Anuluje wizytę.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id wizyt do anulowania. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Wizyta z takim Id nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-CompleteAppointment-ARKanyFryzjerstwa-Models-AppointmentCompletionDataModel-'></a>
### CompleteAppointment(appointmentCompletionData) `metoda`

##### Podsumowanie

Zakańcza wizytę.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentCompletionData | [ARKanyFryzjerstwa.Models.AppointmentCompletionDataModel](#T-ARKanyFryzjerstwa-Models-AppointmentCompletionDataModel 'ARKanyFryzjerstwa.Models.AppointmentCompletionDataModel') | Dane kończonej wizyty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Podana wizyta nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-CreateAppointment-ARKanyFryzjerstwa-Models-AppointmentAddModel,System-String,System-Int32-'></a>
### CreateAppointment(appointmentAddModel,authorId,salonId) `metoda`

##### Podsumowanie

Tworzy nową wizytę.

##### Zwraca

Obiekt [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') z danymi o utworzonej wizycie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentAddModel | [ARKanyFryzjerstwa.Models.AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') | Dane nowej wizyty. |
| authorId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika dodającego nową wizytę. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu, w którym dodawana jest wizyta. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-DoAppointmentsOverlap-ARKanyFryzjerstwa-Models-AppointmentAddModel-'></a>
### DoAppointmentsOverlap(appointmentAddModel) `metoda`

##### Podsumowanie

Sprawdza, czy dodawana wizyta konfliktuje z już istniejącą dla danego pracownika.

##### Zwraca

True, jeśli wizyta konfliktuje z już istniejącą. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentAddModel | [ARKanyFryzjerstwa.Models.AppointmentAddModel](#T-ARKanyFryzjerstwa-Models-AppointmentAddModel 'ARKanyFryzjerstwa.Models.AppointmentAddModel') | Dane dodawanej wizyty. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-GetAppointmentCreationData-System-Int32-'></a>
### GetAppointmentCreationData(salonId) `metoda`

##### Podsumowanie

Zwraca dane potrzebne do utworzenia wizyty.

##### Zwraca

Obiekt [AppointmentCreationDataModel](#T-ARKanyFryzjerstwa-Models-AppointmentCreationDataModel 'ARKanyFryzjerstwa.Models.AppointmentCreationDataModel') z danymi potrzebnymi do utworzenia wizyty.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-GetAppointmentServiceModel-System-Int32-'></a>
### GetAppointmentServiceModel(appointmentId) `metoda`

##### Podsumowanie

Zwraca informacje o usłudze przypisanej do danej wizyty.

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi o usłudze.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id wizyty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Wizyta o podanym Id nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IAppointmentService-GetPhoneAndEmail-System-Int32-'></a>
### GetPhoneAndEmail(clientId) `metoda`

##### Podsumowanie

Zwraca numer telefonu i/lub email podanego klienta.

##### Zwraca

Obiekt [ContactData](#T-ARKanyFryzjerstwa-Models-ContactData 'ARKanyFryzjerstwa.Models.ContactData') z numerem telefonu i/lub emailem klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id klienta. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IBaseDaoGetters'></a>
## IBaseDaoGetters `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

##### Podsumowanie

Sprawdza, czy dane w cache są aktualne.

##### Zwraca

True, jeśli dane są aktualne, w przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| cacheModification | [T:ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IBaseDaoGetters](#T-T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IBaseDaoGetters 'T:ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects.IBaseDaoGetters') | Data i czas zamieszczenia danych w cache. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IBaseDaoSetters'></a>
## IBaseDaoSetters `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IBaseDaoSetters-SetModificationDateTimeToNow'></a>
### SetModificationDateTimeToNow() `metoda`

##### Podsumowanie

Ustawia datę i czas modyfikacji danych na aktualną.

##### Parametry

This method has no parameters.

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao'></a>
## IClientDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-AddClient-ARKanyFryzjerstwa-Data-Client-'></a>
### AddClient(client) `metoda`

##### Podsumowanie

Dodaje klienta do bazy danych.

##### Zwraca

Unikalny numer id klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o kliencie. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-GetClientById-System-Int32-'></a>
### GetClientById(clientId) `metoda`

##### Podsumowanie

Pobiera dane o kliencie na podstawie podanego Id.

##### Zwraca

Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o kliencie. Jeśli klient o podanych Id nie istnieje, zwrócony zostaje null.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer id klienta. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-GetClientsForSalon-System-Int32-'></a>
### GetClientsForSalon(salonId) `metoda`

##### Podsumowanie

Pobiera dane wszystkich klientach dla danego salonu.

##### Zwraca

Lista obiektów [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierających informacje o klientach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-IsClientDuplicate-ARKanyFryzjerstwa-Data-Client-'></a>
### IsClientDuplicate(client) `metoda`

##### Podsumowanie

Sprawdza, czy klient o podanych danych istnieje już w bazie danych.

##### Zwraca

True, jeśli klient o podanych danych istnieje już w bazie danych. W przeciwnym wypadku zwraca false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o kliencie. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-RemoveClient-ARKanyFryzjerstwa-Data-Client-'></a>
### RemoveClient(client) `metoda`

##### Podsumowanie

Usuwa klienta z bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o kliencie do usunięcia. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-RemoveClients-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Client}-'></a>
### RemoveClients(clientsToRemove) `metoda`

##### Podsumowanie

Usuwa klientów z bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientsToRemove | [System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Client}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Client}') | Lista obiektów [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierających informacje o klientach do usunięcia. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IClientDao-UpdateClient-ARKanyFryzjerstwa-Data-Client-'></a>
### UpdateClient(client) `metoda`

##### Podsumowanie

Aktualizuje dane klienta w bazie danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') zawierający informacje o dodawanym kliencie. |

<a name='T-ARKanyFryzjerstwa-Services-IServices-IClientsService'></a>
## IClientsService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services.IServices

<a name='M-ARKanyFryzjerstwa-Services-IServices-IClientsService-ConvertClient-ARKanyFryzjerstwa-Data-Client-'></a>
### ConvertClient(client) `metoda`

##### Podsumowanie

Konwertuje obiekt [Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') na obiekt [ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel').

##### Zwraca

Obiekt [ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') z danymi o kliencie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Obiekt z danymi klienta do przekonwertowania. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IClientsService-CreateClient-ARKanyFryzjerstwa-Data-Client-'></a>
### CreateClient(client) `metoda`

##### Podsumowanie

Tworzy nowego klienta.

##### Zwraca

Unikalny numer Id nowo utworzonego klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Dane klienta do utworzenia. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Dane klienta są niepoprawne. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IClientsService-GetClientsModel-System-Int32-'></a>
### GetClientsModel(salonId) `metoda`

##### Podsumowanie

Zwraca klientów dla danego salonu.

##### Zwraca

Obiekt [ClientsModel](#T-ARKanyFryzjerstwa-Models-ClientsModel 'ARKanyFryzjerstwa.Models.ClientsModel') z danymi klientów.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IClientsService-IsClientDuplicate-ARKanyFryzjerstwa-Models-ClientModel-'></a>
### IsClientDuplicate(clientModel) `metoda`

##### Podsumowanie

Sprawdza, czy klient o podanych danych już istnieje.

##### Zwraca

True, jeśli klient o podanych danych już istnieje. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientModel | [ARKanyFryzjerstwa.Models.ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') | Dane klienta do sprawdzenia. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IClientsService-RemoveClient-System-Int32-'></a>
### RemoveClient(clientId) `metoda`

##### Podsumowanie

Usuwa klienta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id klienta do usunięcia. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IClientsService-RemoveClients-System-Collections-Generic-List{System-Int32}-'></a>
### RemoveClients(clientIds) `metoda`

##### Podsumowanie

Usuwa klientów.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientIds | [System.Collections.Generic.List{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Int32}') | Lista unikalnych numerów Id klientów do usunięcia. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IClientsService-UpdateClient-ARKanyFryzjerstwa-Models-ClientModel-'></a>
### UpdateClient(client) `metoda`

##### Podsumowanie

Aktualizuje informacje o kliencie.

##### Zwraca

Obiekt [ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') z zaktualizowanymi danymi o kliencie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Models.ClientModel](#T-ARKanyFryzjerstwa-Models-ClientModel 'ARKanyFryzjerstwa.Models.ClientModel') | Dane klienta do zaktualizowania. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Dane klienta są niepoprawne. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao'></a>
## IResourceDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-AddResource-ARKanyFryzjerstwa-Data-Resource-'></a>
### AddResource(resource) `metoda`

##### Podsumowanie

Dodaje zasób do bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Data.Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') | Obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierający informacje o dodawanym zasobie. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-GetResourceById-System-Int32-'></a>
### GetResourceById(resourceId) `metoda`

##### Podsumowanie

Pobiera informacje o zasobie na podstawie numeru Id.

##### Zwraca

Obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierający informacje o zasobie. Jeśli informacje o danym zasobie nie istnieją, zwracana jest wartość null.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id zasobu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-GetResourcesBySalonId-System-Int32-'></a>
### GetResourcesBySalonId(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o wszystkich zasobach dla danego salonu.

##### Zwraca

Lista obiektów [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierających informacje o zasobach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-GetResourcesGettingLow-System-Int32-'></a>
### GetResourcesGettingLow(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o kończących się zasobach dla danego salonu.

##### Zwraca

Lista obiektów [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierających informacje o kończących się zasobach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-RemoveResource-ARKanyFryzjerstwa-Data-Resource-'></a>
### RemoveResource(resource) `metoda`

##### Podsumowanie

Usuwa podany zasób z bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Data.Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') | Obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierający informacje o zasobie do usunięcia. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-RemoveResources-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Resource}-'></a>
### RemoveResources(resourcesToRemove) `metoda`

##### Podsumowanie

Usuwa podane zasoby z bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourcesToRemove | [System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Resource}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Resource}') | Lista obiektów [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierających informacje o zasobach do usunięcia. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IResourceDao-UpdateResource-ARKanyFryzjerstwa-Data-Resource-'></a>
### UpdateResource(resource) `metoda`

##### Podsumowanie

Aktualizuje informacje o danym zasobie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Data.Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') | Obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierający informacje o zasobie. |

<a name='T-ARKanyFryzjerstwa-Services-IServices-IResourcesService'></a>
## IResourcesService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services.IServices

<a name='M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-AddNewResource-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32-'></a>
### AddNewResource(resource,salonId) `metoda`

##### Podsumowanie

Dodaje nowy zasób.

##### Zwraca

Obiekt [ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') z danymi dodanego zasobu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Models.ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') | Dane o zasobie do dodania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-GetResourcesGettingLow-System-Int32-'></a>
### GetResourcesGettingLow(salonId) `metoda`

##### Podsumowanie

Zwraca informacje o kończących się zasobach dla danego salonu.

##### Zwraca

Obiekt [ResourcesModel](#T-ARKanyFryzjerstwa-Models-ResourcesModel 'ARKanyFryzjerstwa.Models.ResourcesModel') z danymi o kończących się zasobach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-GetResourcesModel-System-Int32-'></a>
### GetResourcesModel(salonId) `metoda`

##### Podsumowanie

Zwraca informacje o zasobach dla danego salonu.

##### Zwraca

Obiekt [ResourcesModel](#T-ARKanyFryzjerstwa-Models-ResourcesModel 'ARKanyFryzjerstwa.Models.ResourcesModel') z danymi o zasobach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-RemoveResource-System-Int32,System-Int32-'></a>
### RemoveResource(resourceId,salonId) `metoda`

##### Podsumowanie

Usuwa zasób.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id zasobu do usunięcia. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-RemoveResources-System-Collections-Generic-List{System-Int32},System-Int32-'></a>
### RemoveResources(resourceIds,salonId) `metoda`

##### Podsumowanie

Usuwa zasoby.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceIds | [System.Collections.Generic.List{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Int32}') | Lista unikalnych numerów Id zasobów do usunięcia. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-UpdateResource-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32-'></a>
### UpdateResource(resource,salonId) `metoda`

##### Podsumowanie

Aktualizuje zasób.

##### Zwraca

Obiekt [ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') z danymi o zaktualizowanym zasobie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Models.ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') | Dane zasobu do zaktualizowania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IResourcesService-UpdateServiceResources-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ResourceUsageModel}-'></a>
### UpdateServiceResources(serviceResourceModels) `metoda`

##### Podsumowanie

Aktualizuje zasoby przypisane do usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceResourceModels | [System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ResourceUsageModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ResourceUsageModel}') | Zasoby do zaktualizowania. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Podany zasób nie istnieje. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-ISalonDao'></a>
## ISalonDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-ISalonDao-GetEmployeesColorsForSalon-System-Int32-'></a>
### GetEmployeesColorsForSalon(salonId) `metoda`

##### Podsumowanie

Pobiera kolory pracowników salonu o podanym identyfikatorze.

##### Zwraca

Kolory pracowników salonu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Identyfikator salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-ISalonDao-GetServicesForSalon-System-Int32-'></a>
### GetServicesForSalon(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o usługach dla danego salonu.

##### Zwraca

Lista obiektów [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierających informacje o usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-ISalonDao-InsertSalon-ARKanyFryzjerstwa-Data-Salon-'></a>
### InsertSalon(salon) `metoda`

##### Podsumowanie

Dodaje przekazany salon do bazy danych.

##### Zwraca

Id dodanego salonu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salon | [ARKanyFryzjerstwa.Data.Salon](#T-ARKanyFryzjerstwa-Data-Salon 'ARKanyFryzjerstwa.Data.Salon') | Salon do dodania do bazy danych. |

<a name='T-ARKanyFryzjerstwa-Services-IServices-IScheduleService'></a>
## IScheduleService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services.IServices

<a name='M-ARKanyFryzjerstwa-Services-IServices-IScheduleService-GetAppointmentsForWeek-System-DateTime,System-Collections-Generic-IList{System-String},System-Boolean,System-Int32-'></a>
### GetAppointmentsForWeek(date,employees,forceCacheRefresh,salonId) `metoda`

##### Podsumowanie

Zwraca informacje o wizytach w tygodniu, w którym znajduje się podana data.

##### Zwraca

Obiekt [ScheduleData](#T-ARKanyFryzjerstwa-Models-ScheduleData 'ARKanyFryzjerstwa.Models.ScheduleData') z danymi o wizytach w danym tygodniu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data w tygodniu, dla którego mają zostać zwrócone informacje. |
| employees | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista unikalnych Id pracowników, dla których należy zwrócić dane. |
| forceCacheRefresh | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Wartość true wymusza aktualizację danych w cache. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IScheduleService-GetScheduleDays-System-DateTime,System-Collections-Generic-IList{System-String},System-Int32-'></a>
### GetScheduleDays(date,employeeIds,salonId) `metoda`

##### Podsumowanie

Zwraca dane o dniach tygodnia, w którym znajduje się podana data.

##### Zwraca

Obiekt [ScheduleData](#T-ARKanyFryzjerstwa-Models-ScheduleData 'ARKanyFryzjerstwa.Models.ScheduleData') z informacjami o dniach tygodnia.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data, dla której należy zwrócić informacje o tygodniu. |
| employeeIds | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista unikalnych Id pracowników, dla których należy zwrócić dane. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IScheduleService-GetScheduleModel-System-Int32-'></a>
### GetScheduleModel(salonId) `metoda`

##### Podsumowanie

Zwraca dane o harmonogramie dla podanego salonu.

##### Zwraca

Obiekt [ScheduleModel](#T-ARKanyFryzjerstwa-Models-ScheduleModel 'ARKanyFryzjerstwa.Models.ScheduleModel') z danymi o harmonogramie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao'></a>
## IServiceDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-AddService-ARKanyFryzjerstwa-Data-Service-'></a>
### AddService(service) `metoda`

##### Podsumowanie

Dodaje podaną usługę do bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Data.Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') | Obiekt [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierający informacje o dodawanej usłudze. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-GetActiveServicesForSalon-System-Int32-'></a>
### GetActiveServicesForSalon(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o aktywnych usługach dla danego salonu.

##### Zwraca

Lista obiektów [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierających informacje o usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-GetServiceById-System-Int32-'></a>
### GetServiceById(serviceId) `metoda`

##### Podsumowanie

Pobiera informacje o usłudze na podstawie numeru Id.

##### Zwraca

Obiekt [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierający informacje o usłudze. Jeśli informacje o danej usłudze nie istnieją, zwracana jest wartość null.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id usługi. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-GetServicesBySalonId-System-Int32-'></a>
### GetServicesBySalonId(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o usługach dla danego salonu.

##### Zwraca

Lista obiektów [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierających informacje o usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-UpdateService-ARKanyFryzjerstwa-Data-Service-'></a>
### UpdateService(service) `metoda`

##### Podsumowanie

Aktualizuje informacje o danej usłudze.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Data.Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') | Obiekt [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierający informacje o usłudze. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceDao-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Service}-'></a>
### UpdateServices(services) `metoda`

##### Podsumowanie

Aktualizuje informacje o danych usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Service}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Service}') | Lista obiektów [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierających informacje o usługach. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceResourceDao'></a>
## IServiceResourceDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceResourceDao-GetServiceResources-System-Int32-'></a>
### GetServiceResources(serviceId) `metoda`

##### Podsumowanie

Pobiera informacje o zasobach używanych podczas podanej usługi.

##### Zwraca

Lista obiektów [DisplayingServiceResourceModel](#T-ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel 'ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel') zawierających informacje o zużyciu zasobów.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id usługi. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IServiceResourceDao-UpdateServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32-'></a>
### UpdateServiceResources(resources,serviceId) `metoda`

##### Podsumowanie

Aktualizuje informacje o zasobach używanych w trakcie podanej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resources | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}') | Lista obiektów [DisplayingServiceResourceModel](#T-ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel 'ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel') zawierających informacje o używanych zasobach. |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id usługi. |

<a name='T-ARKanyFryzjerstwa-Services-IServices-IServicesService'></a>
## IServicesService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services.IServices

<a name='M-ARKanyFryzjerstwa-Services-IServices-IServicesService-AddNewService-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32-'></a>
### AddNewService(service,salonId) `metoda`

##### Podsumowanie

Dodaje usługę.

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi dodanej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Models.ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') | Dane usługi do dodania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IServicesService-GetSalonResources-System-Int32-'></a>
### GetSalonResources(salonId) `metoda`

##### Podsumowanie

Zwraca zasoby dla danego salonu.

##### Zwraca

Lista obiektów [DisplayedResource](#T-ARKanyFryzjerstwa-Models-DisplayedResource 'ARKanyFryzjerstwa.Models.DisplayedResource') z danymi zasobów.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IServicesService-GetServiceModelById-System-Int32-'></a>
### GetServiceModelById(serviceId) `metoda`

##### Podsumowanie

Zwraca dane o usłudze na podstawie unikalnego numeru Id.

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi o usłudze.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id usługi. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Usługa o podanym Id nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IServicesService-GetServiceResources-System-Int32-'></a>
### GetServiceResources(serviceId) `metoda`

##### Podsumowanie

Zwraca zasoby używane w trakcie danej usługi.

##### Zwraca

Lista obiektów [DisplayingServiceResourceModel](#T-ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel 'ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel') z danymi o zasobach używanych w trakcie danej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id usługi. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IServicesService-GetServicesModel-System-Int32-'></a>
### GetServicesModel(salonId) `metoda`

##### Podsumowanie

Zwraca usługi dla danego salonu.

##### Zwraca

Obiekt [ServicesModel](#T-ARKanyFryzjerstwa-Models-ServicesModel 'ARKanyFryzjerstwa.Models.ServicesModel') z danymi o usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IServicesService-SaveServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32-'></a>
### SaveServiceResources(resources,serviceId) `metoda`

##### Podsumowanie

Aktualizuje zasoby używane w trakcie danej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resources | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}') | Aktualizowane zasoby. |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Aktualizowana usługa. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IServicesService-UpdateService-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32-'></a>
### UpdateService(service,salonId) `metoda`

##### Podsumowanie

Aktualizuje usługę.

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi zaktualizowanej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Models.ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') | Dane usługi do zaktualizowania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-IServicesService-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ServiceModel},System-Int32-'></a>
### UpdateServices(services,salonId) `metoda`

##### Podsumowanie

Aktualizuje usługi.

##### Zwraca

Lista obiektów [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi zaktualizowanych usług.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ServiceModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ServiceModel}') | Lista usług do zaktualizowania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='T-ARKanyFryzjerstwa-Services-IServices-ISettingsService'></a>
## ISettingsService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services.IServices

<a name='M-ARKanyFryzjerstwa-Services-IServices-ISettingsService-AddNewEmployee-ARKanyFryzjerstwa-Models-EmployeeToAddModel,System-Int32,Microsoft-AspNetCore-Mvc-IUrlHelper-'></a>
### AddNewEmployee(model,salonId,url) `metoda`

##### Podsumowanie

Dodaje nowego pracownika.

##### Zwraca

Obiekt [EmployeeModel](#T-ARKanyFryzjerstwa-Models-EmployeeModel 'ARKanyFryzjerstwa.Models.EmployeeModel') z danymi o utworzonym pracowniku.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.EmployeeToAddModel](#T-ARKanyFryzjerstwa-Models-EmployeeToAddModel 'ARKanyFryzjerstwa.Models.EmployeeToAddModel') | Dane pracownika do dodania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |
| url | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') | Obiekt [IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') służący do wygenerowania adresu URL. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ARKanyIdentityException](#!-ARKanyIdentityException 'ARKanyIdentityException') | Nieznany błąd. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-ISettingsService-GetEmployees-System-Int32-'></a>
### GetEmployees(salonId) `metoda`

##### Podsumowanie

Zwraca listę pracowników dla danego salonu.

##### Zwraca

Lista obiektów [EmployeeModel](#T-ARKanyFryzjerstwa-Models-EmployeeModel 'ARKanyFryzjerstwa.Models.EmployeeModel') z danymi o pracownikach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-IServices-ISettingsService-SaveEmployeeColor-System-String,System-String-'></a>
### SaveEmployeeColor(color,employeeId) `metoda`

##### Podsumowanie

Aktualizuje kolor pracownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Kolor do zapisania. |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |

<a name='T-ARKanyFryzjerstwa-Services-IServices-IStatisticsService'></a>
## IStatisticsService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services.IServices

<a name='M-ARKanyFryzjerstwa-Services-IServices-IStatisticsService-GetHomepageStatistics-System-String,System-Int32-'></a>
### GetHomepageStatistics(employeeId,salonId) `metoda`

##### Podsumowanie

Zwraca statystyki wyświetlane na głównej stronie.

##### Zwraca

Obiekt [HomepageStatisticsModel](#T-ARKanyFryzjerstwa-Models-HomepageStatisticsModel 'ARKanyFryzjerstwa.Models.HomepageStatisticsModel') ze statystykiami.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika, dla którego mają zostać wyświetlone statystyki. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao'></a>
## IUserDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-GetEmployeesByEmployeeIds-System-Collections-Generic-IList{System-String}-'></a>
### GetEmployeesByEmployeeIds(employeeIds) `metoda`

##### Podsumowanie

Pobiera informacje o pracownikach na podstawie podanych Id.

##### Zwraca

Lista obiektów [User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') zawierających informacje o pracownikach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeIds | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista unikalnych Id pracowników. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-GetEmployeesBySalonId-System-Int32-'></a>
### GetEmployeesBySalonId(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o pracownikach dla danego salonu.

##### Zwraca

Lista obiektów [User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') zawierających informacje o pracownikach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-GetUserNamesStartsWith-System-String-'></a>
### GetUserNamesStartsWith(value) `metoda`

##### Podsumowanie

Pobiera informacje o nazwach użytkowników zaczynających się od podanej wartości.

##### Zwraca

Lista nazw użytkowników zaczynających się od podanej wartości.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Ciąg znaków, od którch zaczynać mają się zwrócone nazwy użytkowników. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-GetUserNote-System-String-'></a>
### GetUserNote(employeeId) `metoda`

##### Podsumowanie

Pobiera notatkę podanego użytkownika.

##### Zwraca

Tekst notatki.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-SaveUserNote-System-String,System-String-'></a>
### SaveUserNote(note,employeeId) `metoda`

##### Podsumowanie

Zapisuje notatkę podanego użytkownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| note | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Tekst notatki. |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IUserDao-UpdateEmployeeColor-System-String,System-String-'></a>
### UpdateEmployeeColor(employeeId,color) `metoda`

##### Podsumowanie

Aktualizuje kolor danego pracownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |
| color | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Kolor do przypisania. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IVerificationCodeDao'></a>
## IVerificationCodeDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IVerificationCodeDao-AddVerificationCode-System-String,System-String-'></a>
### AddVerificationCode(code,userId) `metoda`

##### Podsumowanie

Dodaje do bazy danych nowy kod dla użytkownika.

##### Zwraca

Obiekt z informacjami na temat dodanego kodu

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Wygenerowany kod |
| userId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Identyfikator użytkownika |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IVerificationCodeDao-GetLastUserVerificationCode-System-String-'></a>
### GetLastUserVerificationCode(userId) `metoda`

##### Podsumowanie

Pobiera ostatni istniejący kod weryfikacyjny użytkownika

##### Zwraca

Obiekt z informacjami na temat ostatniego istniejącego kodu użytkownika

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Identyfikator użytkownika |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-IDataAccessObjects-IVerificationCodeDao-Update-ARKanyFryzjerstwa-Data-VerificationCode-'></a>
### Update(verificationCode) `metoda`

##### Podsumowanie

Aktualizuje informacje o kodzie w bazie danych

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| verificationCode | [ARKanyFryzjerstwa.Data.VerificationCode](#T-ARKanyFryzjerstwa-Data-VerificationCode 'ARKanyFryzjerstwa.Data.VerificationCode') | Zaaktualizowany kod weryfikacyjny |

<a name='T-ARKanyFryzjerstwa-Resources-IdentityErrorResources'></a>
## IdentityErrorResources `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Resources

##### Podsumowanie

Klasa zasobu wymagająca zdefiniowania typu do wyszukiwania zlokalizowanych ciągów itd.

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-ConcurrencyFailure'></a>
### ConcurrencyFailure `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Błąd optymistycznej współbieżności, obiekt został zmodyfikowany..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-Culture'></a>
### Culture `właściwość`

##### Podsumowanie

Przesłania właściwość CurrentUICulture bieżącego wątku dla wszystkich
  przypadków przeszukiwania zasobów za pomocą tej klasy zasobów wymagającej zdefiniowania typu.

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DefaultError'></a>
### DefaultError `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Wystąpił nieznany błąd..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateEmail'></a>
### DuplicateEmail `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Email '{0}' jest już przypisany do konta..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateRoleName'></a>
### DuplicateRoleName `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nazwa roli '{0}' już istnieje..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateUserName'></a>
### DuplicateUserName `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nazwa użytkownika '{0}' jest już zajęta..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidEmail'></a>
### InvalidEmail `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Email '{0}' jest niepoprawny..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidRoleName'></a>
### InvalidRoleName `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nazwa roli '{0}' jest niepoprawna..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidToken'></a>
### InvalidToken `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Błędny token..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidUserName'></a>
### InvalidUserName `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Nazwa użytkownika '{0}' jest błędna, może zawierać tylko litery i cyfry..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-LoginAlreadyAssociated'></a>
### LoginAlreadyAssociated `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Użytkownik o podanym loginie już istnieje..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordMismatch'></a>
### PasswordMismatch `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Niepoprawne hasło..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresDigit'></a>
### PasswordRequiresDigit `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Hasło musi zawierać minimum jedną cyfrę ('0'-'9')..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresLower'></a>
### PasswordRequiresLower `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Hasło musi zawierać minimum jedną małą literę ('a'-'z')..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresNonAlphanumeric'></a>
### PasswordRequiresNonAlphanumeric `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Hasło musi zawierać minimum jeden znak specjalny..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresUniqueChars'></a>
### PasswordRequiresUniqueChars `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Hasło musi zawierać minimum {0} różnych znaków..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresUpper'></a>
### PasswordRequiresUpper `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Hasło musi zawierać minimum jedną wilką literę ('A'-'Z')..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordTooShort'></a>
### PasswordTooShort `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Hasło jest za krótkie, musi zawierać minimum {0} znaków..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-RecoveryCodeRedemptionFailed'></a>
### RecoveryCodeRedemptionFailed `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Kod odzyskiwania nie został zrealizowany..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-ResourceManager'></a>
### ResourceManager `właściwość`

##### Podsumowanie

Zwraca buforowane wystąpienie ResourceManager używane przez tę klasę.

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserAlreadyHasPassword'></a>
### UserAlreadyHasPassword `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Użytkownik ma już ustawione hasło..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserAlreadyInRole'></a>
### UserAlreadyInRole `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Użytkownik ma już przypisaną rolę '{0}'..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserLockoutNotEnabled'></a>
### UserLockoutNotEnabled `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Blokada tego użytkownika nie jest dostępna..

<a name='P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserNotInRole'></a>
### UserNotInRole `właściwość`

##### Podsumowanie

Wyszukuje zlokalizowany ciąg podobny do ciągu Użytkownik nie posiada przypisanej roli '{0}'..

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatDuplicateEmail-System-String-'></a>
### FormatDuplicateEmail(email) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [DuplicateEmail](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateEmail 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DuplicateEmail').

##### Zwraca

Sformatowany ciąg [DuplicateEmail](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateEmail 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DuplicateEmail').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Zdplikowany email. |

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatDuplicateRoleName-System-String-'></a>
### FormatDuplicateRoleName(roleName) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [DuplicateRoleName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateRoleName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DuplicateRoleName').

##### Zwraca

Sformatowany ciąg [DuplicateRoleName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateRoleName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DuplicateRoleName').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nazwa zduplikowanej roli. |

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatDuplicateUserName-System-String-'></a>
### FormatDuplicateUserName(userName) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [DuplicateUserName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateUserName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DuplicateUserName').

##### Zwraca

Sformatowany ciąg [DuplicateUserName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-DuplicateUserName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.DuplicateUserName').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Zduplikowana nazwa użytkownika. |

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatInvalidEmail-System-String-'></a>
### FormatInvalidEmail(email) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [InvalidEmail](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidEmail 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidEmail').

##### Zwraca

Sformatowany ciąg [InvalidEmail](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidEmail 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidEmail').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Błędny email. |

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatInvalidRoleName-System-String-'></a>
### FormatInvalidRoleName(roleName) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [InvalidRoleName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidRoleName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidRoleName').

##### Zwraca

Sformatowany ciąg [InvalidRoleName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidRoleName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidRoleName').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Błędna nazwa roli. |

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatInvalidUserName-System-String-'></a>
### FormatInvalidUserName(userName) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [InvalidUserName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidUserName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidUserName').

##### Zwraca

Sformatowany ciąg [InvalidUserName](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-InvalidUserName 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.InvalidUserName').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Błędna nazwa użytkownika. |

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatPasswordRequiresUniqueChars-System-Int32-'></a>
### FormatPasswordRequiresUniqueChars(uniqueChars) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [PasswordRequiresUniqueChars](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresUniqueChars 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordRequiresUniqueChars').

##### Zwraca

Sformatowany ciąg [PasswordRequiresUniqueChars](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordRequiresUniqueChars 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordRequiresUniqueChars').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| uniqueChars | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Wymagana liczba róznych znaków. |

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatPasswordTooShort-System-Int32-'></a>
### FormatPasswordTooShort(length) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [PasswordTooShort](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordTooShort 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordTooShort').

##### Zwraca

Sformatowany ciąg [PasswordTooShort](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-PasswordTooShort 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.PasswordTooShort').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minimalna długość hasła. |

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatUserAlreadyInRole-System-String-'></a>
### FormatUserAlreadyInRole(roleName) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [UserAlreadyInRole](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserAlreadyInRole 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.UserAlreadyInRole').

##### Zwraca

Sformatowany ciąg [UserAlreadyInRole](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserAlreadyInRole 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.UserAlreadyInRole').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nazwa istniejącej roli. |

<a name='M-ARKanyFryzjerstwa-Resources-IdentityErrorResources-FormatUserNotInRole-System-String-'></a>
### FormatUserNotInRole(roleName) `metoda`

##### Podsumowanie

Zwraca sformatowany ciąg [UserNotInRole](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserNotInRole 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.UserNotInRole').

##### Zwraca

Sformatowany ciąg [UserNotInRole](#P-ARKanyFryzjerstwa-Resources-IdentityErrorResources-UserNotInRole 'ARKanyFryzjerstwa.Resources.IdentityErrorResources.UserNotInRole').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| roleName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nazwa roli. |

<a name='T-ARKanyFryzjerstwa-Extensions-IntExtensions'></a>
## IntExtensions `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-IntExtensions-MinutesToDurationString-System-Int32-'></a>
### MinutesToDurationString(minutes) `metoda`

##### Podsumowanie

Zwraca przekazane minuty jako czas w postaci "hh:mm".

##### Zwraca

Czas trwania w postaci "hh:mm".

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| minutes | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Czas trwania w minutach. |

<a name='M-ARKanyFryzjerstwa-Extensions-IntExtensions-ToHex-System-Int32-'></a>
### ToHex(number) `metoda`

##### Podsumowanie

Zwraca liczbę w postaci heksadecymalnej.

##### Zwraca

Liczba w postaci heksadecymalnej jako tekst.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Liczba do przekonwertowania. |

<a name='M-ARKanyFryzjerstwa-Extensions-IntExtensions-ToLeftPadHex-System-Int32,System-Int32,System-Char-'></a>
### ToLeftPadHex(number,width,padChar) `metoda`

##### Podsumowanie

Zwraca liczbę w postaci (domyślnie dwucyfrowej) liczby heksadecymalnej.

##### Zwraca

Liczba w postaci heksadecymalnej o określonej liczbie cyfr, jako tekst.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Liczba do przekonwertowania. |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Liczba cyfr w zwracanej liczbie. |
| padChar | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | Znak uzupełniający. |

<a name='T-ARKanyFryzjerstwa-Extensions-ListExtension'></a>
## ListExtension `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-ListExtension-IsEqualTo``1-System-Collections-Generic-IList{``0},System-Collections-Generic-IList{``0}-'></a>
### IsEqualTo\`\`1(list1,list2) `metoda`

##### Podsumowanie

Sprawdza, czy lista jest równa innej liście.

##### Zwraca

True, jeśli listy są równe.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| list1 | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | Pierwsza lista. |
| list2 | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | Druga lista. |

<a name='M-ARKanyFryzjerstwa-Extensions-ListExtension-IsNullOrEmpty``1-System-Collections-Generic-IList{``0}-'></a>
### IsNullOrEmpty\`\`1(list) `metoda`

##### Podsumowanie

Sprawdza, czy lista jest pusta lub równa null.

##### Zwraca

True, jeśli lista jest pusta lub równa null.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | Lista do sprawdzenia. |

<a name='M-ARKanyFryzjerstwa-Extensions-ListExtension-Shuffle``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### Shuffle\`\`1(values) `metoda`

##### Podsumowanie

Losowo sortuje elementy obiektu [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Zwraca

Losowo posortowany obiekt [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1').

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | Obiekt [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') do sprawdzenia. |

<a name='T-ARKanyFryzjerstwa-Services-MailService'></a>
## MailService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services

<a name='M-ARKanyFryzjerstwa-Services-MailService-Send-System-String,System-String,System-String-'></a>
### Send(to,subject,body) `metoda`

##### Podsumowanie

Wysyła maila na określony adres email.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| to | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Adres odbiorcy. |
| subject | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Temat. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Wiadomość. |

<a name='M-ARKanyFryzjerstwa-Services-MailService-Send-System-Collections-Generic-IList{System-String},System-Collections-Generic-IList{System-String},System-Collections-Generic-IList{System-String},System-String,System-String-'></a>
### Send(to,cc,bcc,subject,body) `metoda`

##### Podsumowanie

Wysyła maila.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| to | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Odbiorca. |
| cc | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Dodatkowi odbiorcy. |
| bcc | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Dodatkowi tajni odbiorcy. |
| subject | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Temat. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Zawartośc maila. |

<a name='M-ARKanyFryzjerstwa-Services-MailService-Send-MimeKit-MimeMessage-'></a>
### Send(mail) `metoda`

##### Podsumowanie

Wysyła maila.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| mail | [MimeKit.MimeMessage](#T-MimeKit-MimeMessage 'MimeKit.MimeMessage') | Mail do wysłania. |

<a name='M-ARKanyFryzjerstwa-Services-MailService-SendCreationEmployeeAccountMailBody-ARKanyFryzjerstwa-Data-User,System-String,System-String-'></a>
### SendCreationEmployeeAccountMailBody(user,password) `metoda`

##### Podsumowanie

Wysyła maila do pracownika o utworzeniu mu konta.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [ARKanyFryzjerstwa.Data.User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') | Pracownik salonu |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Hasło do konta |

<a name='M-ARKanyFryzjerstwa-Services-MailService-SendResetPasswordVerificationCodeMail-ARKanyFryzjerstwa-Data-User,System-String,System-DateTime,System-String-'></a>
### SendResetPasswordVerificationCodeMail(user,code,expirationDate,url) `metoda`

##### Podsumowanie

Wysyła maila z kodem weryfikacyjnym potrzebnym do zresetowania hasła.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [ARKanyFryzjerstwa.Data.User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') | Użytkownik |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Kod weryfikacyjny |
| expirationDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data ważności kodu |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Adres url prowadzący do strony resetu hasła |

<a name='T-ARKanyFryzjerstwa-Extensions-MenuHelper'></a>
## MenuHelper `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-MenuHelper-GetTabClassActive-System-String,System-String-'></a>
### GetTabClassActive(currentPath,tabPath) `metoda`

##### Podsumowanie

Zwraca klasę HTML, jeśli dana zakładka jest aktualnie aktwyna.

##### Zwraca

Klasa "active", jeśli zakładka jest aktywna. W przeciwnym wypadku zwraca pusty ciąg znaków.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| currentPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Ścieżka do aktualnej strony. |
| tabPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Ścieżka do sprawdzanej strony. |

<a name='T-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber'></a>
## PolishIdentityErrorDescriber `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Data

##### Podsumowanie

Klasa umożliwiająca zwracania polskich opisów błędów dla [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError').

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-ConcurrencyFailure'></a>
### ConcurrencyFailure() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący na błąd współbieżności.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący na błąd współbieżności.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-DefaultError'></a>
### DefaultError() `metoda`

##### Podsumowanie

Zwraca domyślny [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError').

##### Zwraca

Domyślny [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError').

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-DuplicateEmail-System-String-'></a>
### DuplicateEmail(email) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określony `email` jest już powiązany z kontem.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określony `email` jest już powiązany z kontem.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Email, który jet już powiązany z kontem. |

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-DuplicateRoleName-System-String-'></a>
### DuplicateRoleName(role) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określona nazwa `role` juz istnieje.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określona nazwa `role` juz istnieje.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| role | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Zduplikowana rola. |

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-DuplicateUserName-System-String-'></a>
### DuplicateUserName(userName) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, żę określony `userName` już istnieje.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, żę określony `userName` już istnieje.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nazwa użytkownika, która już istnieje. |

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-InvalidEmail-System-String-'></a>
### InvalidEmail(email) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określony `email` jest niepoprawny.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określony `email` jest niepoprawny.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Email , który jest niepoprawny. |

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-InvalidRoleName-System-String-'></a>
### InvalidRoleName(role) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określona nazwa `role` jest nieprawidłowa.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określona nazwa `role` jest nieprawidłowa.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| role | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nieprawidłowa rola.. |

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-InvalidToken'></a>
### InvalidToken() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący na błędny token.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący na błędny token.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-InvalidUserName-System-String-'></a>
### InvalidUserName(userName) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określony `userName` jest niepoprawny.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że określony `userName` jest niepoprawny.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nazwa użytkownika, która jest niepoprawna. |

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-LoginAlreadyAssociated'></a>
### LoginAlreadyAssociated() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że zewnętrzny login jest już powiązany z kontem.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że zewnętrzny login jest już powiązany z kontem.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordMismatch'></a>
### PasswordMismatch() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie pasuje.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie pasuje.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresDigit'></a>
### PasswordRequiresDigit() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogu posiadania cyfr.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogu posiadania cyfr.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresLower'></a>
### PasswordRequiresLower() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogu posiadania małych liter.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogu posiadania małych liter.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresNonAlphanumeric'></a>
### PasswordRequiresNonAlphanumeric() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogu posiadania znaków specjalnych.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogu posiadania znaków specjalnych.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresUniqueChars-System-Int32-'></a>
### PasswordRequiresUniqueChars(uniqueChars) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymagania minimalnej liczby `uniqueChars` różnych znaków.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymagania minimalnej liczby `uniqueChars` różnych znaków.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| uniqueChars | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Wymagana liczba róznych znaków. |

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordRequiresUpper'></a>
### PasswordRequiresUpper() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogu posiadania wielkich liter.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogu posiadania wielkich liter.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-PasswordTooShort-System-Int32-'></a>
### PasswordTooShort(length) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogów minimalnej długości `length` znaków.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że hasło nie spełnia wymogów minimalnej długości `length` znaków.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minimalna długość hasła. |

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-RecoveryCodeRedemptionFailed'></a>
### RecoveryCodeRedemptionFailed() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że kod odzyskiwania nie został zrealizowany.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że kod odzyskiwania nie został zrealizowany.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-UserAlreadyHasPassword'></a>
### UserAlreadyHasPassword() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że użytkownik ma już ustawione hasło.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że użytkownik ma już ustawione hasło.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-UserAlreadyInRole-System-String-'></a>
### UserAlreadyInRole(role) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że użytkownik ma już przypisaną określoną `role`.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że użytkownik ma już przypisaną określoną `role`.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| role | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Zduplikowana rola. |

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-UserLockoutNotEnabled'></a>
### UserLockoutNotEnabled() `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że blokada użytkownika jest niedostępna.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że blokada użytkownika jest niedostępna.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Data-PolishIdentityErrorDescriber-UserNotInRole-System-String-'></a>
### UserNotInRole(role) `metoda`

##### Podsumowanie

Zwraca [IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że użytkownik nie ma przypisanej określonej `role`.

##### Zwraca

[IdentityError](#T-Microsoft-AspNetCore-Identity-IdentityError 'Microsoft.AspNetCore.Identity.IdentityError') wskazujący, że użytkownik nie ma przypisanej określonej `role`.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| role | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nieprzypisana do użytkownika rola. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao'></a>
## ResourceDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-AddResource-ARKanyFryzjerstwa-Data-Resource-'></a>
### AddResource(resource) `metoda`

##### Podsumowanie

Dodaje zasób do bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Data.Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') | Obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierający informacje o dodawanym zasobie. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-GetResourceById-System-Int32-'></a>
### GetResourceById(resourceId) `metoda`

##### Podsumowanie

Pobiera informacje o zasobie na podstawie numeru Id.

##### Zwraca

Obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierający informacje o zasobie. Jeśli informacje o danym zasobie nie istnieją, zwracana jest wartość null.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id zasobu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-GetResourcesBySalonId-System-Int32-'></a>
### GetResourcesBySalonId(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o wszystkich zasobach dla danego salonu.

##### Zwraca

Lista obiektów [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierających informacje o zasobach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-GetResourcesGettingLow-System-Int32-'></a>
### GetResourcesGettingLow(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o kończących się zasobach dla danego salonu.

##### Zwraca

Lista obiektów [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierających informacje o kończących się zasobach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-RemoveResource-ARKanyFryzjerstwa-Data-Resource-'></a>
### RemoveResource(resource) `metoda`

##### Podsumowanie

Usuwa podany zasób z bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Data.Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') | Obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierający informacje o zasobie do usunięcia. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-RemoveResources-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Resource}-'></a>
### RemoveResources(resourcesToRemove) `metoda`

##### Podsumowanie

Usuwa podane zasoby z bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourcesToRemove | [System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Resource}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Resource}') | Lista obiektów [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierających informacje o zasobach do usunięcia. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ResourceDao-UpdateResource-ARKanyFryzjerstwa-Data-Resource-'></a>
### UpdateResource(resource) `metoda`

##### Podsumowanie

Aktualizuje informacje o danym zasobie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Data.Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') | Obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') zawierający informacje o zasobie. |

<a name='T-ARKanyFryzjerstwa-Controllers-ResourcesController'></a>
## ResourcesController `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Controllers

<a name='M-ARKanyFryzjerstwa-Controllers-ResourcesController-AddNewResource-ARKanyFryzjerstwa-Models-ResourceModel-'></a>
### AddNewResource(resource) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Resources/AddNewResource

##### Zwraca

Obiekt [ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') w formacie JSON dodanego zasobu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Models.ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') | Zasób do dodania. |

<a name='M-ARKanyFryzjerstwa-Controllers-ResourcesController-Index'></a>
### Index() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /Resources

##### Zwraca

Obiekt [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony z listą zasobów salonu.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-ResourcesController-RemoveResource-System-Int32-'></a>
### RemoveResource(resourceId) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Resources/RemoveResource

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny identyfikator zasobu. |

<a name='M-ARKanyFryzjerstwa-Controllers-ResourcesController-RemoveResources-System-Collections-Generic-List{System-Int32}-'></a>
### RemoveResources(resourcesIds) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Resources/RemoveResources

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourcesIds | [System.Collections.Generic.List{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Int32}') | Lista unikalnych identyfikatorów zasobów. |

<a name='M-ARKanyFryzjerstwa-Controllers-ResourcesController-UpdateResource-ARKanyFryzjerstwa-Models-ResourceModel-'></a>
### UpdateResource(resource) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Resources/UpdateResource

##### Zwraca

Obiekt [ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') w formacie JSON zaktualizowanego zasobu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Models.ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') | Zasób do zaktualizowania. |

<a name='T-ARKanyFryzjerstwa-Services-ResourcesService'></a>
## ResourcesService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-AddNewResource-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32-'></a>
### AddNewResource(resource,salonId) `metoda`

##### Podsumowanie

Dodaje nowy zasób.

##### Zwraca

Obiekt [ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') z danymi dodanego zasobu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Models.ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') | Dane o zasobie do dodania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-ConvertResource-ARKanyFryzjerstwa-Data-Resource-'></a>
### ConvertResource(resource) `metoda`

##### Podsumowanie

Konwertuje obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') na obiekt [ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel').

##### Zwraca

Przekonwertowany obiekt [ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') z danymi o zasobie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Data.Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') | Obiekt do przekonwertowania. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-ConvertResourceModel-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32-'></a>
### ConvertResourceModel(resource,salonId) `metoda`

##### Podsumowanie

Konwertuje obiekt [ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') na obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource').

##### Zwraca

Przekonwertowany obiekt [Resource](#T-ARKanyFryzjerstwa-Data-Resource 'ARKanyFryzjerstwa.Data.Resource') z danymi o zasobie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Models.ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') | Obiekt do przekonwertowania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Podane dane o zasobie są niepoprawne. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-ConvertServiceResource-ARKanyFryzjerstwa-Data-ServiceResource-'></a>
### ConvertServiceResource(serviceResource) `metoda`

##### Podsumowanie

Konwertuje obiekt [ServiceResource](#T-ARKanyFryzjerstwa-Data-ServiceResource 'ARKanyFryzjerstwa.Data.ServiceResource') na obiekt [ServiceResourceModel](#T-ARKanyFryzjerstwa-Models-ServiceResourceModel 'ARKanyFryzjerstwa.Models.ServiceResourceModel').

##### Zwraca

Przekonwertowany obiekt [ServiceResourceModel](#T-ARKanyFryzjerstwa-Models-ServiceResourceModel 'ARKanyFryzjerstwa.Models.ServiceResourceModel') z danymi o zasobie przypisanym do usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceResource | [ARKanyFryzjerstwa.Data.ServiceResource](#T-ARKanyFryzjerstwa-Data-ServiceResource 'ARKanyFryzjerstwa.Data.ServiceResource') | Obiekt do przekonwertowania. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-ConvertServiceResources-System-Collections-Generic-ICollection{ARKanyFryzjerstwa-Data-ServiceResource}-'></a>
### ConvertServiceResources(serviceResources) `metoda`

##### Podsumowanie

Konwertuje obiekty [ServiceResource](#T-ARKanyFryzjerstwa-Data-ServiceResource 'ARKanyFryzjerstwa.Data.ServiceResource') na obiekty [ServiceResourceModel](#T-ARKanyFryzjerstwa-Models-ServiceResourceModel 'ARKanyFryzjerstwa.Models.ServiceResourceModel').

##### Zwraca

Lista przekonwertowanych obiektów [ServiceResourceModel](#T-ARKanyFryzjerstwa-Models-ServiceResourceModel 'ARKanyFryzjerstwa.Models.ServiceResourceModel') z danymi o zasobach przypisanych do usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceResources | [System.Collections.Generic.ICollection{ARKanyFryzjerstwa.Data.ServiceResource}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{ARKanyFryzjerstwa.Data.ServiceResource}') | Kolekcja obiektów do przekonwertowania. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-GetResourcesGettingLow-System-Int32-'></a>
### GetResourcesGettingLow(salonId) `metoda`

##### Podsumowanie

Zwraca informacje o kończących się zasobach dla danego salonu.

##### Zwraca

Obiekt [ResourcesModel](#T-ARKanyFryzjerstwa-Models-ResourcesModel 'ARKanyFryzjerstwa.Models.ResourcesModel') z danymi o kończących się zasobach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-GetResourcesModel-System-Int32-'></a>
### GetResourcesModel(salonId) `metoda`

##### Podsumowanie

Zwraca informacje o zasobach dla danego salonu.

##### Zwraca

Obiekt [ResourcesModel](#T-ARKanyFryzjerstwa-Models-ResourcesModel 'ARKanyFryzjerstwa.Models.ResourcesModel') z danymi o zasobach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-RemoveResource-System-Int32,System-Int32-'></a>
### RemoveResource(resourceId,salonId) `metoda`

##### Podsumowanie

Usuwa zasób.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id zasobu do usunięcia. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-RemoveResources-System-Collections-Generic-List{System-Int32},System-Int32-'></a>
### RemoveResources(resourceIds,salonId) `metoda`

##### Podsumowanie

Usuwa zasoby.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceIds | [System.Collections.Generic.List{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Int32}') | Lista unikalnych numerów Id zasobów do usunięcia. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-UpdateResource-ARKanyFryzjerstwa-Models-ResourceModel,System-Int32-'></a>
### UpdateResource(resource,salonId) `metoda`

##### Podsumowanie

Aktualizuje zasób.

##### Zwraca

Obiekt [ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') z danymi o zaktualizowanym zasobie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Models.ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') | Dane zasobu do zaktualizowania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-UpdateServiceResources-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ResourceUsageModel}-'></a>
### UpdateServiceResources(serviceResourceModels) `metoda`

##### Podsumowanie

Aktualizuje zasoby przypisane do usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceResourceModels | [System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ResourceUsageModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ResourceUsageModel}') | Zasoby do zaktualizowania. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Podany zasób nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-ResourcesService-ValidateResourceModel-ARKanyFryzjerstwa-Models-ResourceModel-'></a>
### ValidateResourceModel(resource) `metoda`

##### Podsumowanie

Sprawdza, czy dane o zasobie są poprawne.

##### Zwraca

True, jeśli dane są poprawne. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resource | [ARKanyFryzjerstwa.Models.ResourceModel](#T-ARKanyFryzjerstwa-Models-ResourceModel 'ARKanyFryzjerstwa.Models.ResourceModel') | Dane do sprawdzenia. |

<a name='T-ARKanyFryzjerstwa-Models-Colors-RgbColor'></a>
## RgbColor `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Models.Colors

<a name='P-ARKanyFryzjerstwa-Models-Colors-RgbColor-Blue'></a>
### Blue `właściwość`

##### Podsumowanie

Pobiera lub ustawia poziom natężenia koloru niebieskiego (wartości od 0 do 255).

<a name='P-ARKanyFryzjerstwa-Models-Colors-RgbColor-Green'></a>
### Green `właściwość`

##### Podsumowanie

Pobiera lub ustawia poziom natężenia koloru zielonego (wartości od 0 do 255).

<a name='P-ARKanyFryzjerstwa-Models-Colors-RgbColor-Red'></a>
### Red `właściwość`

##### Podsumowanie

Pobiera lub ustawia poziom natężenia koloru czerwonego (wartości od 0 do 255).

<a name='M-ARKanyFryzjerstwa-Models-Colors-RgbColor-Set-System-Int32,System-Int32,System-Int32-'></a>
### Set(red,green,blue) `metoda`

##### Podsumowanie

Ustawia przekazane wartości składowych koloru.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| red | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Natężenie składowej czerwonej |
| green | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Natężenie składowej zielonej |
| blue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Natężenie składowej niebieskiej |

<a name='M-ARKanyFryzjerstwa-Models-Colors-RgbColor-ToHsvColor'></a>
### ToHsvColor() `metoda`

##### Podsumowanie

Konwertuje kolor w formacie RGB do formatu HSV.

##### Zwraca

Kolor HSV

##### Parametry

This method has no parameters.

<a name='T-ARKanyFryzjerstwa-Extensions-RolesFactory'></a>
## RolesFactory `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-RolesFactory-GetName-ARKanyFryzjerstwa-Extensions-Role-'></a>
### GetName(role) `metoda`

##### Podsumowanie

Zwraca nazwę podanej roli.

##### Zwraca

Nazwa roli w postaci ciągu znaków.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| role | [ARKanyFryzjerstwa.Extensions.Role](#T-ARKanyFryzjerstwa-Extensions-Role 'ARKanyFryzjerstwa.Extensions.Role') | Rola, której nazwa ma zostać zwrócona. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-SalonDao'></a>
## SalonDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-SalonDao-GetEmployeesColorsForSalon-System-Int32-'></a>
### GetEmployeesColorsForSalon(salonId) `metoda`

##### Podsumowanie

Pobiera kolory pracowników salonu o podanym identyfikatorze.

##### Zwraca

Kolory pracowników salonu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Identyfikator salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-SalonDao-GetServicesForSalon-System-Int32-'></a>
### GetServicesForSalon(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o usługach dla danego salonu.

##### Zwraca

Lista obiektów [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierających informacje o usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-SalonDao-InsertSalon-ARKanyFryzjerstwa-Data-Salon-'></a>
### InsertSalon(salon) `metoda`

##### Podsumowanie

Dodaje przekazany salon do bazy danych.

##### Zwraca

Id dodanego salonu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salon | [ARKanyFryzjerstwa.Data.Salon](#T-ARKanyFryzjerstwa-Data-Salon 'ARKanyFryzjerstwa.Data.Salon') | Salon do dodania do bazy danych. |

<a name='T-ARKanyFryzjerstwa-Controllers-ScheduleController'></a>
## ScheduleController `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Controllers

<a name='M-ARKanyFryzjerstwa-Controllers-ScheduleController-CancelAppointment-System-Int32-'></a>
### CancelAppointment(appointmentId) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Schedule/CancelAppointment

##### Zwraca

Unikalny identyfikator odwołanej wizyty.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny identyfikator wizyty do odwołania. |

<a name='M-ARKanyFryzjerstwa-Controllers-ScheduleController-CompleteAppointment-ARKanyFryzjerstwa-Models-AppointmentCompletionDataModel-'></a>
### CompleteAppointment(appointmentCompletionData) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Schedule/CompleteAppointment

##### Zwraca

Unikalny identyfikator zakończonej wizyty.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentCompletionData | [ARKanyFryzjerstwa.Models.AppointmentCompletionDataModel](#T-ARKanyFryzjerstwa-Models-AppointmentCompletionDataModel 'ARKanyFryzjerstwa.Models.AppointmentCompletionDataModel') | Dane wizyty do zakończenia. |

<a name='M-ARKanyFryzjerstwa-Controllers-ScheduleController-GetAllResources'></a>
### GetAllResources() `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Schedule/GetAllResources

##### Zwraca

Obiekt [ResourcesModel](#T-ARKanyFryzjerstwa-Models-ResourcesModel 'ARKanyFryzjerstwa.Models.ResourcesModel') w formacie JSON z danymi o zasobach salonu.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-ScheduleController-GetAppointmentServiceModel-System-Int32-'></a>
### GetAppointmentServiceModel(appointmentId) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Schedule/GetAppointmentServiceModel

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') w formacie JSON z danymi o usłudze dla wizyty.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointmentId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny identyfikator wizyty. |

<a name='M-ARKanyFryzjerstwa-Controllers-ScheduleController-GetAppointmentsForWeek-System-DateTime,System-Collections-Generic-IList{System-String},System-Boolean-'></a>
### GetAppointmentsForWeek(date,employees,forceCacheRefresh) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Schedule/GetAppointmentsForWeek

##### Zwraca

Obiekt [ScheduleData](#T-ARKanyFryzjerstwa-Models-ScheduleData 'ARKanyFryzjerstwa.Models.ScheduleData') w formacie JSON z danymi o wizytach w aktualnym salonie w wybranym tygodniu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data. |
| employees | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista pracowników. |
| forceCacheRefresh | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Wartość `true` wymusza aktualizację danych w cache. |

<a name='M-ARKanyFryzjerstwa-Controllers-ScheduleController-Index'></a>
### Index() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /Schedule

##### Zwraca

Obiekt [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony z widokiem harmonogramu.

##### Parametry

This method has no parameters.

<a name='T-ARKanyFryzjerstwa-Services-ScheduleService'></a>
## ScheduleService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services

<a name='M-ARKanyFryzjerstwa-Services-ScheduleService-ConvertAppointments-System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Appointment},System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Client},System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-User},System-Collections-Generic-IList{ARKanyFryzjerstwa-Data-Service},System-Int32@,System-Int32@-'></a>
### ConvertAppointments(appointments,clients,employees,services,startHour,endHour) `metoda`

##### Podsumowanie

Konwertuje listę obiektów [Appointment](#T-ARKanyFryzjerstwa-Data-Appointment 'ARKanyFryzjerstwa.Data.Appointment') na listę obiektow [AppointmentInfo](#T-ARKanyFryzjerstwa-Models-AppointmentInfo 'ARKanyFryzjerstwa.Models.AppointmentInfo').

##### Zwraca

Listę obiektów [AppointmentInfo](#T-ARKanyFryzjerstwa-Models-AppointmentInfo 'ARKanyFryzjerstwa.Models.AppointmentInfo') z danymi o wizytach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| appointments | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Appointment}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Appointment}') | Lista wizyt do przekonwertowania. |
| clients | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Client}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Client}') | Lista klientów. |
| employees | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.User}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.User}') | Lista pracowników. |
| services | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Service}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Data.Service}') | Lista usług. |
| startHour | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Godzina rozpoczęcia dnia pracy. |
| endHour | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Godzina zakończniea dnia pracy. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Podany klient / pracownik / usługa nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-ScheduleService-GetAppointmentsForWeek-System-DateTime,System-Collections-Generic-IList{System-String},System-Boolean,System-Int32-'></a>
### GetAppointmentsForWeek(date,employees,forceCacheRefresh,salonId) `metoda`

##### Podsumowanie

Zwraca informacje o wizytach w tygodniu, w którym znajduje się podana data.

##### Zwraca

Obiekt [ScheduleData](#T-ARKanyFryzjerstwa-Models-ScheduleData 'ARKanyFryzjerstwa.Models.ScheduleData') z danymi o wizytach w danym tygodniu.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data w tygodniu, dla którego mają zostać zwrócone informacje. |
| employees | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista unikalnych Id pracowników, dla których należy zwrócić dane. |
| forceCacheRefresh | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Wartość true wymusza aktualizację danych w cache. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ScheduleService-GetScheduleDays-System-DateTime,System-Collections-Generic-IList{System-String},System-Int32-'></a>
### GetScheduleDays(date,employeeIds,salonId) `metoda`

##### Podsumowanie

Zwraca dane o dniach tygodnia, w którym znajduje się podana data.

##### Zwraca

Obiekt [ScheduleData](#T-ARKanyFryzjerstwa-Models-ScheduleData 'ARKanyFryzjerstwa.Models.ScheduleData') z informacjami o dniach tygodnia.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Data, dla której należy zwrócić informacje o tygodniu. |
| employeeIds | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista unikalnych Id pracowników, dla których należy zwrócić dane. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ScheduleService-GetScheduleModel-System-Int32-'></a>
### GetScheduleModel(salonId) `metoda`

##### Podsumowanie

Zwraca dane o harmonogramie dla podanego salonu.

##### Zwraca

Obiekt [ScheduleModel](#T-ARKanyFryzjerstwa-Models-ScheduleModel 'ARKanyFryzjerstwa.Models.ScheduleModel') z danymi o harmonogramie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao'></a>
## ServiceDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-AddService-ARKanyFryzjerstwa-Data-Service-'></a>
### AddService(service) `metoda`

##### Podsumowanie

Dodaje podaną usługę do bazy danych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Data.Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') | Obiekt [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierający informacje o dodawanej usłudze. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-GetActiveServicesForSalon-System-Int32-'></a>
### GetActiveServicesForSalon(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o aktywnych usługach dla danego salonu.

##### Zwraca

Lista obiektów [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierających informacje o usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-GetServiceById-System-Int32-'></a>
### GetServiceById(serviceId) `metoda`

##### Podsumowanie

Pobiera informacje o usłudze na podstawie numeru Id.

##### Zwraca

Obiekt [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierający informacje o usłudze. Jeśli informacje o danej usłudze nie istnieją, zwracana jest wartość null.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id usługi. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-GetServicesBySalonId-System-Int32-'></a>
### GetServicesBySalonId(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o usługach dla danego salonu.

##### Zwraca

Lista obiektów [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierających informacje o usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Uniklany numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-UpdateService-ARKanyFryzjerstwa-Data-Service-'></a>
### UpdateService(service) `metoda`

##### Podsumowanie

Aktualizuje informacje o danej usłudze.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Data.Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') | Obiekt [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierający informacje o usłudze. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ServiceDao-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Data-Service}-'></a>
### UpdateServices(services) `metoda`

##### Podsumowanie

Aktualizuje informacje o danych usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Service}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Data.Service}') | Lista obiektów [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') zawierających informacje o usługach. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-ServiceResourceDao'></a>
## ServiceResourceDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ServiceResourceDao-GetServiceResources-System-Int32-'></a>
### GetServiceResources(serviceId) `metoda`

##### Podsumowanie

Pobiera informacje o zasobach używanych podczas podanej usługi.

##### Zwraca

Lista obiektów [DisplayingServiceResourceModel](#T-ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel 'ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel') zawierających informacje o zużyciu zasobów.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id usługi. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-ServiceResourceDao-UpdateServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32-'></a>
### UpdateServiceResources(resources,serviceId) `metoda`

##### Podsumowanie

Aktualizuje informacje o zasobach używanych w trakcie podanej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resources | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}') | Lista obiektów [DisplayingServiceResourceModel](#T-ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel 'ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel') zawierających informacje o używanych zasobach. |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id usługi. |

<a name='T-ARKanyFryzjerstwa-Controllers-ServicesController'></a>
## ServicesController `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Controllers

<a name='M-ARKanyFryzjerstwa-Controllers-ServicesController-AddNewService-ARKanyFryzjerstwa-Models-ServiceModel-'></a>
### AddNewService(service) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Services/AddNewService

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') w formacie JSON dodanej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Models.ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') | Usługa do dodania. |

<a name='M-ARKanyFryzjerstwa-Controllers-ServicesController-GetSalonResources'></a>
### GetSalonResources() `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Services/GetSalonResources

##### Zwraca

Lista obiektów [DisplayedResource](#T-ARKanyFryzjerstwa-Models-DisplayedResource 'ARKanyFryzjerstwa.Models.DisplayedResource') w formacie JSON z danymi o zasobach salonu.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-ServicesController-GetServiceResources-System-Int32-'></a>
### GetServiceResources(serviceId) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Services/GetServiceResources

##### Zwraca

Lista obiektów [DisplayingServiceResourceModel](#T-ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel 'ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel') w formacie JSON z danymi o zasobach usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny identyfikator usługi. |

<a name='M-ARKanyFryzjerstwa-Controllers-ServicesController-Index'></a>
### Index() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /Services

##### Zwraca

Obiekt [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony z listą usług salonu.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-ServicesController-SaveServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32-'></a>
### SaveServiceResources(resources,serviceId) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Services/SaveServiceResources

##### Zwraca

"Success".

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resources | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}') | Lista zasobów. |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny identyfikator usługi. |

<a name='M-ARKanyFryzjerstwa-Controllers-ServicesController-UpdateServiceData-ARKanyFryzjerstwa-Models-ServiceModel-'></a>
### UpdateServiceData(service) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Services/UpdateServiceData

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') w formacie JSON zaktualizowanej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Models.ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') | Usługa do zaktualizowania. |

<a name='M-ARKanyFryzjerstwa-Controllers-ServicesController-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ServiceModel}-'></a>
### UpdateServices(services) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Services/UpdateServices

##### Zwraca

Lista obiektów [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') w formacie JSON zaktualizowanych usług.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ServiceModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ServiceModel}') | Lista usług do zaktualizowania. |

<a name='T-ARKanyFryzjerstwa-Services-ServicesService'></a>
## ServicesService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-AddNewService-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32-'></a>
### AddNewService(service,salonId) `metoda`

##### Podsumowanie

Dodaje usługę.

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi dodanej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Models.ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') | Dane usługi do dodania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-ConvertService-ARKanyFryzjerstwa-Data-Service-'></a>
### ConvertService(service) `metoda`

##### Podsumowanie

Konwertuje obiekt [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') na obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel').

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi o usłudze.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Data.Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') | Obiekt do przekonwertowania. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-ConvertServiceModel-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32-'></a>
### ConvertServiceModel(service,salonId) `metoda`

##### Podsumowanie

Konwertuje obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') na obiekt [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service').

##### Zwraca

Obiekt [Service](#T-ARKanyFryzjerstwa-Data-Service 'ARKanyFryzjerstwa.Data.Service') z danymi o usłudze.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Models.ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') | Obiekt do przekonwertowania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Dane usługi są niepoprawne. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-GetSalonResources-System-Int32-'></a>
### GetSalonResources(salonId) `metoda`

##### Podsumowanie

Zwraca zasoby dla danego salonu.

##### Zwraca

Lista obiektów [DisplayedResource](#T-ARKanyFryzjerstwa-Models-DisplayedResource 'ARKanyFryzjerstwa.Models.DisplayedResource') z danymi zasobów.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-GetServiceModelById-System-Int32-'></a>
### GetServiceModelById(serviceId) `metoda`

##### Podsumowanie

Zwraca dane o usłudze na podstawie unikalnego numeru Id.

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi o usłudze.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id usługi. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Usługa o podanym Id nie istnieje. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-GetServiceResources-System-Int32-'></a>
### GetServiceResources(serviceId) `metoda`

##### Podsumowanie

Zwraca zasoby używane w trakcie danej usługi.

##### Zwraca

Lista obiektów [DisplayingServiceResourceModel](#T-ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel 'ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel') z danymi o zasobach używanych w trakcie danej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id usługi. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-GetServicesModel-System-Int32-'></a>
### GetServicesModel(salonId) `metoda`

##### Podsumowanie

Zwraca usługi dla danego salonu.

##### Zwraca

Obiekt [ServicesModel](#T-ARKanyFryzjerstwa-Models-ServicesModel 'ARKanyFryzjerstwa.Models.ServicesModel') z danymi o usługach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-SaveServiceResources-System-Collections-Generic-IList{ARKanyFryzjerstwa-Models-DisplayingServiceResourceModel},System-Int32-'></a>
### SaveServiceResources(resources,serviceId) `metoda`

##### Podsumowanie

Aktualizuje zasoby używane w trakcie danej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| resources | [System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{ARKanyFryzjerstwa.Models.DisplayingServiceResourceModel}') | Aktualizowane zasoby. |
| serviceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Aktualizowana usługa. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-UpdateService-ARKanyFryzjerstwa-Models-ServiceModel,System-Int32-'></a>
### UpdateService(service,salonId) `metoda`

##### Podsumowanie

Aktualizuje usługę.

##### Zwraca

Obiekt [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi zaktualizowanej usługi.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Models.ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') | Dane usługi do zaktualizowania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-UpdateServices-System-Collections-Generic-List{ARKanyFryzjerstwa-Models-ServiceModel},System-Int32-'></a>
### UpdateServices(services,salonId) `metoda`

##### Podsumowanie

Aktualizuje usługi.

##### Zwraca

Lista obiektów [ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') z danymi zaktualizowanych usług.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ServiceModel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{ARKanyFryzjerstwa.Models.ServiceModel}') | Lista usług do zaktualizowania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-ServicesService-ValidateServiceModel-ARKanyFryzjerstwa-Models-ServiceModel-'></a>
### ValidateServiceModel(service) `metoda`

##### Podsumowanie

Sprawdza, czy dane o usłudze są poprawne.

##### Zwraca

True, jeśli dane są poprawne. W przeciwnym wypadku - false.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [ARKanyFryzjerstwa.Models.ServiceModel](#T-ARKanyFryzjerstwa-Models-ServiceModel 'ARKanyFryzjerstwa.Models.ServiceModel') | Dane do sprawdzenia. |

<a name='T-ARKanyFryzjerstwa-Extensions-SessionExtensions'></a>
## SessionExtensions `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-SessionExtensions-Get``1-Microsoft-AspNetCore-Http-ISession,System-String-'></a>
### Get\`\`1(session,key) `metoda`

##### Podsumowanie

Zwraca wartość dla podanego klucza w sesji.

##### Zwraca

Wartość dla danego klucza w sesji.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| session | [Microsoft.AspNetCore.Http.ISession](#T-Microsoft-AspNetCore-Http-ISession 'Microsoft.AspNetCore.Http.ISession') | Obiekt [ISession](#T-Microsoft-AspNetCore-Http-ISession 'Microsoft.AspNetCore.Http.ISession'). |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Klucz elementu w sesji. |

<a name='M-ARKanyFryzjerstwa-Extensions-SessionExtensions-Set``1-Microsoft-AspNetCore-Http-ISession,System-String,``0-'></a>
### Set\`\`1(session,key,value) `metoda`

##### Podsumowanie

Ustawia wartość dla podanego klucza w sesji.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| session | [Microsoft.AspNetCore.Http.ISession](#T-Microsoft-AspNetCore-Http-ISession 'Microsoft.AspNetCore.Http.ISession') | Obiekt [ISession](#T-Microsoft-AspNetCore-Http-ISession 'Microsoft.AspNetCore.Http.ISession'). |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Klucz elementu w sesji. |
| value | [\`\`0](#T-``0 '``0') | Wartość elementu w sesji. |

<a name='T-ARKanyFryzjerstwa-Controllers-SettingsController'></a>
## SettingsController `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Controllers

<a name='M-ARKanyFryzjerstwa-Controllers-SettingsController-AddNewEmployee-ARKanyFryzjerstwa-Models-EmployeeToAddModel-'></a>
### AddNewEmployee(model) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Settings/AddNewEmployee

##### Zwraca

Obiekt [EmployeeModel](#T-ARKanyFryzjerstwa-Models-EmployeeModel 'ARKanyFryzjerstwa.Models.EmployeeModel') w formacie JSON z danymi utworzonego pracownika lub obiekt w formacie JSON z informacją o błędzie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.EmployeeToAddModel](#T-ARKanyFryzjerstwa-Models-EmployeeToAddModel 'ARKanyFryzjerstwa.Models.EmployeeToAddModel') | Dane pracownika do utworzenia. |

<a name='M-ARKanyFryzjerstwa-Controllers-SettingsController-GetEmployees'></a>
### GetEmployees() `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Settings/GetEmployees

##### Zwraca

Lista obiektów [EmployeeModel](#T-ARKanyFryzjerstwa-Models-EmployeeModel 'ARKanyFryzjerstwa.Models.EmployeeModel') w formacie JSON z danymi pracowników aktualnego salonu.

##### Parametry

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Użytkowik nie ma uprawnień. |

<a name='M-ARKanyFryzjerstwa-Controllers-SettingsController-Index'></a>
### Index() `metoda`

##### Podsumowanie

Obsługuje żądanie GET: /Settings

##### Zwraca

Zwraca obiekt [ViewResult](#T-Microsoft-AspNetCore-Mvc-ViewResult 'Microsoft.AspNetCore.Mvc.ViewResult') strony z panelem ustawień salonu lub przekierowuje do akcji Index kontrolera Schedule.

##### Parametry

This method has no parameters.

<a name='M-ARKanyFryzjerstwa-Controllers-SettingsController-SaveEmployeeColor-System-String,System-String-'></a>
### SaveEmployeeColor(color,employeeId) `metoda`

##### Podsumowanie

Obsługuje żądanie POST: /Settings/SaveEmployeeColor

##### Zwraca

"Succes" lub obiekt w formacie JSON z informacją o błędzie.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Kolor. |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny identyfikator pracownika. |

<a name='T-ARKanyFryzjerstwa-Services-SettingsService'></a>
## SettingsService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services

<a name='M-ARKanyFryzjerstwa-Services-SettingsService-AddNewEmployee-ARKanyFryzjerstwa-Models-EmployeeToAddModel,System-Int32,Microsoft-AspNetCore-Mvc-IUrlHelper-'></a>
### AddNewEmployee(model,salonId,url) `metoda`

##### Podsumowanie

Dodaje nowego pracownika.

##### Zwraca

Obiekt [EmployeeModel](#T-ARKanyFryzjerstwa-Models-EmployeeModel 'ARKanyFryzjerstwa.Models.EmployeeModel') z danymi o utworzonym pracowniku.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.EmployeeToAddModel](#T-ARKanyFryzjerstwa-Models-EmployeeToAddModel 'ARKanyFryzjerstwa.Models.EmployeeToAddModel') | Dane pracownika do dodania. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |
| url | [Microsoft.AspNetCore.Mvc.IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') | Obiekt [IUrlHelper](#T-Microsoft-AspNetCore-Mvc-IUrlHelper 'Microsoft.AspNetCore.Mvc.IUrlHelper') służący do wygenerowania adresu URL. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ARKanyFryzjerstwa.Errors.ARKanyIdentityException](#T-ARKanyFryzjerstwa-Errors-ARKanyIdentityException 'ARKanyFryzjerstwa.Errors.ARKanyIdentityException') | Nieznany błąd. |

<a name='M-ARKanyFryzjerstwa-Services-SettingsService-ConvertToEmployeeModel-ARKanyFryzjerstwa-Data-User-'></a>
### ConvertToEmployeeModel(employee) `metoda`

##### Podsumowanie

Konwertuje obiekt [User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') na obiekt [EmployeeModel](#T-ARKanyFryzjerstwa-Models-EmployeeModel 'ARKanyFryzjerstwa.Models.EmployeeModel').

##### Zwraca

Obiekt [EmployeeModel](#T-ARKanyFryzjerstwa-Models-EmployeeModel 'ARKanyFryzjerstwa.Models.EmployeeModel') z danymi o użytkowniku.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employee | [ARKanyFryzjerstwa.Data.User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') | Obiekt do przekonwertowania. |

<a name='M-ARKanyFryzjerstwa-Services-SettingsService-GenerateEmployeeColor-System-Int32-'></a>
### GenerateEmployeeColor(salonId) `metoda`

##### Podsumowanie

Generuje kolor pracownika.

##### Zwraca

Ciąg znaków będący wygenerowanym kolorem pracownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-SettingsService-GenerateEmployeeUserName-ARKanyFryzjerstwa-Models-EmployeeToAddModel-'></a>
### GenerateEmployeeUserName(model) `metoda`

##### Podsumowanie

Generuje nazwę użytkownika dla podanego pracownika.

##### Zwraca

Ciąg znaków będący wygenerowaną nazwą użytkownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [ARKanyFryzjerstwa.Models.EmployeeToAddModel](#T-ARKanyFryzjerstwa-Models-EmployeeToAddModel 'ARKanyFryzjerstwa.Models.EmployeeToAddModel') | Dane pracownika. |

<a name='M-ARKanyFryzjerstwa-Services-SettingsService-GetEmployees-System-Int32-'></a>
### GetEmployees(salonId) `metoda`

##### Podsumowanie

Zwraca listę pracowników dla danego salonu.

##### Zwraca

Lista obiektów [EmployeeModel](#T-ARKanyFryzjerstwa-Models-EmployeeModel 'ARKanyFryzjerstwa.Models.EmployeeModel') z danymi o pracownikach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-SettingsService-SaveEmployeeColor-System-String,System-String-'></a>
### SaveEmployeeColor(color,employeeId) `metoda`

##### Podsumowanie

Aktualizuje kolor pracownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Kolor do zapisania. |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |

<a name='T-ARKanyFryzjerstwa-Services-StatisticsService'></a>
## StatisticsService `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Services

<a name='M-ARKanyFryzjerstwa-Services-StatisticsService-GetEmployeesAppointmentsCount-System-Collections-Generic-List{System-String},System-Collections-Generic-List{System-DateTime}-'></a>
### GetEmployeesAppointmentsCount(employees,dates) `metoda`

##### Podsumowanie

Zwraca liczbę wizyt, zakończonych wizyt oraz wizyt z nowymi klientami dla podanych pracowników i dat.

##### Zwraca

Lista obiektów [EmployeeAppointmentsCounts](#T-ARKanyFryzjerstwa-Models-EmployeeAppointmentsCounts 'ARKanyFryzjerstwa.Models.EmployeeAppointmentsCounts') z danymi o wizytach pracowników z danego zakresu dat.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employees | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | Lista unikalnych Id pracowników. |
| dates | [System.Collections.Generic.List{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.DateTime}') | Lista dat. |

<a name='M-ARKanyFryzjerstwa-Services-StatisticsService-GetHomepageStatistics-System-String,System-Int32-'></a>
### GetHomepageStatistics(employeeId,salonId) `metoda`

##### Podsumowanie

Zwraca statystyki wyświetlane na głównej stronie.

##### Zwraca

Obiekt [HomepageStatisticsModel](#T-ARKanyFryzjerstwa-Models-HomepageStatisticsModel 'ARKanyFryzjerstwa.Models.HomepageStatisticsModel') ze statystykiami.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika, dla którego mają zostać wyświetlone statystyki. |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-Services-StatisticsService-GetNotCanceledClientAppointmentsCount-System-Int32-'></a>
### GetNotCanceledClientAppointmentsCount(clientId) `metoda`

##### Podsumowanie

Zwraca liczbę nieanulowanych wizyt dla danego klienta.

##### Zwraca

Liczba nieanulowanych wizyt.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id klienta. |

<a name='T-ARKanyFryzjerstwa-Extensions-StringExtensions'></a>
## StringExtensions `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-StringExtensions-GetMinutesFromDurationString-System-String-'></a>
### GetMinutesFromDurationString(durationString) `metoda`

##### Podsumowanie

Zwraca czas trwania w minutach z czasu w postaci "hh:mm".

##### Zwraca

Czas trwania w minutach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| durationString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Czas trwania w postaci tekstu. |

<a name='M-ARKanyFryzjerstwa-Extensions-StringExtensions-GetPrice-System-String-'></a>
### GetPrice(priceString) `metoda`

##### Podsumowanie

Zwraca cenę w postaci liczby dziesiętnej.

##### Zwraca

Cena w postaci liczby dziesiętnej.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| priceString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Cena w postaci tekstu. |

<a name='M-ARKanyFryzjerstwa-Extensions-StringExtensions-HexToInt-System-String-'></a>
### HexToInt(hex) `metoda`

##### Podsumowanie

Zamienia liczbę z postaci heksadecymalnej na dzisiętną.

##### Zwraca

Liczba w postaci dziesiętnej.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| hex | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Liczba do konwersji. |

<a name='M-ARKanyFryzjerstwa-Extensions-StringExtensions-IsNotOnlyWhitespaces-System-String-'></a>
### IsNotOnlyWhitespaces(str) `metoda`

##### Podsumowanie

Sprawdza, czy ciąg znaków nie zawiera tylko znaków białych lub nie jest pusty.

##### Zwraca

True, jeśli ciąg znaków nie jest pusty lub nie zawiera tylko znaków białych.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Ciąg znaków do sprawdzenia. |

<a name='M-ARKanyFryzjerstwa-Extensions-StringExtensions-NormalizeUserName-System-String-'></a>
### NormalizeUserName(userName) `metoda`

##### Podsumowanie

Normalizuje nazwę użytkownika.

##### Zwraca

Znormalizowana nazwa użytkownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Nazwa użytkownika do znormalizowania. |

<a name='M-ARKanyFryzjerstwa-Extensions-StringExtensions-ReplaceToNormalizedChars-System-Text-RegularExpressions-Match-'></a>
### ReplaceToNormalizedChars(match) `metoda`

##### Podsumowanie

Zastępuje znaki w ciągu znaków ich znormalizowaną wersją.

##### Zwraca

Znormalizowany ciąg znaków.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| match | [System.Text.RegularExpressions.Match](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Match 'System.Text.RegularExpressions.Match') | Obiekt [Match](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Match 'System.Text.RegularExpressions.Match') do znormalizowania. |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-UserDao'></a>
## UserDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-GetEmployeesByEmployeeIds-System-Collections-Generic-IList{System-String}-'></a>
### GetEmployeesByEmployeeIds(employeeIds) `metoda`

##### Podsumowanie

Pobiera informacje o pracownikach na podstawie podanych Id.

##### Zwraca

Lista obiektów [User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') zawierających informacje o pracownikach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeIds | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | Lista unikalnych Id pracowników. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-GetEmployeesBySalonId-System-Int32-'></a>
### GetEmployeesBySalonId(salonId) `metoda`

##### Podsumowanie

Pobiera informacje o pracownikach dla danego salonu.

##### Zwraca

Lista obiektów [User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') zawierających informacje o pracownikach.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| salonId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Unikalny numer Id salonu. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-GetUserNamesStartsWith-System-String-'></a>
### GetUserNamesStartsWith(value) `metoda`

##### Podsumowanie

Pobiera informacje o nazwach użytkowników zaczynających się od podanej wartości.

##### Zwraca

Lista nazw użytkowników zaczynających się od podanej wartości.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Ciąg znaków, od którch zaczynać mają się zwrócone nazwy użytkowników. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-GetUserNote-System-String-'></a>
### GetUserNote(employeeId) `metoda`

##### Podsumowanie

Pobiera notatkę podanego użytkownika.

##### Zwraca

Tekst notatki.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-SaveUserNote-System-String,System-String-'></a>
### SaveUserNote(note,employeeId) `metoda`

##### Podsumowanie

Zapisuje notatkę podanego użytkownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| note | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Tekst notatki. |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-UserDao-UpdateEmployeeColor-System-String,System-String-'></a>
### UpdateEmployeeColor(employeeId,color) `metoda`

##### Podsumowanie

Aktualizuje kolor danego pracownika.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| employeeId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Unikalny Id pracownika. |
| color | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Kolor do przypisania. |

<a name='T-ARKanyFryzjerstwa-Extensions-UserExtensions'></a>
## UserExtensions `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.Extensions

<a name='M-ARKanyFryzjerstwa-Extensions-UserExtensions-DisplayName-ARKanyFryzjerstwa-Data-Client-'></a>
### DisplayName(client) `metoda`

##### Podsumowanie

Zwraca nazwę klienta w postaci do wyświetlenia.

##### Zwraca

Nazwa klienta w postaci do wyświetlenia.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [ARKanyFryzjerstwa.Data.Client](#T-ARKanyFryzjerstwa-Data-Client 'ARKanyFryzjerstwa.Data.Client') | Klient, którego nazwa ma zostać zwrócona. |

<a name='M-ARKanyFryzjerstwa-Extensions-UserExtensions-DisplayName-ARKanyFryzjerstwa-Data-User-'></a>
### DisplayName(user) `metoda`

##### Podsumowanie

Zwraca nazwę użytkownika w postaci do wyświetlenia.

##### Zwraca

Nazwa użytkownika w postaci do wyświetlenia.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [ARKanyFryzjerstwa.Data.User](#T-ARKanyFryzjerstwa-Data-User 'ARKanyFryzjerstwa.Data.User') | Użytkownik, którego nazwa ma zostać zwrócona. |

<a name='M-ARKanyFryzjerstwa-Extensions-UserExtensions-GetUser-Microsoft-AspNetCore-Identity-UserManager{ARKanyFryzjerstwa-Data-User},System-Security-Claims-ClaimsPrincipal-'></a>
### GetUser(userManager,user) `metoda`

##### Podsumowanie

Zwraca użytkownika odpowiadajacego przekazanemu obiektowi [ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal').

##### Zwraca

Użytkownik odpowiadający przekazanemu obiektowi [ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') lub null, jeśli taki użytkownik nie istnieje.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| userManager | [Microsoft.AspNetCore.Identity.UserManager{ARKanyFryzjerstwa.Data.User}](#T-Microsoft-AspNetCore-Identity-UserManager{ARKanyFryzjerstwa-Data-User} 'Microsoft.AspNetCore.Identity.UserManager{ARKanyFryzjerstwa.Data.User}') | Obiekt [UserManager\`1](#T-Microsoft-AspNetCore-Identity-UserManager`1 'Microsoft.AspNetCore.Identity.UserManager`1'). |
| user | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') | Obiekt [ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal'), dla którego ma zostać zwrócony użytkownik. |

<a name='M-ARKanyFryzjerstwa-Extensions-UserExtensions-IsInRole-System-Security-Claims-ClaimsPrincipal,ARKanyFryzjerstwa-Extensions-Role-'></a>
### IsInRole(user,role) `metoda`

##### Podsumowanie

Sprawdza, czy przekazany obiekt [ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') posiada określoną rolę.

##### Zwraca

True, jeśli podany [ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') posiada określoną rolę.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') | Obiekt [ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal'), który ma zostać sprawdzony. |
| role | [ARKanyFryzjerstwa.Extensions.Role](#T-ARKanyFryzjerstwa-Extensions-Role 'ARKanyFryzjerstwa.Extensions.Role') | Obiekt [Role](#T-ARKanyFryzjerstwa-Extensions-Role 'ARKanyFryzjerstwa.Extensions.Role'). |

<a name='M-ARKanyFryzjerstwa-Extensions-UserExtensions-IsNotInRole-System-Security-Claims-ClaimsPrincipal,ARKanyFryzjerstwa-Extensions-Role-'></a>
### IsNotInRole(user,role) `metoda`

##### Podsumowanie

Sprawdza, czy przekazany obiekt [ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') nie posiada określonej roli.

##### Zwraca

True, jeśli podany [ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') nie posiada określonej roli.

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| user | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal') | Obiekt [ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal 'System.Security.Claims.ClaimsPrincipal'), który ma zostać sprawdzony. |
| role | [ARKanyFryzjerstwa.Extensions.Role](#T-ARKanyFryzjerstwa-Extensions-Role 'ARKanyFryzjerstwa.Extensions.Role') | Obiekt [Role](#T-ARKanyFryzjerstwa-Extensions-Role 'ARKanyFryzjerstwa.Extensions.Role'). |

<a name='T-ARKanyFryzjerstwa-DataAccessObjects-VerificationCodeDao'></a>
## VerificationCodeDao `typ`

##### Przestrzeń nazw

ARKanyFryzjerstwa.DataAccessObjects

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-VerificationCodeDao-AddVerificationCode-System-String,System-String-'></a>
### AddVerificationCode(code,userId) `metoda`

##### Podsumowanie

Dodaje do bazy danych nowy kod dla użytkownika.

##### Zwraca

Obiekt z informacjami na temat dodanego kodu

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Wygenerowany kod |
| userId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Identyfikator użytkownika |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-VerificationCodeDao-GetLastUserVerificationCode-System-String-'></a>
### GetLastUserVerificationCode(userId) `metoda`

##### Podsumowanie

Pobiera ostatni istniejący kod weryfikacyjny użytkownika

##### Zwraca

Obiekt z informacjami na temat ostatniego istniejącego kodu użytkownika

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| userId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Identyfikator użytkownika |

<a name='M-ARKanyFryzjerstwa-DataAccessObjects-VerificationCodeDao-Update-ARKanyFryzjerstwa-Data-VerificationCode-'></a>
### Update(verificationCode) `metoda`

##### Podsumowanie

Aktualizuje informacje o kodzie w bazie danych

##### Parametry

| Name | Type | Description |
| ---- | ---- | ----------- |
| verificationCode | [ARKanyFryzjerstwa.Data.VerificationCode](#T-ARKanyFryzjerstwa-Data-VerificationCode 'ARKanyFryzjerstwa.Data.VerificationCode') | Zaaktualizowany kod weryfikacyjny |

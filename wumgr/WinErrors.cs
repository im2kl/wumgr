﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wumgr
{
    static class WinErrors
    {
        static public string GetErrorStr(uint id)
        {
            switch (id)
            {
                // Error codes that the Component Based Servicing (CBS) interface methods return";
                /*case 0xf0801: return "CBS_S_BUSY operation is still in progress";
                case 0xf0802: return "CBS_S_ALREADY_EXISTS source already exists, now copy not added";
                case 0xf0803: return "CBS_S_STACK_SHUTDOWN_REQUIRED servicing stack updated, aborting";*/
                case 0xf0800: return "CBS_E_INTERNAL_ERROR Reserved error(|); there is no message for this error";
                case 0xf0801: return "CBS_E_NOT_INITIALIZED session not initialized";
                case 0xf0802: return "CBS_E_ALREADY_INITIALIZED session already initialized";
                case 0xf0803: return "CBS_E_INVALID_PARAMETER invalid method argument";
                case 0xf0804: return "CBS_E_OPEN_FAILED the update could not be found or could not be opened";
                case 0xf0805: return "CBS_E_INVALID_PACKAGE the update package was not a valid CSI update";
                case 0xf0806: return "CBS_E_PENDING the operation could not be complete due to locked resources";
                case 0xf0807: return "CBS_E_NOT_INSTALLABLE the component referenced is not separately installable";
                case 0xf0808: return "CBS_E_IMAGE_NOT_ACCESSIBLE the image location specified could not be accessed";
                case 0xf0809: return "CBS_E_ARRAY_ELEMENT_MISSING attempt to get non - existent array element";
                case 0xf080A: return "CBS_E_REESTABLISH_SESSION session object updated, must recreate session";
                case 0xf080B: return "CBS_E_PROPERTY_NOT_AVAILABLE requested property is not supported";
                case 0xf080C: return "CBS_E_UNKNOWN_UPDATE named update not present in package";
                case 0xf080D: return "CBS_E_MANIFEST_INVALID_ITEM invalid attribute or element name encountered";
                case 0xf080E: return "CBS_E_MANIFEST_VALIDATION_DUPLICATE_ATTRIBUTES multiple attributes have the same name";
                case 0xf080F: return "CBS_E_MANIFEST_VALIDATION_DUPLICATE_ELEMENT multiple elements have the same name";
                case 0xf0810: return "CBS_E_MANIFEST_VALIDATION_MISSING_REQUIRED_ATTRIBUTES required attributes are missing";
                case 0xf0811: return "CBS_E_MANIFEST_VALIDATION_MISSING_REQUIRED_ELEMENTS required attributes are missing";
                case 0xf0812: return "CBS_E_MANIFEST_VALIDATION_UPDATES_PARENT_MISSING required attributes are missing";
                case 0xf0813: return "CBS_E_INVALID_INSTALL_STATE install state value not acceptable";
                case 0xf0814: return "CBS_E_INVALID_CONFIG_VALUE invalid setting configuration value";
                case 0xf0815: return "CBS_E_INVALID_CARDINALITY invalid cardinality";
                case 0xf0816: return "CBS_E_DPX_JOB_STATE_SAVED job state for DPX has been saved";
                case 0xf0817: return "CBS_E_PACKAGE_DELETED package was uninstalled and is no longer accessible";
                case 0xf0818: return "CBS_E_IDENTITY_MISMATCH container package points to a package manifest whose identity doesn &#39;t match the identity specified";
                case 0xf0819: return "CBS_E_DUPLICATE_UPDATENAME update name is duplicated in package.";
                case 0xf081A: return "CBS_E_INVALID_DRIVER_OPERATION_KEY the driver operations key is corrupt or invalid";
                case 0xf081B: return "CBS_E_UNEXPECTED_PROCESSOR_ARCHITECTURE the processor architecture specified is not supported";
                case 0xf081C: return "CBS_E_EXCESSIVE_EVALUATION Watchlist: not able to reach steady state after too many attempts.";
                case 0xf081D: return "CBS_E_CYCLE_EVALUATION Watchlist: cycle appears when planning component intended state.";
                case 0xf081E: return "CBS_E_NOT_APPLICABLE the package is not applicable";
                case 0xf081F: return "CBS_E_SOURCE_MISSING source for package or file not found, ResolveSource() unsuccessful";
                case 0xf0820: return "CBS_E_CANCEL user cancel, IDCANCEL returned by ICbsUIHandler method except Error()";
                case 0xf0821: return "CBS_E_ABORT client abort, IDABORT returned by ICbsUIHandler method except Error()";
                case 0xf0822: return "CBS_E_ILLEGAL_COMPONENT_UPDATE Component update without specifying & lt; updateComponent & gt; in package manifest.";
                case 0xf0823: return "CBS_E_NEW_SERVICING_STACK_REQUIRED Package needs a newer version of the servicing stack.";
                case 0xf0824: return "CBS_E_SOURCE_NOT_IN_LIST Package source not in list.";
                case 0xf0825: return "CBS_E_CANNOT_UNINSTALL Package cannot be uninstalled.";
                case 0xf0826: return "CBS_E_PENDING_VICTIM Package failed to install because another pended package failed.";
                case 0xf0827: return "CBS_E_STACK_SHUTDOWN_REQUIRED servicing stack updated, aborting";
                case 0xf0900: return "CBS_E_XML_PARSER_FAILURE unexpected internal XML parser error.";
                case 0xf0901: return "CBS_E_MANIFEST_VALIDATION_MULTIPLE_UPDATE_COMPONENT_ON_SAME_FAMILY_NOT_ALLOWED In a given package, only one &lt;updateComponent&gt; Is allowed for a component family.";
                    
                //Windows Update success codes
                case 0x240001: return "WU_S_SERVICE_STOP WindowsUpdate Windows Update Agent was stopped successfully";
                case 0x00240002: return "WU_S_SELFUPDATE Windows Update Agent updated itself";
                case 0x00240003: return "WU_S_UPDATE_ERROR Operation completed successfully but there were errors applying the updates";
                case 0x00240004: return "WU_S_MARKED_FOR_DISCONNECT A callback was marked to be disconnected later because the request to disconnect the operation came while a callback was executing";
                case 0x00240005: return "WU_S_REBOOT_REQUIRED The system must be restarted to complete installation of the update";
                case 0x00240006: return "WU_S_ALREADY_INSTALLED The update to be installed is already installed on the system";
                case 0x00240007: return "WU_S_ALREADY_UNINSTALLED The update to be removed is not installed on the system";
                case 0x00240008: return "WU_S_ALREADY_DOWNLOADED The update to be downloaded has already been downloaded ";
                    
                //Windows Update error codes
                case 0x80240001: return "WU_E_NO_SERVICE Windows Update Agent was unable to provide the service.";
                case 0x80240002: return "WU_E_MAX_CAPACITY_REACHED The maximum capacity of the service was exceeded.";
                case 0x80240003: return "WU_E_UNKNOWN_ID An ID cannot be found.";
                case 0x80240004: return "WU_E_NOT_INITIALIZED The object could not be initialized.";
                case 0x80240005: return "WU_E_RANGEOVERLAP The update handler requested a byte range overlapping a previously requested range.";
                case 0x80240006: return "WU_E_TOOMANYRANGES The requested number of byte ranges exceeds the maximum number (2^31 - 1).";
                case 0x80240007: return "WU_E_INVALIDINDEX The index to a collection was invalid.";
                case 0x80240008: return "WU_E_ITEMNOTFOUND The key for the item queried could not be found.";
                case 0x80240009: return "WU_E_OPERATIONINPROGRESS Another conflicting operation was in progress.Some operations such as installation cannot be performed twice simultaneously.";
                case 0x8024000A: return "WU_E_COULDNOTCANCEL Cancellation of the operation was not allowed.";
                case 0x8024000B: return "WU_E_CALL_CANCELLED Operation was cancelled.";
                case 0x8024000C: return "WU_E_NOOP No operation was required.";
                case 0x8024000D: return "WU_E_XML_MISSINGDATA Windows Update Agent could not find required information in the update&#39;s XML data.";
                case 0x8024000E: return "WU_E_XML_INVALID Windows Update Agent found invalid information in the update&#39;s XML data.";
                case 0x8024000F: return "WU_E_CYCLE_DETECTED Circular update relationships were detected in the metadata.";
                case 0x80240010: return "WU_E_TOO_DEEP_RELATION Update relationships too deep to evaluate were evaluated.";
                case 0x80240011: return "WU_E_INVALID_RELATIONSHIP An invalid update relationship was detected.";
                case 0x80240012: return "WU_E_REG_VALUE_INVALID An invalid registry value was read.";
                case 0x80240013: return "WU_E_DUPLICATE_ITEM Operation tried to add a duplicate item to a list.";
                case 0x80240016: return "WU_E_INSTALL_NOT_ALLOWED Operation tried to install while another installation was in progress or the system was pending a mandatory restart.";
                case 0x80240017: return "WU_E_NOT_APPLICABLE Operation was not performed because there are no applicable updates.";
                case 0x80240018: return "WU_E_NO_USERTOKEN Operation failed because a required user token is missing.";
                case 0x80240019: return "WU_E_EXCLUSIVE_INSTALL_CONFLICT An exclusive update cannot be installed with other updates at the same time.";
                case 0x8024001A: return "WU_E_POLICY_NOT_SET A policy value was not set.";
                case 0x8024001B: return "WU_E_SELFUPDATE_IN_PROGRESS The operation could not be performed because the Windows Update Agent is self-updating.";
                case 0x8024001D: return "WU_E_INVALID_UPDATE An update contains invalid metadata.";
                case 0x8024001E: return "WU_E_SERVICE_STOP Operation did not complete because the service or system was being shut down.";
                case 0x8024001F: return "WU_E_NO_CONNECTION Operation did not complete because the network connection was unavailable.";
                case 0x80240020: return "WU_E_NO_INTERACTIVE_USER Operation did not complete because there is no logged-on interactive user.";
                case 0x80240021: return "WU_E_TIME_OUT Operation did not complete because it timed out.";
                case 0x80240022: return "WU_E_ALL_UPDATES_FAILED Operation failed for all the updates.";
                case 0x80240023: return "WU_E_EULAS_DECLINED The license terms for all updates were declined.";
                case 0x80240024: return "WU_E_NO_UPDATE There are no updates.";
                case 0x80240025: return "WU_E_USER_ACCESS_DISABLED Group Policy settings prevented access to Windows Update.";
                case 0x80240026: return "WU_E_INVALID_UPDATE_TYPE The type of update is invalid.";
                case 0x80240027: return "WU_E_URL_TOO_LONG The URL exceeded the maximum length.";
                case 0x80240028: return "WU_E_UNINSTALL_NOT_ALLOWED The update could not be uninstalled because the request did not originate from a WSUS server.";
                case 0x80240029: return "WU_E_INVALID_PRODUCT_LICENSE Search may have missed some updates before there is an unlicensed application on the system.";
                case 0x8024002A: return "WU_E_MISSING_HANDLER A component required to detect applicable updates was missing.";
                case 0x8024002B: return "WU_E_LEGACYSERVER An operation did not complete because it requires a newer version of server.";
                case 0x8024002C: return "WU_E_BIN_SOURCE_ABSENT A delta-compressed update could not be installed because it required the source.";
                case 0x8024002D: return "WU_E_SOURCE_ABSENT A full-file update could not be installed because it required the source.";
                case 0x8024002E: return "WU_E_WU_DISABLED Access to an unmanaged server is not allowed.";
                case 0x8024002F: return "WU_E_CALL_CANCELLED_BY_POLICY Operation did not complete because the DisableWindowsUpdateAccess policy was set.";
                case 0x80240030: return "WU_E_INVALID_PROXY_SERVER The format of the proxy list was invalid.";
                case 0x80240031: return "WU_E_INVALID_FILE The file is in the wrong format.";
                case 0x80240032: return "WU_E_INVALID_CRITERIA The search criteria string was invalid.";
                case 0x80240033: return "WU_E_EULA_UNAVAILABLE License terms could not be downloaded.";
                case 0x80240034: return "WU_E_DOWNLOAD_FAILED Update failed to download.";
                case 0x80240035: return "WU_E_UPDATE_NOT_PROCESSED The update was not processed.";
                case 0x80240036: return "WU_E_INVALID_OPERATION The object&#39;s current state did not allow the operation.";
                case 0x80240037: return "WU_E_NOT_SUPPORTED The functionality for the operation is not supported.";
                case 0x80240038: return "WU_E_WINHTTP_INVALID_FILE The downloaded file has an unexpected content type.";
                case 0x80240039: return "WU_E_TOO_MANY_RESYNC Agent is asked by server to resync too many times.";
                case 0x80240040: return "WU_E_NO_SERVER_CORE_SUPPORT WUA API method does not run on Server Core installation.";
                case 0x80240041: return "WU_E_SYSPREP_IN_PROGRESS Service is not available while sysprep is running.";
                case 0x80240042: return "WU_E_UNKNOWN_SERVICE The update service is no longer registered with AU.";
                case 0x80240FFF: return "WU_E_UNEXPECTED An operation failed due to reasons not covered by another error code.";

                //Windows Installer minor errors The following errors are used to indicate that part of a search fails because of Windows Installer problems. Another part of the search may successfully return updates. All Windows Installer minor codes must share the same error code range so that the caller can tell that they are related to Windows Installer.
                case 0x80241001: return "WU_E_MSI_WRONG_VERSION Search may have missed some updates because the Windows Installer is less than version 3.1.";
                case 0x80241002: return "WU_E_MSI_NOT_CONFIGURED Search may have missed some updates because the Windows Installer is not configured.";
                case 0x80241003: return "WU_E_MSP_DISABLED Search may have missed some updates because policy has disabled Windows Installer patching.";
                case 0x80241004: return "WU_E_MSI_WRONG_APP_CONTEXT An update could not be applied because the application is installed per-user.";
                case 0x80241FFF: return "WU_E_MSP_UNEXPECTED Search may have missed some updates because there was a failure of the Windows Installer.";

                //Protocol Talker errors  The following errors map to SOAPCLIENT_ERRORs through the Atlsoap.h file. These errors are obtained when the CClientWebService object calls the
                case 0x80244000: return "WU_E_PT_SOAPCLIENT_BASE WU_E_PT_SOAPCLIENT_* error codes map to the SOAPCLIENT_ERROR enum of the ATL Server Library.";
                case 0x80244001: return "WU_E_PT_SOAPCLIENT_INITIALIZE Same as SOAPCLIENT_INITIALIZE_ERROR - initialization of the SOAP client failed, possibly because of an MSXML installation failure.";
                case 0x80244002: return "WU_E_PT_SOAPCLIENT_OUTOFMEMORY Same as SOAPCLIENT_OUTOFMEMORY - SOAP client failed because it ran out of memory.";
                case 0x80244003: return "WU_E_PT_SOAPCLIENT_GENERATE Same as SOAPCLIENT_GENERATE_ERROR - SOAP client failed to generate the request.";
                case 0x80244004: return "WU_E_PT_SOAPCLIENT_CONNECT Same as SOAPCLIENT_CONNECT_ERROR - SOAP client failed to connect to the server.";
                case 0x80244005: return "WU_E_PT_SOAPCLIENT_SEND Same as SOAPCLIENT_SEND_ERROR - SOAP client failed to send a message for reasons of WU_E_WINHTTP_* error codes.";
                case 0x80244006: return "WU_E_PT_SOAPCLIENT_SERVER Same as SOAPCLIENT_SERVER_ERROR - SOAP client failed because there was a server error.";
                case 0x80244007: return "WU_E_PT_SOAPCLIENT_SOAPFAULT Same as SOAPCLIENT_SOAPFAULT - SOAP client failed because there was a SOAP fault for reasons of WU_E_PT_SOAP_* error codes.";
                case 0x80244008: return "WU_E_PT_SOAPCLIENT_PARSEFAULT Same as SOAPCLIENT_PARSEFAULT_ERROR - SOAP client failed to parse a SOAP fault.";
                case 0x80244009: return "WU_E_PT_SOAPCLIENT_READ Same as SOAPCLIENT_READ_ERROR - SOAP client failed while reading the response from the server.";
                case 0x8024400A: return "WU_E_PT_SOAPCLIENT_PARSE Same as SOAPCLIENT_PARSE_ERROR - SOAP client failed to parse the response from the server.";

                //Protocol Talker errors The following errors map to SOAP_ERROR_CODEs from the Atlsoap.h file. These errors are obtained from the m_fault.m_soapErrCode member of the CClientWebService object when ";
                case 0x8024400B: return "WU_E_PT_SOAP_VERSION Same as SOAP_E_VERSION_MISMATCH - SOAP client found an unrecognizable namespace for the SOAP envelope.";
                case 0x8024400C: return "WU_E_PT_SOAP_MUST_UNDERSTAND Same as SOAP_E_MUST_UNDERSTAND - SOAP client was unable to understand a header.";
                case 0x8024400D: return "WU_E_PT_SOAP_CLIENT Same as SOAP_E_CLIENT - SOAP client found the message was malformed; fix before resending.";
                case 0x8024400E: return "WU_E_PT_SOAP_SERVER Same as SOAP_E_SERVER - The SOAP message could not be processed due to a server error; resend later.";
                case 0x8024400F: return "WU_E_PT_WMI_ERROR There was an unspecified Windows Management Instrumentation (WMI) error.";
                case 0x80244010: return "WU_E_PT_EXCEEDED_MAX_SERVER_TRIPS The number of round trips to the server exceeded the maximum limit.";
                case 0x80244011: return "WU_E_PT_SUS_SERVER_NOT_SET WUServer policy value is missing in the registry.";
                case 0x80244012: return "WU_E_PT_DOUBLE_INITIALIZATION Initialization failed because the object was already initialized.";
                case 0x80244013: return "WU_E_PT_INVALID_COMPUTER_NAME The computer name could not be determined.";
                case 0x80244014: return "WU_E_PT_INVALID_COMPUTER_LSID Cannot determine computer LSID.";
                case 0x80244015: return "WU_E_PT_REFRESH_CACHE_REQUIRED The reply from the server indicates that the server was changed or the cookie was invalid; refresh the state of the internal cache and retry.";
                case 0x80244016: return "WU_E_PT_HTTP_STATUS_BAD_REQUEST Same as HTTP status 400 - the server could not process the request due to invalid syntax.";
                case 0x80244017: return "WU_E_PT_HTTP_STATUS_DENIED Same as HTTP status 401 - the requested resource requires user authentication.";
                case 0x80244018: return "WU_E_PT_HTTP_STATUS_FORBIDDEN Same as HTTP status 403 - server understood the request, but declined to fulfill it.";
                case 0x80244019: return "WU_E_PT_HTTP_STATUS_NOT_FOUND Same as HTTP status 404 - the server cannot find the requested URI (Uniform Resource Identifier)";
                case 0x8024401A: return "WU_E_PT_HTTP_STATUS_BAD_METHOD Same as HTTP status 405 - the HTTP method is not allowed.";
                case 0x8024401B: return "WU_E_PT_HTTP_STATUS_PROXY_AUTH_REQ Same as HTTP status 407 - proxy authentication is required.";
                case 0x8024401C: return "WU_E_PT_HTTP_STATUS_REQUEST_TIMEOUT Same as HTTP status 408 - the server timed out waiting for the request.";
                case 0x8024401D: return "WU_E_PT_HTTP_STATUS_CONFLICT Same as HTTP status 409 - the request was not completed due to a conflict with the current state of the resource.";
                case 0x8024401E: return "WU_E_PT_HTTP_STATUS_GONE Same as HTTP status 410 - requested resource is no longer available at the server.";
                case 0x8024401F: return "WU_E_PT_HTTP_STATUS_SERVER_ERROR Same as HTTP status 500 - an error internal to the server prevented fulfilling the request.";
                case 0x80244020: return "WU_E_PT_HTTP_STATUS_NOT_SUPPORTED Same as HTTP status 500 - server does not support the functionality required to fulfill the request.";
                case 0x80244021: return "WU_E_PT_HTTP_STATUS_BAD_GATEWAY Same as HTTP status 502 - the server, while acting as a gateway or proxy, received an invalid response from the upstream server it accessed in attempting to fulfill the request.";
                case 0x80244022: return "WU_E_PT_HTTP_STATUS_SERVICE_UNAVAIL Same as HTTP status 503 - the service is temporarily overloaded.";
                case 0x80244023: return "WU_E_PT_HTTP_STATUS_GATEWAY_TIMEOUT Same as HTTP status 503 - the request was timed out waiting for a gateway.";
                case 0x80244024: return "WU_E_PT_HTTP_STATUS_VERSION_NOT_SUP Same as HTTP status 505 - the server does not support the HTTP protocol version used for the request.";
                case 0x80244025: return "WU_E_PT_FILE_LOCATIONS_CHANGED Operation failed due to a changed file location; refresh internal state and resend.";
                case 0x80244026: return "WU_E_PT_REGISTRATION_NOT_SUPPORTED Operation failed because Windows Update Agent does not support registration with a non-WSUS server.";
                case 0x80244027: return "WU_E_PT_NO_AUTH_PLUGINS_REQUESTED The server returned an empty authentication information list.";
                case 0x80244028: return "WU_E_PT_NO_AUTH_COOKIES_CREATED Windows Update Agent was unable to create any valid authentication cookies.";
                case 0x80244029: return "WU_E_PT_INVALID_CONFIG_PROP A configuration property value was wrong.";
                case 0x8024402A: return "WU_E_PT_CONFIG_PROP_MISSING A configuration property value was missing.";
                case 0x8024402B: return "WU_E_PT_HTTP_STATUS_NOT_MAPPED The HTTP request could not be completed and the reason did not correspond to any of the WU_E_PT_HTTP_* error codes.";
                case 0x8024402C: return "WU_E_PT_WINHTTP_NAME_NOT_RESOLVED Same as ERROR_WINHTTP_NAME_NOT_RESOLVED - the proxy server or target server name cannot be resolved.";
                case 0x8024502D: return "WU_E_PT_SAME_REDIR_ID Windows Update Agent failed to download a redirector cabinet file with a new redirectorId value from the server during the recovery.";
                case 0x8024502E: return "WU_E_PT_NO_MANAGED_RECOVER A redirector recovery action did not complete because the server is managed.";
                case 0x8024402F: return "WU_E_PT_ECP_SUCCEEDED_WITH_ERRORS External cab file processing completed with some errors.";
                case 0x80244030: return "WU_E_PT_ECP_INIT_FAILED The external cab processor initialization did not complete.";
                case 0x80244031: return "WU_E_PT_ECP_INVALID_FILE_FORMAT The format of a metadata file was invalid.";
                case 0x80244032: return "WU_E_PT_ECP_INVALID_METADATA External cab processor found invalid metadata.";
                case 0x80244033: return "WU_E_PT_ECP_FAILURE_TO_EXTRACT_DIGEST The file digest could not be extracted from an external cab file.";
                case 0x80244034: return "WU_E_PT_ECP_FAILURE_TO_DECOMPRESS_CAB_FILE An external cab file could not be decompressed.";
                case 0x80244035: return "WU_E_PT_ECP_FILE_LOCATION_ERROR External cab processor was unable to get file locations.";
                case 0x80244FFF: return "WU_E_PT_UNEXPECTED A communication error not covered by another WU_E_PT_* error code.";

                //Redirector errors The components that download the Wuredir.cab file and then parse the Wuredir.cab file generate the following errors.
                case 0x80245001: return "WU_E_REDIRECTOR_LOAD_XML The redirector XML document could not be loaded into the DOM class.";
                case 0x80245002: return "WU_E_REDIRECTOR_S_FALSE The redirector XML document is missing some required information.";
                case 0x80245003: return "WU_E_REDIRECTOR_ID_SMALLER The redirectorId in the downloaded redirector cab is less than in the cached cab.";
                case 0x80245FFF: return "WU_E_REDIRECTOR_UNEXPECTED The redirector failed for reasons not covered by another WU_E_REDIRECTOR_* error code.";

                //Driver util errors The PnP enumerated device is removed from the System Spec because one of the hardware IDs or the compatible IDs matches an installed printer driver. This is not a fatal error, and the device is merely skipped.";
                case 0x8024C001: return "WU_E_DRV_PRUNED A driver was skipped.";
                case 0x8024C002: return "WU_E_DRV_NOPROP_OR_LEGACY A property for the driver could not be found. It may not conform with required specifications.";
                case 0x8024C003: return "WU_E_DRV_REG_MISMATCH The registry type read for the driver does not match the expected type.";
                case 0x8024C004: return "WU_E_DRV_NO_METADATA The driver update is missing metadata.";
                case 0x8024C005: return "WU_E_DRV_MISSING_ATTRIBUTE The driver update is missing a required attribute.";
                case 0x8024C006: return "WU_E_DRV_SYNC_FAILED Driver synchronization failed.";
                case 0x8024C007: return "WU_E_DRV_NO_PRINTER_CONTENT Information required for the synchronization of applicable printers is missing.";
                case 0x8024CFFF: return "WU_E_DRV_UNEXPECTED A driver error not covered by another WU_E_DRV_* code.";

                //Data store errors
                case 0x80248000: return "WU_E_DS_SHUTDOWN An operation failed because Windows Update Agent is shutting down.";
                case 0x80248001: return "WU_E_DS_INUSE An operation failed because the data store was in use.";
                case 0x80248002: return "WU_E_DS_INVALID The current and expected states of the data store do not match.";
                case 0x80248003: return "WU_E_DS_TABLEMISSING The data store is missing a table.";
                case 0x80248004: return "WU_E_DS_TABLEINCORRECT The data store contains a table with unexpected columns.";
                case 0x80248005: return "WU_E_DS_INVALIDTABLENAME A table could not be opened because the table is not in the data store.";
                case 0x80248006: return "WU_E_DS_BADVERSION The current and expected versions of the data store do not match.";
                case 0x80248007: return "WU_E_DS_NODATA The information requested is not in the data store.";
                case 0x80248008: return "WU_E_DS_MISSINGDATA The data store is missing required information or has a NULL in a table column that requires a non-null value.";
                case 0x80248009: return "WU_E_DS_MISSINGREF The data store is missing required information or has a reference to missing license terms, file, localized property or linked row.";
                case 0x8024800A: return "WU_E_DS_UNKNOWNHANDLER The update was not processed because its update handler could not be recognized.";
                case 0x8024800B: return "WU_E_DS_CANTDELETE The update was not deleted because it is still referenced by one or more services.";
                case 0x8024800C: return "WU_E_DS_LOCKTIMEOUTEXPIRED The data store section could not be locked within the allotted time.";
                case 0x8024800D: return "WU_E_DS_NOCATEGORIES The category was not added because it contains no parent categories and is not a top-level category itself.";
                case 0x8024800E: return "WU_E_DS_ROWEXISTS The row was not added because an existing row has the same primary key.";
                case 0x8024800F: return "WU_E_DS_STOREFILELOCKED The data store could not be initialized because it was locked by another process.";
                case 0x80248010: return "WU_E_DS_CANNOTREGISTER The data store is not allowed to be registered with COM in the current process.";
                case 0x80248011: return "WU_E_DS_UNABLETOSTART Could not create a data store object in another process.";
                case 0x80248013: return "WU_E_DS_DUPLICATEUPDATEID The server sent the same update to the client with two different revision IDs.";
                case 0x80248014: return "WU_E_DS_UNKNOWNSERVICE An operation did not complete because the service is not in the data store.";
                case 0x80248015: return "WU_E_DS_SERVICEEXPIRED An operation did not complete because the registration of the service has expired.";
                case 0x80248016: return "WU_E_DS_DECLINENOTALLOWED A request to hide an update was declined because it is a mandatory update or because it was deployed with a deadline.";
                case 0x80248017: return "WU_E_DS_TABLESESSIONMISMATCH A table was not closed because it is not associated with the session.";
                case 0x80248018: return "WU_E_DS_SESSIONLOCKMISMATCH A table was not closed because it is not associated with the session.";
                case 0x80248019: return "WU_E_DS_NEEDWINDOWSSERVICE A request to remove the Windows Update service or to unregister it with Automatic Updates was declined because it is a built-in service and/or Automatic Updates cannot fall back to another service.";
                case 0x8024801A: return "WU_E_DS_INVALIDOPERATION A request was declined because the operation is not allowed.";
                case 0x8024801B: return "WU_E_DS_SCHEMAMISMATCH The schema of the current data store and the schema of a table in a backup XML document do not match.";
                case 0x8024801C: return "WU_E_DS_RESETREQUIRED The data store requires a session reset; release the session and retry with a new session.";
                case 0x8024801D: return "WU_E_DS_IMPERSONATED A data store operation did not complete because it was requested with an impersonated identity.";
                case 0x80248FFF: return "WU_E_DS_UNEXPECTED A data store error not covered by another WU_E_DS_* code.";
                
                //Inventory errors
                case 0x80249001: return "WU_E_INVENTORY_PARSEFAILED Parsing of the rule file failed.";
                case 0x80249002: return "WU_E_INVENTORY_GET_INVENTORY_TYPE_FAILED Failed to get the requested inventory type from the server.";
                case 0x80249003: return "WU_E_INVENTORY_RESULT_UPLOAD_FAILED Failed to upload inventory result to the server.";
                case 0x80249004: return "WU_E_INVENTORY_UNEXPECTED There was an inventory error not covered by another error code.";
                case 0x80249005: return "WU_E_INVENTORY_WMI_ERROR A WMI error occurred when enumerating the instances for a particular class.";
                
                //AU errors";
                case 0x8024A000: return "WU_E_AU_NOSERVICE Automatic Updates was unable to service incoming requests.";
                case 0x8024A002: return "WU_E_AU_NONLEGACYSERVER The old version of the Automatic Updates client has stopped because the WSUS server has been upgraded.";
                case 0x8024A003: return "WU_E_AU_LEGACYCLIENTDISABLED The old version of the Automatic Updates client was disabled.";
                case 0x8024A004: return "WU_E_AU_PAUSED Automatic Updates was unable to process incoming requests because it was paused.";
                case 0x8024A005: return "WU_E_AU_NO_REGISTERED_SERVICE No unmanaged service is registered with AU.";
                case 0x8024AFFF: return "WU_E_AU_UNEXPECTED An Automatic Updates error not covered by another WU_E_AU* code.";

                //Update handler errors
                case 0x80242000: return "WU_E_UH_REMOTEUNAVAILABLE A request for a remote update handler could not be completed because no remote process is available.";
                case 0x80242001: return "WU_E_UH_LOCALONLY A request for a remote update handler could not be completed because the handler is local only.";
                case 0x80242002: return "WU_E_UH_UNKNOWNHANDLER A request for an update handler could not be completed because the handler could not be recognized.";
                case 0x80242003: return "WU_E_UH_REMOTEALREADYACTIVE A remote update handler could not be created because one already exists.";
                case 0x80242004: return "WU_E_UH_DOESNOTSUPPORTACTION A request for the handler to install (uninstall) an update could not be completed because the update does not support install (uninstall).";
                case 0x80242005: return "WU_E_UH_WRONGHANDLER An operation did not complete because the wrong handler was specified.";
                case 0x80242006: return "WU_E_UH_INVALIDMETADATA A handler operation could not be completed because the update contains invalid metadata.";
                case 0x80242007: return "WU_E_UH_INSTALLERHUNG An operation could not be completed because the installer exceeded the time limit.";
                case 0x80242008: return "WU_E_UH_OPERATIONCANCELLED An operation being done by the update handler was cancelled.";
                case 0x80242009: return "WU_E_UH_BADHANDLERXML An operation could not be completed because the handler-specific metadata is invalid.";
                case 0x8024200A: return "WU_E_UH_CANREQUIREINPUT A request to the handler to install an update could not be completed because the update requires user input.";
                case 0x8024200B: return "WU_E_UH_INSTALLERFAILURE The installer failed to install (uninstall) one or more updates.";
                case 0x8024200C: return "WU_E_UH_FALLBACKTOSELFCONTAINED The update handler should download self-contained content rather than delta-compressed content for the update.";
                case 0x8024200D: return "WU_E_UH_NEEDANOTHERDOWNLOAD The update handler did not install the update because it needs to be downloaded again.";
                case 0x8024200E: return "WU_E_UH_NOTIFYFAILURE The update handler failed to send notification of the status of the install (uninstall) operation.";
                case 0x8024200F: return "WU_E_UH_INCONSISTENT_FILE_NAMES The file names contained in the update metadata and in the update package are inconsistent.";
                case 0x80242010: return "WU_E_UH_FALLBACKERROR The update handler failed to fall back to the self-contained content.";
                case 0x80242011: return "WU_E_UH_TOOMANYDOWNLOADREQUESTS The update handler has exceeded the maximum number of download requests.";
                case 0x80242012: return "WU_E_UH_UNEXPECTEDCBSRESPONSE The update handler has received an unexpected response from CBS.";
                case 0x80242013: return "WU_E_UH_BADCBSPACKAGEID The update metadata contains an invalid CBS package identifier.";
                case 0x80242014: return "WU_E_UH_POSTREBOOTSTILLPENDING The post-reboot operation for the update is still in progress.";
                case 0x80242015: return "WU_E_UH_POSTREBOOTRESULTUNKNOWN The result of the post-reboot operation for the update could not be determined.";
                case 0x80242016: return "WU_E_UH_POSTREBOOTUNEXPECTEDSTATE The state of the update after its post-reboot operation has completed is unexpected.";
                case 0x80242017: return "WU_E_UH_NEW_SERVICING_STACK_REQUIRED The OS servicing stack must be updated before this update is downloaded or installed.";
                case 0x80242FFF: return "WU_E_UH_UNEXPECTED An update handler error not covered by another WU_E_UH_* code. ";

                //Download manager errors
                case 0x80246001: return "WU_E_DM_URLNOTAVAILABLE A download manager operation could not be completed because the requested file does not have a URL.";
                case 0x80246002: return "WU_E_DM_INCORRECTFILEHASH A download manager operation could not be completed because the file digest was not recognized.";
                case 0x80246003: return "WU_E_DM_UNKNOWNALGORITHM A download manager operation could not be completed because the file metadata requested an unrecognized hash algorithm.";
                case 0x80246004: return "WU_E_DM_NEEDDOWNLOADREQUEST An operation could not be completed because a download request is required from the download handler.";
                case 0x80246005: return "WU_E_DM_NONETWORK A download manager operation could not be completed because the network connection was unavailable.";
                case 0x80246006: return "WU_E_DM_WRONGBITSVERSION A download manager operation could not be completed because the version of Background Intelligent Transfer Service (BITS) is incompatible.";
                case 0x80246007: return "WU_E_DM_NOTDOWNLOADED The update has not been downloaded.";
                case 0x80246008: return "WU_E_DM_FAILTOCONNECTTOBITS A download manager operation failed because the download manager was unable to connect the Background Intelligent Transfer Service (BITS).";
                case 0x80246009: return "WU_E_DM_BITSTRANSFERERROR A download manager operation failed because there was an unspecified Background Intelligent Transfer Service (BITS) transfer error.";
                case 0x8024600A: return "WU_E_DM_DOWNLOADLOCATIONCHANGED A download must be restarted because the location of the source of the download has changed.";
                case 0x8024600B: return "WU_E_DM_CONTENTCHANGED A download must be restarted because the update content changed in a new revision.";
                case 0x80246FFF: return "WU_E_DM_UNEXPECTED There was a download manager error not covered by another WU_E_DM_* error code.";

                //Setup and SelfUpdate errors
                case 0x8024D001: return "WU_E_SETUP_INVALID_INFDATA Windows Update Agent could not be updated because an INF file contains invalid information.";
                case 0x8024D002: return "WU_E_SETUP_INVALID_IDENTDATA Windows Update Agent could not be updated because the wuident.cab file contains invalid information.";
                case 0x8024D003: return "WU_E_SETUP_ALREADY_INITIALIZED Windows Update Agent could not be updated because of an internal error that caused setup initialization to be performed twice.";
                case 0x8024D004: return "WU_E_SETUP_NOT_INITIALIZED Windows Update Agent could not be updated because setup initialization never completed successfully.";
                case 0x8024D005: return "WU_E_SETUP_SOURCE_VERSION_MISMATCH Windows Update Agent could not be updated because the versions specified in the INF do not match the actual source file versions.";
                case 0x8024D006: return "WU_E_SETUP_TARGET_VERSION_GREATER Windows Update Agent could not be updated because a WUA file on the target system is newer than the corresponding source file.";
                case 0x8024D007: return "WU_E_SETUP_REGISTRATION_FAILED Windows Update Agent could not be updated because regsvr32.exe returned an error.";
                case 0x8024D008: return "WU_E_SELFUPDATE_SKIP_ON_FAILURE An update to the Windows Update Agent was skipped because previous attempts to update have failed.";
                case 0x8024D009: return "WU_E_SETUP_SKIP_UPDATE An update to the Windows Update Agent was skipped due to a directive in the wuident.cab file.";
                case 0x8024D00A: return "WU_E_SETUP_UNSUPPORTED_CONFIGURATION Windows Update Agent could not be updated because the current system configuration is not supported.";
                case 0x8024D00B: return "WU_E_SETUP_BLOCKED_CONFIGURATION Windows Update Agent could not be updated because the system is configured to block the update.";
                case 0x8024D00C: return "WU_E_SETUP_REBOOT_TO_FIX Windows Update Agent could not be updated because a restart of the system is required.";
                case 0x8024D00D: return "WU_E_SETUP_ALREADYRUNNING Windows Update Agent setup is already running.";
                case 0x8024D00E: return "WU_E_SETUP_REBOOTREQUIRED Windows Update Agent setup package requires a reboot to complete installation.";
                case 0x8024D00F: return "WU_E_SETUP_HANDLER_EXEC_FAILURE Windows Update Agent could not be updated because the setup handler failed during execution.";
                case 0x8024D010: return "WU_E_SETUP_INVALID_REGISTRY_DATA Windows Update Agent could not be updated because the registry contains invalid information.";
                case 0x8024D011: return "WU_E_SELFUPDATE_REQUIRED Windows Update Agent must be updated before search can continue.";
                case 0x8024D012: return "WU_E_SELFUPDATE_REQUIRED_ADMIN Windows Update Agent must be updated before search can continue. An administrator is required to perform the operation.";
                case 0x8024D013: return "WU_E_SETUP_WRONG_SERVER_VERSION Windows Update Agent could not be updated because the server does not contain update information for this version.";
                case 0x8024DFFF: return "WU_E_SETUP_UNEXPECTED Windows Update Agent could not be updated because of an error not covered by another WU_E_SETUP_* error code.";

                //Expression evaluator errors
                case 0x8024E001: return "WU_E_EE_UNKNOWN_EXPRESSION An expression evaluator operation could not be completed because an expression was unrecognized.";
                case 0x8024E002: return "WU_E_EE_INVALID_EXPRESSION An expression evaluator operation could not be completed because an expression was invalid.";
                case 0x8024E003: return "WU_E_EE_MISSING_METADATA An expression evaluator operation could not be completed because an expression contains an incorrect number of metadata nodes.";
                case 0x8024E004: return "WU_E_EE_INVALID_VERSION An expression evaluator operation could not be completed because the version of the serialized expression data is invalid.";
                case 0x8024E005: return "WU_E_EE_NOT_INITIALIZED The expression evaluator could not be initialized.";
                case 0x8024E006: return "WU_E_EE_INVALID_ATTRIBUTEDATA An expression evaluator operation could not be completed because there was an invalid attribute.";
                case 0x8024E007: return "WU_E_EE_CLUSTER_ERROR An expression evaluator operation could not be completed because the cluster state of the computer could not be determined.";
                case 0x8024EFFF: return "WU_E_EE_UNEXPECTED There was an expression evaluator error not covered by another WU_E_EE_* error code.";
                
                //UI errors
                case 0x80243001: return "WU_E_INSTALLATION_RESULTS_UNKNOWN_VERSION The results of download and installation could not be read from the registry due to an unrecognized data format version.";
                case 0x80243002: return "WU_E_INSTALLATION_RESULTS_INVALID_DATA The results of download and installation could not be read from the registry due to an invalid data format.";
                case 0x80243003: return "WU_E_INSTALLATION_RESULTS_NOT_FOUND The results of download and installation are not available; the operation may have failed to start.";
                case 0x80243004: return "WU_E_TRAYICON_FAILURE A failure occurred when trying to create an icon in the taskbar notification area.";
                case 0x80243FFD: return "WU_E_NON_UI_MODE Unable to show UI when in non-UI mode; WU client UI modules may not be installed.";
                case 0x80243FFE: return "WU_E_WUCLTUI_UNSUPPORTED_VERSION Unsupported version of WU client UI exported functions.";
                case 0x80243FFF: return "WU_E_AUCLIENT_UNEXPECTED There was a user interface error not covered by another WU_E_AUCLIENT_* error code. ";

                //Reporter errors
                case 0x8024F001: return "WU_E_REPORTER_EVENTCACHECORRUPT The event cache file was defective.";
                case 0x8024F002: return "WU_E_REPORTER_EVENTNAMESPACEPARSEFAILED The XML in the event namespace descriptor could not be parsed.";
                case 0x8024F003: return "WU_E_INVALID_EVENT The XML in the event namespace descriptor could not be parsed.";
                case 0x8024F004: return "WU_E_SERVER_BUSY The server rejected an event because the server was too busy.";
                case 0x8024FFFF: return "WU_E_REPORTER_UNEXPECTED There was a reporter error not covered by another error code.";
                case 0x80247001: return "WU_E_OL_INVALID_SCANFILE An operation could not be completed because the scan package was invalid.";
                case 0x80247002: return "WU_E_OL_NEWCLIENT_REQUIRED An operation could not be completed because the scan package requires a greater version of the Windows Update Agent.";
                case 0x80247FFF: return "WU_E_OL_UNEXPECTED Search using the scan package failed.";

                default:
                    return "Unknown Error: " + id;
            }
        }
    }
}

& .\AccountManagement\AccountManagement.Host\bin\Debug\NServiceBus.Host.exe /install /startManually
& .\Billing\Billing.Host\bin\Debug\NServiceBus.Host.exe /install /startManually
& .\Communications\Communications.Host\bin\Debug\NServiceBus.Host.exe /install /startManually

& .\AccountManagement\AccountManagement.Host\bin\Debug\NServiceBus.Host.exe -new_console:sH
& .\Billing\Billing.Host\bin\Debug\NServiceBus.Host.exe -new_console:s67V
& .\Communications\Communications.Host\bin\Debug\NServiceBus.Host.exe -new_console:s33V

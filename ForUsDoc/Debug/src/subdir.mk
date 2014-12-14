################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/AppResourceId.cpp \
../src/Enrollment.cpp \
../src/ForUsDocApp.cpp \
../src/ForUsDocEntry.cpp \
../src/ForUsDocForm.cpp \
../src/ForUsDocFrame.cpp \
../src/FormFactory.cpp 

OBJS += \
./src/AppResourceId.o \
./src/Enrollment.o \
./src/ForUsDocApp.o \
./src/ForUsDocEntry.o \
./src/ForUsDocForm.o \
./src/ForUsDocFrame.o \
./src/FormFactory.o 

CPP_DEPS += \
./src/AppResourceId.d \
./src/Enrollment.d \
./src/ForUsDocApp.d \
./src/ForUsDocEntry.d \
./src/ForUsDocForm.d \
./src/ForUsDocFrame.d \
./src/FormFactory.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	clang++.exe -I"pch" -D_DEBUG -I"C:\Users\div_S\tizen\ForUsDoc\inc" -O0 -g3 -Wall -c -fmessage-length=0 -target arm-tizen-linux-gnueabi -gcc-toolchain "C:/tizen-sdk/tools/smart-build-interface/../arm-linux-gnueabi-gcc-4.5/" -ccc-gcc-name arm-linux-gnueabi-g++ -march=armv7-a -mfloat-abi=softfp -mfpu=vfpv3-d16 -mtune=cortex-a8 -Wno-gnu -fPIE --sysroot="C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include/libxml2" -I"C:\tizen-sdk\library" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include/osp" -D_APP_LOG -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '



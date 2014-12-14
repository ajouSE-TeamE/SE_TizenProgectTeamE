S/W Version Information
Model: Ref.Device-PQ
Tizen-Version: 2.2.1
Build-Number: Tizen_Ref.Device-PQ_20131118.1124
Build-Date: 2013.11.18 11:24:59

Crash Information
Process Name: ForUsDoc
PID: 9722
Date: 2015-02-09 03:30:32(GMT+0900)
Executable File Path: /opt/apps/tGwjUrErhZ/bin/ForUsDoc
This process is multi-thread process
pid=9722 tid=9722
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9722, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x0041bf48, r3   = 0x00000000
r4   = 0xb261e658, r5   = 0x00000000
r6   = 0xbedd4924, r7   = 0x004585c8
r8   = 0xbedd4940, r9   = 0x000aec38
r10  = 0xb4413940, fp   = 0xbedd4a88
ip   = 0xb6bd1000, sp   = 0xbedd48d0
lr   = 0xb25cab0d, pc   = 0xb25ae8c8
cpsr = 0x60000030

Memory Information
MemTotal:   797320 KB
MemFree:    246356 KB
Buffers:     51340 KB
Cached:     250668 KB
VmPeak:      96732 KB
VmSize:      89528 KB
VmLck:           0 KB
VmHWM:       34164 KB
VmRSS:       34164 KB
VmData:      15856 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       43544 KB
VmPTE:          86 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 000dc000 rw-p [heap]
000dc000 0096b000 rw-p [heap]
b1c57000 b1c5c000 r-xp /usr/lib/libhaptic-module.so
b245c000 b246d000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2476000 b247b000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b24b0000 b24b3000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b24bb000 b24bc000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b24c4000 b24ce000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b24fa000 b250e000 r-xp /usr/lib/libnetwork.so.0.0.0
b2517000 b252b000 r-xp /usr/lib/libwifi-direct.so.0.0
b2533000 b253b000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b253c000 b2545000 r-xp /usr/lib/libcapi-network-connection.so.0.1.3_18
b254d000 b2612000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2620000 b2629000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b2632000 b2647000 r-xp /opt/usr/apps/tGwjUrErhZ/bin/ForUsDoc.exe
b2650000 b26c2000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b26ca000 b2704000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b270d000 b2711000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2719000 b274a000 r-xp /usr/lib/libpulse.so.0.12.4
b2752000 b27b5000 r-xp /usr/lib/libasound.so.2.0.0
b27bf000 b27c2000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b27ca000 b27ce000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b27d7000 b27f4000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b27fc000 b280a000 r-xp /usr/lib/libmmfsound.so.0.1.0
b2812000 b28ae000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b28ba000 b28fb000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b2904000 b290d000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b2915000 b2922000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b292b000 b2931000 r-xp /usr/lib/libUMP.so
b2939000 b293c000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2944000 b2953000 r-xp /usr/lib/libICE.so.6.3.0
b295d000 b2962000 r-xp /usr/lib/libSM.so.6.0.1
b296a000 b296b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2973000 b297b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2983000 b298b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b2996000 b2999000 r-xp /usr/lib/libmmfsession.so.0.0.0
b29a1000 b29e5000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b29ee000 b2a01000 r-xp /usr/lib/libEGL_platform.so
b2a0a000 b2ae1000 r-xp /usr/lib/libMali.so
b2aec000 b2af2000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2afa000 b2afb000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2b04000 b2b42000 r-xp /usr/lib/libGLESv2.so.2.0
b2b4a000 b2b95000 r-xp /usr/lib/libtiff.so.5.1.0
b2ba0000 b2bc9000 r-xp /usr/lib/libturbojpeg.so
b2be2000 b2be8000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b2bf0000 b2bf6000 r-xp /usr/lib/libgif.so.4.1.6
b2bfe000 b2c20000 r-xp /usr/lib/libavutil.so.51.73.101
b2c2f000 b2c5d000 r-xp /usr/lib/libswscale.so.2.1.101
b2c66000 b2f5d000 r-xp /usr/lib/libavcodec.so.54.59.100
b3284000 b329d000 r-xp /usr/lib/libpng12.so.0.50.0
b32a6000 b32ac000 r-xp /usr/lib/libfeedback.so.0.1.4
b32b4000 b32c0000 r-xp /usr/lib/libtts.so
b32c8000 b32df000 r-xp /usr/lib/libEGL.so.1.4
b32e8000 b339f000 r-xp /usr/lib/libcairo.so.2.11200.12
b33a9000 b33c3000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b33cc000 b3cc7000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b3d3a000 b3d3f000 r-xp /usr/lib/libslp_devman_plugin.so
b3d48000 b3d4b000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d53000 b3d57000 r-xp /usr/lib/libsysman.so.0.2.0
b3d5f000 b3d70000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3d79000 b3d7b000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b3d83000 b3d85000 r-xp /usr/lib/libdeviced.so.0.1.0
b3d8d000 b3da3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b3dab000 b3dad000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3db5000 b3db8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3dc0000 b3dc3000 r-xp /usr/lib/libdevice-node.so.0.1
b3dcb000 b3dcf000 r-xp /usr/lib/libheynoti.so.0.0.2
b3dd7000 b3e1c000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b3e25000 b3e3a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3e43000 b3e47000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3e4f000 b3e54000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3e5c000 b3e5d000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b3e66000 b3e69000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3e71000 b3e74000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b3e7d000 b3e80000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b3e88000 b3e89000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b3e91000 b3e9f000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b3ea8000 b3eca000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b3ed2000 b3ed5000 r-xp /usr/lib/libuuid.so.1.3.0
b3ede000 b3efc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b3f04000 b3f1b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3f24000 b3f25000 r-xp /usr/lib/libpmapi.so.1.2
b3f2d000 b3f35000 r-xp /usr/lib/libminizip.so.1.0.0
b3f3d000 b3f48000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3f50000 b4028000 r-xp /usr/lib/libxml2.so.2.7.8
b4035000 b4053000 r-xp /usr/lib/libpcre.so.0.0.1
b405b000 b405e000 r-xp /usr/lib/libiniparser.so.0
b4067000 b406b000 r-xp /usr/lib/libhaptic.so.0.1
b4073000 b407e000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b408b000 b4090000 r-xp /usr/lib/libdevman.so.0.1
b4099000 b409d000 r-xp /usr/lib/libchromium.so.1.0
b40a5000 b40ab000 r-xp /usr/lib/libappsvc.so.0.1.0
b40b3000 b40b4000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b40c4000 b40c6000 r-xp /opt/usr/apps/tGwjUrErhZ/bin/ForUsDoc
b40ce000 b40d4000 r-xp /usr/lib/libalarm.so.0.0.0
b40dd000 b40ef000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b40f7000 b43f6000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b441d000 b4427000 r-xp /lib/libnss_files-2.13.so
b4430000 b4439000 r-xp /lib/libnss_nis-2.13.so
b4442000 b4453000 r-xp /lib/libnsl-2.13.so
b445e000 b4464000 r-xp /lib/libnss_compat-2.13.so
b446d000 b4476000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b479e000 b47af000 r-xp /usr/lib/libcom-core.so.0.0.1
b47b7000 b47b9000 r-xp /usr/lib/libdri2.so.0.0.0
b47c1000 b47c9000 r-xp /usr/lib/libdrm.so.2.4.0
b47d1000 b47d5000 r-xp /usr/lib/libtbm.so.1.0.0
b47dd000 b47e0000 r-xp /usr/lib/libXv.so.1.0.0
b47e8000 b48b3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b48c9000 b48d9000 r-xp /usr/lib/libnotification.so.0.1.0
b48e1000 b4905000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b490e000 b491e000 r-xp /lib/libresolv-2.13.so
b4922000 b4924000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b492c000 b4a7f000 r-xp /usr/lib/libcrypto.so.1.0.0
b4a9d000 b4ae9000 r-xp /usr/lib/libssl.so.1.0.0
b4af5000 b4b21000 r-xp /usr/lib/libidn.so.11.5.44
b4b2a000 b4b34000 r-xp /usr/lib/libcares.so.2.0.0
b4b3c000 b4b53000 r-xp /lib/libexpat.so.1.5.2
b4b5d000 b4b81000 r-xp /usr/lib/libicule.so.48.1
b4b8a000 b4b92000 r-xp /usr/lib/libsf_common.so
b4b9a000 b4c35000 r-xp /usr/lib/libstdc++.so.6.0.14
b4c48000 b4d25000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4d30000 b4d55000 r-xp /usr/lib/libexif.so.12.3.3
b4d69000 b4d73000 r-xp /usr/lib/libethumb.so.1.7.99
b4d7b000 b4dbf000 r-xp /usr/lib/libsndfile.so.1.0.25
b4dcd000 b4dcf000 r-xp /usr/lib/libctxdata.so.0.0.0
b4dd7000 b4de5000 r-xp /usr/lib/libremix.so.0.0.0
b4ded000 b4dee000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4df6000 b4e0f000 r-xp /usr/lib/liblua-5.1.so
b4e18000 b4e1f000 r-xp /usr/lib/libembryo.so.1.7.99
b4e28000 b4e2b000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4e33000 b4e70000 r-xp /usr/lib/libcurl.so.4.3.0
b4e7a000 b4e7e000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4e87000 b4ef1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4efe000 b4f22000 r-xp /usr/lib/libfontconfig.so.1.5.0
b4f2b000 b4f87000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b4f99000 b4fad000 r-xp /usr/lib/libfribidi.so.0.3.1
b4fb5000 b500a000 r-xp /usr/lib/libfreetype.so.6.8.1
b5015000 b5039000 r-xp /usr/lib/libjpeg.so.8.0.2
b5051000 b5068000 r-xp /lib/libz.so.1.2.5
b5070000 b507d000 r-xp /usr/lib/libsensor.so.1.1.0
b5088000 b508a000 r-xp /usr/lib/libapp-checker.so.0.1.0
b5092000 b5098000 r-xp /usr/lib/libxdgmime.so.1.1.0
b61af000 b6297000 r-xp /usr/lib/libicuuc.so.48.1
b62a4000 b63c4000 r-xp /usr/lib/libicui18n.so.48.1
b63d2000 b63d5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b63dd000 b63e6000 r-xp /usr/lib/libvconf.so.0.2.45
b63ee000 b63fc000 r-xp /usr/lib/libail.so.0.1.0
b6404000 b641c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b641d000 b6422000 r-xp /usr/lib/libffi.so.5.0.10
b642a000 b642b000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6433000 b643d000 r-xp /usr/lib/libXext.so.6.4.0
b6446000 b6449000 r-xp /usr/lib/libXtst.so.6.1.0
b6451000 b6457000 r-xp /usr/lib/libXrender.so.1.3.0
b645f000 b6465000 r-xp /usr/lib/libXrandr.so.2.2.0
b646d000 b646e000 r-xp /usr/lib/libXinerama.so.1.0.0
b6477000 b6480000 r-xp /usr/lib/libXi.so.6.1.0
b6488000 b648b000 r-xp /usr/lib/libXfixes.so.3.1.0
b6493000 b6495000 r-xp /usr/lib/libXgesture.so.7.0.0
b649d000 b649f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b64a7000 b64a8000 r-xp /usr/lib/libXdamage.so.1.1.0
b64b1000 b64b8000 r-xp /usr/lib/libXcursor.so.1.0.2
b64c0000 b64c8000 r-xp /usr/lib/libemotion.so.1.7.99
b64d0000 b64eb000 r-xp /usr/lib/libecore_con.so.1.7.99
b64f4000 b64f9000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6502000 b650a000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6512000 b6514000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b651c000 b6520000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6529000 b653f000 r-xp /usr/lib/libefreet.so.1.7.99
b6549000 b6552000 r-xp /usr/lib/libedbus.so.1.7.99
b655a000 b655f000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6568000 b65c4000 r-xp /usr/lib/libedje.so.1.7.99
b65ce000 b65e5000 r-xp /usr/lib/libecore_input.so.1.7.99
b6600000 b6605000 r-xp /usr/lib/libecore_file.so.1.7.99
b660d000 b662a000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6633000 b6672000 r-xp /usr/lib/libeina.so.1.7.99
b667b000 b672a000 r-xp /usr/lib/libevas.so.1.7.99
b674c000 b675f000 r-xp /usr/lib/libeet.so.1.7.99
b6768000 b67d2000 r-xp /lib/libm-2.13.so
b67de000 b67e5000 r-xp /usr/lib/libutilX.so.1.1.0
b67ed000 b67f2000 r-xp /usr/lib/libappcore-common.so.1.1
b67fa000 b6805000 r-xp /usr/lib/libaul.so.0.1.0
b680e000 b6842000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b684b000 b687b000 r-xp /usr/lib/libecore_x.so.1.7.99
b6884000 b6899000 r-xp /usr/lib/libecore.so.1.7.99
b68b0000 b69d0000 r-xp /usr/lib/libelementary.so.1.7.99
b69e3000 b69e6000 r-xp /lib/libattr.so.1.1.0
b69ee000 b69f0000 r-xp /usr/lib/libXau.so.6.0.0
b69f8000 b69fe000 r-xp /lib/librt-2.13.so
b6a07000 b6a0f000 r-xp /lib/libcrypt-2.13.so
b6a3f000 b6a42000 r-xp /lib/libcap.so.2.21
b6a4a000 b6a4c000 r-xp /usr/lib/libiri.so
b6a54000 b6a69000 r-xp /usr/lib/libxcb.so.1.1.0
b6a71000 b6a7c000 r-xp /lib/libunwind.so.8.0.1
b6aaa000 b6bc7000 r-xp /lib/libc-2.13.so
b6bd5000 b6bde000 r-xp /lib/libgcc_s-4.5.3.so.1
b6be6000 b6be9000 r-xp /usr/lib/libsmack.so.1.0.0
b6bf1000 b6c1d000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c26000 b6c2a000 r-xp /usr/lib/libbundle.so.0.1.22
b6c32000 b6c34000 r-xp /lib/libdl-2.13.so
b6c3d000 b6d17000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d20000 b6d8a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6d94000 b6da1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6daa000 b6e90000 r-xp /usr/lib/libX11.so.6.3.0
b6e9b000 b6eaf000 r-xp /lib/libpthread-2.13.so
b6ebf000 b6ec3000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ecc000 b6ecd000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed5000 b6ed9000 r-xp /usr/lib/libsys-assert.so
b6ee1000 b6efe000 r-xp /lib/ld-2.13.so
bedb6000 bedd7000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9722)
Call Stack Count: 45
 0: (0xb25ae8c8) [/usr/lib/osp/libosp-net.so.1] + 0x618c8
 1: Tizen::Net::Sockets::_SocketImpl::SendTo(Tizen::Base::ByteBuffer&, Tizen::Net::NetEndPoint const&) + 0x34 (0xb25cab0d) [/usr/lib/osp/libosp-net.so.1] + 0x7db0d
 2: Tizen::Net::Sockets::Socket::SendTo(Tizen::Base::ByteBuffer&, Tizen::Net::NetEndPoint const&) + 0x1a (0xb25c57b7) [/usr/lib/osp/libosp-net.so.1] + 0x787b7
 3: Enrollment::SendData() + 0x304 (0xb263a6d8) [/opt/apps/tGwjUrErhZ/bin/ForUsDoc.exe] + 0x86d8
 4: Enrollment::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x488 (0xb263a29c) [/opt/apps/tGwjUrErhZ/bin/ForUsDoc.exe] + 0x829c
 5: non-virtual thunk to Enrollment::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x3c (0xb263a82c) [/opt/apps/tGwjUrErhZ/bin/ForUsDoc.exe] + 0x882c
End of Call Stack

Package Information
Package Name: tGwjUrErhZ.ForUsDoc
Package ID : tGwjUrErhZ
Version: 1.0.0
Package Type: tpk
App Name: ForUsDoc
App ID: tGwjUrErhZ.ForUsDoc
Type: Application
Categories: (NULL)

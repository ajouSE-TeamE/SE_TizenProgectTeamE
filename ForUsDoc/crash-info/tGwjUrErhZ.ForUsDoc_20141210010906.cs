S/W Version Information
Model: Ref.Device-PQ
Tizen-Version: 2.2.1
Build-Number: Tizen_Ref.Device-PQ_20131118.1124
Build-Date: 2013.11.18 11:24:59

Crash Information
Process Name: ForUsDoc
PID: 14203
Date: 2014-12-10 01:09:06(GMT+0900)
Executable File Path: /opt/apps/tGwjUrErhZ/bin/ForUsDoc
This process is multi-thread process
pid=14203 tid=14203
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 14203, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xbea7cc38
r2   = 0x00000006, r3   = 0x00000016
r4   = 0xb26e7374, r5   = 0xbea7cc38
r6   = 0x00328890, r7   = 0x00195640
r8   = 0xbea7cd80, r9   = 0x000a86f0
r10  = 0xb44bf940, fp   = 0xbea7cc68
ip   = 0xb37dd75d, sp   = 0xbea7cad8
lr   = 0xb37dd765, pc   = 0xb3908f18
cpsr = 0x60000030

Memory Information
MemTotal:   797320 KB
MemFree:    141960 KB
Buffers:     51252 KB
Cached:     362076 KB
VmPeak:      96728 KB
VmSize:      89524 KB
VmLck:           0 KB
VmHWM:       34068 KB
VmRSS:       34068 KB
VmData:      15852 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       43540 KB
VmPTE:          88 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 000dc000 rw-p [heap]
000dc000 0096b000 rw-p [heap]
b1d04000 b1d09000 r-xp /usr/lib/libhaptic-module.so
b2509000 b251a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b2523000 b2528000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b255d000 b2560000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b2568000 b2569000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b2571000 b257b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b25a7000 b25bb000 r-xp /usr/lib/libnetwork.so.0.0.0
b25c4000 b25d8000 r-xp /usr/lib/libwifi-direct.so.0.0
b25e0000 b25e8000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b25e9000 b25f2000 r-xp /usr/lib/libcapi-network-connection.so.0.1.3_18
b25fa000 b26bf000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b26cd000 b26d6000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b26df000 b26f3000 r-xp /opt/usr/apps/tGwjUrErhZ/bin/ForUsDoc.exe
b26fc000 b276e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b2776000 b27b0000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b27b9000 b27bd000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b27c5000 b27f6000 r-xp /usr/lib/libpulse.so.0.12.4
b27fe000 b2861000 r-xp /usr/lib/libasound.so.2.0.0
b286b000 b286e000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b2876000 b287a000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b2883000 b28a0000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b28a8000 b28b6000 r-xp /usr/lib/libmmfsound.so.0.1.0
b28be000 b295a000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b2966000 b29a7000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b29b0000 b29b9000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b29c1000 b29ce000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b29d7000 b29dd000 r-xp /usr/lib/libUMP.so
b29e5000 b29e8000 r-xp /usr/lib/libmm_ta.so.0.0.0
b29f0000 b29ff000 r-xp /usr/lib/libICE.so.6.3.0
b2a09000 b2a0e000 r-xp /usr/lib/libSM.so.6.0.1
b2a16000 b2a17000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2a1f000 b2a27000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2a2f000 b2a37000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b2a42000 b2a45000 r-xp /usr/lib/libmmfsession.so.0.0.0
b2a4d000 b2a91000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b2a9a000 b2aad000 r-xp /usr/lib/libEGL_platform.so
b2ab6000 b2b8d000 r-xp /usr/lib/libMali.so
b2b98000 b2b9e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2ba6000 b2ba7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2bb0000 b2bee000 r-xp /usr/lib/libGLESv2.so.2.0
b2bf6000 b2c41000 r-xp /usr/lib/libtiff.so.5.1.0
b2c4c000 b2c75000 r-xp /usr/lib/libturbojpeg.so
b2c8e000 b2c94000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b2c9c000 b2ca2000 r-xp /usr/lib/libgif.so.4.1.6
b2caa000 b2ccc000 r-xp /usr/lib/libavutil.so.51.73.101
b2cdb000 b2d09000 r-xp /usr/lib/libswscale.so.2.1.101
b2d12000 b3009000 r-xp /usr/lib/libavcodec.so.54.59.100
b3330000 b3349000 r-xp /usr/lib/libpng12.so.0.50.0
b3352000 b3358000 r-xp /usr/lib/libfeedback.so.0.1.4
b3360000 b336c000 r-xp /usr/lib/libtts.so
b3374000 b338b000 r-xp /usr/lib/libEGL.so.1.4
b3394000 b344b000 r-xp /usr/lib/libcairo.so.2.11200.12
b3455000 b346f000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3478000 b3d73000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b3de6000 b3deb000 r-xp /usr/lib/libslp_devman_plugin.so
b3df4000 b3df7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3dff000 b3e03000 r-xp /usr/lib/libsysman.so.0.2.0
b3e0b000 b3e1c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3e25000 b3e27000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b3e2f000 b3e31000 r-xp /usr/lib/libdeviced.so.0.1.0
b3e39000 b3e4f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b3e57000 b3e59000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3e61000 b3e64000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3e6c000 b3e6f000 r-xp /usr/lib/libdevice-node.so.0.1
b3e77000 b3e7b000 r-xp /usr/lib/libheynoti.so.0.0.2
b3e83000 b3ec8000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b3ed1000 b3ee6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3eef000 b3ef3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3efb000 b3f00000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3f08000 b3f09000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b3f12000 b3f15000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3f1d000 b3f20000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b3f29000 b3f2c000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b3f34000 b3f35000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b3f3d000 b3f4b000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b3f54000 b3f76000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b3f7e000 b3f81000 r-xp /usr/lib/libuuid.so.1.3.0
b3f8a000 b3fa8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b3fb0000 b3fc7000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3fd0000 b3fd1000 r-xp /usr/lib/libpmapi.so.1.2
b3fd9000 b3fe1000 r-xp /usr/lib/libminizip.so.1.0.0
b3fe9000 b3ff4000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3ffc000 b40d4000 r-xp /usr/lib/libxml2.so.2.7.8
b40e1000 b40ff000 r-xp /usr/lib/libpcre.so.0.0.1
b4107000 b410a000 r-xp /usr/lib/libiniparser.so.0
b4113000 b4117000 r-xp /usr/lib/libhaptic.so.0.1
b411f000 b412a000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b4137000 b413c000 r-xp /usr/lib/libdevman.so.0.1
b4145000 b4149000 r-xp /usr/lib/libchromium.so.1.0
b4151000 b4157000 r-xp /usr/lib/libappsvc.so.0.1.0
b415f000 b4160000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b4170000 b4172000 r-xp /opt/usr/apps/tGwjUrErhZ/bin/ForUsDoc
b417a000 b4180000 r-xp /usr/lib/libalarm.so.0.0.0
b4189000 b419b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b41a3000 b44a2000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b44c9000 b44d3000 r-xp /lib/libnss_files-2.13.so
b44dc000 b44e5000 r-xp /lib/libnss_nis-2.13.so
b44ee000 b44ff000 r-xp /lib/libnsl-2.13.so
b450a000 b4510000 r-xp /lib/libnss_compat-2.13.so
b4519000 b4522000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b484a000 b485b000 r-xp /usr/lib/libcom-core.so.0.0.1
b4863000 b4865000 r-xp /usr/lib/libdri2.so.0.0.0
b486d000 b4875000 r-xp /usr/lib/libdrm.so.2.4.0
b487d000 b4881000 r-xp /usr/lib/libtbm.so.1.0.0
b4889000 b488c000 r-xp /usr/lib/libXv.so.1.0.0
b4894000 b495f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4975000 b4985000 r-xp /usr/lib/libnotification.so.0.1.0
b498d000 b49b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b49ba000 b49ca000 r-xp /lib/libresolv-2.13.so
b49ce000 b49d0000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b49d8000 b4b2b000 r-xp /usr/lib/libcrypto.so.1.0.0
b4b49000 b4b95000 r-xp /usr/lib/libssl.so.1.0.0
b4ba1000 b4bcd000 r-xp /usr/lib/libidn.so.11.5.44
b4bd6000 b4be0000 r-xp /usr/lib/libcares.so.2.0.0
b4be8000 b4bff000 r-xp /lib/libexpat.so.1.5.2
b4c09000 b4c2d000 r-xp /usr/lib/libicule.so.48.1
b4c36000 b4c3e000 r-xp /usr/lib/libsf_common.so
b4c46000 b4ce1000 r-xp /usr/lib/libstdc++.so.6.0.14
b4cf4000 b4dd1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4ddc000 b4e01000 r-xp /usr/lib/libexif.so.12.3.3
b4e15000 b4e1f000 r-xp /usr/lib/libethumb.so.1.7.99
b4e27000 b4e6b000 r-xp /usr/lib/libsndfile.so.1.0.25
b4e79000 b4e7b000 r-xp /usr/lib/libctxdata.so.0.0.0
b4e83000 b4e91000 r-xp /usr/lib/libremix.so.0.0.0
b4e99000 b4e9a000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4ea2000 b4ebb000 r-xp /usr/lib/liblua-5.1.so
b4ec4000 b4ecb000 r-xp /usr/lib/libembryo.so.1.7.99
b4ed4000 b4ed7000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4edf000 b4f1c000 r-xp /usr/lib/libcurl.so.4.3.0
b4f26000 b4f2a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4f33000 b4f9d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4faa000 b4fce000 r-xp /usr/lib/libfontconfig.so.1.5.0
b4fd7000 b5033000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5045000 b5059000 r-xp /usr/lib/libfribidi.so.0.3.1
b5061000 b50b6000 r-xp /usr/lib/libfreetype.so.6.8.1
b50c1000 b50e5000 r-xp /usr/lib/libjpeg.so.8.0.2
b50fd000 b5114000 r-xp /lib/libz.so.1.2.5
b511c000 b5129000 r-xp /usr/lib/libsensor.so.1.1.0
b5134000 b5136000 r-xp /usr/lib/libapp-checker.so.0.1.0
b513e000 b5144000 r-xp /usr/lib/libxdgmime.so.1.1.0
b625b000 b6343000 r-xp /usr/lib/libicuuc.so.48.1
b6350000 b6470000 r-xp /usr/lib/libicui18n.so.48.1
b647e000 b6481000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6489000 b6492000 r-xp /usr/lib/libvconf.so.0.2.45
b649a000 b64a8000 r-xp /usr/lib/libail.so.0.1.0
b64b0000 b64c8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b64c9000 b64ce000 r-xp /usr/lib/libffi.so.5.0.10
b64d6000 b64d7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b64df000 b64e9000 r-xp /usr/lib/libXext.so.6.4.0
b64f2000 b64f5000 r-xp /usr/lib/libXtst.so.6.1.0
b64fd000 b6503000 r-xp /usr/lib/libXrender.so.1.3.0
b650b000 b6511000 r-xp /usr/lib/libXrandr.so.2.2.0
b6519000 b651a000 r-xp /usr/lib/libXinerama.so.1.0.0
b6523000 b652c000 r-xp /usr/lib/libXi.so.6.1.0
b6534000 b6537000 r-xp /usr/lib/libXfixes.so.3.1.0
b653f000 b6541000 r-xp /usr/lib/libXgesture.so.7.0.0
b6549000 b654b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6553000 b6554000 r-xp /usr/lib/libXdamage.so.1.1.0
b655d000 b6564000 r-xp /usr/lib/libXcursor.so.1.0.2
b656c000 b6574000 r-xp /usr/lib/libemotion.so.1.7.99
b657c000 b6597000 r-xp /usr/lib/libecore_con.so.1.7.99
b65a0000 b65a5000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65ae000 b65b6000 r-xp /usr/lib/libethumb_client.so.1.7.99
b65be000 b65c0000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b65c8000 b65cc000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b65d5000 b65eb000 r-xp /usr/lib/libefreet.so.1.7.99
b65f5000 b65fe000 r-xp /usr/lib/libedbus.so.1.7.99
b6606000 b660b000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6614000 b6670000 r-xp /usr/lib/libedje.so.1.7.99
b667a000 b6691000 r-xp /usr/lib/libecore_input.so.1.7.99
b66ac000 b66b1000 r-xp /usr/lib/libecore_file.so.1.7.99
b66b9000 b66d6000 r-xp /usr/lib/libecore_evas.so.1.7.99
b66df000 b671e000 r-xp /usr/lib/libeina.so.1.7.99
b6727000 b67d6000 r-xp /usr/lib/libevas.so.1.7.99
b67f8000 b680b000 r-xp /usr/lib/libeet.so.1.7.99
b6814000 b687e000 r-xp /lib/libm-2.13.so
b688a000 b6891000 r-xp /usr/lib/libutilX.so.1.1.0
b6899000 b689e000 r-xp /usr/lib/libappcore-common.so.1.1
b68a6000 b68b1000 r-xp /usr/lib/libaul.so.0.1.0
b68ba000 b68ee000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68f7000 b6927000 r-xp /usr/lib/libecore_x.so.1.7.99
b6930000 b6945000 r-xp /usr/lib/libecore.so.1.7.99
b695c000 b6a7c000 r-xp /usr/lib/libelementary.so.1.7.99
b6a8f000 b6a92000 r-xp /lib/libattr.so.1.1.0
b6a9a000 b6a9c000 r-xp /usr/lib/libXau.so.6.0.0
b6aa4000 b6aaa000 r-xp /lib/librt-2.13.so
b6ab3000 b6abb000 r-xp /lib/libcrypt-2.13.so
b6aeb000 b6aee000 r-xp /lib/libcap.so.2.21
b6af6000 b6af8000 r-xp /usr/lib/libiri.so
b6b00000 b6b15000 r-xp /usr/lib/libxcb.so.1.1.0
b6b1d000 b6b28000 r-xp /lib/libunwind.so.8.0.1
b6b56000 b6c73000 r-xp /lib/libc-2.13.so
b6c81000 b6c8a000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c92000 b6c95000 r-xp /usr/lib/libsmack.so.1.0.0
b6c9d000 b6cc9000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6cd2000 b6cd6000 r-xp /usr/lib/libbundle.so.0.1.22
b6cde000 b6ce0000 r-xp /lib/libdl-2.13.so
b6ce9000 b6dc3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6dcc000 b6e36000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e40000 b6e4d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e56000 b6f3c000 r-xp /usr/lib/libX11.so.6.3.0
b6f47000 b6f5b000 r-xp /lib/libpthread-2.13.so
b6f6b000 b6f6f000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f78000 b6f79000 r-xp /usr/lib/libdlog.so.0.0.0
b6f81000 b6f85000 r-xp /usr/lib/libsys-assert.so
b6f8d000 b6faa000 r-xp /lib/ld-2.13.so
bea5e000 bea7f000 rwxp [stack]
End of Maps Information

Callstack Information (PID:14203)
Call Stack Count: 43
 0: (0xb3908f18) [/usr/lib/osp/libosp-uifw.so] + 0x490f18
 1: Tizen::Ui::Controls::CheckButton::SetText(Tizen::Base::String const&) + 0x8 (0xb37dd765) [/usr/lib/osp/libosp-uifw.so] + 0x365765
 2: Enrollment::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x100 (0xb26e6ad8) [/opt/apps/tGwjUrErhZ/bin/ForUsDoc.exe] + 0x7ad8
 3: non-virtual thunk to Enrollment::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x3c (0xb26e73b0) [/opt/apps/tGwjUrErhZ/bin/ForUsDoc.exe] + 0x83b0
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

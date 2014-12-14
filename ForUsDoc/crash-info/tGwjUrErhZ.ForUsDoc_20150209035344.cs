S/W Version Information
Model: Ref.Device-PQ
Tizen-Version: 2.2.1
Build-Number: Tizen_Ref.Device-PQ_20131118.1124
Build-Date: 2013.11.18 11:24:59

Crash Information
Process Name: ForUsDoc
PID: 11534
Date: 2015-02-09 03:53:44(GMT+0900)
Executable File Path: /opt/apps/tGwjUrErhZ/bin/ForUsDoc
This process is multi-thread process
pid=11534 tid=11534
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0xbeffc348, r1   = 0x2a2f2ad0
r2   = 0x2a2f2b2c, r3   = 0x00000000
r4   = 0x2a013155, r5   = 0x2a0130c0
r6   = 0xffff573d, r7   = 0x2a369728
r8   = 0xbeffc704, r9   = 0x00000000
r10  = 0xbeffc604, fp   = 0xbeffc3a8
ip   = 0xb6645214, sp   = 0xbeffbf78
lr   = 0xb6457d89, pc   = 0x2a00b120
cpsr = 0x80000010

Memory Information
MemTotal:   797320 KB
MemFree:    197624 KB
Buffers:     54500 KB
Cached:     296716 KB
VmPeak:      94432 KB
VmSize:      87228 KB
VmLck:           0 KB
VmHWM:       37244 KB
VmRSS:       37244 KB
VmData:      14152 KB
VmStk:         136 KB
VmExe:          84 KB
VmLib:       64080 KB
VmPTE:          84 KB
VmSwap:          0 KB

Maps Information
2a000000 2a015000 r-xp /opt/usr/apps/tGwjUrErhZ/bin/ForUsDoc.exe
2a01d000 2a01e000 rwxp /opt/usr/apps/tGwjUrErhZ/bin/ForUsDoc.exe
2a01e000 2a5e7000 rwxp [heap]
b1dcd000 b1dd2000 r-xp /usr/lib/libhaptic-module.so
b1dd9000 b1dda000 rwxp /usr/lib/libhaptic-module.so
b1dda000 b215e000 rwxs /drm
b215e000 b24e2000 rwxs /drm
b24e2000 b250d000 rwxs /dev/shm/elm_indicator_portrait-0-1423229565.2738.110079263
b250d000 b2558000 rwxs /dev/shm/elm_indicator_landscape-0-1423229565.2738.1494973742
b2558000 b2583000 rwxs /dev/shm/elm_indicator_portrait-0-1423229565.2738.110079263
b2583000 b25ce000 rwxs /dev/shm/elm_indicator_landscape-0-1423229565.2738.1494973742
b25ce000 b25df000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25e7000 b25e8000 rwxp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b25e8000 b2707000 r-xp /usr/lib/locale/locale-archive
b2707000 b270c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2713000 b2714000 rwxp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b2714000 b2739000 r-xp /usr/share/fonts/TizenSansRegular.ttf
b2739000 b2741000 r-xs /var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-3
b2741000 b2742000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b2749000 b274a000 rwxp /usr/lib/libdrm_slp.so.1.0.0
b274a000 b274e000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/scim.mo
b274e000 b2751000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/osp.mo
b2751000 b2754000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b275b000 b275c000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b275c000 b2765000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b276d000 b276e000 rwxp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b276e000 b2775000 r-xs /usr/lib/gconv/gconv-modules.cache
b2775000 b2799000 r-xp /usr/share/locale/ko/LC_MESSAGES/libc.mo
b2799000 b27a3000 r-xp /lib/libnss_files-2.13.so
b27aa000 b27ab000 r-xp /lib/libnss_files-2.13.so
b27ab000 b27ac000 rwxp /lib/libnss_files-2.13.so
b27ac000 b27b5000 r-xp /lib/libnss_nis-2.13.so
b27bc000 b27bd000 r-xp /lib/libnss_nis-2.13.so
b27bd000 b27be000 rwxp /lib/libnss_nis-2.13.so
b27be000 b27cf000 r-xp /lib/libnsl-2.13.so
b27d6000 b27d7000 r-xp /lib/libnsl-2.13.so
b27d7000 b27d8000 rwxp /lib/libnsl-2.13.so
b27da000 b27e0000 r-xp /lib/libnss_compat-2.13.so
b27e7000 b27e8000 r-xp /lib/libnss_compat-2.13.so
b27e8000 b27e9000 rwxp /lib/libnss_compat-2.13.so
b27e9000 b28b4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b28bc000 b28ca000 rwxp /usr/lib/libscim-1.0.so.8.2.3
b28ca000 b28d4000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b28db000 b28dc000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b28dc000 b2900000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b2907000 b2909000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
b2909000 b2b09000 r-xp /usr/lib/locale/locale-archive
b2b11000 b2b4b000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b2b53000 b2b54000 rwxp /usr/lib/libpulsecommon-0.9.23.so
b2b54000 b2b58000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2b5f000 b2b60000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
b2b61000 b2b64000 r-xp /lib/libattr.so.1.1.0
b2b6b000 b2b6c000 rwxp /lib/libattr.so.1.1.0
b2b6c000 b2b6f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b2b76000 b2b77000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
b2b78000 b2ba9000 r-xp /usr/lib/libpulse.so.0.12.4
b2bb0000 b2bb1000 rwxp /usr/lib/libpulse.so.0.12.4
b2bb1000 b2c14000 r-xp /usr/lib/libasound.so.2.0.0
b2c1b000 b2c1e000 rwxp /usr/lib/libasound.so.2.0.0
b2c1e000 b2c21000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b2c28000 b2c29000 rwxp /usr/lib/libpulse-simple.so.0.0.3
b2c29000 b2c2d000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b2c35000 b2c36000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
b2c36000 b2c53000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b2c5a000 b2c5b000 rwxp /usr/lib/libavsysaudio.so.0.0.1
b2c5b000 b2c69000 r-xp /usr/lib/libmmfsound.so.0.1.0
b2c70000 b2c71000 rwxp /usr/lib/libmmfsound.so.0.1.0
b2c72000 b2d0e000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b2d16000 b2d19000 rwxp /usr/lib/libgstreamer-0.10.so.0.30.0
b2d1a000 b2d5b000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b2d63000 b2d64000 rwxp /usr/lib/libgstbase-0.10.so.0.30.0
b2d64000 b2d6d000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b2d74000 b2d75000 rwxp /usr/lib/libgstapp-0.10.so.0.25.0
b2d75000 b2d82000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2d8a000 b2d8b000 rwxp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2d8b000 b2d91000 r-xp /usr/lib/libUMP.so
b2d98000 b2d99000 rwxp /usr/lib/libUMP.so
b2d9a000 b2d9c000 r-xp /usr/lib/libXau.so.6.0.0
b2da3000 b2da4000 rwxp /usr/lib/libXau.so.6.0.0
b2da4000 b2db4000 r-xp /lib/libresolv-2.13.so
b2db4000 b2db5000 r-xp /lib/libresolv-2.13.so
b2db5000 b2db6000 rwxp /lib/libresolv-2.13.so
b2db8000 b2dbd000 r-xp /usr/lib/libffi.so.5.0.10
b2dc4000 b2dc5000 rwxp /usr/lib/libffi.so.5.0.10
b2dc6000 b2dd0000 r-xp /usr/lib/libethumb.so.1.7.99
b2dd7000 b2dd8000 rwxp /usr/lib/libethumb.so.1.7.99
b2dd8000 b2e1c000 r-xp /usr/lib/libsndfile.so.1.0.25
b2e24000 b2e26000 rwxp /usr/lib/libsndfile.so.1.0.25
b2e2a000 b2e2c000 r-xp /usr/lib/libctxdata.so.0.0.0
b2e33000 b2e34000 rwxp /usr/lib/libctxdata.so.0.0.0
b2e34000 b2e42000 r-xp /usr/lib/libremix.so.0.0.0
b2e49000 b2e4a000 rwxp /usr/lib/libremix.so.0.0.0
b2e4a000 b2e51000 r-xp /usr/lib/libembryo.so.1.7.99
b2e59000 b2e5a000 rwxp /usr/lib/libembryo.so.1.7.99
b2e5b000 b2e7f000 r-xp /usr/lib/libjpeg.so.8.0.2
b2e86000 b2e87000 rwxp /usr/lib/libjpeg.so.8.0.2
b2e97000 b2e99000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b2ea0000 b2ea1000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b2ea1000 b2ea4000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2eab000 b2eac000 rwxp /usr/lib/libmm_ta.so.0.0.0
b2eac000 b2ebb000 r-xp /usr/lib/libICE.so.6.3.0
b2ec2000 b2ec3000 rwxp /usr/lib/libICE.so.6.3.0
b2ec5000 b2eca000 r-xp /usr/lib/libSM.so.6.0.1
b2ed1000 b2ed2000 rwxp /usr/lib/libSM.so.6.0.1
b2ed3000 b2eff000 r-xp /usr/lib/libidn.so.11.5.44
b2f07000 b2f08000 rwxp /usr/lib/libidn.so.11.5.44
b2f08000 b2f12000 r-xp /usr/lib/libcares.so.2.0.0
b2f19000 b2f1a000 rwxp /usr/lib/libcares.so.2.0.0
b2f1a000 b2f2e000 r-xp /usr/lib/libnetwork.so.0.0.0
b2f35000 b2f36000 rwxp /usr/lib/libnetwork.so.0.0.0
b2f37000 b2f3f000 r-xp /lib/libcrypt-2.13.so
b2f46000 b2f47000 r-xp /lib/libcrypt-2.13.so
b2f47000 b2f48000 rwxp /lib/libcrypt-2.13.so
b2f6f000 b2f72000 r-xp /lib/libcap.so.2.21
b2f79000 b2f7a000 rwxp /lib/libcap.so.2.21
b2f7b000 b2f7d000 r-xp /usr/lib/libiri.so
b2f84000 b2f85000 rwxp /usr/lib/libiri.so
b2f85000 b2f96000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b2f9e000 b2f9f000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b2f9f000 b2fa1000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b2fa8000 b2fa9000 rwxp /usr/lib/libsystemd-daemon.so.0.0.1
b2fa9000 b2faa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b2fb1000 b2fb2000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b2fb3000 b2fb5000 r-xp /usr/lib/libdeviced.so.0.1.0
b2fbc000 b2fbd000 rwxp /usr/lib/libdeviced.so.0.1.0
b2fbd000 b2fd3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b2fda000 b2fdb000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b2fdb000 b2fdd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2fe4000 b2fe5000 rwxp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b2fe5000 b2fe8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2fef000 b2ff0000 rwxp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b2ff1000 b3002000 r-xp /usr/lib/libcom-core.so.0.0.1
b3009000 b300a000 rwxp /usr/lib/libcom-core.so.0.0.1
b300a000 b300d000 r-xp /usr/lib/libdevice-node.so.0.1
b3014000 b3015000 rwxp /usr/lib/libdevice-node.so.0.1
b3015000 b3019000 r-xp /usr/lib/libheynoti.so.0.0.2
b3020000 b3021000 rwxp /usr/lib/libheynoti.so.0.0.2
b3021000 b3023000 r-xp /usr/lib/libapp-checker.so.0.1.0
b302a000 b302b000 rwxp /usr/lib/libapp-checker.so.0.1.0
b302c000 b302f000 r-xp /usr/lib/libsmack.so.1.0.0
b3036000 b3037000 rwxp /usr/lib/libsmack.so.1.0.0
b3037000 b3038000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b303f000 b3040000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
b3040000 b3048000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b304f000 b3050000 rwxp /usr/lib/libmmfcommon.so.0.0.0
b3050000 b3054000 r-xp /usr/lib/libsysman.so.0.2.0
b305b000 b305c000 rwxp /usr/lib/libsysman.so.0.2.0
b305d000 b3065000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b306c000 b306d000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
b3070000 b3073000 r-xp /usr/lib/libmmfsession.so.0.0.0
b307a000 b307b000 rwxp /usr/lib/libmmfsession.so.0.0.0
b307b000 b30bf000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b30c6000 b30c7000 rwxp /usr/lib/libmmfplayer.so.0.0.0
b30c8000 b30db000 r-xp /usr/lib/libEGL_platform.so
b30e3000 b30e4000 rwxp /usr/lib/libEGL_platform.so
b30e4000 b31bb000 r-xp /usr/lib/libMali.so
b31c3000 b31c6000 rwxp /usr/lib/libMali.so
b31c7000 b31eb000 r-xp /usr/lib/libicule.so.48.1
b31f3000 b31f4000 rwxp /usr/lib/libicule.so.48.1
b31f4000 b31fa000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3201000 b3202000 rwxp /usr/lib/libxcb-render.so.0.0.0
b3202000 b3203000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b320b000 b320c000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b320c000 b324a000 r-xp /usr/lib/libGLESv2.so.2.0
b3251000 b3252000 rwxp /usr/lib/libGLESv2.so.2.0
b3252000 b3269000 r-xp /lib/libexpat.so.1.5.2
b3271000 b3273000 rwxp /lib/libexpat.so.1.5.2
b3274000 b3277000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b327e000 b327f000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b327f000 b3283000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b328b000 b328c000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b328c000 b3292000 r-xp /usr/lib/libXrender.so.1.3.0
b3299000 b329a000 rwxp /usr/lib/libXrender.so.1.3.0
b329a000 b32a0000 r-xp /usr/lib/libXrandr.so.2.2.0
b32a7000 b32a8000 rwxp /usr/lib/libXrandr.so.2.2.0
b32a8000 b32a9000 r-xp /usr/lib/libXinerama.so.1.0.0
b32b1000 b32b2000 rwxp /usr/lib/libXinerama.so.1.0.0
b32b3000 b32bc000 r-xp /usr/lib/libXi.so.6.1.0
b32c3000 b32c4000 rwxp /usr/lib/libXi.so.6.1.0
b32c4000 b32c6000 r-xp /usr/lib/libXgesture.so.7.0.0
b32cd000 b32ce000 rwxp /usr/lib/libXgesture.so.7.0.0
b32ce000 b32d0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b32d7000 b32d8000 rwxp /usr/lib/libXcomposite.so.1.0.0
b32d8000 b32df000 r-xp /usr/lib/libXcursor.so.1.0.2
b32e6000 b32e7000 rwxp /usr/lib/libXcursor.so.1.0.2
b32e7000 b32ea000 r-xp /usr/lib/libXfixes.so.3.1.0
b32f1000 b32f2000 rwxp /usr/lib/libXfixes.so.3.1.0
b32f3000 b3308000 r-xp /usr/lib/libxcb.so.1.1.0
b330f000 b3310000 rwxp /usr/lib/libxcb.so.1.1.0
b3310000 b3318000 r-xp /usr/lib/libemotion.so.1.7.99
b331f000 b3320000 rwxp /usr/lib/libemotion.so.1.7.99
b3320000 b3325000 r-xp /usr/lib/libecore_fb.so.1.7.99
b332c000 b332e000 rwxp /usr/lib/libecore_fb.so.1.7.99
b332e000 b3336000 r-xp /usr/lib/libsf_common.so
b333d000 b333e000 rwxp /usr/lib/libsf_common.so
b333e000 b341b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b3422000 b3425000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b3427000 b346c000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b3473000 b3475000 rwxp /usr/lib/libsoup-2.4.so.1.5.0
b3475000 b34a9000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b34b0000 b34b2000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b34b2000 b34cd000 r-xp /usr/lib/libecore_con.so.1.7.99
b34d4000 b34d5000 rwxp /usr/lib/libecore_con.so.1.7.99
b34d6000 b34de000 r-xp /usr/lib/libethumb_client.so.1.7.99
b34e5000 b34e6000 rwxp /usr/lib/libethumb_client.so.1.7.99
b34e6000 b34ef000 r-xp /usr/lib/libedbus.so.1.7.99
b34f6000 b34f7000 rwxp /usr/lib/libedbus.so.1.7.99
b34f8000 b34fa000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b3501000 b3502000 rwxp /usr/lib/libefreet_trash.so.1.7.99
b3502000 b3506000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b350e000 b350f000 rwxp /usr/lib/libefreet_mime.so.1.7.99
b350f000 b3525000 r-xp /usr/lib/libefreet.so.1.7.99
b352d000 b352e000 rwxp /usr/lib/libefreet.so.1.7.99
b352f000 b358b000 r-xp /usr/lib/libedje.so.1.7.99
b3593000 b3595000 rwxp /usr/lib/libedje.so.1.7.99
b3595000 b359a000 r-xp /usr/lib/libecore_file.so.1.7.99
b35a1000 b35a2000 rwxp /usr/lib/libecore_file.so.1.7.99
b35a2000 b35b5000 r-xp /usr/lib/libeet.so.1.7.99
b35bd000 b35be000 rwxp /usr/lib/libeet.so.1.7.99
b35bf000 b46c6000 r-xp /usr/lib/libicudata.so.48.1
b46cd000 b46ce000 rwxp /usr/lib/libicudata.so.48.1
b46ce000 b46d1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b46d8000 b46d9000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b46d9000 b46df000 r-xp /usr/lib/libxdgmime.so.1.1.0
b46e6000 b46e7000 rwxp /usr/lib/libxdgmime.so.1.1.0
b46e7000 b46f5000 r-xp /usr/lib/libail.so.0.1.0
b46fc000 b46fd000 rwxp /usr/lib/libail.so.0.1.0
b46fd000 b4722000 r-xp /usr/lib/libexif.so.12.3.3
b4729000 b4736000 rwxp /usr/lib/libexif.so.12.3.3
b4737000 b4782000 r-xp /usr/lib/libtiff.so.5.1.0
b478a000 b478d000 rwxp /usr/lib/libtiff.so.5.1.0
b478d000 b47b6000 r-xp /usr/lib/libturbojpeg.so
b47be000 b47bf000 rwxp /usr/lib/libturbojpeg.so
b47cf000 b47d5000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b47dc000 b47dd000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
b47dd000 b47e3000 r-xp /usr/lib/libgif.so.4.1.6
b47ea000 b47eb000 rwxp /usr/lib/libgif.so.4.1.6
b47eb000 b480d000 r-xp /usr/lib/libavutil.so.51.73.101
b4815000 b4818000 rwxp /usr/lib/libavutil.so.51.73.101
b481c000 b484a000 r-xp /usr/lib/libswscale.so.2.1.101
b4852000 b4853000 rwxp /usr/lib/libswscale.so.2.1.101
b4854000 b4b4b000 r-xp /usr/lib/libavcodec.so.54.59.100
b4b53000 b4b63000 rwxp /usr/lib/libavcodec.so.54.59.100
b4e72000 b4e8b000 r-xp /usr/lib/libpng12.so.0.50.0
b4e93000 b4e94000 rwxp /usr/lib/libpng12.so.0.50.0
b4e94000 b4ea8000 r-xp /usr/lib/libwifi-direct.so.0.0
b4eaf000 b4eb0000 rwxp /usr/lib/libwifi-direct.so.0.0
b4eb0000 b4eed000 r-xp /usr/lib/libcurl.so.4.3.0
b4ef5000 b4ef7000 rwxp /usr/lib/libcurl.so.4.3.0
b4ef7000 b4f43000 r-xp /usr/lib/libssl.so.1.0.0
b4f4a000 b4f4f000 rwxp /usr/lib/libssl.so.1.0.0
b4f50000 b4f58000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b4f58000 b4f59000 rwxp /usr/lib/libcapi-network-tethering.so.0.1.0
b4f59000 b4f62000 r-xp /usr/lib/libcapi-network-connection.so.0.1.3_18
b4f69000 b4f6a000 rwxp /usr/lib/libcapi-network-connection.so.0.1.3_18
b4f6a000 b4f77000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b4f7f000 b4f80000 rwxp /usr/lib/libprivilege-control.so.0.0.2
b4f80000 b50d3000 r-xp /usr/lib/libcrypto.so.1.0.0
b50db000 b50ee000 rwxp /usr/lib/libcrypto.so.1.0.0
b50f1000 b5106000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b510e000 b510f000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b5110000 b5114000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b511b000 b511c000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b511c000 b5121000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5128000 b5129000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5129000 b512a000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b5132000 b5133000 rwxp /usr/lib/libcapi-system-power.so.0.1.1
b5133000 b5136000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b513d000 b513e000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
b513e000 b5141000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b5148000 b5149000 rwxp /usr/lib/libcapi-network-serial.so.0.0.8
b514a000 b514b000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b5152000 b5153000 rwxp /usr/lib/libcapi-content-mime-type.so.0.0.2
b5153000 b5175000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b517c000 b517d000 rwxp /usr/lib/libSLP-tapi.so.0.0.0
b517d000 b5194000 r-xp /lib/libz.so.1.2.5
b519b000 b519c000 rwxp /lib/libz.so.1.2.5
b519c000 b519f000 r-xp /usr/lib/libuuid.so.1.3.0
b51a7000 b51a8000 rwxp /usr/lib/libuuid.so.1.3.0
b51a8000 b5212000 r-xp /usr/lib/libsqlite3.so.0.8.6
b5219000 b521b000 rwxp /usr/lib/libsqlite3.so.0.8.6
b521d000 b523b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b5242000 b5243000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b5243000 b526f000 r-xp /usr/lib/libdbus-1.so.3.7.2
b5277000 b5278000 rwxp /usr/lib/libdbus-1.so.3.7.2
b5278000 b5290000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b5290000 b5291000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b5291000 b5292000 r-xp /usr/lib/libdlog.so.0.0.0
b5299000 b529a000 rwxp /usr/lib/libdlog.so.0.0.0
b529a000 b52b1000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b52b9000 b52ba000 rwxp /usr/lib/libpkgmgr-client.so.0.1.68
b52ba000 b52bb000 r-xp /usr/lib/libpmapi.so.1.2
b52c2000 b52c3000 rwxp /usr/lib/libpmapi.so.1.2
b52c4000 b52c8000 r-xp /usr/lib/libbundle.so.0.1.22
b52cf000 b52d0000 rwxp /usr/lib/libbundle.so.0.1.22
b52d0000 b52e0000 r-xp /usr/lib/libnotification.so.0.1.0
b52e7000 b52e8000 rwxp /usr/lib/libnotification.so.0.1.0
b52e8000 b52f0000 r-xp /usr/lib/libminizip.so.1.0.0
b52f7000 b52f8000 rwxp /usr/lib/libminizip.so.1.0.0
b52f8000 b5303000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b530a000 b530b000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b530b000 b5329000 r-xp /usr/lib/libpcre.so.0.0.1
b5330000 b5331000 rwxp /usr/lib/libpcre.so.0.0.1
b5331000 b5334000 r-xp /usr/lib/libiniparser.so.0
b533b000 b533c000 rwxp /usr/lib/libiniparser.so.0
b533e000 b5426000 r-xp /usr/lib/libicuuc.so.48.1
b5426000 b5431000 rwxp /usr/lib/libicuuc.so.48.1
b5433000 b5553000 r-xp /usr/lib/libicui18n.so.48.1
b555a000 b5560000 rwxp /usr/lib/libicui18n.so.48.1
b5561000 b5565000 r-xp /usr/lib/libhaptic.so.0.1
b556c000 b556d000 rwxp /usr/lib/libhaptic.so.0.1
b556d000 b5578000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b5580000 b5581000 rwxp /usr/lib/libcryptsvc.so.0.0.1
b5585000 b558a000 r-xp /usr/lib/libdevman.so.0.1
b5592000 b5593000 rwxp /usr/lib/libdevman.so.0.1
b5594000 b559f000 r-xp /usr/lib/libaul.so.0.1.0
b55a7000 b55a8000 rwxp /usr/lib/libaul.so.0.1.0
b55a8000 b55a9000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b55b0000 b55b1000 rwxp /usr/lib/osp/libappinfo.so.1.2.2.1
b55b1000 b55b7000 r-xp /usr/lib/libalarm.so.0.0.0
b55bf000 b55c0000 rwxp /usr/lib/libalarm.so.0.0.0
b55c0000 b55c9000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b55d1000 b55d2000 rwxp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b55d2000 b55e4000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b55eb000 b55ec000 rwxp /usr/lib/libprivacy-manager-client.so.0.0.5
b55ed000 b55f3000 r-xp /lib/librt-2.13.so
b55fa000 b55fb000 r-xp /lib/librt-2.13.so
b55fb000 b55fc000 rwxp /lib/librt-2.13.so
b55fc000 b5666000 r-xp /lib/libm-2.13.so
b566d000 b566e000 r-xp /lib/libm-2.13.so
b566e000 b566f000 rwxp /lib/libm-2.13.so
b566f000 b5673000 r-xp /usr/lib/libchromium.so.1.0
b567a000 b567b000 rwxp /usr/lib/libchromium.so.1.0
b567b000 b567e000 r-xp /usr/lib/libXtst.so.6.1.0
b5685000 b5686000 rwxp /usr/lib/libXtst.so.6.1.0
b5686000 b568d000 r-xp /usr/lib/libutilX.so.1.1.0
b5694000 b5695000 rwxp /usr/lib/libutilX.so.1.1.0
b5696000 b5699000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b56a1000 b56a2000 rwxp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b56a2000 b56bb000 r-xp /usr/lib/liblua-5.1.so
b56c3000 b56c4000 rwxp /usr/lib/liblua-5.1.so
b56c4000 b56c8000 r-xp /usr/lib/libtbm.so.1.0.0
b56cf000 b56d0000 rwxp /usr/lib/libtbm.so.1.0.0
b56d0000 b56d8000 r-xp /usr/lib/libdrm.so.2.4.0
b56df000 b56e0000 rwxp /usr/lib/libdrm.so.2.4.0
b56e0000 b56e2000 r-xp /usr/lib/libdri2.so.0.0.0
b56e9000 b56ea000 rwxp /usr/lib/libdri2.so.0.0.0
b56ea000 b56f0000 r-xp /usr/lib/libfeedback.so.0.1.4
b56f7000 b56f8000 rwxp /usr/lib/libfeedback.so.0.1.4
b56f9000 b5705000 r-xp /usr/lib/libtts.so
b570c000 b570d000 rwxp /usr/lib/libtts.so
b570d000 b5710000 r-xp /usr/lib/libXv.so.1.0.0
b5717000 b5718000 rwxp /usr/lib/libXv.so.1.0.0
b5718000 b572f000 r-xp /usr/lib/libEGL.so.1.4
b5737000 b5738000 rwxp /usr/lib/libEGL.so.1.4
b5738000 b5742000 r-xp /usr/lib/libXext.so.6.4.0
b574a000 b574b000 rwxp /usr/lib/libXext.so.6.4.0
b574b000 b57a7000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b57af000 b57b9000 rwxp /usr/lib/libharfbuzz.so.0.907.0
b57b9000 b57cd000 r-xp /usr/lib/libfribidi.so.0.3.1
b57d4000 b57d5000 rwxp /usr/lib/libfribidi.so.0.3.1
b57d6000 b582b000 r-xp /usr/lib/libfreetype.so.6.8.1
b5832000 b5836000 rwxp /usr/lib/libfreetype.so.6.8.1
b5836000 b5910000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b5918000 b5919000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b5919000 b5983000 r-xp /usr/lib/libpixman-1.so.0.28.2
b598b000 b5990000 rwxp /usr/lib/libpixman-1.so.0.28.2
b5990000 b5a47000 r-xp /usr/lib/libcairo.so.2.11200.12
b5a4e000 b5a51000 rwxp /usr/lib/libcairo.so.2.11200.12
b5a51000 b5a75000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5a7c000 b5a7e000 rwxp /usr/lib/libfontconfig.so.1.5.0
b5a7e000 b5b56000 r-xp /usr/lib/libxml2.so.2.7.8
b5b5d000 b5b63000 rwxp /usr/lib/libxml2.so.2.7.8
b5b64000 b5b7b000 r-xp /usr/lib/libecore_input.so.1.7.99
b5b82000 b5b96000 rwxp /usr/lib/libecore_input.so.1.7.99
b5b96000 b5b97000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5b9e000 b5b9f000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5b9f000 b5ba4000 r-xp /usr/lib/libecore_imf.so.1.7.99
b5bac000 b5bad000 rwxp /usr/lib/libecore_imf.so.1.7.99
b5bad000 b5bdd000 r-xp /usr/lib/libecore_x.so.1.7.99
b5be4000 b5be6000 rwxp /usr/lib/libecore_x.so.1.7.99
b5be6000 b5c03000 r-xp /usr/lib/libecore_evas.so.1.7.99
b5c0a000 b5c0c000 rwxp /usr/lib/libecore_evas.so.1.7.99
b5c0c000 b5c4b000 r-xp /usr/lib/libeina.so.1.7.99
b5c52000 b5c54000 rwxp /usr/lib/libeina.so.1.7.99
b5c54000 b5d03000 r-xp /usr/lib/libevas.so.1.7.99
b5d0b000 b5d13000 rwxp /usr/lib/libevas.so.1.7.99
b5d25000 b5d3a000 r-xp /usr/lib/libecore.so.1.7.99
b5d42000 b5d43000 rwxp /usr/lib/libecore.so.1.7.99
b5d51000 b5d65000 r-xp /lib/libpthread-2.13.so
b5d6c000 b5d6d000 r-xp /lib/libpthread-2.13.so
b5d6d000 b5d6e000 rwxp /lib/libpthread-2.13.so
b5d70000 b5d79000 r-xp /usr/lib/libvconf.so.0.2.45
b5d80000 b5d81000 rwxp /usr/lib/libvconf.so.0.2.45
b5d81000 b5d82000 r-xp /usr/lib/libXdamage.so.1.1.0
b5d8a000 b5d8b000 rwxp /usr/lib/libXdamage.so.1.1.0
b5d8b000 b5e71000 r-xp /usr/lib/libX11.so.6.3.0
b5e78000 b5e7c000 rwxp /usr/lib/libX11.so.6.3.0
b5e7c000 b5f9c000 r-xp /usr/lib/libelementary.so.1.7.99
b5fa3000 b5faa000 rwxp /usr/lib/libelementary.so.1.7.99
b5fae000 b5fbb000 r-xp /usr/lib/libsensor.so.1.1.0
b5fc3000 b5fc4000 rwxp /usr/lib/libsensor.so.1.1.0
b5fc6000 b5fcc000 r-xp /usr/lib/libappsvc.so.0.1.0
b5fd3000 b5fd4000 rwxp /usr/lib/libappsvc.so.0.1.0
b5fd4000 b5fd8000 r-xp /usr/lib/libappcore-efl.so.1.1
b5fdf000 b5fe0000 rwxp /usr/lib/libappcore-efl.so.1.1
b5fe0000 b5fe5000 r-xp /usr/lib/libappcore-common.so.1.1
b5fec000 b5fed000 rwxp /usr/lib/libappcore-common.so.1.1
b5fed000 b5ffb000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b6002000 b6003000 rwxp /usr/lib/libcapi-appfw-application.so.0.1.0
b6004000 b601e000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b6026000 b6027000 rwxp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b6027000 b6029000 r-xp /lib/libdl-2.13.so
b6030000 b6031000 r-xp /lib/libdl-2.13.so
b6031000 b6032000 rwxp /lib/libdl-2.13.so
b6032000 b603d000 r-xp /lib/libunwind.so.8.0.1
b6045000 b6046000 rwxp /lib/libunwind.so.8.0.1
b606b000 b6188000 r-xp /lib/libc-2.13.so
b6190000 b6192000 r-xp /lib/libc-2.13.so
b6192000 b6193000 rwxp /lib/libc-2.13.so
b6196000 b619f000 r-xp /lib/libgcc_s-4.5.3.so.1
b61a6000 b61a7000 rwxp /lib/libgcc_s-4.5.3.so.1
b61a7000 b6242000 r-xp /usr/lib/libstdc++.so.6.0.14
b624a000 b624d000 r-xp /usr/lib/libstdc++.so.6.0.14
b624d000 b624f000 rwxp /usr/lib/libstdc++.so.6.0.14
b6255000 b631a000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b6322000 b6328000 rwxp /usr/lib/osp/libosp-net.so.1.2.2.0
b6328000 b6627000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b662f000 b664d000 rwxp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b664e000 b6f49000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b6f50000 b6fb9000 rwxp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b6fbd000 b6fbe000 r-xp /usr/lib/locale/locale-archive
b6fbe000 b6fbf000 r-xs /var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-3
b6fc0000 b6fc5000 r-xp /usr/lib/libslp_devman_plugin.so
b6fcd000 b6fce000 rwxp /usr/lib/libslp_devman_plugin.so
b6fce000 b6fd2000 r-xp /usr/lib/libsys-assert.so
b6fd9000 b6fda000 rwxp /usr/lib/libsys-assert.so
b6fda000 b6ff7000 r-xp /lib/ld-2.13.so
b6ffe000 b6fff000 r-xp /lib/ld-2.13.so
b6fff000 b7000000 rwxp /lib/ld-2.13.so
befdf000 bf000000 rwxp [stack]
End of Maps Information

Callstack Information (PID:11534)
Call Stack Count: 46
 0: (0x2a00b120) [/opt/apps/tGwjUrErhZ/bin/ForUsDoc] + 0xb120
 1: (0x2a00be30) [/opt/apps/tGwjUrErhZ/bin/ForUsDoc] + 0xbe30
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

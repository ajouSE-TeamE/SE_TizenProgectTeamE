/*
 * Enrollment.h
 *
 *  Created on: Dec 9, 2014
 *      Author: div_S
 */

#ifndef ENROLLMENT_H_
#define ENROLLMENT_H_

#include <new>
#include <FNet.h>
#include <FApp.h>
#include <FBase.h>
#include <FUi.h>

using namespace Tizen::Net;
using namespace Tizen::Net::Sockets;
using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;

class Enrollment: public Tizen::Ui::Controls::Form,
		public Tizen::Ui::IActionEventListener,
		public Tizen::Net::Sockets::ISocketEventListener,
		public Tizen::Ui::Controls::IFormBackEventListener,
		public Tizen::Ui::Scenes::ISceneEventListener

{
public:
	static const int MAX_BTN_COUNT = 6;
	static const int MAX_PILL_COUNT = 3;
	static const int MAX_WORK_COUNT = 4;

	enum CheckBtnActionID {
		ID_WORK_1 = 200, ID_WORK_2, ID_WORK_3, ID_WORK_4,
	};

	enum BtnActionId {
		ID_BTN_PILL_1 = 300,
		ID_BTN_PILL_2,
		ID_BTN_PILL_3,
		ID_BTN_MEET,
		ID_BTN_SAVE,
		ID_BTN_DEL,
	};

	static const int MY_PORT_NUM = 39000;

public:
	enum MyBtn {
		IDC_BUTTON_PILL_1 = 101, IDC_BUTTON_PILL_2, IDC_BUTTON_PILL_3,IDC_BUTTON_MEET,
		IDC_BUTTON_SAVE,
		IDC_BUTTON_DEL,
	};

	Tizen::Ui::Controls::Button* __pPillBtn[MAX_PILL_COUNT];
	Tizen::Ui::Controls::Button* __pMeetBtn, __pDelBtn;
	Tizen::Ui::Controls::Button* __pSaveBtn;
	Tizen::Ui::Controls::Label* __pDate;
	Tizen::Ui::Controls::CheckButton* __pWorkList[MAX_WORK_COUNT];

	Tizen::Net::Ip4Address* __pClientIp;

	int __iport;
	bool __isProtocol;
	bool __isServer;
	int __year;
	int __month;
	String __day;


	Container* __pParent;


	Tizen::Ui::Controls::Form* __pForm;
	Tizen::Ui::Controls::Label* __pLabelWait;

	/*	Tizen::Ui::Controls::EditArea* __pEditAreaData;
	 Tizen::Ui::Controls::EditField* __pEditFieldtext;*/

	int __port;
	bool __isTcp; // true = tcp false = udp
	bool __isConnected;
	bool __isConstructed;
	Tizen::Net::Sockets::Socket* __pSocket;
	Tizen::Net::Sockets::Socket* __pTcpSocket;
	Tizen::Net::NetEndPoint* __pUdpEndpoint;
	Tizen::Ui::Controls::Form* __pPreviousForm;
	Tizen::Ui::Controls::Popup* __pPopup;
	Tizen::Ui::Controls::Footer* __pFooter;



public:
	Enrollment();

	Enrollment(String Date,  Tizen::Ui::Controls::Form* pPreviousForm);

	/*Enrollment(Ip4Address* pAddress, int port, bool isServer, bool isTcp,
			String date, Tizen::Ui::Controls::Form* pPreviousForm);*/

	virtual ~Enrollment();

	bool Initialize(Container* pParent);

	bool Initialize();

	virtual result OnInitializing(void);

	virtual result OnTerminating(void);

	virtual void OnActionPerformed(const Tizen::Ui::Control & source,
			int actionId);

	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);

	result StartSaving(void); //same as start communication

public:
	static const RequestId REQUEST_ENROLLMENT_CLOSE = 1001;

	result EnrollmentData();

	virtual void OnSceneActivatedN(
			const Tizen::Ui::Scenes::SceneId& previousSceneId,
			const Tizen::Ui::Scenes::SceneId& currentSceneId,
			Tizen::Base::Collection::IList* pArgs);

	virtual void OnSceneDeactivated(
			const Tizen::Ui::Scenes::SceneId& currentSceneId,
			const Tizen::Ui::Scenes::SceneId& nextSceneId);

	void EnableControl(bool val);

	virtual void OnSocketAccept(Socket& socket);

	virtual void OnSocketClosed(Socket& socket1, NetSocketClosedReason reason);

	virtual void OnSocketConnected(Socket& socket1);

	virtual void OnSocketReadyToReceive(Socket& socket);

	virtual void OnSocketReadyToSend(Socket& socket1);

private:
	result SendData(void);

	void setDate(String date);

	result ReceiveData(void);

	void OnClose(void);

	result ReceiveDataUDP(void);

	result ReceiveDataTCP(void);

	result DisplayText(ByteBuffer& txBuffer, unsigned long buflen);

	result SendDataCommand(String command);

	result SocketServer(void);

	result SocketClient(void);

	result CreateSocket(NetSocketType type, NetSocketProtocol protocol);

	/*void ShowPopup(void);
	void HidePopup(void);
	void WaitAndHidePopup(void);*/


};

#endif /* ENROLLMENT_H_ */

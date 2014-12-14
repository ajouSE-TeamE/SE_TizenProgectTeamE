/*
 * Enrollment.cpp
 *
 *  Created on: Dec 9, 2014
 *      Author: div_S
 */

#include "Enrollment.h"
#include "AppResourceId.h"
#include "ForUsDocForm.h"
#include "ForUsDocApp.h"
#include "FormFactory.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::Base::Collection;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;
using namespace Tizen::Net;
using namespace Tizen::System;
using namespace Tizen::Net::Sockets;
using namespace Tizen::Graphics;

/*static const int IDC_CHECKServer_SEL = 102;
 static const int IDC_CHECKServer_UNSEL = 103;
 static const int ID_START = 104;
 static const int ID_BUTTON_CLOSE = 107;
 static const int PORT_MIN = 1024;
 static const int PORT_MAX = 49151;*/

Enrollment::Enrollment() :
		__pDate(null), __pClientIp(null), __iport(0), __isProtocol(null), __isServer(
				null) {

}
//불안함
Enrollment::Enrollment(String Date, Tizen::Ui::Controls::Form* pPreviousForm) :
		__pDate(null), __pClientIp(null), __iport(0), __isProtocol(null), __isServer(
				null) {
	setDate(Date);
	__pPreviousForm = pPreviousForm;

}

void Enrollment::setDate(String date) {
	__pDate = dynamic_cast<Label*>(GetControl(IDC_DATE));
	__pDate->SetEnabled(false);
	__pDate->SetText(date);

}

Enrollment::~Enrollment() {
	delete __pClientIp;
	__pClientIp = null;
	// TODO Auto-generated destructor stub
}

bool Enrollment::Initialize() {
	Construct(L"IDF_FORM_ENROLLMENT");
	return true;
}

bool Enrollment::Initialize(Container* pParent) {

	Construct(L"IDF_FORM_ENROLLMENT");

	__pParent = pParent;
	__pForm = null;
	__pLabelWait = null;
	__isConnected = false;
	__isConstructed = false;
	__pSocket = null;
	__pTcpSocket = null;
	__pUdpEndpoint = null;
	__iport = MY_PORT_NUM;
	__isProtocol = false; //UDP
	__isServer = true;
	__pPopup = null;
	__pFooter = null;
	return true;
}

result Enrollment::OnInitializing(void) {
	result r = E_SUCCESS;
	CheckButton* pCheckBtn = null;

	SetFormBackEventListener(this);

	__pSaveBtn = static_cast<Button*>(GetControl(IDC_SAVE));
	__pDate = static_cast<Label*>(GetControl(IDC_DATE));

	String cBtnName[] = { IDC_CHECKBUTTON_WORK1, IDC_CHECKBUTTON_WORK2,
			IDC_CHECKBUTTON_WORK3, IDC_CHECKBUTTON_WORK4 };

	for (int i = 0; i < MAX_WORK_COUNT; i++) {
		__pWorkList[i] = static_cast<CheckButton*>(GetControl(cBtnName[i]));
	}

	for (int i = 0; i < MAX_WORK_COUNT; i++) {
		pCheckBtn = dynamic_cast<CheckButton*>(GetControl(cBtnName[i]));
		TryReturn(pCheckBtn != null, E_SYSTEM,
				"Unable to get control [%ls]", cBtnName[i].GetPointer());
		pCheckBtn->SetEnabled(false);
		pCheckBtn->SetActionId(ID_WORK_1 + i, ID_WORK_1 + 500 + i);

		pCheckBtn->AddActionEventListener(*this);

	}

//!!!!!!!!!!!!!!!!!!!!!!!!!!!

	String btnName[] = { IDC_PILL_1, IDC_PILL_2, IDC_PILL_3, IDC_MEET, IDC_SAVE,
			IDC_DEL };

	Button* pButton = null;

	for (int i = 0; i < MAX_BTN_COUNT; i++) {
		pButton = dynamic_cast<Button*>(GetControl(btnName[i]));
		TryReturn(pButton != null, E_SYSTEM,
				"Unable to get control [%ls]", btnName[i].GetPointer());

		pButton->SetActionId(IDC_BUTTON_PILL_1 + i);
		pButton->AddActionEventListener(*this);
	}

	//!!!!!!!!!!!!!!!!!!!!!!!!!!!!

	__pForm = this;
	EnableControl(false);

	return r;
}

void Enrollment::OnActionPerformed(const Tizen::Ui::Control& source,
		int actionId) {

	static int WORK_LIST_INDEX = 0;
	switch (actionId) {
	case IDC_BUTTON_PILL_1:
		AppLog("Pill_1 is selected");
		if (WORK_LIST_INDEX < 4) {
			__pWorkList[WORK_LIST_INDEX++]->SetText("Pill 1");
		}
		break;

	case IDC_BUTTON_PILL_2:
		AppLog("Pill_2 is selected");
		if (WORK_LIST_INDEX < 4) {
			__pWorkList[WORK_LIST_INDEX++]->SetText("Pill 2");
		}
		break;
	case IDC_BUTTON_PILL_3:
		AppLog("Pill_3 is selected");
		if (WORK_LIST_INDEX < 4) {
			__pWorkList[WORK_LIST_INDEX++]->SetText("Pill 3");
		}
		break;
	case IDC_BUTTON_MEET:
		AppLog("MeetBtn is selected");
		if (WORK_LIST_INDEX < 4) {
			if (__pDate != null) {
				String date = __pDate->GetText();
				String mStr = "Meet at ";
				mStr.Append(date);
				{
					__pWorkList[WORK_LIST_INDEX++]->SetText(mStr);
				}
			}
		}
		break;
	case IDC_BUTTON_DEL:
		__pWorkList[--WORK_LIST_INDEX]->SetText(null);
		break;
	case IDC_BUTTON_SAVE: {
		result res = E_SUCCESS;
		res = SendData();
		if (IsFailed(res)) {
			AppLog("Data send Failed");
			result temp = SendData();
			WORK_LIST_INDEX = 0;
		}
		break;
	}
	default:
		AppLog("I don't know what happen!!!!!!!!!!!!!!!");
		break;

	}

	for (int k = 0; k < MAX_WORK_COUNT; k++) {
		__pWorkList[k]->RequestRedraw();
	}

}

void Enrollment::OnFormBackRequested(Controls::Form& source) {

	AppLog("Back Key Pressed");

	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	pSceneManager->GoBackward(BackwardSceneTransition(SCENE_CALENDAR));

	OnClose();
	EnableControl(false);

}

result Enrollment::CreateSocket(NetSocketType type,
		NetSocketProtocol protocol) {
	unsigned long arg = 1;
	result res = E_SUCCESS;

	//Create socket
	__pSocket = new (std::nothrow) Socket();
	TryReturn(__pSocket != null, E_OUT_OF_MEMORY, "Failed to allocate Socket");

	AppLog("Constructing Socket");
	res = __pSocket->Construct(NET_SOCKET_AF_IPV4, NET_SOCKET_TYPE_DATAGRAM,
			NET_SOCKET_PROTOCOL_UDP);
	TryReturn(res == E_SUCCESS, res, "Socket Construction failed %d", res);

	AppLog("Construct is finished");

	res = __pSocket->Ioctl(NET_SOCKET_FIONBIO, arg);
	TryReturn(res == E_SUCCESS, res, "Socket Ioctl failed %d", res);

	res = __pSocket->AddSocketListener(*this);
	TryReturn(res == E_SUCCESS, res, "Socket AddSocketListener failed %d", res);

	res = __pSocket->SetSockOpt(NET_SOCKET_SOL_SOCKET, NET_SOCKET_SO_REUSEADDR,
			1);
	TryReturn(res == E_SUCCESS, res, "Socket SetSockOpt failed %d", res);

	res = __pSocket->AsyncSelectByListener(
			NET_SOCKET_EVENT_CONNECT | NET_SOCKET_EVENT_WRITE
					| NET_SOCKET_EVENT_READ | NET_SOCKET_EVENT_CLOSE
					| NET_SOCKET_EVENT_ACCEPT);
	return res;

}
result Enrollment::SocketServer(void) {

	result res = E_SUCCESS;
	Ip4Address peerAddr(NET_SOCKET_INADDR_ANY);
	unsigned short peerPort = __port;

	NetEndPoint* pPeerEndPoint = new (std::nothrow) NetEndPoint(peerAddr,
			peerPort);
	TryReturn(pPeerEndPoint != null, E_OUT_OF_MEMORY,
			"Failed to allocate NetEndPoint");

	//Bind socket to server_port
	res = __pSocket->Bind(*pPeerEndPoint);
	delete pPeerEndPoint;

	TryReturn(res == E_SUCCESS, res, "Socket Bind failed %d", res);

	return res;
}
result Enrollment::SocketClient() {

	result res = E_SUCCESS;

	EnableControl(true);
	SendDataCommand(L"__HELLO__");
	__isConnected = true;

	return res;
}

result Enrollment::OnTerminating(void) {
	result r = E_SUCCESS;
	AppLog("Enrollment::OnTerminating");
	OnClose();
	EnableControl(false);
	return r;
}

result Enrollment::StartSaving(void) {
	result res = E_SUCCESS;

	res = CreateSocket(NET_SOCKET_TYPE_DATAGRAM, NET_SOCKET_PROTOCOL_UDP);
	TryReturn(res == E_SUCCESS, res, "Error in creating Socket %d", res);

	if (res != E_SUCCESS) {
		AppLog("creating socket Error");
	}
	__isConstructed = true;

	res = SocketServer();

	return res;
}

void Enrollment::OnSocketAccept(Socket& socket) {

	result res = E_SUCCESS;
	AppLog("OnSocketAccept");

	EnableControl(true);
	__isConnected = true;

	Socket* pSocket = const_cast<Socket*>(&socket);
	__pTcpSocket = __pSocket;

	// Accept the connection attempt.
	__pSocket = pSocket->AcceptN();
	if (__pSocket == null) {
		AppLog("Socket Accept Failed");
		return;
	}
	// Add Socket Listener to listen to socket event.
	res = __pSocket->AddSocketListener(*this);
	if (IsFailed(res)) {
		AppLog("Socket AddSocketListener failed %d", res);
	}

	// Set the socket as select an interested event.
	res = __pSocket->AsyncSelectByListener(
			NET_SOCKET_EVENT_WRITE | NET_SOCKET_EVENT_READ
					| NET_SOCKET_EVENT_CLOSE);
	if (IsFailed(res)) {
		AppLog("Socket AsyncSelectByListener failed %d", res);
	}
}

void Enrollment::OnSocketClosed(Socket& socket, NetSocketClosedReason reason) {
	AppLog("OnSocketClosed");
	AppLog(GetErrorMessage(GetLastResult()));
	AppLog("Reasoning %d", reason);

	OnClose();
	AppLog("Close Socket");

	EnableControl(false);
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	pSceneManager->GoBackward(BackwardSceneTransition(SCENE_CALENDAR));
}

void Enrollment::OnSocketConnected(Socket& socket) {
	AppLog("OnSocketConnected");
	EnableControl(true);
	__isConnected = true;
}

void Enrollment::OnSocketReadyToReceive(Socket& socket) {

	AppLog("OnSocketReadyToReceive");
	ReceiveData();
}

void Enrollment::OnSocketReadyToSend(Socket& socket) {
	AppLog("OnSocketReadyToSend");
}

result Enrollment::SendDataCommand(String command) {
	ByteBuffer* pTxBuffer = null;
	ByteBuffer buffer;
	result res = E_SUCCESS;

	TryReturn(__isTcp == false, E_SYSTEM,
			"Sending Command not required for TCP connection");
	pTxBuffer = Tizen::Base::Utility::StringUtil::StringToUtf8N(command);
	TryReturn(pTxBuffer != null, E_OUT_OF_MEMORY,
			"Failed to allocate ByteBuffer");

	buffer.Construct(1024);
	buffer.CopyFrom(*pTxBuffer);
	delete pTxBuffer;

	buffer.Flip();
	do {
		if (__pUdpEndpoint != null) {
			res = __pSocket->SendTo(buffer, *__pUdpEndpoint);
		}
		if (res == E_WOULD_BLOCK) {
			AppLog("Would block for data sending will try to retransmit");
			Tizen::Base::Runtime::Thread::Sleep(500);
		} else if (res != E_SUCCESS) {
			AppLog("Error sending data");
			break;
		} else {
			AppLog("Command successfully sent");
			break;
		}
	} while (1);

	AppLog("Loop completed");
	buffer.Clear();

	return res;
}

result Enrollment::SendData() {
	String data = "";
	ByteBuffer* pTxBuffer = null;
	ByteBuffer buffer;
	result res = E_SUCCESS;

	for (int i = 0; i < 4; i++) {
		data.Append(__pWorkList[i]->GetText());
		data.Append("\n");
	}
	if (data.IsEmpty()) {
		AppLog("There is no data to send");
		return E_SUCCESS;
	}

	pTxBuffer = Tizen::Base::Utility::StringUtil::StringToUtf8N(data);
	TryReturn(pTxBuffer != null, E_OUT_OF_MEMORY,
			"Failed to allocate ByteBuffer");
	AppLog("Text Length %d", pTxBuffer->GetLimit());

	buffer.Construct(pTxBuffer->GetLimit());
	buffer.CopyFrom(*pTxBuffer);
	buffer.Flip();

	delete pTxBuffer;

	res = __pSocket->SendTo(buffer, *__pUdpEndpoint);
	if (res != E_SUCCESS && res != E_WOULD_BLOCK)
		AppLog("Error sending data");

	buffer.Clear();
	return res;
}

result Enrollment::DisplayText(ByteBuffer& txBuffer, unsigned long buflen) {
	String data;
	char* pBuffer = null;
	result res = E_SUCCESS;

	txBuffer.Flip();
	pBuffer = (char*) (txBuffer.GetPointer());
	data.SetCapacity(buflen + 20);
	res = data.Append(pBuffer);
	TryReturn(res == E_SUCCESS, res, "Append Failed");

	txBuffer.Clear();

	if (data == L"__HELLO__") {
		EnableControl(true);
		__isConnected = true;
		return res;
	}

	if (__isConnected == false) {
		AppLog(
				"Server hasn't received Initial message so all incoming content is discarded");
		// Remove created NetEndPoint
		delete __pUdpEndpoint;
		__pUdpEndpoint = null;
		return res;
	}

	if (data == L"__CLOSE__") {
		SceneManager* pSceneManager = SceneManager::GetInstance();
		AppAssert(pSceneManager);

		pSceneManager->GoBackward(BackwardSceneTransition(SCENE_CALENDAR));

		OnClose();
		return res;
	}

	int i = 0;
	if (data.Contains(__pWorkList[i]->GetText())) {
		__pWorkList[i++]->SetSelected(true);
	}
	if (data.Contains(__pWorkList[i]->GetText())) {
		__pWorkList[i++]->SetSelected(true);
	}
	if (data.Contains(__pWorkList[i]->GetText())) {
		__pWorkList[i++]->SetSelected(true);
	}
	if (data.Contains(__pWorkList[i]->GetText())) {
		__pWorkList[i++]->SetSelected(true);
	}

	TryReturn(res == E_SUCCESS, res, "AppendText Failed");

	for (int k = 0; k < MAX_WORK_COUNT; k++) {
		__pWorkList[k]->RequestRedraw();
	}

	return res;
}

result Enrollment::ReceiveDataUDP(void) {
	result res = E_SUCCESS;
	ByteBuffer txBuffer;
	unsigned long buflen = 0;

	__pSocket->Ioctl(NET_SOCKET_FIONREAD, buflen);

	txBuffer.Construct(buflen + 1);

	Ip4Address peerAddr1(NET_SOCKET_INADDR_ANY);
	unsigned short port = 0;
	NetEndPoint point(peerAddr1, port);

	res = __pSocket->ReceiveFrom(txBuffer, point);
	if (__pUdpEndpoint == null) {
		__pUdpEndpoint = new (std::nothrow) NetEndPoint(point);
	} else {
		if (__pUdpEndpoint->GetNetEndPoint() != point.GetNetEndPoint()) {
			AppLog("It's a data from other endpoint so discard");
			return res;
		}
	}

	TryReturn(res == E_SUCCESS, res, "Receive Failed %d", res);

	res = DisplayText(txBuffer, buflen);
	txBuffer.Clear();

	return res;
}

result Enrollment::ReceiveDataTCP(void) {
	result res = E_SUCCESS;
	ByteBuffer txBuffer;
	String data;
	unsigned long buflen = 0;

	// Get the size of data received
	__pSocket->Ioctl(NET_SOCKET_FIONREAD, buflen);

	txBuffer.Construct(buflen + 1);

	res = __pSocket->Receive(txBuffer);
	TryReturn(res == E_SUCCESS, res, "Receive Failed");

	res = DisplayText(txBuffer, buflen);
	txBuffer.Clear();

	return res;
}

result Enrollment::ReceiveData(void) {
	result res = E_SUCCESS;

	if (__isTcp) {
		res = ReceiveDataTCP();
	} else {
		res = ReceiveDataUDP();
	}

	return res;
}

void Enrollment::OnClose(void) {
	result res = E_SUCCESS;
	AppLog("Socket Close Received");

	if (__isConstructed) {
		if (__pSocket != null) {
			SendDataCommand(L"__CLOSE__");

			res = __pSocket->RemoveSocketListener(*this);
			if (IsFailed(res)) {
				AppLog("RemoveSocketListener failed %d", res);
			}

			__pSocket->Close();
		}

		if (__pTcpSocket != null) {
			__pTcpSocket->Close();
		}
	}

	delete __pSocket;
	delete __pTcpSocket;
	delete __pUdpEndpoint;

	__pUdpEndpoint = null;
	__pSocket = null;
	__pTcpSocket = null;
	__isConnected = false;
	__isConstructed = false;
}

void Enrollment::EnableControl(bool val) {

}

void Enrollment::OnSceneActivatedN(
		const Tizen::Ui::Scenes::SceneId& previousSceneId,
		const Tizen::Ui::Scenes::SceneId& currentSceneId,
		Tizen::Base::Collection::IList* pArgs) {

	AppLog("ChatFrm::OnSceneActivatedN");

	Ip4Address* pAddress = null;

	if (pArgs != null) {
		if (pArgs->GetCount()) {
			Boolean* pServer = dynamic_cast<Boolean*>(pArgs->GetAt(0));
			TryCatch(pServer != null, ,
					"Failed to retrieve the client/server from the Array list.");

			__isServer = pServer->ToBool();

			if (__isServer) {
				Integer* pPort = dynamic_cast<Integer*>(pArgs->GetAt(1));
				TryCatch(pPort != null, ,
						"Failed to retrieve the port number from the Array list.");

				__port = pPort->ToInt();

				Boolean* pProtocol = dynamic_cast<Boolean*>(pArgs->GetAt(2));
				TryCatch(pProtocol != null, ,
						"Failed to retrieve the protocol type from the Array list.");

				__isTcp = pProtocol->ToBool();

				Integer* pYear = dynamic_cast<Integer*>(pArgs->GetAt(3));
				TryCatch(pProtocol != null, ,
						"Failed to retrieve the year from the Array list.");

				__year = pYear->ToInt();

				Integer* pMonth = dynamic_cast<Integer*>(pArgs->GetAt(4));
				TryCatch(pProtocol != null, ,
						"Failed to retrieve the month from the Array list.");

				__month = pMonth->ToInt();

				Integer* pDay = dynamic_cast<Integer*>(pArgs->GetAt(5));
				TryCatch(pProtocol != null, ,
						"Failed to retrieve the month from the Array list.");
				__day = "";
				__day = pDay->ToString();
				if (__day == "") {
					AppLog("Day Error");
				};

				String myDay = "";
				myDay.Append(__year);
				myDay.Append("/");
				myDay.Append(__month);
				myDay.Append("/");
				myDay.Append(__day);
				myDay.Append("");

				__pDate->SetText(myDay);

			} else {
				pAddress = dynamic_cast<Ip4Address*>(pArgs->GetAt(1));
				TryCatch(pAddress !=null, ,
						"Failed to retrieve the Ipaddress from the Array list.");

				Integer* pPort = dynamic_cast<Integer*>(pArgs->GetAt(2));
				TryCatch(pPort != null, ,
						"Failed to retrieve the port number from the Array list.");

				__port = pPort->ToInt();

				Boolean* pProtocol = dynamic_cast<Boolean*>(pArgs->GetAt(3));
				TryCatch(pProtocol != null, ,
						"Failed to retrieve the protocol type from the Array list.");

				__isTcp = pProtocol->ToBool();

				Integer* pYear = dynamic_cast<Integer*>(pArgs->GetAt(3));
				TryCatch(pProtocol != null, ,
						"Failed to retrieve the year from the Array list.");

				__year = pYear->ToInt();

				Integer* pMonth = dynamic_cast<Integer*>(pArgs->GetAt(4));
				TryCatch(pProtocol != null, ,
						"Failed to retrieve the month from the Array list.");

				__month = pMonth->ToInt();

				Integer* pDay = dynamic_cast<Integer*>(pArgs->GetAt(5));
				TryCatch(pProtocol != null, ,
						"Failed to retrieve the month from the Array list.");
				__day = "";
				__day = pDay->ToString();
				if (__day == "") {
					AppLog("Day Error");
				};

				String myDay = "";
				myDay.Append(__year);
				myDay.Append("/");
				myDay.Append(__month);
				myDay.Append("/");
				myDay.Append(__day);
				myDay.Append(".");

				__pDate->SetText(myDay);

			}
		}

		if (!__isTcp) {

		}

		if (!__isServer) {
			__pClientIp = new (std::nothrow) Ip4Address(*pAddress);
		} else {
			__pClientIp = null;
		}

		StartSaving();
	}

	CATCH: pArgs->RemoveAll(true);
	delete pArgs;
}

void Enrollment::OnSceneDeactivated(
		const Tizen::Ui::Scenes::SceneId& currentSceneId,
		const Tizen::Ui::Scenes::SceneId& nextSceneId) {
	AppLog("ChatFrm::OnSceneDeactivated");

}

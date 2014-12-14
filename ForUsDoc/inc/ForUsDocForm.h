#ifndef _FOR_US_DOC_FORM_H_
#define _FOR_US_DOC_FORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>
#include <FLocales.h>
#include <new>
#include <FNet.h>
#include "Enrollment.h"

class ForUsDocForm: public Tizen::Ui::Controls::Form,
		public Tizen::Ui::IActionEventListener,
		public Tizen::Ui::Controls::IFormBackEventListener,
		public Tizen::Ui::ITextEventListener {
public:
	ForUsDocForm(void);
	virtual ~ForUsDocForm(void);

	bool Initialize(void);

	virtual result OnInitializing(void);

	virtual result OnTerminating(void);

	virtual void OnActionPerformed(const Tizen::Ui::Control& source,
			int actionId);

	virtual void OnTextValueChanged(const Tizen::Ui::Control& source);
	virtual void OnTextValueChangeCanceled(const Tizen::Ui::Control& source);
	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);

	void startSaving(int);

	/*void CreateEnrollment();
	 void DeleteEnrollment();*/

	/*virtual void OnUserEventReceivedN(RequestId requestId,
			Tizen::Base::Collection::IList* pArgs);*/

private:
	result InitializeActionControls(void);
	result InitializeDayNumberButtons(void);
	bool UpdateCalendarDisplay(void);

	int __year;
	int __month;

public:
	enum ButtonActionId {
		ID_BUTTON_PREV_YEAR_ID = 101,
		ID_BUTTON_PREV_MONTH_ID,
		ID_BUTTON_NEXT_MONTH_ID,
		ID_BUTTON_NEXT_YEAR_ID,
	};

	enum ButtonDayIndex {
		dayBtn0,
		dayBtn1,
		dayBtn2,
		dayBtn3,
		dayBtn4,
		dayBtn5,
		dayBtn6,
		dayBtn7,
		dayBtn8,
		dayBtn9,
		dayBtn10,
		dayBtn11,
		dayBtn12,
		dayBtn13,
		dayBtn14,
		dayBtn15,
		dayBtn16,
		dayBtn17,
		dayBtn18,
		dayBtn19,
		dayBtn20,
		dayBtn21,
		dayBtn22,
		dayBtn23,
		dayBtn24,
		dayBtn25,
		dayBtn26,
		dayBtn27,
		dayBtn28,
		dayBtn29,
		dayBtn30,
		dayBtn31,
		dayBtn32,
		dayBtn33,
		dayBtn34,
		dayBtn35,
		dayBtn36,
		dayBtn37,
		dayBtn38,
		dayBtn39,
		dayBtn40,
		dayBtn41,
	};

	static const int ACTION_BUTTON_COUNT = 4;
	static const int ACTION_LABEL_COUNT = 2;
	static const int DAY_BUTTON_COUNT = 42;

private:
	Tizen::Locales::Calendar* __pSelectCalendar;
	Tizen::Ui::Controls::EditField* __pEditFields[ACTION_LABEL_COUNT];
	Tizen::Ui::Controls::Button* __pDayBtn[DAY_BUTTON_COUNT];

	/*
	 *this var will be used in Enrollment Form

	 Tizen::Net::Ip4Address& __pClientIp;
	 int __iport;
	 bool __isProtocol;		//	TCP or UDP
	 bool __isServer;
	 */
	Enrollment* __pEnrollment;

};

#endif	//_FOR_US_DOC_FORM_H_

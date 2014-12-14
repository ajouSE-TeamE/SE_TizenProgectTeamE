#include "ForUsDocForm.h"
#include "AppResourceId.h"
#include "ForUsDocApp.h"

#include <new>
#include <FSystem.h>
#include <FAppUiApp.h>

#include <stdlib.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;
using namespace Tizen::Locales;
using namespace Tizen::App;
using namespace Tizen::Base::Collection;

ForUsDocForm::ForUsDocForm(void) :
		__pSelectCalendar(null), __pEnrollment(null) {
}

ForUsDocForm::~ForUsDocForm(void) {
}

bool ForUsDocForm::Initialize(void) {
	result r = Construct(IDL_FORM);
	TryReturn(r == E_SUCCESS, false, "Failed to construct form");

	return true;
}

result ForUsDocForm::InitializeActionControls(void) {

	AppLog(
			"*---------ForUsDocForm::InitializeActionControls started--------*\n");

	String btnName[] = { IDC_BTN_PRV_YEAR, IDC_BTN_PRV_MONTH,
			IDC_BTN_NEXT_MONTH, IDC_BTN_NEXT_YEAR };
	Button* pButton = null;

	for (int i = 0; i < ACTION_BUTTON_COUNT; i++) {
		pButton = dynamic_cast<Button*>(GetControl(btnName[i]));
		TryReturn(pButton != null, E_SYSTEM,
				"Unable to get control [%ls]", btnName[i].GetPointer());

		pButton->SetActionId(ID_BUTTON_PREV_YEAR_ID + i);
		pButton->AddActionEventListener(*this);
	}

	String lblStr[] = { IDC_EDIT_FIELD_YEAR, IDC_EDIT_FIELD_MONTH };

	String value[] = { L"", L"" };
	value[0].Append(__pSelectCalendar->GetTimeField(TIME_FIELD_YEAR));
	value[1].Append(__pSelectCalendar->GetTimeField(TIME_FIELD_MONTH));

	result r = E_SUCCESS;
	for (int i = 0; i < ACTION_LABEL_COUNT; i++) {
		__pEditFields[i] = dynamic_cast<EditField*>(GetControl(lblStr[i]));
		TryReturn(__pEditFields[i] != null, E_SYSTEM,
				"Unable to get control [%ls]", lblStr[i].GetPointer());

		r = __pEditFields[i]->SetText(value[i]);
		TryReturn(!IsFailed(r), r,
				"[%s] EditField::SetText() failed for [%ls]", GetErrorMessage(r), lblStr[i].GetPointer());

		__pEditFields[i]->AddTextEventListener(*this);
	}

	return E_SUCCESS;

}

result ForUsDocForm::InitializeDayNumberButtons(void) {

	AppLog(
			"*---------ForUsDocForm::InitializeDayNumberButtons started--------*\n");

	for (int i = 0; i < DAY_BUTTON_COUNT; i++) {
		String name(L"IDC_BUTTON");
		name.Append(i);
		Control* pControl = GetControl(name);
		__pDayBtn[i] = dynamic_cast<Button*>(pControl);
		TryReturn(__pDayBtn[i] != null, E_SYSTEM,
				"Unable to get control[%ls]", name.GetPointer());
		__pDayBtn[i]->SetEnabled(false);
		__pDayBtn[i]->SetActionId(dayBtn0 + i);
		__pDayBtn[i]->AddActionEventListener(*this);
	}
	return E_SUCCESS;
}

result ForUsDocForm::OnInitializing(void) {

	DateTime CurDateTime;
	SetFormBackEventListener(this);

	result r = SystemTime::GetCurrentTime(CurDateTime);
	TryReturn(!IsFailed(r), r,
			"SystemTime::GetCurrentTime() failed with [%s]", GetErrorMessage(r));

	r = CurDateTime.SetValue(CurDateTime.GetYear(), CurDateTime.GetMonth(), 1);
	TryReturn(!IsFailed(r), r,
			"DateTime::SetValue() failed with [%s]", GetErrorMessage(r));

	__pSelectCalendar = Calendar::CreateInstanceN();
	TryReturn(__pSelectCalendar != null, E_SYSTEM,
			"Unable to get Create Instance");

	r = __pSelectCalendar->SetTime(CurDateTime);
	TryReturn(!IsFailed(r), r,
			"Calendar::SetTime() failed with [%s]", GetErrorMessage(r));

	AppLog(
			"GetCurrentTime : %d/%d/%d", __pSelectCalendar->GetTimeField(TIME_FIELD_YEAR), __pSelectCalendar->GetTimeField(TIME_FIELD_MONTH), __pSelectCalendar->GetTimeField(TIME_FIELD_DAY_OF_MONTH));

	r = InitializeActionControls();
	TryReturn(!IsFailed(r), r,
			"InitializeActionControls() failed with [%s]", GetErrorMessage(r));

	r = InitializeDayNumberButtons();
	TryReturn(!IsFailed(r), r,
			"InitializeDayNumberButtons() failed with [%s]", GetErrorMessage(r));

	TryReturn(UpdateCalendarDisplay() == true, E_SYSTEM,
			"UpdateCalendarDisplay() failed");

	return E_SUCCESS;
}

result ForUsDocForm::OnTerminating(void) {

	delete __pSelectCalendar;
	return E_SUCCESS;

}

bool ForUsDocForm::UpdateCalendarDisplay(void) {

	DateTime oldValue = __pSelectCalendar->GetTime();
	result r = E_SUCCESS;

	for (int i = 0; i < DAY_BUTTON_COUNT; i++) {
		r = __pDayBtn[i]->SetShowState(false);
		TryReturn(!IsFailed(r), false,
				"DayButton::SetShowStqte() failed with [%s]", GetErrorMessage(r));
	}
	r = __pSelectCalendar->SetTimeField(TIME_FIELD_DAY_OF_MONTH, 1);
	int offset = __pSelectCalendar->GetTimeField(TIME_FIELD_DAY_OF_WEEK) - 1;
	int date = __pSelectCalendar->GetTimeField(TIME_FIELD_DAY_OF_MONTH);

	int i = offset;
	do {
		String value(L"");
		value.Append(date);
		__pDayBtn[i]->SetEnabled(true);
		__pDayBtn[i]->SetText(value);
		r = __pDayBtn[i]->SetShowState(true);
		TryReturn(!IsFailed(r), false,
				"Button::SetShowState() failed with [%s]", GetErrorMessage(r));
		r = __pSelectCalendar->AddTimeField(TIME_FIELD_DAY_OF_MONTH, 1);
		TryReturn(!IsFailed(r), false,
				"Calendar::AddTimeField failed with [%s]", GetErrorMessage(r));
		date = __pSelectCalendar->GetTimeField(TIME_FIELD_DAY_OF_MONTH);

		i++;

	} while (date != 1 && i < DAY_BUTTON_COUNT);

	__pSelectCalendar->SetTime(oldValue);

	String year = L"";
	year.Append(__pSelectCalendar->GetTimeField(TIME_FIELD_YEAR));
	__pEditFields[0]->SetText(year);

	String month = L"";
	month.Append(__pSelectCalendar->GetTimeField(TIME_FIELD_MONTH));
	__pEditFields[1]->SetText(month);

	SetFocus();
	RequestRedraw(true);

	return true;

}

void ForUsDocForm::OnActionPerformed(const Tizen::Ui::Control& source,
		int actionId) {

	int year = __pSelectCalendar->GetTimeField(TIME_FIELD_YEAR);
	int month = __pSelectCalendar->GetTimeField(TIME_FIELD_MONTH);

	result r = E_SUCCESS;

	String port = "39000";
	int __iport = 39000;
	bool __isProtocol = false;
	bool __isServer = true;

	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	ArrayList* pList = new (std::nothrow) ArrayList;
	AppAssert(pList);

	__year = year;
	__month = month;

	switch (actionId) {
	case ID_BUTTON_PREV_MONTH_ID:
		TryReturnVoid((year > 1) || (month > 1), "At first page");
		__pSelectCalendar->AddTimeField(TIME_FIELD_MONTH, -1);
		AppLog("PREV_MONTH Button is clicked\n");
		break;
	case ID_BUTTON_NEXT_MONTH_ID:
		TryReturnVoid((year < 9999) || (month < 12), "At last page");
		__pSelectCalendar->AddTimeField(TIME_FIELD_MONTH, 1);
		AppLog("NEXT_MONTH Button is clicked\n");
		break;
	case ID_BUTTON_PREV_YEAR_ID:
		TryReturnVoid(year > 1, "At starting year");
		__pSelectCalendar->AddTimeField(TIME_FIELD_YEAR, -1);
		AppLog("PREV_YEAR Button is clicked\n");
		break;
	case ID_BUTTON_NEXT_YEAR_ID:
		TryReturnVoid(year < 9999, "At starting year");
		__pSelectCalendar->AddTimeField(TIME_FIELD_YEAR, 1);
		AppLog("NEXT_YEAR Button is clicked\n");
		break;
	case dayBtn0:
	case dayBtn1:
	case dayBtn2:
	case dayBtn3:
	case dayBtn4:
	case dayBtn5:
	case dayBtn6:
	case dayBtn7:
	case dayBtn8:
	case dayBtn9:
	case dayBtn10:
	case dayBtn11:
	case dayBtn12:
	case dayBtn13:
	case dayBtn14:
	case dayBtn15:
	case dayBtn16:
	case dayBtn17:
	case dayBtn18:
	case dayBtn19:
	case dayBtn20:
	case dayBtn21:
	case dayBtn22:
	case dayBtn23:
	case dayBtn24:
	case dayBtn25:
	case dayBtn26:
	case dayBtn27:
	case dayBtn28:
	case dayBtn29:
	case dayBtn30:
	case dayBtn31:
	case dayBtn32:
	case dayBtn33:
	case dayBtn34:
	case dayBtn35:
	case dayBtn36:
	case dayBtn37:
	case dayBtn38:
	case dayBtn39:
	case dayBtn40:
	case dayBtn41: {
		int temp = actionId;
		AppLog("DayBtn is clicked");
		AppLog("Btn Num is &d", temp);

		r = pList->Construct();
		{
			TryCatch(r == E_SUCCESS, , "Failed to construct the Array list.");
			CATCH: {
			}
		}

		r = pList->Add(*(new (std::nothrow) Boolean(__isServer)));
		{
			TryCatch(r == E_SUCCESS, ,
				"Failed to add the client/server to the Array list.");

		}

		r = pList->Add(*(new (std::nothrow) Integer(__iport)));
		TryCatch(r == E_SUCCESS, ,
				"Failed to add port number to the Array list.");

		r = pList->Add(*(new (std::nothrow) Boolean(__isProtocol)));
		TryCatch(r == E_SUCCESS, ,
				"Failed to add the protocol to the Array list.");

		r = pList->Add(*(new (std::nothrow) Integer(__year)));
		TryCatch(r == E_SUCCESS, , "Failed to add year to the Array list.");

		r = pList->Add(*(new (std::nothrow) Integer(__month)));
		TryCatch(r == E_SUCCESS, , "Failed to add month to the Array list.");

		String strTmp = __pDayBtn[actionId]->GetText();

		int day;
		r = Tizen::Base::Integer::Parse(strTmp, day);
		r = pList->Add(*new (std::nothrow) Integer(day));
		TryCatch(r == E_SUCCESS, , "Failed to add day to the Array list.");

		if (__pEnrollment != null) {
			delete __pEnrollment;
			__pEnrollment = null;
		}

		pSceneManager->GoForward(ForwardSceneTransition(SCENE_ENROLLMENT),
				pList);

	}
		break;

	default:
		break;
	}

	UpdateCalendarDisplay();

}

void ForUsDocForm::OnTextValueChanged(const Control& source) {

	int newValue = 0;
	result r = E_SUCCESS;
	const Control* pObject = &source;
	if (pObject == __pEditFields[0]) {
		r = Integer::Parse(__pEditFields[0]->GetText(), newValue);
		if ((!IsFailed(r)) && (newValue > 0) && (newValue <= 9999)) {
			__pSelectCalendar->SetTimeField(TIME_FIELD_YEAR, newValue);
		}
	} else if (pObject == __pEditFields[1]) {
		r = Integer::Parse(__pEditFields[1]->GetText(), newValue);
		if ((!IsFailed(r)) && (newValue > 0) && (newValue <= 12)) {
			__pSelectCalendar->SetTimeField(TIME_FIELD_MONTH, newValue);
		}
	}

	UpdateCalendarDisplay();

}
void ForUsDocForm::OnTextValueChangeCanceled(const Tizen::Ui::Control& source) {
	SetFocus();
}

void ForUsDocForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source) {
	UiApp* pApp = UiApp::GetInstance();
	AppAssert(pApp);
	pApp->Terminate();
}


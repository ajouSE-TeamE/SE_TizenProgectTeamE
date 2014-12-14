/*
 * FormFactory.cpp
 *
 *  Created on: Dec 9, 2014
 *      Author: div_S
 */

#include "FormFactory.h"
#include <new>
#include "ForUsDocForm.h"
#include "Enrollment.h"

using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;

const wchar_t* FORM_CALENDAR = L"FormCalendar";
const wchar_t* FORM_ENROLLMENT = L"FormEnrollment";

FormFactory::FormFactory() {
	// TODO Auto-generated constructor stub

}

FormFactory::~FormFactory() {
	// TODO Auto-generated destructor stub
}

Tizen::Ui::Controls::Form* FormFactory::CreateFormN(
		const Tizen::Base::String& formId,
		const Tizen::Ui::Scenes::SceneId& sceneId) {

	Tizen::Ui::Controls::Form* pNewForm = null;
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	if (formId == FORM_CALENDAR) {

		ForUsDocForm* pCalendarFrm = new (std::nothrow) ForUsDocForm();
		pCalendarFrm->Initialize();
		pNewForm = pCalendarFrm;

	} else if (formId == FORM_ENROLLMENT) {

		Enrollment* pEnrollmentFrm = new (std::nothrow) Enrollment();

		if (pEnrollmentFrm == null) {

			int result;
			MessageBox* pMsgBox = new (std::nothrow) MessageBox();
			pMsgBox->Construct(L"Error", L"Error in allocating Memory",
					MSGBOX_STYLE_OK);
			pMsgBox->ShowAndWait(result);
			delete pMsgBox;

		}

		pEnrollmentFrm->Initialize();
		AppLog("initialize:Exit");
		pSceneManager->AddSceneEventListener(sceneId, *pEnrollmentFrm);
		pNewForm = pEnrollmentFrm;
	}
	return pNewForm;
}

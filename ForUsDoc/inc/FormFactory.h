/*
 * FormFactory.h
 *
 *  Created on: Dec 9, 2014
 *      Author: div_S
 */

#ifndef FORMFACTORY_H_
#define FORMFACTORY_H_

#include <FUi.h>

extern const wchar_t* FORM_CALENDAR;
extern const wchar_t* FORM_ENROLLMENT;

class FormFactory: public Tizen::Ui::Scenes::IFormFactory {
public:
	FormFactory();
	virtual ~FormFactory();

	virtual Tizen::Ui::Controls::Form* CreateFormN(const Tizen::Base::String& formId, const Tizen::Ui::Scenes::SceneId& sceneId);
};

#endif /* FORMFACTORY_H_ */

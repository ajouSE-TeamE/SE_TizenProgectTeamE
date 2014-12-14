#include <new>
#include "ForUsDocFrame.h"
#include "ForUsDocForm.h"

using namespace Tizen::Base;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;

ForUsDocFrame::ForUsDocFrame(void)
{
}

ForUsDocFrame::~ForUsDocFrame(void)
{
}

result
ForUsDocFrame::OnInitializing(void)
{
	result r = E_SUCCESS;

	// Create a form
	ForUsDocForm* pForUsDocForm = new (std::nothrow) ForUsDocForm();
	TryReturn(pForUsDocForm != null, false, "The memory is insufficient.");
	pForUsDocForm->Initialize();

	// Add the form to the frame
	AddControl(pForUsDocForm);

	// Set the current form
	SetCurrentForm(pForUsDocForm);

	// Draw the form
	pForUsDocForm->Invalidate(true);

	// TODO: Add your frame initialization code here.

	return r;
}

result
ForUsDocFrame::OnTerminating(void)
{
	result r = E_SUCCESS;

	// TODO: Add your frame termination code here.
	return r;
}



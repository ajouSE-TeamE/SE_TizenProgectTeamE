#ifndef _FOR_US_DOC_FRAME_H_
#define _FOR_US_DOC_FRAME_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class ForUsDocFrame
	: public Tizen::Ui::Controls::Frame
{
public:
	ForUsDocFrame(void);
	virtual ~ForUsDocFrame(void);

private:
	virtual result OnInitializing(void);
	virtual result OnTerminating(void);
};

#endif	//_FOR_US_DOCFRAME_H_

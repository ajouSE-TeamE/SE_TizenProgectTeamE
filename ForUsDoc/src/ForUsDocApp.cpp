#include <new>
#include "ForUsDocApp.h"
#include "FormFactory.h"
#include "ForUsDocForm.h"

using namespace Tizen::App;
using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;

extern const wchar_t* SCENE_CALENDAR = L"CalendarScene";
extern const wchar_t* SCENE_ENROLLMENT = L"EnrollmentScene";

ForUsDocApp::ForUsDocApp(void)
{
}

ForUsDocApp::~ForUsDocApp(void)
{
}


Application*
ForUsDocApp::CreateInstance(void)
{
	// TODO: Create the application instance through the constructor.
	return new (std::nothrow) ForUsDocApp();
}

bool
ForUsDocApp::OnAppInitializing(AppRegistry& appRegistry)
{
    static const wchar_t* PANEL_BLANK = L"";
    static FormFactory formFactory;

    Frame* pAppFrame = new (std::nothrow) Frame();
    pAppFrame->Construct();
    AddFrame(*pAppFrame);

    SceneManager* pSceneManager = SceneManager::GetInstance();
    AppAssert(pSceneManager);

    pSceneManager->RegisterFormFactory(formFactory);

    pSceneManager->RegisterScene(SCENE_CALENDAR, FORM_CALENDAR, PANEL_BLANK);
    pSceneManager->RegisterScene(SCENE_ENROLLMENT, FORM_ENROLLMENT, PANEL_BLANK);

    if(pSceneManager->GoForward(ForwardSceneTransition(SCENE_CALENDAR)) != E_SUCCESS){
    	return false;
    }
    return true;
}



/*
bool
ForUsDocApp::OnAppInitialized(void)
{
	// TODO: Create the application frame.

	ForUsDocFrame* pForUsDocFrame = new (std::nothrow) ForUsDocFrame;
	TryReturn(pForUsDocFrame != null, false, "The memory is insufficient.");
	pForUsDocFrame->Construct();
	pForUsDocFrame->SetName(L"ForUsDoc");
	AddFrame(*pForUsDocFrame);

	return true;
}

*/

bool
ForUsDocApp::OnAppWillTerminate(void)
{
	// TODO: Deallocate or release resources in devices that have the END key.
	return true;
}

bool
ForUsDocApp::OnAppTerminating(AppRegistry& appRegistry, bool forcedTermination)
{
	// TODO: Deallocate all resources allocated by the application.
	// The permanent data and context of the application can be saved through the application registry (appRegistry).
	return true;
}

void
ForUsDocApp::OnForeground(void)
{
	// TODO: Start or resume drawing when the application is moved to the foreground.
}

void
ForUsDocApp::OnBackground(void)
{
	// TODO: Stop drawing when the application is moved to the background to save the CPU and battery consumption.
}

void
ForUsDocApp::OnLowMemory(void)
{
	// TODO: Free unnecessary resources or close the application.
}

void
ForUsDocApp::OnBatteryLevelChanged(BatteryLevel batteryLevel)
{
	// TODO: Handle all battery level changes here.
	// Stop using multimedia features (such as camera and mp3 playback) if the battery level is CRITICAL.
}

void
ForUsDocApp::OnScreenOn(void)
{
	// TODO: Retrieve the released resources or resume the operations that were paused or stopped in the OnScreenOff() event handler.
}

void
ForUsDocApp::OnScreenOff(void)
{
	// TODO: Release resources (such as 3D, media, and sensors) to allow the device to enter the sleep mode 
	// to save the battery (unless you have a good reason to do otherwise).
	// Only perform quick operations in this event handler. Any lengthy operations can be risky; 
	// for example, invoking a long asynchronous method within this event handler can cause problems
	// because the device can enter the sleep mode before the callback is invoked.

}

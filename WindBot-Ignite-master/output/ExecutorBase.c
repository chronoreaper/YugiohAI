// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by Embeddinator-4000.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
#include "ExecutorBase.h"
#include "glib.h"
#include "mono_embeddinator.h"
#include "c-support.h"

mono_embeddinator_context_t __mono_context;
MonoImage* __ExecutorBase_dll_image;

static MonoClass* class_YGOSharp_OCGWrapper_Enums_CardPosition = 0;
static MonoClass* class_YGOSharp_OCGWrapper_Enums_CardLocation = 0;
static MonoClass* class_WindBot_Game_AI_DefaultExecutor = 0;
static MonoClass* class_WindBot_Game_AI_Executor = 0;
static MonoClass* class_WindBot_Game_AI_ExecutorType = 0;

static void __initialize_mono()
{
    if (__mono_context.domain)
        return;
    mono_embeddinator_init(&__mono_context, "mono_embeddinator_binding");
}

static void __lookup_assembly_ExecutorBase_dll()
{
    if (__ExecutorBase_dll_image)
        return;
    __ExecutorBase_dll_image = mono_embeddinator_load_assembly(&__mono_context, "ExecutorBase.dll");
}

static void __lookup_class_WindBot_Game_AI_DefaultExecutor()
{
    if (class_WindBot_Game_AI_DefaultExecutor == 0)
    {
        __initialize_mono();
        __lookup_assembly_ExecutorBase_dll();
        class_WindBot_Game_AI_DefaultExecutor = mono_class_from_name(__ExecutorBase_dll_image, "WindBot.Game.AI", "DefaultExecutor");
    }
}

bool WindBot_Game_AI_DefaultExecutor_OnSelectBattleReplay(WindBot_Game_AI_DefaultExecutor* object)
{
    const char __method_name[] = "WindBot.Game.AI.DefaultExecutor:OnSelectBattleReplay()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_DefaultExecutor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_DefaultExecutor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);

    void* __unbox = mono_object_unbox(__result);

    return *((bool*)__unbox);
}

void WindBot_Game_AI_DefaultExecutor_OnNewTurn(WindBot_Game_AI_DefaultExecutor* object)
{
    const char __method_name[] = "WindBot.Game.AI.DefaultExecutor:OnNewTurn()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_DefaultExecutor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_DefaultExecutor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}

static void __lookup_class_WindBot_Game_AI_Executor()
{
    if (class_WindBot_Game_AI_Executor == 0)
    {
        __initialize_mono();
        __lookup_assembly_ExecutorBase_dll();
        class_WindBot_Game_AI_Executor = mono_class_from_name(__ExecutorBase_dll_image, "WindBot.Game.AI", "Executor");
    }
}

int32_t WindBot_Game_AI_Executor_OnRockPaperScissors(WindBot_Game_AI_Executor* object)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:OnRockPaperScissors()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);

    void* __unbox = mono_object_unbox(__result);

    return *((int32_t*)__unbox);
}

bool WindBot_Game_AI_Executor_OnSelectHand(WindBot_Game_AI_Executor* object)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:OnSelectHand()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);

    void* __unbox = mono_object_unbox(__result);

    return *((bool*)__unbox);
}

void WindBot_Game_AI_Executor_OnChainEnd(WindBot_Game_AI_Executor* object)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:OnChainEnd()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}

void WindBot_Game_AI_Executor_OnNewPhase(WindBot_Game_AI_Executor* object)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:OnNewPhase()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}

void WindBot_Game_AI_Executor_OnNewTurn(WindBot_Game_AI_Executor* object)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:OnNewTurn()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}

void WindBot_Game_AI_Executor_OnDraw(WindBot_Game_AI_Executor* object, int32_t player)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:OnDraw(int)";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    void* __args[1];
    __args[0] = &player;

    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, __args, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}

bool WindBot_Game_AI_Executor_OnSelectYesNo(WindBot_Game_AI_Executor* object, int64_t desc)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:OnSelectYesNo(long)";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    void* __args[1];
    __args[0] = &desc;

    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, __args, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);

    void* __unbox = mono_object_unbox(__result);

    return *((bool*)__unbox);
}

int32_t WindBot_Game_AI_Executor_OnSelectPlace(WindBot_Game_AI_Executor* object, int64_t cardId, int32_t player, YGOSharp_OCGWrapper_Enums_CardLocation location, int32_t available)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:OnSelectPlace(long,int,YGOSharp.OCGWrapper.Enums.CardLocation,int)";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    void* __args[4];
    __args[0] = &cardId;
    __args[1] = &player;
    __args[2] = &location;
    __args[3] = &available;

    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, __args, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);

    void* __unbox = mono_object_unbox(__result);

    return *((int32_t*)__unbox);
}

bool WindBot_Game_AI_Executor_OnSelectBattleReplay(WindBot_Game_AI_Executor* object)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:OnSelectBattleReplay()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoMethod* __virtual_method = mono_object_get_virtual_method(__instance, __method);
    MonoObject* __result = mono_runtime_invoke(__virtual_method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);

    void* __unbox = mono_object_unbox(__result);

    return *((bool*)__unbox);
}

void WindBot_Game_AI_Executor_AddExecutor(WindBot_Game_AI_Executor* object, WindBot_Game_AI_ExecutorType type, int32_t cardId)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:AddExecutor(WindBot.Game.AI.ExecutorType,int)";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    void* __args[2];
    __args[0] = &type;
    __args[1] = &cardId;

    MonoObject* __exception = 0;
    MonoObject* __result = mono_runtime_invoke(__method, __instance, __args, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}

void WindBot_Game_AI_Executor_AddExecutor_1(WindBot_Game_AI_Executor* object, WindBot_Game_AI_ExecutorType type)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:AddExecutor(WindBot.Game.AI.ExecutorType)";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    void* __args[1];
    __args[0] = &type;

    MonoObject* __exception = 0;
    MonoObject* __result = mono_runtime_invoke(__method, __instance, __args, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}

const char* WindBot_Game_AI_Executor_get_Deck(WindBot_Game_AI_Executor* object)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:get_Deck()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoObject* __result = mono_runtime_invoke(__method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);

    char* __string = mono_string_to_utf8((MonoString*) __result);

    return __string;
}

void WindBot_Game_AI_Executor_set_Deck(WindBot_Game_AI_Executor* object, const char* value)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:set_Deck(string)";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    void* __args[1];
    MonoString* __value_0 = (value) ? mono_string_new(__mono_context.domain, value) : 0;
    __args[0] = __value_0;

    MonoObject* __exception = 0;
    MonoObject* __result = mono_runtime_invoke(__method, __instance, __args, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}

WindBot_Game_AI_ExecutorType WindBot_Game_AI_Executor_get_Type(WindBot_Game_AI_Executor* object)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:get_Type()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoObject* __result = mono_runtime_invoke(__method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);

    void* __unbox = mono_object_unbox(__result);

    return *((WindBot_Game_AI_ExecutorType*)__unbox);
}

void WindBot_Game_AI_Executor_set_Type(WindBot_Game_AI_Executor* object, WindBot_Game_AI_ExecutorType value)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:set_Type(WindBot.Game.AI.ExecutorType)";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    void* __args[1];
    __args[0] = &value;

    MonoObject* __exception = 0;
    MonoObject* __result = mono_runtime_invoke(__method, __instance, __args, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}

int64_t WindBot_Game_AI_Executor_get_ActivateDescription(WindBot_Game_AI_Executor* object)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:get_ActivateDescription()";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    MonoObject* __exception = 0;
    MonoObject* __result = mono_runtime_invoke(__method, __instance, 0, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);

    void* __unbox = mono_object_unbox(__result);

    return *((int64_t*)__unbox);
}

void WindBot_Game_AI_Executor_set_ActivateDescription(WindBot_Game_AI_Executor* object, int64_t value)
{
    const char __method_name[] = "WindBot.Game.AI.Executor:set_ActivateDescription(long)";
    static MonoMethod *__method = 0;

    if (!__method)
    {
        __lookup_class_WindBot_Game_AI_Executor();
        __method = mono_embeddinator_lookup_method(__method_name, class_WindBot_Game_AI_Executor);
    }

    MonoObject* __instance = mono_gchandle_get_target(object->_handle);
    void* __args[1];
    __args[0] = &value;

    MonoObject* __exception = 0;
    MonoObject* __result = mono_runtime_invoke(__method, __instance, __args, &__exception);

    if (__exception)
        mono_embeddinator_throw_exception(__exception);
}
#ifndef AUTH_DLL_H
#define AUTH_DLL_H

#ifdef AUTH_EXPORTS
#define AUTH_API __declspec(dllexport)
#else
#define AUTH_API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C"{
#endif

// 0£ºÎ´ÊÚÈ¨
// 1£ºÒÑÊÚÈ¨
AUTH_API int Permission(const char* szKey);

#ifdef __cplusplus
};
#endif

#endif